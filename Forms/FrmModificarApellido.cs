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
  public partial class FrmModificarApellido : Form
  {
    public FrmModificarApellido()
    {
      InitializeComponent();
    }

    private void FrmModificarApellido_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void CambiarApellido()
    {
      string nvoApellido = TxtNvoApellido.Text;
      Medicos medico = new Medicos(Convert.ToInt32(TxtLegajo.Text));
      medico.CambiarApellido(nvoApellido);
     
    }


    private void BtnCambiarApellido_Click(object sender, EventArgs e)
    {
      if (TxtNvoApellido.Text == String.Empty)
      {
        MessageBox.Show("Por favor complete todos los campos ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarApellido();
        this.Close();
      }
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

    }
  }
}
