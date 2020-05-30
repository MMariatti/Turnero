using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.Classes
{
  class Sesion
  {
    private string usuario = "";
    public string Usuario
    {
      get { return this.usuario; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.usuario = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }
    private string contraseña = "";
    public string Contraseña
    {
      get { return this.contraseña; }
      private set
      {
        if (!string.IsNullOrWhiteSpace(value))
        {
          this.contraseña = value;
        }
        else
        {
          throw new ArgumentNullException();
        }
      }
    }
    private int rol = 0;
    public int Rol
    {
      get
      {
        return this.rol;
      }

      private set
      {
        this.rol = value;
      }
    }

    public Sesion(string usuario, string contraseña, int rol)
    {
      this.usuario = usuario;
      this.Contraseña = contraseña;
      this.Rol = rol;
    }
  }
}
