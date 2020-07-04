namespace Turnero.Forms
{
  partial class FrmObrasSociales
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObrasSociales));
      this.GrdObraSocial = new System.Windows.Forms.DataGridView();
      this.BtnAgregarObraSocial = new System.Windows.Forms.Button();
      this.TxtObraSocial = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.BtnActualizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.GrdObraSocial)).BeginInit();
      this.SuspendLayout();
      // 
      // GrdObraSocial
      // 
      this.GrdObraSocial.BackgroundColor = System.Drawing.SystemColors.Menu;
      this.GrdObraSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdObraSocial.Location = new System.Drawing.Point(31, 39);
      this.GrdObraSocial.Name = "GrdObraSocial";
      this.GrdObraSocial.Size = new System.Drawing.Size(240, 150);
      this.GrdObraSocial.TabIndex = 0;
      // 
      // BtnAgregarObraSocial
      // 
      this.BtnAgregarObraSocial.Location = new System.Drawing.Point(31, 315);
      this.BtnAgregarObraSocial.Name = "BtnAgregarObraSocial";
      this.BtnAgregarObraSocial.Size = new System.Drawing.Size(127, 23);
      this.BtnAgregarObraSocial.TabIndex = 3;
      this.BtnAgregarObraSocial.Text = "Agregar obra social";
      this.BtnAgregarObraSocial.UseVisualStyleBackColor = true;
      this.BtnAgregarObraSocial.Click += new System.EventHandler(this.BtnAgregarObraSocial_Click);
      // 
      // TxtObraSocial
      // 
      this.TxtObraSocial.Location = new System.Drawing.Point(178, 250);
      this.TxtObraSocial.Name = "TxtObraSocial";
      this.TxtObraSocial.Size = new System.Drawing.Size(174, 20);
      this.TxtObraSocial.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(28, 253);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre de la obra social :";
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(277, 315);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 4;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnActualizar
      // 
      this.BtnActualizar.Location = new System.Drawing.Point(277, 166);
      this.BtnActualizar.Name = "BtnActualizar";
      this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
      this.BtnActualizar.TabIndex = 1;
      this.BtnActualizar.Text = "Actualizar";
      this.BtnActualizar.UseVisualStyleBackColor = true;
      this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
      // 
      // FrmObrasSociales
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(430, 364);
      this.Controls.Add(this.BtnActualizar);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtObraSocial);
      this.Controls.Add(this.BtnAgregarObraSocial);
      this.Controls.Add(this.GrdObraSocial);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmObrasSociales";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Obras Sociales";
      this.Load += new System.EventHandler(this.FrmObrasSociales_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdObraSocial)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView GrdObraSocial;
    private System.Windows.Forms.Button BtnAgregarObraSocial;
    private System.Windows.Forms.TextBox TxtObraSocial;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Button BtnActualizar;
  }
}