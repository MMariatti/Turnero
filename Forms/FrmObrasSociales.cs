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
  public partial class FrmObrasSociales : Form
  {
    public FrmObrasSociales()
    {
      InitializeComponent();
    }

    private void mostrarObrasSociales()
    {
      DataTable tabla = new DataTable();
      tabla = ObrasSociales.GetAll();
      GrdObraSocial.DataSource = tabla;
    }

    private void AgregarObraSocial(string descripcion)
    {
      try
      {
        ObrasSociales obras = new ObrasSociales(descripcion);
        obras.save();

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void FrmObrasSociales_Load(object sender, EventArgs e)
    {
      mostrarObrasSociales();
    }

    private void BtnActualizar_Click(object sender, EventArgs e)
    {
      mostrarObrasSociales();
    }

    private void BtnAgregarObraSocial_Click(object sender, EventArgs e)
    {
      if (TxtObraSocial.Text==string.Empty)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        AgregarObraSocial(TxtObraSocial.Text);
        TxtObraSocial.Clear();
      }
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir? ", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void BtnModificarObraSocial_Click(object sender, EventArgs e)
    {
      if(GrdObraSocial.SelectedRows.Count !=0)
      {
        FrmModificaObraSocial frmModificaObraSocial = new FrmModificaObraSocial();
        frmModificaObraSocial.TxtIdObraSocial.Text = GrdObraSocial.SelectedRows[0].Cells[0].Value.ToString();
        frmModificaObraSocial.TxtNombreObraSocial.Text = GrdObraSocial.SelectedRows[0].Cells[1].Value.ToString();
        frmModificaObraSocial.Show();
      }
      else
      {
        MessageBox.Show("Por favor, seleccione la obra social que desea modificar ", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      
    }

    private void TxtObraSocial_KeyPress(object sender, KeyPressEventArgs e)
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
