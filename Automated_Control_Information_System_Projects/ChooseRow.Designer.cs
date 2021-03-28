
namespace Automated_Control_Information_System_Projects
{
  partial class ChooseRow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btn_ok = new System.Windows.Forms.Button();
      this.lbl_name = new System.Windows.Forms.Label();
      this.cmbBoxRows = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btn_ok
      // 
      this.btn_ok.BackColor = System.Drawing.SystemColors.Window;
      this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_ok.Location = new System.Drawing.Point(12, 44);
      this.btn_ok.Name = "btn_ok";
      this.btn_ok.Size = new System.Drawing.Size(365, 52);
      this.btn_ok.TabIndex = 7;
      this.btn_ok.Text = "Перемістити";
      this.btn_ok.UseVisualStyleBackColor = false;
      this.btn_ok.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // lbl_name
      // 
      this.lbl_name.AutoSize = true;
      this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbl_name.ForeColor = System.Drawing.SystemColors.Window;
      this.lbl_name.Location = new System.Drawing.Point(7, 7);
      this.lbl_name.Name = "lbl_name";
      this.lbl_name.Size = new System.Drawing.Size(104, 29);
      this.lbl_name.TabIndex = 6;
      this.lbl_name.Text = "Список";
      this.lbl_name.Click += new System.EventHandler(this.lblName_Click);
      // 
      // cmbBoxRows
      // 
      this.cmbBoxRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.cmbBoxRows.FormattingEnabled = true;
      this.cmbBoxRows.Location = new System.Drawing.Point(117, 4);
      this.cmbBoxRows.Name = "cmbBoxRows";
      this.cmbBoxRows.Size = new System.Drawing.Size(260, 37);
      this.cmbBoxRows.TabIndex = 8;
      this.cmbBoxRows.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRows_SelectedIndexChanged);
      // 
      // ChooseRow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SteelBlue;
      this.ClientSize = new System.Drawing.Size(386, 105);
      this.Controls.Add(this.cmbBoxRows);
      this.Controls.Add(this.btn_ok);
      this.Controls.Add(this.lbl_name);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "ChooseRow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "ChooseRow";
      this.Load += new System.EventHandler(this.ChooseRow_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_ok;
    private System.Windows.Forms.Label lbl_name;
    private System.Windows.Forms.ComboBox cmbBoxRows;
  }
}