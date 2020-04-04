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
  public partial class FrmPacientes : Form
  {
    public FrmPacientes()
    {
      InitializeComponent();
    }

    private void mostrarPacientes()
    {
      DataTable tabla = new DataTable();
      tabla = Pacientes.GetAllEspecifico();
      GrdPacientes.DataSource = tabla;

    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void BtnAgregarPaciente_Click(object sender, EventArgs e)
    {
      FrmAgregarPaciente frmAgregarPaciente;
      frmAgregarPaciente = new FrmAgregarPaciente();
      frmAgregarPaciente.Show();
    }

    private void BtnActualizar_Click(object sender, EventArgs e)
    {
      mostrarPacientes();
    }

    private void FrmPacientes_Load(object sender, EventArgs e)
    {
      mostrarPacientes();
    }

    private void BtnModificarPaciente_Click(object sender, EventArgs e)
    {
      if (GrdPacientes.SelectedRows.Count == 0)
      {
        MessageBox.Show("Por favor seleccione al paciente que quiere modificar", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        FrmModificarPaciente frmModificarPaciente;
        frmModificarPaciente = new FrmModificarPaciente();
        frmModificarPaciente.TxtDni.Text = GrdPacientes.SelectedRows[0].Cells[0].Value.ToString();
        frmModificarPaciente.TxtApellido.Text = GrdPacientes.SelectedRows[0].Cells[1].Value.ToString();
        frmModificarPaciente.TxtNombre.Text = GrdPacientes.SelectedRows[0].Cells[2].Value.ToString();
        frmModificarPaciente.TxtFechaNac.Text = GrdPacientes.SelectedRows[0].Cells[3].Value.ToString();
        frmModificarPaciente.TxtTelefono.Text = GrdPacientes.SelectedRows[0].Cells[5].Value.ToString();
        frmModificarPaciente.CmbObraSocial.Text = GrdPacientes.SelectedRows[0].Cells[4].Value.ToString();
        frmModificarPaciente.TxtDireccion.Text = GrdPacientes.SelectedRows[0].Cells[6].Value.ToString();
        frmModificarPaciente.Show();

      }
    }
  }
}
