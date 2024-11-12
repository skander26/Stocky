using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace gestion_de_stock
{
    public partial class voiresortie : Form
    {
        public static string id;

        public voiresortie()
        {
            InitializeComponent();
            date_debut.Value = DateTime.Today.AddMonths(-1);
            date_fin.Value = DateTime.Today;

            LoadSorties();
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
            if (e.ColumnIndex == 7)
            {
                bool sup = showpopup();
                if (sup)
                {
                    var cellValue = e.Row.Cells[0]?.Value;
                    e.Row.Delete();
                    string id = cellValue.ToString();
                    delete("delete from sortie where id = @id", id);
                }
            }
            else if (e.ColumnIndex == 6)
            {
                var cellValue = e.Row.Cells[0]?.Value;
                id = cellValue.ToString();
                var point_d = new repportSortie();
                point_d.Show();
            }
        }

        private void delete(string requet, string id)
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {
                SqlCommand command = new SqlCommand(requet, baseD.cnn);
                command.Parameters.AddWithValue("@id", id);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} row(s) deleted successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("error happened: " + e.Message);
            }
            finally
            {
                baseD.cnn.Close();
            }
        }

        private bool showpopup()
        {
            DialogResult result = MessageBox.Show("Do you want to confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void btn_actualiser_Click_2(object sender, EventArgs e)
        {
            LoadSorties();
        }

        private void LoadSorties()
        {
            tabledata.Rows.Clear();
            var slc = @"SELECT sortie.id, client, SUBSTRING(CAST(date AS VARCHAR(19)), 0, 12) as date, Devise.designation as devise , Reglement.designation as reglement, num_article
FROM sortie
inner join Devise on Devise.id = id_devise inner join Reglement on Reglement.id = id_reglement
WHERE date BETWEEN @dd AND @df";

            Bd b = new Bd();
            SqlCommand sqlCommand = new SqlCommand(slc, b.cnn);
            sqlCommand.Parameters.AddWithValue("@dd", date_debut.Value);
            sqlCommand.Parameters.AddWithValue("@df", date_fin.Value);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    tabledata.Rows.Add(row["id"], row["client"], row["date"], row["devise"], row["reglement"], row["num_article"], Properties.Resources.mise_a_jour_du_systeme, Properties.Resources.supprimer);
                }
            }
            else
            {
                MessageBox.Show("No data found for the selected dates.");
            }

            var query = @"SELECT id_sortie, produit.designation as designation, qt,sortie_article.prix_u as prix_u,produit.code as code
FROM sortie_article 
INNER JOIN produit ON produit.id = sortie_article.id_article;
";

            LoadArticles(query);
        }

        private void LoadArticles(string query)
        {
            Bd b = new Bd();
            SqlCommand cmd = new SqlCommand(query, b.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataTable table = new DataTable();
            table.Columns.Add("id_sortie");
            table.Columns.Add("code");
            table.Columns.Add("designation");
            table.Columns.Add("qt");
            table.Columns.Add("prix_u");

            foreach (DataRow row in dt.Rows)
            {
                table.Rows.Add(row["id_sortie"], row["code"], row["designation"], row["qt"], row["prix_u"]);
            }

            GridViewTemplate template = new GridViewTemplate();
            template.Caption = "Articles";
            template.DataSource = table;
            template.AllowRowResize = false;
            template.ShowColumnHeaders = true;
            template.Columns["id_sortie"].Width = 150;
            template.Columns["designation"].Width = 150;
            template.Columns["qt"].Width = 150;
            template.Columns["prix_u"].Width = 150;
            template.Columns["code"].Width = 150;

            template.Columns["id_sortie"].IsVisible = false;
            template.Columns["designation"].HeaderText = "Designation";
            template.Columns["qt"].HeaderText = "Quantity";
            template.Columns["prix_u"].HeaderText = "Unit Price";
            template.Columns["code"].HeaderText = "Code";

            template.AllowAddNewRow = false;
            template.AllowEditRow = false;

            tabledata.Templates.Add(template);

            GridViewRelation relation = new GridViewRelation(tabledata.MasterTemplate);
            relation.ChildTemplate = template;
            relation.ParentColumnNames.Add("id");
            relation.ChildColumnNames.Add("id_sortie");

            tabledata.Relations.Add(relation);
        }

        private void Entre_Load(object sender, EventArgs e)
        {
        }

        private void titel_Click(object sender, EventArgs e)
        {
        }

        private void btn_actualiser_Click(object sender, EventArgs e)
        {
            LoadSorties();
        }
    }
}
