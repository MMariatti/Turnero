namespace Turnero.Forms
{
  partial class FrmTurnos
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
      this.Btn_DarTurno = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
      this.Btn_salir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Btn_DarTurno
      // 
      this.Btn_DarTurno.Location = new System.Drawing.Point(56, 311);
      this.Btn_DarTurno.Name = "Btn_DarTurno";
      this.Btn_DarTurno.Size = new System.Drawing.Size(75, 23);
      this.Btn_DarTurno.TabIndex = 0;
      this.Btn_DarTurno.Text = "Dar Turno";
      this.Btn_DarTurno.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(133, 63);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.Location = new System.Drawing.Point(369, 63);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(53, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Dni Paciente:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(53, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Medico:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(52, 152);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Practica";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(317, 68);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Fecha:";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(133, 100);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 7;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(133, 145);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(317, 240);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Hora:";
      // 
      // maskedTextBox1
      // 
      this.maskedTextBox1.Location = new System.Drawing.Point(369, 237);
      this.maskedTextBox1.Mask = "00:00";
      this.maskedTextBox1.Name = "maskedTextBox1";
      this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
      this.maskedTextBox1.TabIndex = 10;
      this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
      // 
      // Btn_salir
      // 
      this.Btn_salir.Location = new System.Drawing.Point(486, 311);
      this.Btn_salir.Name = "Btn_salir";
      this.Btn_salir.Size = new System.Drawing.Size(75, 23);
      this.Btn_salir.TabIndex = 11;
      this.Btn_salir.Text = "Salir";
      this.Btn_salir.UseVisualStyleBackColor = true;
      // 
      // FrmTurnos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.Btn_salir);
      this.Controls.Add(this.maskedTextBox1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.monthCalendar1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.Btn_DarTurno);
      this.Name = "FrmTurnos";
      this.Text = "FrmTurnos";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Btn_DarTurno;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    private System.Windows.Forms.Button Btn_salir;
  }
}