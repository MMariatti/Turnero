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
  public partial class FrmPracticas : Form
  {
    public FrmPracticas()
    {
      InitializeComponent();
    }

    public void MostrarPracticas()
    {
      DataTable tabla = new DataTable();
      tabla = Practicas.GetAll();
      GrdPracticas.DataSource = tabla;
    }

    private void AgregarPractica(string descripcion, int costo)
    {
      try
      {
        Practicas practica = new Practicas(descripcion,costo);
        practica.save();

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

      private void FrmPracticas_Load(object sender, EventArgs e)
    {
      MostrarPracticas();
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea salir? ", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void BtnActualizar_Click(object sender, EventArgs e)
    {
      MostrarPracticas();
    }

    private void BtnAgregarPracticas_Click(object sender, EventArgs e)
    {
      if(TxtCostoPractica.Text==string.Empty || TxtNombrePractica.Text==string.Empty)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar Practica", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        AgregarPractica(TxtNombrePractica.Text,Convert.ToInt32(TxtCostoPractica.Text));
        TxtCostoPractica.Clear();
        TxtNombrePractica.Clear();
        TxtNombrePractica.Focus();
      }
    }
  }
}
