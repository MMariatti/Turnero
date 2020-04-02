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
  public partial class FrmMedicos : Form
  {
    public FrmMedicos()
    {
      InitializeComponent();
    }

    private void mostrarMedicos()
    {
      DataTable tabla = new DataTable();
      tabla = Medicos.GetAllEspecifico();
      GrdMedicos.DataSource = tabla;

    }


    private void FrmMedicos_Load(object sender, EventArgs e)
    {
      mostrarMedicos();
    }

    private void BtnActualizar_Click(object sender, EventArgs e)
    {
      mostrarMedicos();
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void BtnAgregarMedico_Click(object sender, EventArgs e)
    {
      FrmAgregarMedico frmAgregarMedico;
      frmAgregarMedico = new FrmAgregarMedico();
      frmAgregarMedico.Show();
    }

    private void BtnModificarNombre_Click(object sender, EventArgs e)
    {
     
        FrmModificarNombreMedico frmModificarNombre;
        frmModificarNombre = new FrmModificarNombreMedico();

        frmModificarNombre.TxtLegajo.Text = GrdMedicos.SelectedRows[0].Cells[0].Value.ToString();
        frmModificarNombre.TxtApellido.Text = GrdMedicos.SelectedRows[0].Cells[1].Value.ToString();
        frmModificarNombre.TxtEspecialidad.Text = GrdMedicos.SelectedRows[0].Cells[3].Value.ToString();

        frmModificarNombre.Show();
      
    }

    private void BtnModificarApellido_Click(object sender, EventArgs e)
    {
      FrmModificarApellido frmModificarApellido;
      frmModificarApellido = new FrmModificarApellido();
      frmModificarApellido.TxtLegajo.Text = GrdMedicos.SelectedRows[0].Cells[0].Value.ToString();
      frmModificarApellido.TxtNombre.Text = GrdMedicos.SelectedRows[0].Cells[2].Value.ToString();
      frmModificarApellido.TxtEspecialidad.Text = GrdMedicos.SelectedRows[0].Cells[3].Value.ToString();
      frmModificarApellido.Show();
    }

    private void BtnModificarEspecialidad_Click(object sender, EventArgs e)
    {
      FrmModificarEspecialidadMedico frmModificarEspecialidadMedico;
      frmModificarEspecialidadMedico = new FrmModificarEspecialidadMedico();

      frmModificarEspecialidadMedico.TxtLegajo.Text = GrdMedicos.SelectedRows[0].Cells[0].Value.ToString();
      frmModificarEspecialidadMedico.TxtApellido.Text = GrdMedicos.SelectedRows[0].Cells[1].Value.ToString();
      frmModificarEspecialidadMedico.TxtNombre.Text = GrdMedicos.SelectedRows[0].Cells[2].Value.ToString();
      frmModificarEspecialidadMedico.Show();
    }
  }
}
