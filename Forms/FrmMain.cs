using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnero.Forms
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
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

   

    private void FrmMain_Load(object sender, EventArgs e)
    {
      
    }
  }
}
