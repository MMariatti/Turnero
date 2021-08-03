using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.Classes
{
  class ItemsComboBox
  {
    public string Nombre { get; set; }
    public int Valor { get; set; }

    public ItemsComboBox(string nombre, int valor)
    {
      this.Nombre = nombre;
      this.Valor = valor;
    }

    
  } 
}
