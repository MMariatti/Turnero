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
  public partial class FrmModificarEspecialidades : Form
  {
    public FrmModificarEspecialidades()
    {
      InitializeComponent();
    }

    public void ActualizarEspecialidades()
    {
      int IdEspecialidad = Convert.ToInt32(TxtIdEspecialidad.Text);
      string nombre = TxtNombreEspecialidad.Text;

      Especialidades especialidad = new Especialidades(IdEspecialidad);
      especialidad.ActualizarEspecialidad(nombre);

    }
    

    private void FrmModificarEspecialidades_Load(object sender, EventArgs e)
    {

    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      if (TxtNombreEspecialidad.Text == string.Empty)
      {
        MessageBox.Show("Por favor, complete todos los campos", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        ActualizarEspecialidades();
        this.Close();
      }
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }
  }
}
