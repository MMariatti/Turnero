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
  public partial class FrmActualizarPractica : Form
  {
    public FrmActualizarPractica()
    {
      InitializeComponent();
    }

    private void ActualizarPractica()
    {
      string nombre = TxtDescripcion.Text;
      int costo = Convert.ToInt32(TxtCosto.Text);
      int idPractica = Convert.ToInt32(TxtIdPractica.Text);
      Practicas practicas = new Practicas(idPractica);
      int especialidad = Convert.ToInt32(CmbEspecialidades.SelectedValue.ToString());
      practicas.ActualizarPractica(nombre, costo, especialidad);
    }


    private void Btn_Salir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void Btn_Guardar_Click(object sender, EventArgs e)
    {
      if (TxtDescripcion.Text == string.Empty || TxtCosto.Text == string.Empty || CmbEspecialidades.SelectedIndex < 0)
      {
        MessageBox.Show("Por favor complete todos los campos","Actualizar datos",MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        ActualizarPractica();
        this.Close();
      }
    }

    private void FrmActualizarPractica_Load(object sender, EventArgs e)
    {
      CmbEspecialidades.DataSource = Especialidades.LlenarCmb();
      CmbEspecialidades.DisplayMember = "descripcion";
      CmbEspecialidades.ValueMember = "idEspecialidad";
      CmbEspecialidades.SelectedIndex = -1;
    }

    private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
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
