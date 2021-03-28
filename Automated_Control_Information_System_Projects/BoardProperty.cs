using System;
using System.Windows.Forms;

namespace Automated_Control_Information_System_Projects
{
  public partial class BoardProperty : Form
  {
    public BoardProperty()
    {
      InitializeComponent();
    }
    public string name, color;
    bool okay = false;

    private void btnBoardColor_Click(object sender, EventArgs e)
    {
      colorDialog1.ShowDialog();
      if (colorDialog1.Color != null)
      {
        color = colorDialog1.Color.ToArgb().ToString("x8");
        btn_board_color.BackColor = colorDialog1.Color;
        okay = true;
      }
      else
      {
        okay = false;
      }
    }

    private void btnCreateBoard_Click(object sender, EventArgs e)
    {
      if (!String.IsNullOrWhiteSpace(txt_board_name.Text))
      {
        if (okay)
        {
          name = txt_board_name.Text;
          Close();
        }
      }
      else
      {
        okay = false;
      }
    }
  }
}
