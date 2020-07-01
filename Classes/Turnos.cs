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
  class Turnos
  {
    public DateTime fechaTurno = new DateTime();
    public DateTime horaTurno = new DateTime();

    private int legajoMedico = 0;

    public int LegajoMedico
    {
      get { return this.legajoMedico; }
      private set
      {
        this.legajoMedico = value;
      
      }
    }

    private string dniPaciente = "";

    public string DniPaciente
    {
      get { return this.dniPaciente; }
      private set
      {
        if(!string.IsNullOrWhiteSpace(value))
        {
          this.dniPaciente = value;
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
        this.idEspecialidad = value;
      }
    }

    private int practica = 0;
    public int Practica
    {
      get { return this.practica; }
      private set
      {
        this.practica = value;
      }
    }

    private int obraSocial = 0;
    public int ObraSocial
    {
      get { return this.obraSocial; }
      private set
      {
        this.obraSocial = value;
      }
    }

    private int confirmado = 0;
    public int Confirmado
    {
      get { return this.confirmado; }
      private set
      {
        this.confirmado = value;

      }
    }

    private int atendido = 0;
    public int Atendido
    {
      get { return this.atendido; }
      private set
      {
        this.atendido = value;
      }
    }

    public Turnos(DateTime fechaTurno, DateTime horaTurno, int legajoMedico, string dniPaciente, int idEspecialidad, int practica, int obraSocial)
    {
      this.fechaTurno = fechaTurno;
      this.horaTurno = horaTurno;
      this.LegajoMedico = legajoMedico;
      this.DniPaciente = dniPaciente;
      this.IdEspecialidad = idEspecialidad;
      this.Practica = practica;
      this.ObraSocial = obraSocial;
    }

    public void GetAll()
    {
      string query = "SELECT * FROM Turnos";
      DataTable tabla = BDHelper.ConsultarSQL(query);
      fechaTurno = DateTime.Parse(tabla.Rows[0]["fecha"].ToString());
      horaTurno = DateTime.Parse(tabla.Rows[0]["hora"].ToString());
      this.LegajoMedico = (int)tabla.Rows[0]["medico"];
      this.IdEspecialidad = (int)tabla.Rows[0]["idEspecialidad"];
      this.DniPaciente = tabla.Rows[0]["paciente"].ToString();
      this.Practica = (int)tabla.Rows[0]["idPractica"];
      this.ObraSocial = (int)tabla.Rows[0]["obraSocial"];
    }

    public void Save()
    {
      string query = "INSERT into Turnos(fecha, hora, medico, idEspecialidad, paciente, idPractica, obraSocial) VALUES ("
        + fechaTurno.ToString("yyyy-MM-dd") + "," + horaTurno.ToString("hh:mm:ss") + "," + this.LegajoMedico + "," + this.IdEspecialidad + ",'" + this.DniPaciente + "',"
        +this.Practica+"," + this.ObraSocial + ")";
      try{
        BDHelper.ConsultarSQL(query);
        MessageBox.Show("Turno cargado para el dia: " + this.fechaTurno.ToString("yyyy-MM-dd") + " a la hora: " + this.horaTurno.ToString("hh:mm:ss") + " para el paciente con dni: " + this.DniPaciente, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
      }



    }
  }


}
