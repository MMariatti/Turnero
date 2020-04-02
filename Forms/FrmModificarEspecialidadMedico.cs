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
  public partial class FrmModificarEspecialidadMedico : Form
  {
    public FrmModificarEspecialidadMedico()
    {
      InitializeComponent();
    }

    private void CambiarEspecialidad()
    {
      int nvaEspecialidad = Convert.ToInt32(CmbNvaEspecialidad.SelectedValue);
      Medicos medico = new Medicos(Convert.ToInt32(TxtLegajo.Text));
      medico.CambiarEspecialidad(nvaEspecialidad);
     
    }



    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void FrmModificarEspecialidadMedico_FormClosing(object sender, FormClosingEventArgs e)
    {
    
    }

    private void FrmModificarEspecialidadMedico_Load(object sender, EventArgs e)
    {
      CmbNvaEspecialidad.DataSource = Especialidades.GetAll();
      CmbNvaEspecialidad.DisplayMember = "descripcion";
      CmbNvaEspecialidad.ValueMember = "idEspecialidad";
      CmbNvaEspecialidad.SelectedIndex = -1;
    }

    private void BtnCambiarEspecialidad_Click(object sender, EventArgs e)
    {
      if(CmbNvaEspecialidad.SelectedIndex <0)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarEspecialidad();
        this.Close();

      }
    }
  }
}
