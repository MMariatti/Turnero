namespace Turnero.Forms
{
  partial class FrmMedicos
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
      this.GrdMedicos = new System.Windows.Forms.DataGridView();
      this.BtnAgregarMedico = new System.Windows.Forms.Button();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.BtnModificarMedico = new System.Windows.Forms.Button();
      this.BtnActualizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.GrdMedicos)).BeginInit();
      this.SuspendLayout();
      // 
      // GrdMedicos
      // 
      this.GrdMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdMedicos.Location = new System.Drawing.Point(12, 39);
      this.GrdMedicos.Name = "GrdMedicos";
      this.GrdMedicos.Size = new System.Drawing.Size(540, 278);
      this.GrdMedicos.TabIndex = 0;
      // 
      // BtnAgregarMedico
      // 
      this.BtnAgregarMedico.Location = new System.Drawing.Point(12, 335);
      this.BtnAgregarMedico.Name = "BtnAgregarMedico";
      this.BtnAgregarMedico.Size = new System.Drawing.Size(97, 23);
      this.BtnAgregarMedico.TabIndex = 1;
      this.BtnAgregarMedico.Text = "Agregar Medico";
      this.BtnAgregarMedico.UseVisualStyleBackColor = true;
      this.BtnAgregarMedico.Click += new System.EventHandler(this.BtnAgregarMedico_Click);
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(573, 415);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 6;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnModificarMedico
      // 
      this.BtnModificarMedico.Location = new System.Drawing.Point(409, 335);
      this.BtnModificarMedico.Name = "BtnModificarMedico";
      this.BtnModificarMedico.Size = new System.Drawing.Size(143, 23);
      this.BtnModificarMedico.TabIndex = 3;
      this.BtnModificarMedico.Text = "Modificar datos del medico";
      this.BtnModificarMedico.UseVisualStyleBackColor = true;
      this.BtnModificarMedico.Click += new System.EventHandler(this.BtnModificarApellido_Click);
      // 
      // BtnActualizar
      // 
      this.BtnActualizar.Location = new System.Drawing.Point(573, 294);
      this.BtnActualizar.Name = "BtnActualizar";
      this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
      this.BtnActualizar.TabIndex = 5;
      this.BtnActualizar.Text = "Actualizar";
      this.BtnActualizar.UseVisualStyleBackColor = true;
      this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
      // 
      // FrmMedicos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(661, 450);
      this.Controls.Add(this.BtnActualizar);
      this.Controls.Add(this.BtnModificarMedico);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnAgregarMedico);
      this.Controls.Add(this.GrdMedicos);
      this.Name = "FrmMedicos";
      this.Text = "FrmMedicos";
      this.Load += new System.EventHandler(this.FrmMedicos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdMedicos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button BtnAgregarMedico;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Button BtnModificarMedico;
    private System.Windows.Forms.Button BtnActualizar;
    protected internal System.Windows.Forms.DataGridView GrdMedicos;
  }
}