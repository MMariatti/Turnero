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
  public partial class FrmAgregarPaciente : Form
  {
    public FrmAgregarPaciente()
    {
      InitializeComponent();
    }

    private void AgregarPaciente(string dni, string apellido, string nombre, int obraSocial, DateTime fechaNac, string telefono,string direccion)
    {
      DataTable tabla = new DataTable();
      try
      {
        
        Pacientes paciente = new Pacientes(dni, apellido,nombre, obraSocial, fechaNac, telefono, direccion);
        paciente.Save();

      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir? los cambios no guardados se perderan", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void FrmAgregarPaciente_Load(object sender, EventArgs e)
    {
      CmbObraSocial.DataSource = ObrasSociales.LlenarCmb();
      CmbObraSocial.DisplayMember = "descripcion";
      CmbObraSocial.ValueMember = "idObraSocial";
      CmbObraSocial.SelectedIndex = -1;
    }

    

    private void FrmAgregarPaciente_FormClosing(object sender, FormClosingEventArgs e)
    {
      
    }

    private void BtnAgregarPaciente_Click(object sender, EventArgs e)
    {
      if (TxtDni.Text == string.Empty || TxtApellido.Text == string.Empty || TxtNombre.Text == string.Empty
       || TxtFechaNac.Text == string.Empty || CmbObraSocial.SelectedIndex < 0 || TxtTelefono.Text == string.Empty || TxtDireccion.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

      }
      else
      {
        AgregarPaciente((TxtDni.Text.ToString()), TxtApellido.Text, TxtNombre.Text, Convert.ToInt32(CmbObraSocial.SelectedValue), DateTime.Parse(TxtFechaNac.Text),(TxtTelefono.Text.ToString()), TxtDireccion.Text);
        this.Close();
      }
    }

    private void CmbObraSocial_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
      {
        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
      {
        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

   

    private void TxtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }
  }
}
