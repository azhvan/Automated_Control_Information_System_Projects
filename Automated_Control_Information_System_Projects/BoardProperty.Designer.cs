
namespace Automated_Control_Information_System_Projects
{
  partial class BoardProperty
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
      this.lbl_board_name = new System.Windows.Forms.Label();
      this.lbl_board_color = new System.Windows.Forms.Label();
      this.txt_board_name = new System.Windows.Forms.TextBox();
      this.btn_board_color = new System.Windows.Forms.Button();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.btn_create_board = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbl_board_name
      // 
      this.lbl_board_name.AutoSize = true;
      this.lbl_board_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbl_board_name.ForeColor = System.Drawing.SystemColors.Window;
      this.lbl_board_name.Location = new System.Drawing.Point(3, 9);
      this.lbl_board_name.Name = "lbl_board_name";
      this.lbl_board_name.Size = new System.Drawing.Size(87, 29);
      this.lbl_board_name.TabIndex = 0;
      this.lbl_board_name.Text = "Назва";
      // 
      // lbl_board_color
      // 
      this.lbl_board_color.AutoSize = true;
      this.lbl_board_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbl_board_color.ForeColor = System.Drawing.SystemColors.Window;
      this.lbl_board_color.Location = new System.Drawing.Point(3, 57);
      this.lbl_board_color.Name = "lbl_board_color";
      this.lbl_board_color.Size = new System.Drawing.Size(83, 29);
      this.lbl_board_color.TabIndex = 0;
      this.lbl_board_color.Text = "Колір";
      // 
      // txt_board_name
      // 
      this.txt_board_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txt_board_name.Location = new System.Drawing.Point(111, 6);
      this.txt_board_name.Name = "txt_board_name";
      this.txt_board_name.Size = new System.Drawing.Size(262, 34);
      this.txt_board_name.TabIndex = 1;
      // 
      // btn_board_color
      // 
      this.btn_board_color.BackColor = System.Drawing.SystemColors.Window;
      this.btn_board_color.Location = new System.Drawing.Point(111, 57);
      this.btn_board_color.Name = "btn_board_color";
      this.btn_board_color.Size = new System.Drawing.Size(262, 34);
      this.btn_board_color.TabIndex = 2;
      this.btn_board_color.UseVisualStyleBackColor = false;
      this.btn_board_color.Click += new System.EventHandler(this.btnBoardColor_Click);
      // 
      // btn_create_board
      // 
      this.btn_create_board.BackColor = System.Drawing.SystemColors.Window;
      this.btn_create_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_create_board.Location = new System.Drawing.Point(8, 109);
      this.btn_create_board.Name = "btn_create_board";
      this.btn_create_board.Size = new System.Drawing.Size(365, 52);
      this.btn_create_board.TabIndex = 2;
      this.btn_create_board.Text = "Створити дошку";
      this.btn_create_board.UseVisualStyleBackColor = false;
      this.btn_create_board.Click += new System.EventHandler(this.btnCreateBoard_Click);
      // 
      // BoardProperty
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SteelBlue;
      this.ClientSize = new System.Drawing.Size(384, 170);
      this.Controls.Add(this.btn_create_board);
      this.Controls.Add(this.btn_board_color);
      this.Controls.Add(this.txt_board_name);
      this.Controls.Add(this.lbl_board_color);
      this.Controls.Add(this.lbl_board_name);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "BoardProperty";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "BoardProperty";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_board_name;
    private System.Windows.Forms.Label lbl_board_color;
    private System.Windows.Forms.TextBox txt_board_name;
    private System.Windows.Forms.Button btn_board_color;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button btn_create_board;
  }
}