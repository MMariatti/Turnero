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
  public partial class FrmModificarNombreMedico : Form
  {
    public FrmModificarNombreMedico()
    {
      InitializeComponent();
    }

    private void CambiarNombre()
    {
      string nvoNombre = TxtNvoNombre.Text;
      Medicos Medico = new Medicos(Convert.ToInt32(TxtLegajo.Text));
      Medico.CambiarNombre(nvoNombre);

     
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void BtnCambiarNombre_Click(object sender, EventArgs e)
    {
      if(TxtNvoNombre.Text == String.Empty)
      {
        MessageBox.Show("Por favor complete todos los campos ", "Modifica datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        CambiarNombre();
        this.Close();
      }
    }

    private void FrmModificarNombreMedico_Load(object sender, EventArgs e)
    {

    }

    private void FrmModificarNombreMedico_FormClosing(object sender, FormClosingEventArgs e)
    {
     
    }
  }
}
