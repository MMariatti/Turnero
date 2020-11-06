namespace Turnero.Forms
{
  partial class FrmActualizarPractica
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarPractica));
      this.TxtIdPractica = new System.Windows.Forms.TextBox();
      this.Btn_Guardar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtDescripcion = new System.Windows.Forms.TextBox();
      this.TxtCosto = new System.Windows.Forms.TextBox();
      this.Btn_Salir = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.CmbEspecialidades = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // TxtIdPractica
      // 
      this.TxtIdPractica.Location = new System.Drawing.Point(96, 24);
      this.TxtIdPractica.Name = "TxtIdPractica";
      this.TxtIdPractica.ReadOnly = true;
      this.TxtIdPractica.Size = new System.Drawing.Size(146, 20);
      this.TxtIdPractica.TabIndex = 0;
      // 
      // Btn_Guardar
      // 
      this.Btn_Guardar.Location = new System.Drawing.Point(15, 252);
      this.Btn_Guardar.Name = "Btn_Guardar";
      this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
      this.Btn_Guardar.TabIndex = 4;
      this.Btn_Guardar.Text = "Guardar";
      this.Btn_Guardar.UseVisualStyleBackColor = true;
      this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "ID Practica :";
      // 
      // TxtDescripcion
      // 
      this.TxtDescripcion.Location = new System.Drawing.Point(96, 84);
      this.TxtDescripcion.Name = "TxtDescripcion";
      this.TxtDescripcion.Size = new System.Drawing.Size(146, 20);
      this.TxtDescripcion.TabIndex = 1;
      // 
      // TxtCosto
      // 
      this.TxtCosto.Location = new System.Drawing.Point(96, 145);
      this.TxtCosto.Name = "TxtCosto";
      this.TxtCosto.Size = new System.Drawing.Size(146, 20);
      this.TxtCosto.TabIndex = 2;
      // 
      // Btn_Salir
      // 
      this.Btn_Salir.Location = new System.Drawing.Point(167, 252);
      this.Btn_Salir.Name = "Btn_Salir";
      this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
      this.Btn_Salir.TabIndex = 5;
      this.Btn_Salir.Text = "Salir";
      this.Btn_Salir.UseVisualStyleBackColor = true;
      this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Nombre :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 148);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Costo : ";
      // 
      // CmbEspecialidades
      // 
      this.CmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbEspecialidades.FormattingEnabled = true;
      this.CmbEspecialidades.Location = new System.Drawing.Point(96, 199);
      this.CmbEspecialidades.Name = "CmbEspecialidades";
      this.CmbEspecialidades.Size = new System.Drawing.Size(146, 21);
      this.CmbEspecialidades.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 202);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(76, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Especialidad : ";
      // 
      // FrmActualizarPractica
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(271, 287);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.CmbEspecialidades);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Btn_Salir);
      this.Controls.Add(this.TxtCosto);
      this.Controls.Add(this.TxtDescripcion);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Btn_Guardar);
      this.Controls.Add(this.TxtIdPractica);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmActualizarPractica";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Actualizar practica";
      this.Load += new System.EventHandler(this.FrmActualizarPractica_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button Btn_Guardar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button Btn_Salir;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    protected internal System.Windows.Forms.TextBox TxtIdPractica;
    protected internal System.Windows.Forms.TextBox TxtDescripcion;
    protected internal System.Windows.Forms.TextBox TxtCosto;
    private System.Windows.Forms.Label label4;
    protected internal System.Windows.Forms.ComboBox CmbEspecialidades;
  }
}