namespace Turnero.Forms
{
  partial class FrmMainMedico
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(284, 81);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(467, 162);
      this.dataGridView1.TabIndex = 1;
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.Location = new System.Drawing.Point(18, 34);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 2;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(284, 34);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(338, 21);
      this.comboBox1.TabIndex = 3;
      // 
      // FrmMainMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.monthCalendar1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmMainMedico";
      this.Text = "FrmMainMedico";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}