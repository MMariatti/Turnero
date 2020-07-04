namespace Turnero.Forms
{
  partial class FrmEspecialidades
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspecialidades));
      this.BtnAgregarEspecialidad = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtAgregarEspecialidad = new System.Windows.Forms.TextBox();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.GrdEspecialidades = new System.Windows.Forms.DataGridView();
      this.BtnActualizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.GrdEspecialidades)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnAgregarEspecialidad
      // 
      this.BtnAgregarEspecialidad.Location = new System.Drawing.Point(32, 308);
      this.BtnAgregarEspecialidad.Name = "BtnAgregarEspecialidad";
      this.BtnAgregarEspecialidad.Size = new System.Drawing.Size(135, 23);
      this.BtnAgregarEspecialidad.TabIndex = 3;
      this.BtnAgregarEspecialidad.Text = "Agregar especialidad";
      this.BtnAgregarEspecialidad.UseVisualStyleBackColor = true;
      this.BtnAgregarEspecialidad.Click += new System.EventHandler(this.BtnAgregarEspecialidad_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(29, 252);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(138, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre de la especialidad :";
      // 
      // TxtAgregarEspecialidad
      // 
      this.TxtAgregarEspecialidad.Location = new System.Drawing.Point(199, 245);
      this.TxtAgregarEspecialidad.Name = "TxtAgregarEspecialidad";
      this.TxtAgregarEspecialidad.Size = new System.Drawing.Size(189, 20);
      this.TxtAgregarEspecialidad.TabIndex = 2;
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(313, 308);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 4;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // GrdEspecialidades
      // 
      this.GrdEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdEspecialidades.Location = new System.Drawing.Point(32, 22);
      this.GrdEspecialidades.Name = "GrdEspecialidades";
      this.GrdEspecialidades.Size = new System.Drawing.Size(258, 150);
      this.GrdEspecialidades.TabIndex = 0;
      // 
      // BtnActualizar
      // 
      this.BtnActualizar.Location = new System.Drawing.Point(313, 149);
      this.BtnActualizar.Name = "BtnActualizar";
      this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
      this.BtnActualizar.TabIndex = 1;
      this.BtnActualizar.Text = "Actualizar";
      this.BtnActualizar.UseVisualStyleBackColor = true;
      this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
      // 
      // FrmEspecialidades
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(430, 364);
      this.Controls.Add(this.BtnActualizar);
      this.Controls.Add(this.GrdEspecialidades);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.TxtAgregarEspecialidad);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BtnAgregarEspecialidad);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmEspecialidades";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Especialidades";
      this.Load += new System.EventHandler(this.FrmEspecialidades_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdEspecialidades)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnAgregarEspecialidad;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtAgregarEspecialidad;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.DataGridView GrdEspecialidades;
    private System.Windows.Forms.Button BtnActualizar;
  }
}