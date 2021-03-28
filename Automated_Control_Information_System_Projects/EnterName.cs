using System;
using System.Windows.Forms;

namespace Automated_Control_Information_System_Projects
{
  public partial class EnterName : Form
  {
    public EnterName()
    {
      InitializeComponent();
    }
    public static string name;
    private void btnCreateBoard_Click(object sender, EventArgs e)
    {
      if (!String.IsNullOrWhiteSpace(txt_name.Text))
      {
        name = txt_name.Text;
        Close();
      }
    }
  }
}
