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
  public partial class FrmModificaObraSocial : Form
  {
    public FrmModificaObraSocial()
    {
      InitializeComponent();
    }

    public void ActualizarObraSocial()
    {
      int IdObraSocial = Convert.ToInt32(TxtIdObraSocial.Text);
      string nombre = TxtNombreObraSocial.Text;
      ObrasSociales obraSocial = new ObrasSociales(IdObraSocial);
      obraSocial.ActualizarObraSocial(nombre);

    }
    private void FrmModificaObraSocial_Load(object sender, EventArgs e)
    {
 
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      if (TxtNombreObraSocial.Text == string.Empty)
      {
        MessageBox.Show("Por favor, complete todos los campos", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        ActualizarObraSocial();
        this.Close();
      }
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir? ", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void TxtNombreObraSocial_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
      {
        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
        return;
      }
    }
  }
}
