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
      tabla = Practicas.GetAllEspecifico();
      GrdPracticas.DataSource = tabla;
    }

    private void AgregarPractica(string descripcion, int costo, int idEspecialidad)
    {
      try
      {
        Practicas practica = new Practicas(descripcion,costo, idEspecialidad);
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
      cmbEspecialidades.DataSource = Especialidades.LlenarCmb();
      cmbEspecialidades.DisplayMember = "descripcion";
      cmbEspecialidades.ValueMember = "idEspecialidad";
      cmbEspecialidades.SelectedIndex = -1;

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
      if(TxtCostoPractica.Text == string.Empty || TxtNombrePractica.Text == string.Empty || cmbEspecialidades.SelectedIndex < 0)
      {
        MessageBox.Show("Por favor complete todos los campos", "Error al cargar Practica", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        int especialidad = Convert.ToInt32(cmbEspecialidades.SelectedValue.ToString());
        AgregarPractica(TxtNombrePractica.Text,Convert.ToInt32(TxtCostoPractica.Text), especialidad);
        TxtCostoPractica.Clear();
        TxtNombrePractica.Clear();
        TxtNombrePractica.Focus();
        cmbEspecialidades.SelectedIndex = -1;
      }
    }

    private void Btn_ModificarPractica_Click(object sender, EventArgs e)
    {
      if (GrdPracticas.SelectedRows.Count != 0)
      {
        FrmActualizarPractica frmActualizarPractica = new FrmActualizarPractica();
        frmActualizarPractica.TxtIdPractica.Text = GrdPracticas.SelectedRows[0].Cells[0].Value.ToString();
        frmActualizarPractica.TxtDescripcion.Text = GrdPracticas.SelectedRows[0].Cells[1].Value.ToString();
        frmActualizarPractica.CmbEspecialidades.Text = GrdPracticas.SelectedRows[0].Cells[2].Value.ToString();
        frmActualizarPractica.TxtCosto.Text = GrdPracticas.SelectedRows[0].Cells[3].Value.ToString();
        frmActualizarPractica.Show();
      }
      else
      {
        MessageBox.Show("Por favor, seleccione la practica que desea modificar","Modificar datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
      }

    }

    private void TxtNombrePractica_KeyPress(object sender, KeyPressEventArgs e)
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
