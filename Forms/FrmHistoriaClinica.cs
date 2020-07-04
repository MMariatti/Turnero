using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turnero.Classes;

namespace Turnero.Forms
{
  public partial class FrmHistoriaClinica : Form
  {
    public FrmHistoriaClinica()
    {
      InitializeComponent();
    }
    private void BuscarHistoriaClinica(string dni)
    {
      Pacientes paciente = new Pacientes(dni);
      paciente.BuscarHistoriaClinica();
      RtbHistoriaClinica.Text = paciente.HistoriaClinica.ToString();
    }
    private void BtnImprimir_Click(object sender, EventArgs e)
    {
      printDialog1.Document = printHistoriaClinica;

      if (printDialog1.ShowDialog() == DialogResult.OK)
      {
        printHistoriaClinica.Print();
      }
    }

    private void printHistoriaClinica_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(RtbHistoriaClinica.Text, new Font("Made Tommy Regular", 12, FontStyle.Regular),Brushes.Black,150,125); 
     
    }

    private void FrmHistoriaClinica_Load(object sender, EventArgs e)
    {

    }

    private void BtnBuscar_Click(object sender, EventArgs e)
    {
      if(txtDni.Text != string.Empty)
      {
        BuscarHistoriaClinica(txtDni.Text);
      }
      else
      {
        MessageBox.Show("Ingrese el dni del paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      
    }

    private void RtbHistoriaClinica_TextChanged(object sender, EventArgs e)
    {

    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      Pacientes paciente = new Pacientes(txtDni.Text);
      paciente.GuardarHistoriaClinica(RtbHistoriaClinica.Text);
    }

    private void FrmHistoriaClinica_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir? Los cambios no guardados se perderan", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        e.Cancel = false;
      else
        e.Cancel = true;
    }
  }
}
