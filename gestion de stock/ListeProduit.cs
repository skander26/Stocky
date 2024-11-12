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
using Telerik.WinControls.VirtualKeyboard;
using Telerik.WinForms.UI.Barcode;

namespace gestion_de_stock
{
    public partial class ListeProduit : Form
    {
        public static string id;
        public ListeProduit()
        {
            InitializeComponent();
            tabledata.CellClick += CellClick;
            

        }

        private void ListeProduit_Load(object sender, EventArgs e)
        {
            LoadFamille();
        }
        private void LoadFamille()
        {
            tabledata.Rows.Clear();
            string slc = " select produit.id,produit.code,produit.designation,quantite,prix_u,unite.designation as unite,reference,stock_min,stock_max from produit inner join unite on produit.unite = unite.id  ";

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
                    tabledata.Rows.Add(dt.Rows[i].ItemArray[0], dt.Rows[i].ItemArray[1], dt.Rows[i].ItemArray[2], dt.Rows[i].ItemArray[3], dt.Rows[i].ItemArray[4], dt.Rows[i].ItemArray[5], dt.Rows[i].ItemArray[6], dt.Rows[i].ItemArray[7], dt.Rows[i].ItemArray[8], Properties.Resources.mise_a_jour_du_systeme, Properties.Resources.supprimer);
                }
            }

            //for (int k= 1; k< tabledata.Columns.Count;k++)
            //{
            //    tabledata.Columns[k].Width = 150;
            //}
            tabledata.Columns[1].Width = 120;
            tabledata.Columns[2].Width = 250;
            tabledata.Columns[3].Width = 150;
            tabledata.Columns[4].Width = 150;
            tabledata.Columns[5].Width = 100;
            tabledata.Columns[6].Width = 100;
            tabledata.Columns[7].Width = 150;
            tabledata.Columns[8].Width = 150;
            tabledata.Columns[9].Width = 80;
            tabledata.Columns[10].Width = 80;

        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            Bd baseD = new Bd();

            //Update
            try
            {


                if (e.ColumnIndex == 9)
                {
                    
                    //object code = tabledata.Rows[e.RowIndex].Cells["code"].Value;
                    //object degn = tabledata.Rows[e.RowIndex].Cells["designation"].Value;
                    //object qut = tabledata.Rows[e.RowIndex].Cells["quantite"].Value;
                    //object prix = tabledata.Rows[e.RowIndex].Cells["prix_u"].Value;
                    //object unite = tabledata.Rows[e.RowIndex].Cells["unite"].Value;
                    //object reference = tabledata.Rows[e.RowIndex].Cells["ref"].Value;
                    //object min = tabledata.Rows[e.RowIndex].Cells["minS"].Value;
                    //object max = tabledata.Rows[e.RowIndex].Cells["maxS"].Value;

                    id = Convert.ToString(tabledata.Rows[e.RowIndex].Cells[0].Value);
                    


                    //num.Text = numm.ToString();
                    //matricule.Text = mat.ToString();
                    //telephone.Text = tel.ToString();
                    //adresse.Text = add.ToString();
                    //ville.Text = vill.ToString();
                    var updtae = new Update_prod();
                    updtae.Show();
                }
                //Delete
                if (e.ColumnIndex == 10)
                {
                    object id = tabledata.Rows[e.RowIndex].Cells["id"].Value;
                    string query = "delete from produit where id = @Id";
                    bool sup = showpopup();
                    if (sup)
                    {
                        delete(query, id.ToString());
                    }

                    LoadFamille();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur" + ex.Message);
            }

        }
        //popup
        private bool showpopup()
        {
            DialogResult result = MessageBox.Show("Do you want to confirm ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        //delete
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

        private void actualiser_Click(object sender, EventArgs e)
        {
            LoadFamille();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            ReportEntre child = new ReportEntre();
            child.Show();
        }
    }
}
