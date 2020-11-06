using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnero.FormsReportes
{
  public partial class FrmCobroMedicos : Form
  {
    public FrmCobroMedicos()
    {
      InitializeComponent();
    }

    private void FrmCobroMedicos_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dataSetCaja.Caja' Puede moverla o quitarla según sea necesario.
      this.cajaTableAdapter.Fill(this.dataSetCaja.Caja);

      this.reportViewer1.RefreshReport();
    }
  }
}
