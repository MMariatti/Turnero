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
  public partial class FrmAgregarMedico : Form
  {
    public FrmAgregarMedico()
    {
      InitializeComponent();
    }

    private void AgregarMedico(string apellido, string nombre, int idEspecialidad)
    {
      
      try
      {

       Medicos Medico = new Medicos(apellido, nombre, idEspecialidad);
        Medico.Save();
        MessageBox.Show("Se ha cargado con exito a " + apellido +" "+ nombre + "", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }
    private void BtnCancelar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void FrmAgregarMedico_Load(object sender, EventArgs e)
    {
      CmbEspecialidades.DataSource = Especialidades.LlenarCmb();
      CmbEspecialidades.DisplayMember = "descripcion";
      CmbEspecialidades.ValueMember = "idEspecialidad";
      CmbEspecialidades.SelectedIndex = -1;
    }

    private void BtnAgregar_Click(object sender, EventArgs e)
    {
      if(TxtApellido.Text == string.Empty || TxtNombre.Text == string.Empty || CmbEspecialidades.SelectedIndex < 0)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        AgregarMedico(TxtApellido.Text, TxtNombre.Text, Convert.ToInt32(CmbEspecialidades.SelectedValue.ToString()));
        this.Close();
      }
    }
  }
}
