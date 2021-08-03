namespace Turnero.Forms
{
  partial class FrmPracticas
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPracticas));
      this.BtnAgregarPracticas = new System.Windows.Forms.Button();
      this.TxtCostoPractica = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.GrdPracticas = new System.Windows.Forms.DataGridView();
      this.BtnActualizar = new System.Windows.Forms.Button();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.TxtNombrePractica = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Btn_ModificarPractica = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
      this.btnEliminarPractica = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.GrdPracticas)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnAgregarPracticas
      // 
      this.BtnAgregarPracticas.Location = new System.Drawing.Point(26, 348);
      this.BtnAgregarPracticas.Name = "BtnAgregarPracticas";
      this.BtnAgregarPracticas.Size = new System.Drawing.Size(100, 23);
      this.BtnAgregarPracticas.TabIndex = 5;
      this.BtnAgregarPracticas.Text = "Agregar Practica";
      this.BtnAgregarPracticas.UseVisualStyleBackColor = true;
      this.BtnAgregarPracticas.Click += new System.EventHandler(this.BtnAgregarPracticas_Click);
      // 
      // TxtCostoPractica
      // 
      this.TxtCostoPractica.Location = new System.Drawing.Point(105, 247);
      this.TxtCostoPractica.Name = "TxtCostoPractica";
      this.TxtCostoPractica.Size = new System.Drawing.Size(172, 20);
      this.TxtCostoPractica.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 202);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Nombre:";
      // 
      // GrdPracticas
      // 
      this.GrdPracticas.BackgroundColor = System.Drawing.SystemColors.Menu;
      this.GrdPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdPracticas.Location = new System.Drawing.Point(26, 21);
      this.GrdPracticas.Name = "GrdPracticas";
      this.GrdPracticas.Size = new System.Drawing.Size(554, 150);
      this.GrdPracticas.TabIndex = 0;
      // 
      // BtnActualizar
      // 
      this.BtnActualizar.Location = new System.Drawing.Point(505, 202);
      this.BtnActualizar.Name = "BtnActualizar";
      this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
      this.BtnActualizar.TabIndex = 1;
      this.BtnActualizar.Text = "Actualizar";
      this.BtnActualizar.UseVisualStyleBackColor = true;
      this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(505, 348);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 7;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // TxtNombrePractica
      // 
      this.TxtNombrePractica.Location = new System.Drawing.Point(105, 199);
      this.TxtNombrePractica.Name = "TxtNombrePractica";
      this.TxtNombrePractica.Size = new System.Drawing.Size(172, 20);
      this.TxtNombrePractica.TabIndex = 2;
      this.TxtNombrePractica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombrePractica_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 250);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Costo : ";
      // 
      // Btn_ModificarPractica
      // 
      this.Btn_ModificarPractica.Location = new System.Drawing.Point(184, 348);
      this.Btn_ModificarPractica.Name = "Btn_ModificarPractica";
      this.Btn_ModificarPractica.Size = new System.Drawing.Size(100, 23);
      this.Btn_ModificarPractica.TabIndex = 6;
      this.Btn_ModificarPractica.Text = "Modificar Practica";
      this.Btn_ModificarPractica.UseVisualStyleBackColor = true;
      this.Btn_ModificarPractica.Click += new System.EventHandler(this.Btn_ModificarPractica_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 288);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Especialidad : ";
      // 
      // cmbEspecialidades
      // 
      this.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEspecialidades.FormattingEnabled = true;
      this.cmbEspecialidades.Location = new System.Drawing.Point(105, 285);
      this.cmbEspecialidades.Name = "cmbEspecialidades";
      this.cmbEspecialidades.Size = new System.Drawing.Size(172, 21);
      this.cmbEspecialidades.TabIndex = 4;
      // 
      // btnEliminarPractica
      // 
      this.btnEliminarPractica.Location = new System.Drawing.Point(347, 348);
      this.btnEliminarPractica.Name = "btnEliminarPractica";
      this.btnEliminarPractica.Size = new System.Drawing.Size(100, 23);
      this.btnEliminarPractica.TabIndex = 9;
      this.btnEliminarPractica.Text = "Eliminar Practica";
      this.btnEliminarPractica.UseVisualStyleBackColor = true;
      this.btnEliminarPractica.Click += new System.EventHandler(this.btnEliminarPractica_Click);
      // 
      // FrmPracticas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(607, 389);
      this.Controls.Add(this.btnEliminarPractica);
      this.Controls.Add(this.cmbEspecialidades);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.Btn_ModificarPractica);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtNombrePractica);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnActualizar);
      this.Controls.Add(this.GrdPracticas);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtCostoPractica);
      this.Controls.Add(this.BtnAgregarPracticas);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmPracticas";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Practicas";
      this.Load += new System.EventHandler(this.FrmPracticas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdPracticas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnAgregarPracticas;
    private System.Windows.Forms.TextBox TxtCostoPractica;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnActualizar;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.TextBox TxtNombrePractica;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button Btn_ModificarPractica;
    protected internal System.Windows.Forms.DataGridView GrdPracticas;
    private System.Windows.Forms.Label label3;
    protected internal System.Windows.Forms.ComboBox cmbEspecialidades;
    private System.Windows.Forms.Button btnEliminarPractica;
  }
}