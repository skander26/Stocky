using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace gestion_de_stock
{
    public partial class addSortie : Form
    {
        private int id2;
        private int ID;

        public addSortie()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Size = new System.Drawing.Size(1709, 1426);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            order.Text = "N°" + selectId();
            tabledata.CellClick += CellClick;
            radTreeView1.NodeMouseClick += RadTreeView1_NodeMouseClick;
            LoadTree();

            string queryd = "select id, designation from Devise";
            select_liste(queryd, radDropDownList2);

            string queryr = "select id, designation from Reglement";
            select_liste(queryr, radDropDownList3);
        }

        private void select_liste(string query, RadDropDownList liste)
        {
            Bd b = new Bd();
            try
            {
                liste.Items.Clear();
                SqlCommand cmd = new SqlCommand(query, b.cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    for (int k = 0; k < dt.Rows.Count; k++)
                    {
                        liste.Items.Add(dt.Rows[k].ItemArray[1].ToString());
                        liste.Items[k].Tag = dt.Rows[k].ItemArray[0].ToString();
                    }
                }
                else
                {
                    liste.Items.Add("vide");
                    liste.Items[0].Tag = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                b.cnn.Close();
            }
        }

        private void LoadTree()
        {
            radTreeView1.Nodes.Clear();
            string query = "SELECT id, designation, quantite FROM produit";

            Bd b = new Bd();
            SqlCommand sqlCommand = new SqlCommand(query, b.cnn);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RadTreeNode node = new RadTreeNode
                    {
                        Tag = dt.Rows[i]["id"].ToString(),
                        Text = $"{dt.Rows[i]["designation"]} - Qt: {dt.Rows[i]["quantite"]}"
                    };
                    radTreeView1.Nodes.Add(node);
                }
            }
        }

        private void RadTreeView1_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            RadTreeNode clickedNode = e.Node;
            id2 = Convert.ToInt32(clickedNode.Tag);
            if (CheckExistId(id2.ToString()))
            {
                AddProduit();
            }
            else
            {
                MessageBox.Show("Produit déjà ajouté !");
            }
        }

        private void AddProduit()
        {
            Bd b = new Bd();
            string query = "SELECT id, code, designation, quantite, prix_u FROM produit WHERE id = @id";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, b.cnn);
                sqlCommand.Parameters.AddWithValue("@id", id2);
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tabledata.Rows.Add(
                            dt.Rows[i]["id"],
                            dt.Rows[i]["code"],
                            dt.Rows[i]["designation"],
                            dt.Rows[i]["quantite"],
                            0,
                            dt.Rows[i]["prix_u"],
                            Properties.Resources.supprimer);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                b.cnn.Close();
            }
        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (showPopup())
                {
                    e.Row.Delete();
                }
            }
        }

        private bool showPopup()
        {
            DialogResult result = MessageBox.Show("Do you want to confirm ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            radTreeView1.Filter = radTextBox1.Text;
        }

        private bool CheckExistId(string id)
        {
            bool exists = false;
            foreach (var row in tabledata.Rows)
            {
                if (id == row.Cells[0].Value.ToString())
                {
                    exists = true;
                    break;
                }
            }
            return !exists;
        }

        private void ajouter_btn_Click_1(object sender, EventArgs e)
        {
            InsertData();
            order.Text = "N°" + (selectId() + 1);
        }

        private void InsertData()
        {
            if (VerifyAllRows(tabledata) && ValidateInputs())
            {
                try
                {
                    int posd = radDropDownList2.FindString(radDropDownList2.Text);
                    int posr = radDropDownList3.FindString(radDropDownList3.Text);

                    var nom = this.nom.Text;
                    var date = DateTime.Parse(datepicker.Text);

                    int devise = Convert.ToInt32(radDropDownList2.Items[posd].Tag);
                    int regl = Convert.ToInt32(radDropDownList3.Items[posr].Tag);
                    selectId();
                    var num = "N°" + (selectId() + 1);
                    Console.WriteLine(num);
                    order.Text = num;

                    Bd baseD = new Bd();
                    baseD.ouverture_bd(baseD.cnn);
                    string query = "INSERT INTO sortie (client, date, id_devise, id_reglement, num_article) VALUES (@client, @date, @id_devise, @id_reglement, @num_article); SELECT CAST(SCOPE_IDENTITY() as int)";

                    SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                    cmd.Parameters.AddWithValue("@client", nom);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@id_devise", devise);
                    cmd.Parameters.AddWithValue("@id_reglement", regl);
                    cmd.Parameters.AddWithValue("@num_article", num);

                    // Execute the insert command and retrieve the ID of the inserted row
                    ID = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (GridViewRowInfo row in tabledata.Rows)
                    {
                        if (row is GridViewDataRowInfo)
                        {
                            var id_article = row.Cells["id"].Value.ToString();
                            double qtAcheter = Convert.ToDouble(row.Cells["qt"].Value.ToString());
                            var prix = row.Cells["prix_u"].Value.ToString();

                            string query1 = "INSERT INTO sortie_article (id_sortie, id_article, qt, prix_u) VALUES (@id_sortie, @id_article, @qt, @prix_u)";
                            SqlCommand cmd1 = new SqlCommand(query1, baseD.cnn);
                            cmd1.Parameters.AddWithValue("@id_sortie", ID);
                            cmd1.Parameters.AddWithValue("@id_article", id_article);
                            cmd1.Parameters.AddWithValue("@qt", qtAcheter);
                            cmd1.Parameters.AddWithValue("@prix_u", prix);
                            cmd1.ExecuteNonQuery();

                            update_quantite_article_normale(Convert.ToInt32(id_article), qtAcheter);
                        }
                    }

                    baseD.cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during insertion: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled correctly and quantities are greater than 0.");
            }
        }

        private bool VerifyAllRows(RadGridView table)
        {
            foreach (GridViewRowInfo row in table.Rows)
            {
                if (row is GridViewDataRowInfo)
                {
                    var id = int.Parse(row.Cells["id"].Value.ToString());
                    var qtStr = row.Cells["qt"].Value.ToString();
                    if (!verifQt(id, qtStr))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(nom.Text))
            {
                isValid = false;
                MessageBox.Show("Client name is required.");
            }

            if (radDropDownList2.SelectedIndex == -1)
            {
                isValid = false;
                MessageBox.Show("Please select a currency.");
            }

            if (radDropDownList3.SelectedIndex == -1)
            {
                isValid = false;
                MessageBox.Show("Please select a payment method.");
            }

            return isValid;
        }

        private bool verifQt(int id, string qtStr)
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);
            try
            {
                string query = "SELECT quantite FROM produit WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    return false;
                }

                var availableQuantity = int.Parse(dt.Rows[0]["quantite"].ToString());

                if (!int.TryParse(qtStr, out int qt) || qt <= 0)
                {
                    return false;
                }

                if (availableQuantity < qt)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                baseD.cnn.Close();
            }
        }

        private int selectId()
        {
            Bd basee = new Bd();
            try
            {
                string query = "SELECT COUNT(id) AS total FROM sortie";
                SqlCommand cmd = new SqlCommand(query, basee.cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    var total = dt.Rows[0]["total"];
                    return Convert.ToInt32(total);
                }
                else
                {
                    return 0; // If no rows are returned, default to 0
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0; // Return 0 in case of an error
            }
            finally
            {
                basee.cnn.Close(); // Ensure the connection is closed
            }
        }

        private void Sortie_Load(object sender, EventArgs e)
        {
            order.Text = "N°" + (selectId() + 1);
        }

        private void TableData(RadGridView table)
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);
            StringBuilder dataBuilder = new StringBuilder();
            try
            {
                // Your logic here
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            // Loop through each row in the RadGridView
            // Your logic here
        }

        private void radDropDownList3_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            // Your logic here
        }

        private void update_quantite_article_normale(int id_article, double quantite)
        {
            Bd b = new Bd();
            string upd = "update produit set quantite = quantite - @v where id = @i";
            SqlCommand cmd = new SqlCommand(upd, b.cnn);
            cmd.Parameters.Add("@i", SqlDbType.Int).Value = id_article;
            cmd.Parameters.Add("@v", SqlDbType.Real).Value = quantite;
            b.ouverture_bd(b.cnn);
            cmd.ExecuteNonQuery();
        }

        private void ajouter_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
