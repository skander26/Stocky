using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace gestion_de_stock
{
    
    public partial class Entre : Form
    {
        public static string id;
        

        public Entre()
        {

            InitializeComponent();
            date_debut.Value = DateTime.Today.AddMonths(-1);
            date_fin.Value = DateTime.Today;

            LoadFamille();
            tabledata.CellClick += CellClick;
            tabledata.Columns[0].Width = 200;
            tabledata.Columns[1].Width = 150;
            this.tabledata.Columns[2].Width = 200;
            this.tabledata.Columns[3].Width = 150;
            this.tabledata.Columns[4].Width = 150;
            this.tabledata.Columns[5].Width = 150;
            this.tabledata.Columns[6].Width = 80;
        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            Bd baseD = new Bd();

            if (e.ColumnIndex == 7)
            {
                bool sup = showpopup();
                if (sup)
                {
                    var cellValue = e.Row.Cells[0]?.Value;
                    e.Row.Delete();
                    string id = cellValue.ToString();
                    delete("delete from Entre where id = @id", id);
                }
            }
            else if (e.ColumnIndex == 6)
            {
                var cellValue = e.Row.Cells[0]?.Value;
                id = cellValue.ToString();
                var point_d = new ReportEntre();
                point_d.Show();
                

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
            DialogResult result = MessageBox.Show("Do you want to confirm?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        

        private void actualiser_Click_1(object sender, EventArgs e)
        {
            //LoadFamille("select * from Entre");
        }

        private void btn_actualiser_Click_2(object sender, EventArgs e)
        {
            //var datedebut = date_debut.Text;
            //var datefin = date_fin.Text;
            LoadFamille();
        }


        private void LoadFamille()
        {
            

            tabledata.Rows.Clear();
            var slc = "SELECT Entre.id, receptioniste, date_entrer, Fournisseur.nom, Devise.designation, Reglement.designation FROM Entre INNER JOIN Fournisseur ON Fournisseur.id = Entre.id_fournisseur INNER JOIN Reglement ON Reglement.id = Entre.id_reglement INNER JOIN Devise ON Devise.id = Entre.id_devise WHERE date_entrer BETWEEN '" + date_debut.Text + "' AND '" + date_fin.Text + "';";



            Bd b = new Bd();
            SqlCommand sqlCommand = new SqlCommand(slc, b.cnn);
            sqlCommand.Parameters.AddWithValue("@dd",date_debut.Text);
            sqlCommand.Parameters.AddWithValue("@df",date_fin.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tabledata.Rows.Add(dt.Rows[i].ItemArray[0], dt.Rows[i].ItemArray[1], dt.Rows[i].ItemArray[2], dt.Rows[i].ItemArray[3], dt.Rows[i].ItemArray[4], dt.Rows[i].ItemArray[5], Properties.Resources.mise_a_jour_du_systeme, Properties.Resources.supprimer);
                }
            }
            else
            {
                MessageBox.Show("No data found for the selected dates.");

            }



            var query = "SELECT Entre_Article.id_entre,produit.code, produit.designation, Entre_Article.quantite_entre, produit.prix_u, Unite.designation, (produit.prix_u*Entre_Article.quantite_entre) as total FROM Entre_Article INNER JOIN produit ON produit.id = Entre_Article.id_Article INNER JOIN Unite ON produit.unite = Unite.id ";
            load_article(query);



        }


        private void load_article(string query )
        {
            Bd b = new Bd();
            var slc = query;
            
            SqlCommand cmd = new SqlCommand(slc, b.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataTable table = new DataTable();
            table.Columns.Add("column1");
            table.Columns.Add("column2");
            table.Columns.Add("column3");
            table.Columns.Add("column4");
            table.Columns.Add("column5");
            table.Columns.Add("column6");
            table.Columns.Add("column7");

            foreach (DataRow row in dt.Rows)
            {
                table.Rows.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(), row.ItemArray[5].ToString(), row.ItemArray[6].ToString());
            }

            GridViewTemplate template = new GridViewTemplate();
            template.Caption = "Article";
            template.DataSource = table;
            template.AllowRowResize = false;
            template.ShowColumnHeaders = true;

            // Adjust column settings
            template.Columns["column1"].IsVisible = false; // Hide the first column
            template.Columns["column2"].Width = 150;
            template.Columns["column3"].Width = 200;
            template.Columns["column4"].Width = 200;
            template.Columns["column5"].Width = 150;
            template.Columns["column6"].Width = 150;
            template.Columns["column7"].Width = 150;

            // Set column headers
            template.Columns["column2"].HeaderText = "Code Article";
            template.Columns["column3"].HeaderText = "Désignation";
            template.Columns["column4"].HeaderText = "Quantité";
            template.Columns["column5"].HeaderText = "Prix U HT";
            template.Columns["column6"].HeaderText = "Unite";
            template.Columns["column7"].HeaderText = "Total";

            // Configure text alignment
            template.Columns["column2"].TextAlignment = ContentAlignment.MiddleCenter;
            template.Columns["column3"].TextAlignment = ContentAlignment.MiddleCenter;
            template.Columns["column4"].TextAlignment = ContentAlignment.MiddleCenter;
            template.Columns["column5"].TextAlignment = ContentAlignment.MiddleCenter;
            template.Columns["column6"].TextAlignment = ContentAlignment.MiddleCenter;
            template.Columns["column7"].TextAlignment = ContentAlignment.MiddleCenter;

            template.AllowAddNewRow = false;
            template.AllowEditRow = false;

            // Add the template to the main GridView
            tabledata.Templates.Add(template);

            // Define the relationship between the main table and the template
            GridViewRelation relation = new GridViewRelation(tabledata.MasterTemplate);
            relation.ChildTemplate = template;
            relation.ParentColumnNames.Add(tabledata.MasterTemplate.Columns[0].Name);
            relation.ChildColumnNames.Add(template.Columns[0].Name);

            tabledata.Relations.Add(relation);
        }

        private void Entre_Load(object sender, EventArgs e)
        {

                    }

        private void titel_Click(object sender, EventArgs e)
        {

        }

        private void tabledata_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------------------------------------

    }
}
