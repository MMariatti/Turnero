using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Turnero.Classes
{
  class Practicas
  {
    private int idPractica = 0;
    private string descripcion = "";
    private int costo = 0;

    public  Practicas()
    {

    }

    public Practicas(int idPractica, string descripcion,int costo)
    {
      this.idPractica = idPractica;
      this.descripcion = descripcion;
      this.costo = costo;

    }
    public Practicas(string descripcion, int costo)
    {
      this.descripcion = descripcion;
      this.costo = costo;
    }
    public Practicas(int idPractica)
    {
      this.idPractica = idPractica;
      getAttr();
    }

    private void getAttr()
    {
      string query = "SELECT * FROM Practicas WHERE idPractica = " + idPractica + "";
      DataTable tabla = BDHelper.ConsultarSQL(query);
      descripcion = tabla.Rows[0]["descripcion"].ToString();
      costo = (int)tabla.Rows[0]["costo"];
      
    }



    public static DataTable GetAll()
    {
      string query = "SELECT idPractica as Codigo, descripcion AS Nombre, costo AS Costo From Practicas";
      DataTable tabla = new DataTable();
      try
      {
        tabla = BDHelper.ConsultarSQL(query);
        return tabla;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return tabla;

      }


    }

    public Practicas GetPracticas(int idPractica)
    {
      string query = "SELECT * FROM Medicos WHERE legajo = " + idPractica;
      DataTable tabla = BDHelper.ConsultarSQL(query);
      DataRowCollection filas = tabla.Rows;
      DataRow fila = filas[0];
      Practicas practica = new Practicas(fila.Field<string>("descripcion"), fila.Field<int>("costo"));
      return practica;
    }

    public void save()
    {
      try
      {
        string query = "INSERT INTO Practicas(descripcion, costo) " + "VALUES('" + this. descripcion+ "'," + this.costo +")";
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("La practica " + this.descripcion + " con un costo de " + this.costo + " ha sido cargada correctamente", "Exito!",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
