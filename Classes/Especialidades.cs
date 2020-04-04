using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Turnero.Classes
{
  public class Especialidades
  {
    private int idEspecialidad = 0;
   
    private string descripcion = "";

    public int IdEspecialidad
    {
      get { return this.idEspecialidad; }
      private set
      {
        this.idEspecialidad = value;
      }
    }
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




    public Especialidades()
    {

    }

   

    public Especialidades(string descripcion)
    {
      
      this.descripcion = descripcion;
    }

    public Especialidades(int idEspecialidad)
    {
      this.IdEspecialidad = idEspecialidad;
      getAttr();
    }

    private void getAttr()
    {
      string query = "SELECT  descripcion FROM Especialidades WHERE idEspecialidad = " + IdEspecialidad;
      DataTable tabla = BDHelper.ConsultarSQL(query);
      Descripcion = tabla.Rows[0]["descripcion"].ToString();
    }

    public void Save()
    {
      try
      {
        string query = "INSERT INTO Especialidades(descripcion) values('" + this.Descripcion + "')";
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("Se ha cargado " + this.Descripcion + " con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public static DataTable GetAll()
    {
      DataTable tabla = new DataTable();
      string query = "SELECT idEspecialidad AS Codigo, descripcion AS Nombre FROM Especialidades";
      try
      {
        tabla = BDHelper.ConsultarSQL(query);
        return tabla;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return tabla;
      }
    }

    public static DataTable LlenarCmb()
    {
      DataTable tabla = new DataTable();
      string query = "SELECT * FROM Especialidades";
      try
      {
        tabla = BDHelper.ConsultarSQL(query);
        return tabla;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return tabla;
      }
    }
    public void CambiarDescripcion(string descripcionNueva)
    {
      string query = "UPDATE Especialidades SET descripcion = '" + descripcionNueva + "' WHERE idEspecialidad = '" + this.IdEspecialidad + "'";
      try
      {
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("Descripcion: " + this.Descripcion + " cambiado a " + descripcionNueva + ".", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
