namespace Turnero.Forms
{
  partial class FrmAgregarMedico
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarMedico));
      this.BtnAgregar = new System.Windows.Forms.Button();
      this.LblApellido = new System.Windows.Forms.Label();
      this.TxtNombre = new System.Windows.Forms.TextBox();
      this.CmbEspecialidades = new System.Windows.Forms.ComboBox();
      this.LblNombre = new System.Windows.Forms.Label();
      this.LblEspecialidad = new System.Windows.Forms.Label();
      this.TxtApellido = new System.Windows.Forms.TextBox();
      this.BtnCancelar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnAgregar
      // 
      this.BtnAgregar.Location = new System.Drawing.Point(49, 294);
      this.BtnAgregar.Name = "BtnAgregar";
      this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
      this.BtnAgregar.TabIndex = 3;
      this.BtnAgregar.Text = "Agregar";
      this.BtnAgregar.UseVisualStyleBackColor = true;
      this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
      // 
      // LblApellido
      // 
      this.LblApellido.AutoSize = true;
      this.LblApellido.Location = new System.Drawing.Point(46, 41);
      this.LblApellido.Name = "LblApellido";
      this.LblApellido.Size = new System.Drawing.Size(44, 13);
      this.LblApellido.TabIndex = 1;
      this.LblApellido.Text = "Apellido";
      // 
      // TxtNombre
      // 
      this.TxtNombre.Location = new System.Drawing.Point(119, 100);
      this.TxtNombre.Name = "TxtNombre";
      this.TxtNombre.Size = new System.Drawing.Size(137, 20);
      this.TxtNombre.TabIndex = 1;
      // 
      // CmbEspecialidades
      // 
      this.CmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CmbEspecialidades.FormattingEnabled = true;
      this.CmbEspecialidades.Location = new System.Drawing.Point(119, 172);
      this.CmbEspecialidades.Name = "CmbEspecialidades";
      this.CmbEspecialidades.Size = new System.Drawing.Size(137, 21);
      this.CmbEspecialidades.TabIndex = 2;
      // 
      // LblNombre
      // 
      this.LblNombre.AutoSize = true;
      this.LblNombre.Location = new System.Drawing.Point(46, 103);
      this.LblNombre.Name = "LblNombre";
      this.LblNombre.Size = new System.Drawing.Size(44, 13);
      this.LblNombre.TabIndex = 4;
      this.LblNombre.Text = "Nombre";
      // 
      // LblEspecialidad
      // 
      this.LblEspecialidad.AutoSize = true;
      this.LblEspecialidad.Location = new System.Drawing.Point(46, 175);
      this.LblEspecialidad.Name = "LblEspecialidad";
      this.LblEspecialidad.Size = new System.Drawing.Size(67, 13);
      this.LblEspecialidad.TabIndex = 5;
      this.LblEspecialidad.Text = "Especialidad";
      // 
      // TxtApellido
      // 
      this.TxtApellido.Location = new System.Drawing.Point(119, 38);
      this.TxtApellido.Name = "TxtApellido";
      this.TxtApellido.Size = new System.Drawing.Size(137, 20);
      this.TxtApellido.TabIndex = 0;
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.Location = new System.Drawing.Point(181, 294);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
      this.BtnCancelar.TabIndex = 4;
      this.BtnCancelar.Text = "Cancelar";
      this.BtnCancelar.UseVisualStyleBackColor = true;
      this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
      // 
      // FrmAgregarMedico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(341, 350);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.TxtApellido);
      this.Controls.Add(this.LblEspecialidad);
      this.Controls.Add(this.LblNombre);
      this.Controls.Add(this.CmbEspecialidades);
      this.Controls.Add(this.TxtNombre);
      this.Controls.Add(this.LblApellido);
      this.Controls.Add(this.BtnAgregar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmAgregarMedico";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Agregar Medico";
      this.Load += new System.EventHandler(this.FrmAgregarMedico_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnAgregar;
    private System.Windows.Forms.Label LblApellido;
    private System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.ComboBox CmbEspecialidades;
    private System.Windows.Forms.Label LblNombre;
    private System.Windows.Forms.Label LblEspecialidad;
    private System.Windows.Forms.TextBox TxtApellido;
    private System.Windows.Forms.Button BtnCancelar;
  }
}