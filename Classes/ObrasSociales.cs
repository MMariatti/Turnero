using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turnero.Classes;
using System.Data;

namespace Turnero.Classes
{
  class ObrasSociales
  {
    private int idObraSocial = 0;
    private string descripcion = "";

    public ObrasSociales()
    {

    }

    public ObrasSociales(int idObraSocial,string descripcion)
    {
      this.idObraSocial = idObraSocial;
      this.descripcion = descripcion;
    }

    public ObrasSociales(string descripcion)
    {
      this.descripcion = descripcion;
    }

    public static DataTable GetAll()
    {
      string query = "SELECT idObraSocial AS Codigo, descripcion AS Nombre FROM ObrasSociales";
      DataTable tabla = new DataTable();

      tabla = BDHelper.ConsultarSQL(query);
      return tabla;
    }
    public static DataTable LLenarCmb()
    {
      string query = "SELECT * FROM ObrasSociales";
      DataTable tabla = new DataTable();

      tabla = BDHelper.ConsultarSQL(query);
      return tabla;
    }
    public void save()
    {
      try
      {
        string query = "INSERT INTO ObrasSociales VALUES('" + descripcion + "')";
        BDHelper.ConsultarSQL(query);
        MessageBox.Show(descripcion + " se ha cargado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
     
    }


    

  }
}
