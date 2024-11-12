using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock
{
    public partial class repportSortie : Form
    {
        public repportSortie()
        {
            InitializeComponent();
        }

        private void repportSortie_Load(object sender, EventArgs e)
        {
            raportSortie child = new raportSortie();

            DataTable dt1 = backend_stock.etat_stock2();

            try
            {
                child.Database.Tables["tbsortie"].SetDataSource(dt1);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }




            crystalReportViewer1.ReportSource = child;
        }
    }
}
