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
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.UI.Barcode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace gestion_de_stock
{
    public partial class Fournissuer : Form
    {
        Bd DataBase = new Bd();
        object id;
        public Fournissuer()
        {
            InitializeComponent();
            tabledata.CellClick += CellClick;

            tabledata.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(TableStyle.select_change);
            tabledata.ViewRowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(TableStyle.select_changee);
            LoadFamille();
        }

        private void LoadFamille()
        {
            tabledata.Rows.Clear();
            string slc = " select * from fournisseur ";

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
                    tabledata.Rows.Add(dt.Rows[i].ItemArray[0], dt.Rows[i].ItemArray[1], dt.Rows[i].ItemArray[2], dt.Rows[i].ItemArray[3], dt.Rows[i].ItemArray[4], dt.Rows[i].ItemArray[5], Properties.Resources.mise_a_jour_du_systeme, Properties.Resources.supprimer);
                }
            }



        }





        private void insert()
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {


                string nomValue = nom.Text.Trim();
                string matValue = matricule.Text.Trim();
                string telValue = telephone.Text.Trim();
                string addValue = adresse.Text.Trim();
                string villeValue = ville.Text.Trim();
                if (string.IsNullOrEmpty(nomValue) || string.IsNullOrEmpty(matValue) || string.IsNullOrEmpty(telValue) || string.IsNullOrEmpty(addValue) || string.IsNullOrEmpty(villeValue))
                {
                    MessageBox.Show("Check Your Input ");

                }
                else
                {


                    string query = "INSERT INTO fournisseur ( nom, matricule, telephone, adresse, ville) VALUES ( @nom, @mat,@tel, @add, @ville)";
                    SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                    cmd.Parameters.AddWithValue("@nom", nomValue);
                    cmd.Parameters.AddWithValue("@mat", matValue);
                    cmd.Parameters.AddWithValue("@tel", telValue);
                    cmd.Parameters.AddWithValue("@add", addValue);
                    cmd.Parameters.AddWithValue("@ville", villeValue);



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data successfully inserted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                nom.Clear();
                baseD.cnn.Close();
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

        private void add_Button_Click(object sender, EventArgs e)
        {
            add_Button.Enabled = true;
            insert();
            LoadFamille();

        }
        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            update.Visible = false;
            nom.Clear();
            cancel_button.Visible = false;

        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            Bd baseD = new Bd();
            //Update
            if (e.ColumnIndex == 6)
            {

                object nomm = tabledata.Rows[e.RowIndex].Cells["nom"].Value;
                object mat = tabledata.Rows[e.RowIndex].Cells["matricule"].Value;
                object tel = tabledata.Rows[e.RowIndex].Cells["telephone"].Value;
                object add = tabledata.Rows[e.RowIndex].Cells["adresse"].Value;
                object vill = tabledata.Rows[e.RowIndex].Cells["ville"].Value;

                id = tabledata.Rows[e.RowIndex].Cells["id"].Value;

                update.Visible = true;

                nom.Text = nomm.ToString();
                matricule.Text = mat.ToString();
                telephone.Text = tel.ToString();
                adresse.Text = add.ToString();  
                ville.Text = vill.ToString();  
               
                cancel_button.Visible = true;
            }
            //Delete
            if (e.ColumnIndex == 7)
            {
                object id = tabledata.Rows[e.RowIndex].Cells["Id"].Value;
                string query = "delete from fournisseur where id = @Id";
                bool sup = showpopup();
                if (sup)
                {
                    delete(query, id.ToString());
                }

                LoadFamille();
            }

        }

        private void Updated(string id)
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {

                string nomValue = nom.Text.Trim();
                string matValue = matricule.Text.Trim();
                string telValue = telephone.Text.Trim();
                string addValue = adresse.Text.Trim();
                string villeValue = ville.Text.Trim();

                string query = "UPDATE fournisseur SET nom = @nom, matricule = @mat, telephone = @tel, adresse = @add, ville = @ville WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                cmd.Parameters.AddWithValue("@nom", nomValue);
                cmd.Parameters.AddWithValue("@mat", matValue);
                cmd.Parameters.AddWithValue("@tel", telValue);
                cmd.Parameters.AddWithValue("@add", addValue);
                cmd.Parameters.AddWithValue("@ville", villeValue);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("product updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            { baseD.cnn.Close(); }


        }

        private void update_Click(object sender, EventArgs e)
        {
            Updated(id.ToString());
            LoadFamille();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cancel_button.Visible = false;
           
        }
        private void CheckDatabaseConnection()
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);
            try
            {


                if (baseD.cnn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Connection to the database is successful.");
                }
                else
                {
                    MessageBox.Show("Failed to connect to the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed even if an error occurs
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

        
      
    }
}
