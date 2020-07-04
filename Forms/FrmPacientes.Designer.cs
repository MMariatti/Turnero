namespace Turnero.Forms
{
  partial class FrmPacientes
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
      this.GrdPacientes = new System.Windows.Forms.DataGridView();
      this.BtnAgregarPaciente = new System.Windows.Forms.Button();
      this.BtnSalir = new System.Windows.Forms.Button();
      this.BtnActualizar = new System.Windows.Forms.Button();
      this.BtnModificarPaciente = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.GrdPacientes)).BeginInit();
      this.SuspendLayout();
      // 
      // GrdPacientes
      // 
      this.GrdPacientes.AllowUserToAddRows = false;
      this.GrdPacientes.AllowUserToDeleteRows = false;
      this.GrdPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.GrdPacientes.BackgroundColor = System.Drawing.SystemColors.Menu;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.GrdPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.GrdPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.GrdPacientes.DefaultCellStyle = dataGridViewCellStyle2;
      this.GrdPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
      this.GrdPacientes.Location = new System.Drawing.Point(12, 12);
      this.GrdPacientes.Name = "GrdPacientes";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.GrdPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.GrdPacientes.Size = new System.Drawing.Size(714, 150);
      this.GrdPacientes.TabIndex = 0;
      // 
      // BtnAgregarPaciente
      // 
      this.BtnAgregarPaciente.Location = new System.Drawing.Point(12, 190);
      this.BtnAgregarPaciente.Name = "BtnAgregarPaciente";
      this.BtnAgregarPaciente.Size = new System.Drawing.Size(121, 23);
      this.BtnAgregarPaciente.TabIndex = 1;
      this.BtnAgregarPaciente.Text = "Agregar Paciente";
      this.BtnAgregarPaciente.UseVisualStyleBackColor = true;
      this.BtnAgregarPaciente.Click += new System.EventHandler(this.BtnAgregarPaciente_Click);
      // 
      // BtnSalir
      // 
      this.BtnSalir.Location = new System.Drawing.Point(778, 253);
      this.BtnSalir.Name = "BtnSalir";
      this.BtnSalir.Size = new System.Drawing.Size(75, 23);
      this.BtnSalir.TabIndex = 2;
      this.BtnSalir.Text = "Salir";
      this.BtnSalir.UseVisualStyleBackColor = true;
      this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
      // 
      // BtnActualizar
      // 
      this.BtnActualizar.Location = new System.Drawing.Point(778, 139);
      this.BtnActualizar.Name = "BtnActualizar";
      this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
      this.BtnActualizar.TabIndex = 3;
      this.BtnActualizar.Text = "Actualizar";
      this.BtnActualizar.UseVisualStyleBackColor = true;
      this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
      // 
      // BtnModificarPaciente
      // 
      this.BtnModificarPaciente.Location = new System.Drawing.Point(552, 190);
      this.BtnModificarPaciente.Name = "BtnModificarPaciente";
      this.BtnModificarPaciente.Size = new System.Drawing.Size(174, 23);
      this.BtnModificarPaciente.TabIndex = 4;
      this.BtnModificarPaciente.Text = "Modificar datos del paciente ";
      this.BtnModificarPaciente.UseVisualStyleBackColor = true;
      this.BtnModificarPaciente.Click += new System.EventHandler(this.BtnModificarPaciente_Click);
      // 
      // FrmPacientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(865, 293);
      this.Controls.Add(this.BtnModificarPaciente);
      this.Controls.Add(this.BtnActualizar);
      this.Controls.Add(this.BtnSalir);
      this.Controls.Add(this.BtnAgregarPaciente);
      this.Controls.Add(this.GrdPacientes);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmPacientes";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pacientes";
      this.Load += new System.EventHandler(this.FrmPacientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GrdPacientes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button BtnAgregarPaciente;
    private System.Windows.Forms.Button BtnSalir;
    private System.Windows.Forms.Button BtnActualizar;
    private System.Windows.Forms.Button BtnModificarPaciente;
    protected internal System.Windows.Forms.DataGridView GrdPacientes;
  }
}