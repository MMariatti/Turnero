namespace Turnero.Forms
{
  partial class FrmModificarEspecialidades
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarEspecialidades));
      this.label1 = new System.Windows.Forms.Label();
      this.BtnGuardar = new System.Windows.Forms.Button();
      this.TxtIdEspecialidad = new System.Windows.Forms.TextBox();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.TxtNombreEspecialidad = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(112, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Codigo Especialidad : ";
      // 
      // BtnGuardar
      // 
      this.BtnGuardar.Location = new System.Drawing.Point(15, 144);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
      this.BtnGuardar.TabIndex = 2;
      this.BtnGuardar.Text = "Guardar";
      this.BtnGuardar.UseVisualStyleBackColor = true;
      this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // TxtIdEspecialidad
      // 
      this.TxtIdEspecialidad.Location = new System.Drawing.Point(129, 45);
      this.TxtIdEspecialidad.Name = "TxtIdEspecialidad";
      this.TxtIdEspecialidad.ReadOnly = true;
      this.TxtIdEspecialidad.Size = new System.Drawing.Size(153, 20);
      this.TxtIdEspecialidad.TabIndex = 0;
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(207, 144);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 3;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // TxtNombreEspecialidad
      // 
      this.TxtNombreEspecialidad.Location = new System.Drawing.Point(129, 91);
      this.TxtNombreEspecialidad.Name = "TxtNombreEspecialidad";
      this.TxtNombreEspecialidad.Size = new System.Drawing.Size(153, 20);
      this.TxtNombreEspecialidad.TabIndex = 1;
      this.TxtNombreEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreEspecialidad_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 94);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Nombre :";
      // 
      // FrmModificarEspecialidades
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(294, 177);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtNombreEspecialidad);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.TxtIdEspecialidad);
      this.Controls.Add(this.BtnGuardar);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmModificarEspecialidades";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Modificar Especialidades";
      this.Load += new System.EventHandler(this.FrmModificarEspecialidades_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnGuardar;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Label label2;
    protected internal System.Windows.Forms.TextBox TxtIdEspecialidad;
    protected internal System.Windows.Forms.TextBox TxtNombreEspecialidad;
  }
}