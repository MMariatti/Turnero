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
  public partial class FrmModificarMedico : Form
  {
    public FrmModificarMedico()
    {
      InitializeComponent();
    }

    private void FrmModificarApellido_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void CambiarApellido()
    {
      string nvoApellido = TxtApellido.Text;
      Medicos medico = new Medicos(Convert.ToInt32(TxtLegajo.Text));
      medico.CambiarApellido(nvoApellido);

    }
    private void CambiarEspecialidad()
    {
      int nvaEspecialidad = Convert.ToInt32(CmbEspecialidad.SelectedValue);
      Medicos medico = new Medicos(Convert.ToInt32(TxtLegajo.Text));
      medico.CambiarEspecialidad(nvaEspecialidad);

    }
    private void CambiarNombre()
    {
      string nvoNombre = TxtNombre.Text;
      Medicos Medico = new Medicos(Convert.ToInt32(TxtLegajo.Text));
      Medico.CambiarNombre(nvoNombre);


    }


    private void BtnCambiarApellido_Click(object sender, EventArgs e)
    {
      if (TxtApellido.Text == String.Empty)
      {
        MessageBox.Show("Por favor complete el campo que desea modificar ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarApellido();

      }
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void FrmModificarApellido_Load(object sender, EventArgs e)
    {
      CmbEspecialidad.DataSource = Especialidades.LlenarCmb();
      CmbEspecialidad.DisplayMember = "descripcion";
      CmbEspecialidad.ValueMember = "idEspecialidad";
    }

    private void BtnCambiarNombre_Click(object sender, EventArgs e)
    {
      if (TxtNombre.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete el campo que desea modificar ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarNombre();
      }
    }

    private void BtnCambiarEspecialidad_Click(object sender, EventArgs e)
    {
      if (CmbEspecialidad.SelectedIndex <= 0)
      {
        MessageBox.Show("Por favor complete el campo que desea modificar ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarEspecialidad();
      }
    }

    private void TxtApellido_Click(object sender, EventArgs e)
    {
      TxtApellido.Clear();
    }

    private void TxtNombre_TextChanged(object sender, EventArgs e)
    {

    }

    private void TxtNombre_Click(object sender, EventArgs e)
    {
      TxtNombre.Clear();
    }
  }
}
