using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Turnero.Classes;
using System.Windows.Forms;

namespace Turnero.Classes
{
  public class Pacientes
  {
    //Forzamos que los parametros sean privados para que una vez creados solo puedan ser modificados por la misma clase
    private string nombre;
    //Creamos Properties que definen los get y set de cada atributo, manteniendo el set privado para que todo el comportamiento quede dentro de la clase
    //y no exista posibilidad de manipulacion maliciosa de datos.
    public string Nombre
    {
      get { return this.nombre; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.nombre = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }
    private string apellido;
    public string Apellido
    {
      get { return this.apellido; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.apellido = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }

    private string telefono;
    public string Telefono
    {
      get { return this.telefono; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.telefono = value;
        }
        else
        {
          throw new ArgumentOutOfRangeException();
        }
      }
    }
    private string dni;
    public string Dni
    {
      get { return this.dni; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.dni = value;
        }
        else
        {
          throw new ArgumentOutOfRangeException();
        }
      }
    }

    
    public DateTime fechaNac = new DateTime() ;

   

    private string direccion;
    public string Direccion
    {
      get { return this.direccion; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.direccion = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }

    private int obraSocial;
    public int ObraSocial
    {
      get { return this.obraSocial; }
      private set
      {
        if (value > 0)
        {
          this.obraSocial = value;
        }
        else
        {
          throw new ArgumentOutOfRangeException();
        }
      }
    }
    private int nroHistoriaClinica;
    public int NroHistoriaClinica
    {
      get { return this.nroHistoriaClinica; }
      private set
      {
        if (value > 0)
        {
          this.nroHistoriaClinica = value;
        }
        else
        {
          throw new ArgumentOutOfRangeException();
        }
      }
    }
   

    private string historiaClinica;
    public string HistoriaClinica
    {
      get { return this.historiaClinica; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.historiaClinica = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }
      



    public Pacientes(string dniPaciente, string apellidoPaciente, string nombrePaciente, int obraSocialPaciente, DateTime fechaNac,string telefonoPaciente, string direccionPaciente)
    {
      this.Dni = dniPaciente;
      this.Apellido = apellidoPaciente;
      this.Nombre = nombrePaciente;
      this.fechaNac = fechaNac;
      this.ObraSocial = obraSocialPaciente;
      this.Telefono = telefonoPaciente;
      this.Direccion = direccionPaciente;
    }

    public Pacientes(string dniPaciente, string apellidoPaciente, string nombrePaciente, int obraSocialPaciente, DateTime fechaNac, string telefonoPaciente, string direccionPaciente, string historiaClinicaPaciente)
    {
      this.Dni = dniPaciente;
      this.Apellido = apellidoPaciente;
      this.Nombre = nombrePaciente;
      this.fechaNac = fechaNac;
      this.ObraSocial = obraSocialPaciente;
      this.Telefono = telefonoPaciente;
      this.Direccion = direccionPaciente;
      this.historiaClinica = historiaClinicaPaciente;
    }
    public Pacientes(string nombre, string apellido)
    {
      this.Nombre = nombre;
      this.apellido = apellido;
      getAttr(Nombre, Apellido);
    }
    public Pacientes(string dni)
    {
      this.Dni = dni;
      getAttr();
    }

    public void getAttr()
    {
      string query = "SELECT * FROM Pacientes WHERE dni = '" + this.Dni + "'";
      DataTable tabla = BDHelper.ConsultarSQL(query);
      if(tabla.Rows.Count != 0)
      {
        Apellido = tabla.Rows[0]["apellido"].ToString();
        Nombre = tabla.Rows[0]["nombre"].ToString();
        ObraSocial = (int)tabla.Rows[0]["obraSocial"];
        fechaNac = DateTime.Parse(tabla.Rows[0]["fechaNac"].ToString());
        Direccion = tabla.Rows[0]["direccion"].ToString();
        Telefono = tabla.Rows[0]["Telefono"].ToString();
        NroHistoriaClinica = (int)tabla.Rows[0]["nroHistoriaClinica"];
        
      }
      else
      {
        MessageBox.Show("El paciente que busca no está cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

    }
    public void getAttr( string nombre, string apellido)
    {
      string query = "SELECT * FROM Pacientes WHERE nombre = '" + nombre + "' AND apellido ='"+apellido+"'";
      DataTable tabla = BDHelper.ConsultarSQL(query);
      if (tabla.Rows.Count != 0)
      {
        Dni = tabla.Rows[0]["dni"].ToString();
        Apellido = tabla.Rows[0]["apellido"].ToString();
        Nombre = tabla.Rows[0]["nombre"].ToString();
        ObraSocial = (int)tabla.Rows[0]["obraSocial"];
        fechaNac = DateTime.Parse(tabla.Rows[0]["fechaNac"].ToString());
        Direccion = tabla.Rows[0]["direccion"].ToString();
        Telefono = tabla.Rows[0]["Telefono"].ToString();
        NroHistoriaClinica = (int)tabla.Rows[0]["nroHistoriaClinica"];

      }
      else
      {
        MessageBox.Show("El paciente que busca no está cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

    }

    public void Save()
    {
      try
      {
        string query = "INSERT INTO Pacientes(dni, apellido, nombre,obraSocial,fechaNac,direccion,telefono) " + "VALUES('" + this.Dni + "','" + this.Apellido + "','" + this.Nombre + "', " + this.ObraSocial + ",'" + this.fechaNac.ToString("yyyy-MM-dd") + "','" + this.Direccion + "','"+ this.Telefono +"')";
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("El paciente "+this.nombre + " " + this.apellido + " se ha cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public static DataTable GetAll()
    {
      DataTable tabla = new DataTable();
      string query = "SELECT * FROM Pacientes";
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

    public static DataTable GetAllEspecifico()
    {
      DataTable tabla = new DataTable();
      string query = "SELECT P.dni AS DNI, P.nroHistoriaClinica AS 'Nº Historia Clinica', P.apellido AS Apellido, P.nombre AS Nombre, P.fechaNac AS 'Fecha de nacimiento'," +
        " O.descripcion AS 'Obra Social', " + "P.telefono AS Telefono, P.direccion AS Direccion, DATEDIFF(YEAR,P.fechaNac,GETDATE())" +
        " - (CASE WHEN DATEADD(YY, DATEDIFF(YEAR, P.fechaNac, GETDATE()),P.fechaNac)> GETDATE() THEN   1 ELSE   0  END) as Edad"  +
        " FROM Pacientes P, ObrasSociales O WHERE P.obraSocial = O.idObraSocial ";
      try
      {
        tabla = BDHelper.ConsultarSQL(query);
        return tabla;
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        return tabla;
      }
    }


    public Pacientes GetPacientes(string dniPaciente, string apellidoPaciente, string nombrePaciente, int obraSocial, DateTime fechaNac, string telefono, string direccion, string historiaClinica)
    {
      string query = "SELECT * FROM Pacientes WHERE dni = '" + dniPaciente + "' AND apellido= '" + apellidoPaciente + "' AND nombre = '" + nombrePaciente + "' AND telefono = '" + telefono + "' AND obraSocial = "
        + obraSocial + "AND direccion ='" + direccion + "' AND historiaClinica ='"+this.historiaClinica+"')";
      DataTable tabla = BDHelper.ConsultarSQL(query);
      DataRowCollection filas = tabla.Rows;
      DataRow fila = filas[0];
      Pacientes paciente = new Pacientes(fila.Field<string>("dni"), fila.Field<string>("apellido"), fila.Field<string>("nombre"), fila.Field<int>("obraSocial"), DateTime.Parse(fila.Field<string>("fechaNac")), fila.Field<string>("telefono"), fila.Field<string>("direccion"), fila.Field<string>("historiaClinica"));
      return paciente;
    }

    public void ActualizarPaciente(string dni, string nombre, string apellido, int obraSocial, DateTime fechaNacimiento, string direccion, string telefono)
    {
      try
      {
        string query = "UPDATE Pacientes SET dni='"+dni+"', apellido = '" + apellido + "', nombre = '" + nombre + "', obraSocial=" + obraSocial +
        ", fechaNac='" + fechaNacimiento.ToString("yyyy-MM-dd") + "', direccion ='" + direccion + "', telefono ='" + telefono + "' WHERE nroHistoriaClinica = " +this.NroHistoriaClinica ;
        BDHelper.ConsultarSQL(query);
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.ObraSocial = obraSocial;
        this.fechaNac = fechaNacimiento;
        this.Direccion = direccion;
        this.Telefono = telefono;
        MessageBox.Show("Datos del paciente actualizados", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error al actualizar datos del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      
    }

    

    public void BuscarHistoriaClinica()
    {
      string query = "SELECT HistoriaClinica FROM Pacientes WHERE dni ='" + this.Dni + "'";
      DataTable tabla = new DataTable();
      try
      {
        tabla = BDHelper.ConsultarSQL(query);

        tabla.Rows[0]["HistoriaClinica"].ToString();
        historiaClinica = tabla.Rows[0]["HistoriaClinica"].ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void GuardarHistoriaClinica(string nuevaHc)
    {
      string query = "UPDATE Pacientes SET HistoriaClinica ='"+nuevaHc+"' WHERE dni ='"+this.Dni+"'";
      try
      {
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("Historia Clinica Guardada", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public static DataTable CheckearPaciente(string dni)
    {
      DataTable tabla = new DataTable();
      string query = "SELECT * FROM Pacientes WHERE dni= '"+dni+"'";
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

    public void BorrarPaciente()
    {
      string query = "DELETE FROM Pacientes WHERE dni = '" + this.Dni+ "'" ;
      try
      {
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("Paciente Eliminado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    
  }
}

