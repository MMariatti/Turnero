using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace Turnero.Classes
{
  class Meses
  {
    public static DataTable LlenarCmb()
    {
      DataTable tabla = new DataTable();
      string query = "SELECT * FROM Meses";
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
  }
}
