namespace Turnero.Forms
{
  partial class FrmHistoriaClinica
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoriaClinica));
      this.RtbHistoriaClinica = new System.Windows.Forms.RichTextBox();
      this.BtnGuardar = new System.Windows.Forms.Button();
      this.BtnImprimir = new System.Windows.Forms.Button();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.printHistoriaClinica = new System.Drawing.Printing.PrintDocument();
      this.txtDni = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BtnBuscar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // RtbHistoriaClinica
      // 
      this.RtbHistoriaClinica.AcceptsTab = true;
      this.RtbHistoriaClinica.Location = new System.Drawing.Point(39, 92);
      this.RtbHistoriaClinica.Name = "RtbHistoriaClinica";
      this.RtbHistoriaClinica.ReadOnly = true;
      this.RtbHistoriaClinica.Size = new System.Drawing.Size(715, 339);
      this.RtbHistoriaClinica.TabIndex = 2;
      this.RtbHistoriaClinica.Text = "";
      this.RtbHistoriaClinica.TextChanged += new System.EventHandler(this.RtbHistoriaClinica_TextChanged);
      // 
      // BtnGuardar
      // 
      this.BtnGuardar.Location = new System.Drawing.Point(39, 452);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
      this.BtnGuardar.TabIndex = 1;
      this.BtnGuardar.Text = "Guardar";
      this.BtnGuardar.UseVisualStyleBackColor = true;
      this.BtnGuardar.Visible = false;
      this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // BtnImprimir
      // 
      this.BtnImprimir.Location = new System.Drawing.Point(679, 452);
      this.BtnImprimir.Name = "BtnImprimir";
      this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
      this.BtnImprimir.TabIndex = 2;
      this.BtnImprimir.Text = "Imprimir";
      this.BtnImprimir.UseVisualStyleBackColor = true;
      this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
      // 
      // printDialog1
      // 
      this.printDialog1.UseEXDialog = true;
      // 
      // printHistoriaClinica
      // 
      this.printHistoriaClinica.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printHistoriaClinica_PrintPage);
      // 
      // txtDni
      // 
      this.txtDni.Location = new System.Drawing.Point(125, 33);
      this.txtDni.Name = "txtDni";
      this.txtDni.Size = new System.Drawing.Size(154, 20);
      this.txtDni.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Dni paciente :";
      // 
      // BtnBuscar
      // 
      this.BtnBuscar.Location = new System.Drawing.Point(679, 31);
      this.BtnBuscar.Name = "BtnBuscar";
      this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
      this.BtnBuscar.TabIndex = 1;
      this.BtnBuscar.Text = "Buscar";
      this.BtnBuscar.UseVisualStyleBackColor = true;
      this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
      // 
      // FrmHistoriaClinica
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 487);
      this.Controls.Add(this.BtnBuscar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDni);
      this.Controls.Add(this.BtnImprimir);
      this.Controls.Add(this.BtnGuardar);
      this.Controls.Add(this.RtbHistoriaClinica);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmHistoriaClinica";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Historia Clinica";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistoriaClinica_FormClosing);
      this.Load += new System.EventHandler(this.FrmHistoriaClinica_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button BtnImprimir;
    private System.Windows.Forms.PrintDialog printDialog1;
    private System.Drawing.Printing.PrintDocument printHistoriaClinica;
    protected internal System.Windows.Forms.RichTextBox RtbHistoriaClinica;
    protected internal System.Windows.Forms.Button BtnGuardar;
    private System.Windows.Forms.TextBox txtDni;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnBuscar;
  }
}