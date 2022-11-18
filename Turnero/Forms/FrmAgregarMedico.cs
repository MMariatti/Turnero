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

    private void AgregarMedico(string apellido, string nombre, int idEspecialidad, DateTime horaInicio, DateTime horaFin, int intervaloTurnos, double porcDesc)
    {

      try
      {

        Medicos Medico = new Medicos(apellido, nombre, idEspecialidad, horaInicio, horaFin, intervaloTurnos, porcDesc);
        Medico.Save();
        MessageBox.Show("Se ha cargado con exito a " + apellido + " " + nombre + "", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
      if (TxtApellido.Text == string.Empty || TxtNombre.Text == string.Empty || CmbEspecialidades.SelectedIndex < 0 || TxtPorcentajeDescuento.Text == string.Empty ||
        TxtHoraInicio.Text == string.Empty || TxtHoraFin.Text == string.Empty || TxtIntervaloTurnos.Text == string.Empty)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        TxtPorcentajeDescuento.Text.Replace(",", ".");
        double porcentaje;
        porcentaje = Convert.ToDouble(TxtPorcentajeDescuento.Text.ToString());
        DateTime horaInicio = new DateTime();
        DateTime horaFin = new DateTime();
        horaInicio = DateTime.Parse(TxtHoraInicio.Text);
        horaFin = DateTime.Parse(TxtHoraFin.Text);
        int intervaloTurnos = Convert.ToInt32(TxtIntervaloTurnos.Text);
        AgregarMedico(TxtApellido.Text, TxtNombre.Text, Convert.ToInt32(CmbEspecialidades.SelectedValue.ToString()), horaInicio, horaFin, intervaloTurnos, porcentaje);
        this.Close();
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

    private void TxtIntervaloTurnos_KeyPress(object sender, KeyPressEventArgs e)
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
