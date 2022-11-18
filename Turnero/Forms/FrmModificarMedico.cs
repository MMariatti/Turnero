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
      DateTime horaInicio = DateTime.Parse(TxtHoraInicio.Text);
      DateTime horaFin = DateTime.Parse(TxtHoraFin.Text);
      int intervaloTurnos = Convert.ToInt32(TxtIntervaloTurnos.Text);
      TxtPorcentajeDescuento.Text.Replace(",", ".");
      double porcentaje = Convert.ToDouble(TxtPorcentajeDescuento.Text);
      Medicos medico = new Medicos(legajo);
      medico.ActualizarMedico(nombreM, apellidoM, idEspecialidadM, horaInicio, horaFin, intervaloTurnos, porcentaje);
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
      CmbEspecialidad.SelectedIndex = -1;
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      if (TxtApellido.Text != string.Empty && TxtNombre.Text != string.Empty && CmbEspecialidad.SelectedIndex != -1 && TxtPorcentajeDescuento.Text != string.Empty &&
        TxtHoraFin.Text != string.Empty && TxtHoraInicio.Text != string.Empty && TxtIntervaloTurnos.Text != string.Empty)
      {
        ActualizarMedico();
        this.Close();
      }
      else
      {
        MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

    private void TxtHoraInicio_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtHoraFin_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
      {
        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }

    private void TxtPorcentajeDescuento_KeyPress(object sender, KeyPressEventArgs e)
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
