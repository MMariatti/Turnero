using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnero.Forms
{
  public partial class FrmMainMedico : Form
  {
    public FrmMainMedico()
    {
      InitializeComponent();
    }

    private void BtnHistoriaClinica_Click(object sender, EventArgs e)
    {
      FrmHistoriaClinica frmHistoriaClinica = new FrmHistoriaClinica();
      frmHistoriaClinica.RtbHistoriaClinica.ReadOnly = false;
      frmHistoriaClinica.BtnGuardar.Visible = true;
      frmHistoriaClinica.Show();
    }

    private void FrmMainMedico_Load(object sender, EventArgs e)
    {

    }
  }
}
