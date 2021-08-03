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

    private void EliminarMedico(int idMedico)
    {
      Medicos medico = new Medicos(idMedico);
      medico.BorrarMedico();
    }
    private void EliminarTurnosMedico(int idMedico)
    {
      Medicos medico = new Medicos(idMedico);
      medico.BorrarTurnosMedico();
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
        frmModificarMedico.TxtHoraInicio.Text = GrdMedicos.SelectedRows[0].Cells[4].Value.ToString();
        frmModificarMedico.TxtHoraFin.Text = GrdMedicos.SelectedRows[0].Cells[5].Value.ToString();
        frmModificarMedico.TxtIntervaloTurnos.Text = GrdMedicos.SelectedRows[0].Cells[6].Value.ToString();
        frmModificarMedico.TxtPorcentajeDescuento.Text = GrdMedicos.SelectedRows[0].Cells[7].Value.ToString();
        frmModificarMedico.Show();
      }
     
    }

    private void BtnEliminarMedico_Click(object sender, EventArgs e)
    {
      if (GrdMedicos.SelectedRows.Count != 0)
      {
        int legajo = Convert.ToInt32(GrdMedicos.SelectedRows[0].Cells[0].Value.ToString());

        if (MessageBox.Show("¿Está seguro que desea eliminar el medico  seleccionado? ", "Eliminar Medico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          EliminarTurnosMedico(legajo);
          EliminarMedico(legajo);

        }
      }
        
      else
      {
        MessageBox.Show("Por favor, seleccione el medico que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

    }

  }
}
