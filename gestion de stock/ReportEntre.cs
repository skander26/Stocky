using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock
{
    public partial class ReportEntre : Form
    {
        public ReportEntre()
        {
            InitializeComponent();
        }

        private void ReportEntre_Load(object sender, EventArgs e)
        {
            raportEntre child = new raportEntre();

            DataTable dt1 = backend_stock.etat_stock();
          


            child.Database.Tables["rapport"].SetDataSource(dt1);
           


            crystalReportViewer1.ReportSource = child;
        }
    }
}
