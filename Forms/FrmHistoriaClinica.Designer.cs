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
      this.RtbHistoriaClinica = new System.Windows.Forms.RichTextBox();
      this.BtnGuardar = new System.Windows.Forms.Button();
      this.BtnImprimir = new System.Windows.Forms.Button();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.printHistoriaClinica = new System.Drawing.Printing.PrintDocument();
      this.SuspendLayout();
      // 
      // RtbHistoriaClinica
      // 
      this.RtbHistoriaClinica.AcceptsTab = true;
      this.RtbHistoriaClinica.Enabled = false;
      this.RtbHistoriaClinica.Location = new System.Drawing.Point(39, 38);
      this.RtbHistoriaClinica.Name = "RtbHistoriaClinica";
      this.RtbHistoriaClinica.Size = new System.Drawing.Size(715, 339);
      this.RtbHistoriaClinica.TabIndex = 0;
      this.RtbHistoriaClinica.Text = "";
      // 
      // BtnGuardar
      // 
      this.BtnGuardar.Location = new System.Drawing.Point(39, 415);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
      this.BtnGuardar.TabIndex = 1;
      this.BtnGuardar.Text = "Guardar";
      this.BtnGuardar.UseVisualStyleBackColor = true;
      this.BtnGuardar.Visible = false;
      // 
      // BtnImprimir
      // 
      this.BtnImprimir.Location = new System.Drawing.Point(679, 415);
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
      // FrmHistoriaClinica
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnImprimir);
      this.Controls.Add(this.BtnGuardar);
      this.Controls.Add(this.RtbHistoriaClinica);
      this.Name = "FrmHistoriaClinica";
      this.Text = "FrmHistoriaClinica";
      this.Load += new System.EventHandler(this.FrmHistoriaClinica_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox RtbHistoriaClinica;
    private System.Windows.Forms.Button BtnGuardar;
    private System.Windows.Forms.Button BtnImprimir;
    private System.Windows.Forms.PrintDialog printDialog1;
    private System.Drawing.Printing.PrintDocument printHistoriaClinica;
  }
}