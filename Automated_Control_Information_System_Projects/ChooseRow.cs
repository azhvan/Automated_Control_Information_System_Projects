using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Automated_Control_Information_System_Projects
{
  public partial class ChooseRow : Form
  {
    public ChooseRow(int id)
    {
      InitializeComponent();
      Id = id;
      rows = new List<Rows.Row>();
    }
    public static int Id;
    public static int index;
    static List<Rows.Row> rows;
    private void lblName_Click(object sender, EventArgs e)
    {

    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      if (cmbBoxRows.SelectedItem != null)
      {
        Close();
      }
    }

    private void cmbBoxRows_SelectedIndexChanged(object sender, EventArgs e)
    {
      for (int i = 0; i < cmbBoxRows.Items.Count; i++)
      {
        if (cmbBoxRows.Items[i] == cmbBoxRows.SelectedItem)
        {
          index = i;
          break;
        }
      }
      Id = rows[index].ID;
    }

    private void ChooseRow_Load(object sender, EventArgs e)
    {
      LoadRow(Id);
      foreach (var item in rows)
      {
        cmbBoxRows.Items.Add(item.Name);
      }
    }
    private static void LoadRow(int id)
    {
      rows.AddRange(ACISP.GetACISP().getRowsForBoard(id));
    }
  }
}
