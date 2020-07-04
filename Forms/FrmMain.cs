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
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void MostrarTurnosDelDia()
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetTurnosDelDia();
      GrdTurnos.DataSource = tabla;
      GrdTurnos.Columns[7].Visible = false;
      GrdTurnos.Columns[8].Visible = false;
      GrdTurnos.Columns[9].Visible = false;

      foreach (DataGridViewRow row in GrdTurnos.Rows)
      {

        if (Convert.ToBoolean(row.Cells[8].Value.ToString()) && Convert.ToBoolean(row.Cells[9].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.Red;
        }
        else if (Convert.ToBoolean(row.Cells[8].Value.ToString()))
        {
          row.DefaultCellStyle.BackColor = Color.LightBlue;
        }
      }
    }

    private void gestionarMedicosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmMedicos frmMedicos;
      frmMedicos = new FrmMedicos();
      frmMedicos.Show();
    }

    private void gestionarEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmEspecialidades frmEspecialidades;
      frmEspecialidades = new FrmEspecialidades();
      frmEspecialidades.Show();
    }

    private void gestionarObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmObrasSociales frmObrasSociales;
      frmObrasSociales = new FrmObrasSociales();
      frmObrasSociales.Show();
    }

    private void gestionarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmPacientes frmPacientes;
      frmPacientes = new FrmPacientes();
      frmPacientes.Show();
    }

    private void gestionarPracticasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmPracticas frmPracticas;
      frmPracticas = new FrmPracticas();
      frmPracticas.Show();
    }

    private void gestionarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmTurnos frmTurnos;
      frmTurnos = new FrmTurnos();
      frmTurnos.Show();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea cerrar la aplicacion?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        e.Cancel = false;
      else
        e.Cancel = true;
      
    }

   private void VerTurnos(DateTime fecha)
    {
      DataTable tabla = new DataTable();
      tabla = Turnos.GetAllEspecifico(fecha);
      GrdTurnos.DataSource = tabla;
      GrdTurnos.Columns[7].Visible = false;
      GrdTurnos.Columns[8].Visible = false;
      GrdTurnos.Columns[8].Visible = false;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      MostrarTurnosDelDia();
      
    }

    private void verHistoriaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmHistoriaClinica frmHistoriaClinica = new FrmHistoriaClinica();
      frmHistoriaClinica.Show();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      MostrarTurnosDelDia();
      BtnConfirmarTurno.Enabled = true;

    }

    private void btnBuscarTurnos_Click(object sender, EventArgs e)
    {
        VerTurnos(monthCalendarTurno.SelectionStart);
        BtnConfirmarTurno.Enabled = false;
  
    }

    private void BtnConfirmarTurno_Click(object sender, EventArgs e)
    {
      if(GrdTurnos.SelectedRows.Count == 0)
      {
        MessageBox.Show("Por favor, seleccione un turno para ser confirmado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      else
      {
        DateTime fecha = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[1].Value.ToString());
        

        DateTime hora = DateTime.Parse(GrdTurnos.SelectedRows[0].Cells[1].Value.ToString());
        
       

        int medico = Convert.ToInt32(GrdTurnos.SelectedRows[0].Cells[7].Value);
        Turnos turno = new Turnos(fecha, hora, medico);
       
        turno.Confirmar();
      }
    }

    

    private void btnReporte_Click(object sender, EventArgs e)
    {
      this.GrdTurnos.DefaultCellStyle.BackColor = Color.White;
      printPreviewDialogTurnos.Document = printDocumentTurnos;
      printPreviewDialogTurnos.ShowDialog();
    }

    private void printDocumentTurnos_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      this.GrdTurnos.DefaultCellStyle.BackColor = Color.White;

      Bitmap bmp = new Bitmap(this.GrdTurnos.Width, this.GrdTurnos.Height);
      GrdTurnos.DrawToBitmap(bmp, new Rectangle(0,0,this.GrdTurnos.Width,this.GrdTurnos.Height));

      e.Graphics.DrawImage(bmp, 0,0);


    }

    
  }
}
