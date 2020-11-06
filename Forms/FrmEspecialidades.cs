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
  public partial class FrmEspecialidades : Form
  {
    public FrmEspecialidades()
    {
      InitializeComponent();
    }

    public void mostrarEspecialidades()
    {
      DataTable tabla = new DataTable();
      tabla = Especialidades.GetAll();
      GrdEspecialidades.DataSource = tabla;
    }

    private void AgregarEspecialidad(string descripcion)
    {
      try
      {
        Especialidades especialidad = new Especialidades(descripcion);
        especialidad.Save();
        
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
      }
    }
    private void BtnAgregarEspecialidad_Click(object sender, EventArgs e)
    {
      if( TxtAgregarEspecialidad.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        AgregarEspecialidad(TxtAgregarEspecialidad.Text);
        TxtAgregarEspecialidad.Clear();
      }
    }

    private void FrmEspecialidades_Load(object sender, EventArgs e)
    {
      mostrarEspecialidades();
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void BtnActualizar_Click(object sender, EventArgs e)
    {
      mostrarEspecialidades();
    }

    private void BtnModificarEspecialidades_Click(object sender, EventArgs e)
    {
      if(GrdEspecialidades.SelectedRows.Count != 0)
      {
        FrmModificarEspecialidades frmModificarEspecialidades = new FrmModificarEspecialidades();
        frmModificarEspecialidades.TxtIdEspecialidad.Text = GrdEspecialidades.SelectedRows[0].Cells[0].Value.ToString();
        frmModificarEspecialidades.TxtNombreEspecialidad.Text = GrdEspecialidades.SelectedRows[0].Cells[1].Value.ToString();
        frmModificarEspecialidades.Show();

      }
      else
      {
        MessageBox.Show("Por favor, seleccione la especialidad que desea modificar", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
