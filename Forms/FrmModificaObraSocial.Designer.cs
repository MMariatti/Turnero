namespace Turnero.Forms
{
  partial class FrmModificaObraSocial
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificaObraSocial));
      this.label1 = new System.Windows.Forms.Label();
      this.BtnGuardar = new System.Windows.Forms.Button();
      this.TxtIdObraSocial = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtNombreObraSocial = new System.Windows.Forms.TextBox();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Id ObraSocial :";
      // 
      // BtnGuardar
      // 
      this.BtnGuardar.Location = new System.Drawing.Point(12, 146);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
      this.BtnGuardar.TabIndex = 2;
      this.BtnGuardar.Text = "Guardar";
      this.BtnGuardar.UseVisualStyleBackColor = true;
      this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // TxtIdObraSocial
      // 
      this.TxtIdObraSocial.Location = new System.Drawing.Point(95, 33);
      this.TxtIdObraSocial.Name = "TxtIdObraSocial";
      this.TxtIdObraSocial.ReadOnly = true;
      this.TxtIdObraSocial.Size = new System.Drawing.Size(177, 20);
      this.TxtIdObraSocial.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 98);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Nombre :";
      // 
      // TxtNombreObraSocial
      // 
      this.TxtNombreObraSocial.Location = new System.Drawing.Point(95, 95);
      this.TxtNombreObraSocial.Name = "TxtNombreObraSocial";
      this.TxtNombreObraSocial.Size = new System.Drawing.Size(177, 20);
      this.TxtNombreObraSocial.TabIndex = 1;
      this.TxtNombreObraSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreObraSocial_KeyPress);
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(197, 146);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 3;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // FrmModificaObraSocial
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 192);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.TxtNombreObraSocial);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtIdObraSocial);
      this.Controls.Add(this.BtnGuardar);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmModificaObraSocial";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Modifica Obra Social";
      this.Load += new System.EventHandler(this.FrmModificaObraSocial_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnGuardar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BtnSalir;
    protected internal System.Windows.Forms.TextBox TxtIdObraSocial;
    protected internal System.Windows.Forms.TextBox TxtNombreObraSocial;
  }
}