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
  public partial class FrmModificarPaciente : Form
  {
    public FrmModificarPaciente()
    {
      InitializeComponent();
    }

 

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void ActualizarP()
    {
      string nombre = TxtNombre.Text;
      string apellido = TxtApellido.Text;
      string dni = TxtDni.Text;
     DateTime fechaNacimiento = DateTime.Parse(TxtFechaNac.Text);
      string direccion = TxtDireccion.Text;
      string telefono = TxtTelefono.Text;
      int obraSocial = Convert.ToInt32(CmbObraSocial.SelectedValue);
      Pacientes paciente = new Pacientes(dni);
      paciente.ActualizarPaciente(nombre, apellido, obraSocial, fechaNacimiento, direccion, telefono);
    }

    private void FrmModificarPaciente_Load(object sender, EventArgs e)
    {
      CmbObraSocial.DataSource = ObrasSociales.LlenarCmb();
      CmbObraSocial.DisplayMember = "descripcion";
      CmbObraSocial.ValueMember = "idObraSocial";
      
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      if(TxtApellido.Text != string.Empty && TxtDireccion.Text != string.Empty &&TxtFechaNac.Text != string.Empty && TxtDni.Text != string.Empty && TxtNombre.Text != string.Empty && TxtTelefono.Text != string.Empty&& CmbObraSocial.SelectedIndex != -1
       )
      {
        ActualizarP();
        this.Close();
      }
      else
      {
        MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }


    
    }
  }
}
