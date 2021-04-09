namespace Turnero.Forms
{
  partial class FrmBuscarPaciente
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarPaciente));
      this.label1 = new System.Windows.Forms.Label();
      this.TxtDni = new System.Windows.Forms.TextBox();
      this.BtnBuscar = new System.Windows.Forms.Button();
      this.GrdPacientes = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.GrdPacientes)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "DNI :";
      // 
      // TxtDni
      // 
      this.TxtDni.Location = new System.Drawing.Point(82, 24);
      this.TxtDni.Name = "TxtDni";
      this.TxtDni.Size = new System.Drawing.Size(149, 20);
      this.TxtDni.TabIndex = 0;
      this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
      // 
      // BtnBuscar
      // 
      this.BtnBuscar.Location = new System.Drawing.Point(297, 21);
      this.BtnBuscar.Name = "BtnBuscar";
      this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
      this.BtnBuscar.TabIndex = 1;
      this.BtnBuscar.Text = "Buscar";
      this.BtnBuscar.UseVisualStyleBackColor = true;
      this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
      // 
      // GrdPacientes
      // 
      this.GrdPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GrdPacientes.Location = new System.Drawing.Point(26, 149);
      this.GrdPacientes.Name = "GrdPacientes";
      this.GrdPacientes.ReadOnly = true;
      this.GrdPacientes.Size = new System.Drawing.Size(346, 150);
      this.GrdPacientes.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 113);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Apellido :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 70);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Nombre :";
      // 
      // TxtApellido
      // 
      this.TxtApellido.Location = new System.Drawing.Point(82, 110);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(149, 20);
      this.TxtApellido.TabIndex = 3;
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(82, 67);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(149, 20);
      this.TxtNombre.TabIndex = 2;
      // 
      // FrmBuscarPaciente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(401, 323);
      this.Controls.Add(this.TxtNombre);
      this.Controls.Add(this.TxtApellido);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.GrdPacientes);
      this.Controls.Add(this.BtnBuscar);
      this.Controls.Add(this.TxtDni);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmBuscarPaciente";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Buscar Paciente";
      this.Load += new System.EventHandler(this.FrmBuscarPaciente_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdPacientes)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtDni;
    private System.Windows.Forms.Button BtnBuscar;
    private System.Windows.Forms.DataGridView GrdPacientes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TxtApellido;
    private System.Windows.Forms.TextBox TxtNombre;
  }
}