using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Automated_Control_Information_System_Projects.Boards;

namespace Automated_Control_Information_System_Projects
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    static int id = 0;
    ACISP acisp;

    private void Form1_Load(object sender, EventArgs e)
    {
      acisp = ACISP.GetACISP();
      if (acisp.getBoards().Count > 0)
      {
        DrawRows(acisp.getBoards()[0]);
      }
      else
      {
        string color = "ffffff";
        var board = acisp.addBoard("Проект 1", color);
        id = board.ID;
        acisp.addRow(board, "Потрібно зробити");
        acisp.addRow(board, "В процесі");
        acisp.addRow(board, "Готово");
        DrawRows(board);
        pnl_board.BackColor = ColorTranslator.FromHtml("#" + color);
      }
    }

    private void btn_add_new_board_Click(object sender, EventArgs e)
    {
      BoardProperty boardProForm = new BoardProperty();
      boardProForm.ShowDialog();
      pnl_board.Visible = true;
      string name = boardProForm.name;
      string color = boardProForm.color;
      var board = acisp.addBoard(name, color);
      id = board.ID;
      lbl_board_name.Text = name;
      acisp.addRow(board, "Потрібно зробити");
      acisp.addRow(board, "В процесі");
      acisp.addRow(board, "Готово");
      DrawRows(board);
      pnl_board.BackColor = ColorTranslator.FromHtml("#"+color);
    }

    private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      colorDialog1.ShowDialog();
      pnl_board.BackColor = colorDialog1.Color;
      acisp.ChangeBoardColor(colorDialog1.Color.ToArgb().ToString("x8"), id);
    }

    private void зміниНазвуДоскиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      TextBox board_name = new TextBox();
      board_name.Visible = true;
      board_name.Left = 90;
      board_name.Top = 7;
      board_name.Size = new Size(200, 10);
      board_name.Font = new Font("", 14);
      Controls.Add(board_name);
      board_name.BringToFront();
      board_name.KeyPress += Boardname_KeyPress;
    }

    private void Boardname_KeyPress(object sender, KeyPressEventArgs e)
    {
      var board_name = sender as TextBox;
      if (e.KeyChar == (char)Keys.Enter)
      {
        e.Handled = true;
        acisp.ChangeBoardName(board_name.Text, id);
        lbl_board_name.Text = board_name.Text;
        board_name.Visible = false;

      }
    }

    private void видалитиДоскуToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lbl_board_name.Text = "";
      acisp.DeleteBoardById(id);
      pnl_board.Visible = false;
    }

    private void btn_boards_Click(object sender, EventArgs e)
    {
      pnl_boards.Controls.Clear();
      if (pnl_boards.Visible == true)
      {
        pnl_boards.Visible = false;
      }

      else if (acisp.getBoards().Count > 0)
      {
        int left = 5;
        int top = 5;
        pnl_boards.Visible = true;
        Controls.Add(pnl_boards);
        pnl_boards.Left = 5;
        pnl_boards.Top = 43;
        pnl_boards.BringToFront();
        pnl_boards.Height = 0;
        pnl_boards.Width = 200;
        foreach (var item in acisp.getBoards())
        {
          Button btn = new Button();
          btn.Width = 190;
          btn.Height = 45;
          btn.Left = left;
          btn.Top = top;
          btn.FlatStyle = FlatStyle.Flat;
          btn.FlatAppearance.BorderSize = 0;
          btn.ForeColor = Color.White;
          btn.Font = new Font("Roboto Cn", 12);
          btn.BackColor = Color.FromArgb(2, 106, 167);
          btn.Text = item.Name;
          btn.Click += Btn_Click;
          btn.Name = item.ID.ToString();
          pnl_boards.Controls.Add(btn);
          top += btn.Height + 5;
          pnl_boards.Height += btn.Height + 15;
        }
      }
    }

    private void Btn_Click(object sender, EventArgs e)
    {
      pnl_board.Controls.Clear();
      pnl_board.Visible = true;
      var btn = sender as Button;
      string color = acisp.getBoardId(Convert.ToInt32(btn.Name)).Color;
      pnl_board.BackColor = ColorTranslator.FromHtml("#" + color);
      id = Convert.ToInt32(btn.Name);
      lbl_board_name.Text = btn.Text;
      int left = 10, top = 10;
      foreach (var item in acisp.getRowsForBoard(Convert.ToInt32(btn.Name)))
      {
        Panel panel = new Panel();
        panel.MaximumSize = new Size(255, 472);
        panel.AutoScroll = true;
        panel.BackColor = Color.FromArgb(226, 228, 230);
        panel.Width = 245;
        panel.Height = 81;
        panel.Left = left;
        panel.Top = top;
        panel.Name = item.ID.ToString();
        Label label = new Label();
        label.Font = new Font("Roboto Cn", 12);
        label.BackColor = Color.Transparent;
        label.Left = 3;
        label.Top = 2;
        label.Width = 46;
        label.Height = 19;
        label.Text = item.Name;
        label.AutoSize = true;
        Button btn_add = new Button();
        btn_add.Left = 215;
        btn_add.Top = 3;
        btn_add.Width = 24;
        btn_add.Height = 23;
        btn_add.Text = "...";
        btn_add.FlatStyle = FlatStyle.Flat;
        btn_add.FlatAppearance.BorderSize = 0;
        btn_add.ContextMenuStrip = new ContextMenuStrip();
        ToolStripItem item1 = btn_add.ContextMenuStrip.Items.Add("Змінити назву");
        item1.Click += Item1_Click;
        ToolStripItem item2 = btn_add.ContextMenuStrip.Items.Add("Видалити список");
        item2.Click += Item2_Click;
        Button btn_card = new Button();
        top = DrawTask(item.ID, panel, top);
        btn_card.Left = -1;
        btn_card.Top = top;
        btn_card.FlatStyle = FlatStyle.Flat;
        btn_card.FlatAppearance.BorderSize = 0;
        btn_card.Width = 209;
        btn_card.Height = 27;
        btn_card.Name = item.ID.ToString();
        btn_card.BackColor = Color.Transparent;
        btn_card.Text = "Додати завдання";
        btn_card.TextAlign = ContentAlignment.MiddleLeft;
        btn_card.Font = new Font("Roboto Cn", 12);
        btn_card.ForeColor = Color.FromArgb(131, 140, 145);
        btn_card.Click += CardButton_Click;
        panel.Controls.Add(label);
        panel.Controls.Add(btn_add);
        panel.Controls.Add(btn_card);
        pnl_board.Controls.Add(panel);
        panel.BringToFront();
        top = 10;
        left += panel.Width + 10;
      }
      btn_add_row.Left = left;
      pnl_board.Controls.Add(btn_add_row);
      pnl_boards.Visible = false;
    }

    private void DrawRows(Board board)
    {
      pnl_board.Controls.Clear();
      string color = board.Color;
      pnl_board.BackColor = ColorTranslator.FromHtml("#" + color);
      id = board.ID;
      lbl_board_name.Text = board.Name;
      int left = 10, top = 10;
      foreach (var item in acisp.getRowsForBoard(board.ID))
      {
        Panel panel = new Panel();
        panel.MaximumSize = new Size(255, 472);
        panel.AutoScroll = true;
        panel.BackColor = Color.FromArgb(226, 228, 230);
        panel.Width = 245;
        panel.Height = 81;
        panel.Left = left;
        panel.Top = top;
        panel.Name = item.ID.ToString();
        Label label = new Label();
        label.Font = new Font("Roboto Cn", 12);
        label.BackColor = Color.Transparent;
        label.Left = 3;
        label.Top = 2;
        label.Width = 46;
        label.Height = 19;
        label.Text = item.Name;
        label.AutoSize = true;
        Button btn_add = new Button();
        btn_add.Left = 215;
        btn_add.Top = 3;
        btn_add.Width = 24;
        btn_add.Height = 23;
        btn_add.Text = "...";
        btn_add.FlatStyle = FlatStyle.Flat;
        btn_add.FlatAppearance.BorderSize = 0;
        btn_add.ContextMenuStrip = new ContextMenuStrip();
        ToolStripItem item1 = btn_add.ContextMenuStrip.Items.Add("Змінити назву");
        item1.Click += Item1_Click;
        ToolStripItem item2 = btn_add.ContextMenuStrip.Items.Add("Видалити список");
        item2.Click += Item2_Click;
        Button btn_card = new Button();
        top = DrawTask(item.ID, panel, top);
        btn_card.Left = -1;
        btn_card.Top = top;
        btn_card.FlatStyle = FlatStyle.Flat;
        btn_card.FlatAppearance.BorderSize = 0;
        btn_card.Width = 209;
        btn_card.Height = 27;
        btn_card.Name = item.ID.ToString();
        btn_card.BackColor = Color.Transparent;
        btn_card.Text = "Додати завдання";
        btn_card.TextAlign = ContentAlignment.MiddleLeft;
        btn_card.Font = new Font("Roboto Cn", 12);
        btn_card.ForeColor = Color.FromArgb(131, 140, 145);
        btn_card.Click += CardButton_Click;
        panel.Controls.Add(label);
        panel.Controls.Add(btn_add);
        panel.Controls.Add(btn_card);
        pnl_board.Controls.Add(panel);
        panel.BringToFront();
        top = 10;
        left += panel.Width + 10;
      }
      btn_add_row.Left = left;
      pnl_board.Controls.Add(btn_add_row);
      pnl_boards.Visible = false;
    }

    private void CardButton_Click(object sender, EventArgs e)
    {
      var button = sender as Button;
      EnterName enterName = new EnterName();
      enterName.ShowDialog();
      acisp.AddTask(acisp.GetRowById(Convert.ToInt32(button.Name)), EnterName.name);
      DrawRows(acisp.getBoardId(id));
    }

    private int DrawTask(int id, Panel panel, int top)
    {
      int left = 5;
      top = 30;
      foreach (var item in acisp.GetRowById(id).getTasks())
      {
        RichTextBox textBox = new RichTextBox();
        textBox.Left = left;
        textBox.Top = top;
        textBox.Width = 209;
        textBox.Height = 40;
        textBox.AutoSize = true;
        textBox.Name = item.ID.ToString();
        textBox.Text = item.Name;
        textBox.Font = new Font("Roboto Cn", 12);
        textBox.ForeColor = Color.FromArgb(131, 140, 145);
        textBox.Enabled = false;
        Button btn_add = new Button();
        btn_add.Left = textBox.Width + 5;
        btn_add.Top = top;
        btn_add.Width = 24;
        btn_add.Height = 23;
        btn_add.Text = "...";
        btn_add.FlatStyle = FlatStyle.Flat;
        btn_add.FlatAppearance.BorderSize = 0;
        btn_add.ContextMenuStrip = new ContextMenuStrip();
        ToolStripItem draganddrop = btn_add.ContextMenuStrip.Items.Add("Перемістити");
        ToolStripItem changetask = btn_add.ContextMenuStrip.Items.Add("Змінити назву");
        ToolStripItem deletetask = btn_add.ContextMenuStrip.Items.Add("Видалити");
        changetask.Name = textBox.Name;
        deletetask.Name = textBox.Name;
        draganddrop.Name = textBox.Name;
        draganddrop.Click += Draganddrop_Click;
        changetask.Click += Changetask_Click;
        deletetask.Click += Deletetask_Click;
        top = top + textBox.Height;
        panel.Controls.Add(btn_add);
        panel.Controls.Add(textBox);
        panel.Height = top + textBox.Height;
      }
      return top;
    }

    private void Deletetask_Click(object sender, EventArgs e)
    {
      var stripitem = sender as ToolStripItem;
      foreach (var item in pnl_board.Controls.OfType<Panel>())
      {
        foreach (var item2 in item.Controls.OfType<Button>())
        {
          if (item2.ContextMenuStrip != null)
          {
            foreach (ToolStripItem item3 in item2.ContextMenuStrip.Items)
            {
              if (item3 == stripitem)
              {
                var textbox = item.Controls.OfType<RichTextBox>().Where(x => x.Name == stripitem.Name).First();
                pnl_board.Controls.Remove(item2);
                pnl_board.Controls.Remove(textbox);
                acisp.DeleteTask(acisp.GetRowById(Convert.ToInt32(item.Name)), Convert.ToInt32(stripitem.Name));
                DrawRows(acisp.getBoardId(id));
              }
            }
          }
        }
      }
    }

    private void Changetask_Click(object sender, EventArgs e)
    {
      var stripitem = sender as ToolStripItem;
      foreach (var item in pnl_board.Controls.OfType<Panel>())
      {
        foreach (var item2 in item.Controls.OfType<Button>())
        {
          if (item2.ContextMenuStrip != null)
          {
            foreach (ToolStripItem item3 in item2.ContextMenuStrip.Items)
            {
              if (item3 == stripitem)
              {
                EnterName enterName = new EnterName();
                enterName.ShowDialog();
                item.Controls.OfType<RichTextBox>().Where(x => x.Name == stripitem.Name).First().Text = EnterName.name;
                acisp.ChangeTaskContent(acisp.GetRowById(Convert.ToInt32(item.Name)), EnterName.name, Convert.ToInt32(stripitem.Name));
              }
            }
          }
        }
      }
    }

    private void Draganddrop_Click(object sender, EventArgs e)
    {
      var stripitem = sender as ToolStripItem;
      foreach (var item in pnl_board.Controls.OfType<Panel>())
      {
        foreach (var item2 in item.Controls.OfType<Button>())
        {
          if (item2.ContextMenuStrip != null)
          {
            foreach (ToolStripItem item3 in item2.ContextMenuStrip.Items)
            {
              if (item3 == stripitem)
              {
                ChooseRow chooseRow = new ChooseRow(id);
                chooseRow.ShowDialog();
                acisp.DragAndDrop(Convert.ToInt32(item.Name), ChooseRow.Id, Convert.ToInt32(stripitem.Name));
                DrawRows(acisp.getBoardId(id));
                break;
              }
            }
          }
        }
      }
    }
    private void Item2_Click(object sender, EventArgs e)
    {
      var stripitem = sender as ToolStripItem;
      foreach (var item in pnl_board.Controls.OfType<Panel>())
      {
        foreach (var item2 in item.Controls.OfType<Button>())
        {
          if (item2.ContextMenuStrip != null)
          {
            foreach (ToolStripItem item3 in item2.ContextMenuStrip.Items)
            {
              if (item3 == stripitem)
              {
                pnl_board.Controls.Remove(item);
                acisp.DeleteRow(id, Convert.ToInt32(item.Name));
                DrawRows(acisp.getBoardId(id));
              }
            }
          }
        }
      }
    }

    private void Item1_Click(object sender, EventArgs e)
    {
      var stripitem = sender as ToolStripItem;
      foreach (var item in pnl_board.Controls.OfType<Panel>())
      {
        foreach (var item2 in item.Controls.OfType<Button>())
        {
          if (item2.ContextMenuStrip != null)
          {
            foreach (ToolStripItem item3 in item2.ContextMenuStrip.Items)
            {
              if (item3 == stripitem)
              {
                EnterName enterName = new EnterName();
                enterName.ShowDialog();
                item.Controls.OfType<Label>().First().Text = EnterName.name;
                acisp.ChangeRowName(acisp.getBoardId(id), EnterName.name, Convert.ToInt32(item.Name));
              }
            }
          }
        }
      }
    }

    private void linkLbl_menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      EnterName name = new EnterName();
      name.ShowDialog();
      acisp.addRow(id, EnterName.name);
      DrawRows(acisp.getBoardId(id));
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Json.Serializer(acisp.getBoards(), @"./datas.json");
    }
  }
}
