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
  public partial class FrmLogin : Form
  {

    private string usuarioActual;
    private string contraseñaActual;
    private int rolActual;
   

    public FrmLogin()
    {
      InitializeComponent();
    }

  

    private bool loguear(string usuario, string contra)
    {
      DataTable tabla;
      string consulta = "SELECT usuario , contraseña, idRol FROM Usuarios U WHERE " +
          "U.usuario = '" + usuario + "' AND U.contraseña = '" + contra + "' AND U.activo = 1";
      tabla = BDHelper.ConsultarSQL(consulta);
      if (tabla.Rows.Count == 0)
      {
        return false;
      }
      else
      {
        contraseñaActual = contra;
        usuarioActual = usuario;
        rolActual = (int)tabla.Rows[0]["idRol"];
        
        
        
        return true;
      }
    } 

    private void FrmLogin_Load(object sender, EventArgs e)
    {
      
    }

    private void BtnInciarSesion_Click(object sender, EventArgs e)
    {
      if (TxtUsuario.Text == string.Empty || TxtContra.Text == string.Empty)
      {
        MessageBox.Show("Ingrese Usuario y/o Contrasena", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        
        //Logueo con base de datos 
        if (loguear(TxtUsuario.Text, TxtContra.Text))
        {
          Sesion sesion = new Sesion(usuarioActual,contraseñaActual, rolActual);
          sesion.Logs();
          //Logueo satisfactorio, creacion de instancia de menu principal
          FrmMain frmMainMenu = new FrmMain();
            
          frmMainMenu.Show();
          
          //Minimizacion del frmLogin y eliminacion del TaskBar 
          this.WindowState = FormWindowState.Minimized;
          this.ShowInTaskbar = false;
        }
        else
        {
          MessageBox.Show("Usuario Incorrecto, por favor ingrese nuevamente", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
        }
      }
      
    }

   
    private void BtnSalir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea cerrar la aplicacion?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        e.Cancel = false;
      else
        e.Cancel = true;
    }
  }
}

