
namespace Automated_Control_Information_System_Projects
{
  partial class EnterName
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
      this.txt_name = new System.Windows.Forms.TextBox();
      this.lbl_name = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btn_ok
      // 
      this.btn_ok.BackColor = System.Drawing.SystemColors.Window;
      this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_ok.Location = new System.Drawing.Point(6, 45);
      this.btn_ok.Name = "btn_ok";
      this.btn_ok.Size = new System.Drawing.Size(365, 52);
      this.btn_ok.TabIndex = 5;
      this.btn_ok.Text = "Підтвердити";
      this.btn_ok.UseVisualStyleBackColor = false;
      this.btn_ok.Click += new System.EventHandler(this.btnCreateBoard_Click);
      // 
      // txt_name
      // 
      this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txt_name.Location = new System.Drawing.Point(109, 5);
      this.txt_name.Name = "txt_name";
      this.txt_name.Size = new System.Drawing.Size(262, 34);
      this.txt_name.TabIndex = 4;
      // 
      // lbl_name
      // 
      this.lbl_name.AutoSize = true;
      this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbl_name.ForeColor = System.Drawing.SystemColors.Window;
      this.lbl_name.Location = new System.Drawing.Point(1, 8);
      this.lbl_name.Name = "lbl_name";
      this.lbl_name.Size = new System.Drawing.Size(87, 29);
      this.lbl_name.TabIndex = 3;
      this.lbl_name.Text = "Назва";
      // 
      // EnterName
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SteelBlue;
      this.ClientSize = new System.Drawing.Size(380, 104);
      this.Controls.Add(this.btn_ok);
      this.Controls.Add(this.txt_name);
      this.Controls.Add(this.lbl_name);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "EnterName";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "EnterName";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_ok;
    private System.Windows.Forms.TextBox txt_name;
    private System.Windows.Forms.Label lbl_name;
  }
}