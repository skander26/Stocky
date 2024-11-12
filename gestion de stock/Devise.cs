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
    public partial class Devise : Form
    {
        Bd DataBase = new Bd();
        object id;
        public Devise()
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
            string slc = " select * from Devise ";

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
                    tabledata.Rows.Add(dt.Rows[i].ItemArray[0], dt.Rows[i].ItemArray[1], dt.Rows[i].ItemArray[2], Properties.Resources.mise_a_jour_du_systeme, Properties.Resources.supprimer);
                }
            }



        }





        private void insert()
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {


                string converstoionValue = conversion.Text.Trim();
                string designationValue = designation.Text.Trim();
                if (string.IsNullOrEmpty(converstoionValue) || string.IsNullOrEmpty(designationValue))
                {
                    MessageBox.Show("Check Your Input ");

                }
                else
                {


                    string query = "INSERT INTO Devise ( designation, convertion) VALUES ( @design, @conv)";
                    SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                    cmd.Parameters.AddWithValue("@conv", converstoionValue);
                    cmd.Parameters.AddWithValue("@design", designationValue);



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
                conversion.Clear();
                designation.Clear();   
                baseD.cnn.Close();
            }
        }


        private void InsertData(string id, string convertion, string designation, Image i1, Image i2)
        {

            GridViewRowInfo newRow = tabledata.Rows.AddNew();

            newRow.Cells["Id"].Value = id;
            newRow.Cells["Designation"].Value = designation;
            newRow.Cells["Convertion"].Value = convertion;
            
            newRow.Cells["i1"].Value = i1;
            newRow.Cells["i2"].Value = i2;

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
            insert();
            LoadFamille();

        }
        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            update.Visible = false;
            conversion.Clear();
            designation.Clear();
            cancel_button.Visible = false;

        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            Bd baseD = new Bd();
            //Update
            if (e.ColumnIndex == 3)
            {
                object desgn = tabledata.Rows[e.RowIndex].Cells["designation"].Value;
                object convert = tabledata.Rows[e.RowIndex].Cells["convertion"].Value;
                id = tabledata.Rows[e.RowIndex].Cells["Id"].Value;
                update.Visible = true;
                conversion.Text = convert.ToString();
                designation.Text = desgn.ToString();
                cancel_button.Visible = true;
            }
            //Delete
            if (e.ColumnIndex == 4)
            {
                object id = tabledata.Rows[e.RowIndex].Cells["Id"].Value;
                string query = "delete from devis where id = @Id";
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

                string Updatedconv = conversion.Text;
                string UpdatedDesg = designation.Text;
                string query = "UPDATE devis SET  designation = @desg, convertion = @conv  WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                cmd.Parameters.AddWithValue("@conv", Updatedconv);
                cmd.Parameters.AddWithValue("@desg", UpdatedDesg);
                cmd.Parameters.AddWithValue("id", id);
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
            //CheckDatabaseConnection();
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
            DialogResult result = MessageBox.Show("Do you want to confirm ?","confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void Devise_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

