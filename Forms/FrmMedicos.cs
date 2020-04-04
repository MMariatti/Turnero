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

   
       
      
    

    private void BtnModificarApellido_Click(object sender, EventArgs e)
    {
      if (GrdMedicos.SelectedRows.Count == 0)
      {
        MessageBox.Show("Seleccione al medico que quiere realizarle modificaciones", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

      }
      else
      {
        FrmModificarMedico frmModificarMedico;
        frmModificarMedico = new FrmModificarMedico();
        frmModificarMedico.TxtLegajo.Text = GrdMedicos.SelectedRows[0].Cells[0].Value.ToString();
        frmModificarMedico.TxtApellido.Text = GrdMedicos.SelectedRows[0].Cells[1].Value.ToString();
        frmModificarMedico.TxtNombre.Text = GrdMedicos.SelectedRows[0].Cells[2].Value.ToString();
        frmModificarMedico.CmbEspecialidad.Text = GrdMedicos.SelectedRows[0].Cells[3].Value.ToString();
        frmModificarMedico.Show();
      }
     
    }

   
  }
}
