using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace gestion_de_stock
{
    public partial class Entre_Article : Form
    {
        public Entre_Article()
        {
            InitializeComponent();
            LoadFamille();
            tabledata.CellClick += CellClick;
        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            Bd baseD = new Bd();

            if (e.ColumnIndex == 6)
            {
                bool sup = showpopup();
                if (sup)
                {

                    var cellValue = e.Row.Cells[0]?.Value;

                    e.Row.Delete();

                    string id = cellValue.ToString();

                    delete("delete from Entre_Article where id = @id", id);




                }
            }
        }


        private void delete(string requet, string id)

        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {




                string query = requet;
                SqlCommand command = new SqlCommand(query, baseD.cnn);
                command.Parameters.AddWithValue("@id", id);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} row(s) deleted successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("error hapen : " + e.Message);
            }
            finally
            {
                baseD.cnn.Close();
            }

        }
        private bool showpopup()
        {
            DialogResult result = MessageBox.Show("Do you want to confirm ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void LoadFamille()
        {
            tabledata.Rows.Clear();
            string slc = " select * from Entre_Article";

            Bd b = new Bd();
            SqlCommand sqlCommand = new SqlCommand(slc, b.cnn);
            sqlCommand.Parameters.Add("@i1", SqlDbType.Int).Value = 0;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tabledata.Rows.Add(dt.Rows[i].ItemArray[0], dt.Rows[i].ItemArray[1], dt.Rows[i].ItemArray[2], dt.Rows[i].ItemArray[3], dt.Rows[i].ItemArray[4], Properties.Resources.supprimer);
                }
            }



        }

        
    }
}
