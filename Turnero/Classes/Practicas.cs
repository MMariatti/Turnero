﻿using System;
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

    public int IdPractica
    {
      get { return this.idPractica; }

      private set
      {
       if(value >=0)
        {
          this.idPractica = value;
        }
       else
        {
          throw new ArgumentNullException();
        }
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

    private int costo = 0;

    public int Costo
    {
      get { return this.costo; }
      private set
      {
        if (value >=0)
        {
          this.costo = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }

    private int idEspecialidad = 0;

    public int IdEspecialidad
    {
      get { return this.idEspecialidad; }
      private set
      {
        if (value >= 0)
        {
          this.idEspecialidad = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }

    private int activo;

    public int Activo
    {
      get { return this.activo; }
      private set
      {
        if (value >= 0)
        {
          this.activo = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }

    public  Practicas()
    {

    }

    public Practicas(int idPractica, string descripcion,int costo, int idEspecialidad, int activo)
    {
      this.IdPractica = idPractica;
      this.Descripcion = descripcion;
      this.Costo = costo;
      this.IdEspecialidad = idEspecialidad;
      this.Activo = activo;

    }
    public Practicas(string descripcion, int costo, int idEspecialidad)
    {
      this.Descripcion = descripcion;
      this.Costo= costo;
      this.IdEspecialidad = idEspecialidad;
    }
    public Practicas(int idPractica)
    {
      this.idPractica = idPractica;
      GetAttr();
    }

    private void GetAttr()
    {
      string query = "SELECT * FROM Practicas WHERE activo=1 AND idPractica = " + idPractica + "";
      DataTable tabla = BDHelper.ConsultarSQL(query);
      this.Descripcion = tabla.Rows[0]["descripcion"].ToString();
      this.Costo = (int)tabla.Rows[0]["costo"];
      this.IdEspecialidad = (int)tabla.Rows[0]["idEspecialidad"];

      
    }



    public static DataTable GetAllEspecifico()
    {
      string query = "SELECT P.idPractica as Codigo, P.descripcion AS Nombre, E.descripcion AS Especialidad, P.costo AS Costo From Practicas P, Especialidades E WHERE P.idEspecialidad = E.idEspecialidad AND P.activo =1 ORDER BY P.descripcion";
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

    public static DataTable GetAll()
    {
      string query = "SELECT * From Practicas WHERE activo =1 ";
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

    public static DataTable GetAll(int idEspecialidad)
    {
      string query = "SELECT * From Practicas WHERE activo=1 AND idEspecialidad = "+idEspecialidad+" ORDER BY descripcion";
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
      string query = "SELECT * FROM Practicas WHERE activo=1 AND idPractica = " + idPractica;
      DataTable tabla = BDHelper.ConsultarSQL(query);
      DataRowCollection filas = tabla.Rows;
      DataRow fila = filas[0];
      Practicas practica = new Practicas(fila.Field<string>("descripcion"), fila.Field<int>("costo"), fila.Field<int>("idEspecialidad"));
      return practica;
    }

    public void save()
    {
      try
      {
        string query = "INSERT INTO Practicas(descripcion, costo, idEspecialidad, activo) " + "VALUES('" + this. descripcion+ "'," + this.costo +","+this.IdEspecialidad+", 1)";
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("La practica " + this.descripcion + " con un costo de " + this.costo + " ha sido cargada correctamente", "Exito!",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void ActualizarPractica(string descripcionN, int costoN, int especialidadN )
    {
      try
      { 
        string query = "UPDATE Practicas SET descripcion = '" + descripcionN + "', costo = " + costoN + ", idEspecialidad ="+ especialidadN +" WHERE idPractica =" + this.idPractica;
        BDHelper.ConsultarSQL(query);
        this.Descripcion = descripcionN;
        this.Costo = costoN;
        this.IdEspecialidad = especialidadN;
        MessageBox.Show("Practica actualizada con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

      }

      catch (Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error al actualizar practica", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    public void BorrarPractica()
    {
      string query = "UPDATE Practicas SET activo = 0 WHERE idPractica = " + IdPractica + " ";
      try
      {
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("Practica borrada", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Primero debe borrar todos los turnos que tengan esta practica asignada", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


    }


  }
}
