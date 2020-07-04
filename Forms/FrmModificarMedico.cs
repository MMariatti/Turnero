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

    private void ActualizarMedico()
    {
      string nombreM = TxtNombre.Text;
      string apellidoM = TxtApellido.Text;
      int idEspecialidadM = Convert.ToInt32(CmbEspecialidad.SelectedValue);
      int legajo = Convert.ToInt32(TxtLegajo.Text);
      Medicos medico = new Medicos(legajo);
      medico.ActualizarMedico(nombreM,apellidoM,idEspecialidadM);
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

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      if(TxtApellido.Text != string.Empty && TxtNombre.Text != string.Empty && CmbEspecialidad.SelectedIndex!= -1 )
      {
        ActualizarMedico();
        this.Close();
      }
      else
      {
        MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      
    }
  }
}
