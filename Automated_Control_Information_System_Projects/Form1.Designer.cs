
namespace Automated_Control_Information_System_Projects
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.linkLbl_menu = new System.Windows.Forms.LinkLabel();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.змінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.зміниНазвуДоскиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.видалитиДоскуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lbl_board_name = new System.Windows.Forms.Label();
      this.btn_add_new_board = new System.Windows.Forms.Button();
      this.btn_boards = new System.Windows.Forms.Button();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.pnl_board = new System.Windows.Forms.Panel();
      this.btn_add_row = new System.Windows.Forms.Button();
      this.pnl_boards = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.pnl_board.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.SteelBlue;
      this.panel1.Controls.Add(this.linkLbl_menu);
      this.panel1.Controls.Add(this.lbl_board_name);
      this.panel1.Controls.Add(this.btn_add_new_board);
      this.panel1.Controls.Add(this.btn_boards);
      this.panel1.Location = new System.Drawing.Point(0, -1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(884, 55);
      this.panel1.TabIndex = 0;
      // 
      // linkLbl_menu
      // 
      this.linkLbl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.linkLbl_menu.AutoSize = true;
      this.linkLbl_menu.ContextMenuStrip = this.contextMenuStrip1;
      this.linkLbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.linkLbl_menu.ForeColor = System.Drawing.SystemColors.Window;
      this.linkLbl_menu.LinkColor = System.Drawing.SystemColors.Window;
      this.linkLbl_menu.Location = new System.Drawing.Point(666, 14);
      this.linkLbl_menu.Name = "linkLbl_menu";
      this.linkLbl_menu.Size = new System.Drawing.Size(161, 29);
      this.linkLbl_menu.TabIndex = 4;
      this.linkLbl_menu.TabStop = true;
      this.linkLbl_menu.Text = "Меню дошки";
      this.linkLbl_menu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_menu_LinkClicked);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиToolStripMenuItem,
            this.зміниНазвуДоскиToolStripMenuItem,
            this.видалитиДоскуToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(220, 76);
      // 
      // змінитиToolStripMenuItem
      // 
      this.змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
      this.змінитиToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
      this.змінитиToolStripMenuItem.Text = "Змінити колір доски";
      this.змінитиToolStripMenuItem.Click += new System.EventHandler(this.змінитиToolStripMenuItem_Click);
      // 
      // зміниНазвуДоскиToolStripMenuItem
      // 
      this.зміниНазвуДоскиToolStripMenuItem.Name = "зміниНазвуДоскиToolStripMenuItem";
      this.зміниНазвуДоскиToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
      this.зміниНазвуДоскиToolStripMenuItem.Text = "Зміни назву доски";
      this.зміниНазвуДоскиToolStripMenuItem.Click += new System.EventHandler(this.зміниНазвуДоскиToolStripMenuItem_Click);
      // 
      // видалитиДоскуToolStripMenuItem
      // 
      this.видалитиДоскуToolStripMenuItem.Name = "видалитиДоскуToolStripMenuItem";
      this.видалитиДоскуToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
      this.видалитиДоскуToolStripMenuItem.Text = "Видалити доску";
      this.видалитиДоскуToolStripMenuItem.Click += new System.EventHandler(this.видалитиДоскуToolStripMenuItem_Click);
      // 
      // lbl_board_name
      // 
      this.lbl_board_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbl_board_name.AutoSize = true;
      this.lbl_board_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbl_board_name.ForeColor = System.Drawing.SystemColors.Window;
      this.lbl_board_name.Location = new System.Drawing.Point(114, 14);
      this.lbl_board_name.Name = "lbl_board_name";
      this.lbl_board_name.Size = new System.Drawing.Size(155, 29);
      this.lbl_board_name.TabIndex = 2;
      this.lbl_board_name.Text = "Назва доски";
      // 
      // btn_add_new_board
      // 
      this.btn_add_new_board.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btn_add_new_board.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.btn_add_new_board.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_add_new_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_add_new_board.ForeColor = System.Drawing.SystemColors.Window;
      this.btn_add_new_board.Location = new System.Drawing.Point(833, 6);
      this.btn_add_new_board.Name = "btn_add_new_board";
      this.btn_add_new_board.Size = new System.Drawing.Size(44, 44);
      this.btn_add_new_board.TabIndex = 1;
      this.btn_add_new_board.Text = "+";
      this.btn_add_new_board.UseVisualStyleBackColor = false;
      this.btn_add_new_board.Click += new System.EventHandler(this.btn_add_new_board_Click);
      // 
      // btn_boards
      // 
      this.btn_boards.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.btn_boards.CausesValidation = false;
      this.btn_boards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_boards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_boards.ForeColor = System.Drawing.SystemColors.Window;
      this.btn_boards.Location = new System.Drawing.Point(5, 6);
      this.btn_boards.Margin = new System.Windows.Forms.Padding(0);
      this.btn_boards.Name = "btn_boards";
      this.btn_boards.Size = new System.Drawing.Size(106, 44);
      this.btn_boards.TabIndex = 0;
      this.btn_boards.Text = "Дошки";
      this.btn_boards.UseVisualStyleBackColor = false;
      this.btn_boards.Click += new System.EventHandler(this.btn_boards_Click);
      // 
      // pnl_board
      // 
      this.pnl_board.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_board.AutoScroll = true;
      this.pnl_board.Controls.Add(this.btn_add_row);
      this.pnl_board.Controls.Add(this.pnl_boards);
      this.pnl_board.Location = new System.Drawing.Point(0, 53);
      this.pnl_board.Name = "pnl_board";
      this.pnl_board.Size = new System.Drawing.Size(884, 510);
      this.pnl_board.TabIndex = 2;
      // 
      // btn_add_row
      // 
      this.btn_add_row.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.btn_add_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_add_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_add_row.ForeColor = System.Drawing.SystemColors.Window;
      this.btn_add_row.Location = new System.Drawing.Point(590, 12);
      this.btn_add_row.Margin = new System.Windows.Forms.Padding(0);
      this.btn_add_row.Name = "btn_add_row";
      this.btn_add_row.Size = new System.Drawing.Size(215, 37);
      this.btn_add_row.TabIndex = 5;
      this.btn_add_row.Text = "Додати список";
      this.btn_add_row.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_add_row.UseVisualStyleBackColor = false;
      this.btn_add_row.Click += new System.EventHandler(this.button1_Click);
      // 
      // pnl_boards
      // 
      this.pnl_boards.AutoScroll = true;
      this.pnl_boards.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnl_boards.Location = new System.Drawing.Point(5, 0);
      this.pnl_boards.Name = "pnl_boards";
      this.pnl_boards.Size = new System.Drawing.Size(200, 287);
      this.pnl_boards.TabIndex = 0;
      this.pnl_boards.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(882, 553);
      this.Controls.Add(this.pnl_board);
      this.Controls.Add(this.panel1);
      this.MinimumSize = new System.Drawing.Size(900, 600);
      this.Name = "Form1";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Автоматизована інформаційна система управління";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.pnl_board.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_add_new_board;
    private System.Windows.Forms.Button btn_boards;
    private System.Windows.Forms.Label lbl_board_name;
    private System.Windows.Forms.LinkLabel linkLbl_menu;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem змінитиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem зміниНазвуДоскиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem видалитиДоскуToolStripMenuItem;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Panel pnl_board;
    private System.Windows.Forms.Panel pnl_boards;
    private System.Windows.Forms.Button btn_add_row;
  }
}

