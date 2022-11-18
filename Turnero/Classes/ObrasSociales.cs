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
    public int IdObraSocial
    {
      get { return this.idObraSocial; }
      private set
      {
        this.idObraSocial = value;
      }
    }
    private string descripcion = "";
    public string Descripcion
    {
      get { return this.descripcion; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.descripcion = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }
    public ObrasSociales()
    {

    }
    public ObrasSociales(int idObraSocial)
    {
      this.idObraSocial = idObraSocial;
      GetAttr();
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
    public static DataTable LlenarCmb()
    {
      string query = "SELECT * FROM ObrasSociales";
      DataTable tabla = new DataTable();

      tabla = BDHelper.ConsultarSQL(query);
      return tabla;
    
    }

    public void  GetAttr()
    {
      string query = "SELECT * FROM ObrasSociales WHERE idObraSocial = " + this.IdObraSocial;
      DataTable table = new DataTable();
      table = BDHelper.ConsultarSQL(query);
      if (table.Rows.Count != 0)
      {
        IdObraSocial = (int)table.Rows[0]["idObraSocial"];
        Descripcion = table.Rows[0]["descripcion"].ToString();
        
      }
      else
      {
        MessageBox.Show("La obra social que busca no está cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      
      
      
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

    public void ActualizarObraSocial(string descripcionN)
    {
      string query = "UPDATE ObrasSociales SET descripcion = '" + descripcionN + "' WHERE idObraSocial = " + this.IdObraSocial;
      try
      {
        BDHelper.ConsultarSQL(query);
        MessageBox.Show( " Obra Social actualizada", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    

  }
}
