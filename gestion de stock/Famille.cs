using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Telerik.WinControls.UI;
using Telerik.WinControls.VirtualKeyboard;
using System.Linq.Expressions;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace gestion_de_stock
{
    public partial class Famille : Form
    {
        Bd DataBase = new Bd();
        object id;
        public Famille()
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
            string slc = " select * from famille ";

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
                

                string codeValue = Cf.Text.Trim();
                string designationValue = Cd.Text.Trim();
                if (string.IsNullOrEmpty(codeValue) || string.IsNullOrEmpty(designationValue))
                {
                    MessageBox.Show("Check Your Input ");

                }
                else
                {


                    string query = "INSERT INTO famille ( Code, Designation) VALUES ( @Code, @Designation)";
                    SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                    cmd.Parameters.AddWithValue("@Code", codeValue);
                    cmd.Parameters.AddWithValue("@Designation", designationValue);
                   


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
                baseD.cnn.Close();
            }
        }


        private void InsertData(string id, string code, string designation,Image i1,Image i2)
        {

            GridViewRowInfo newRow = tabledata.Rows.AddNew();

            newRow.Cells["Id"].Value = id;
            newRow.Cells["Code"].Value = code;
            newRow.Cells["Designation"].Value = designation;
            newRow.Cells["i1"].Value = i1;
            newRow.Cells["i2"].Value = i2;

        }

      

        private void delete(string requet,string id)

        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {

                

                
                string query = requet;
                SqlCommand command = new SqlCommand(query, baseD.cnn);
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} row(s) deleted successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("error hapen : "+e.Message);
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
        private void cancel_button_Click(object sender, EventArgs e)
        {
           update.Visible = false;
            Cf.Clear();
            Cd.Clear();
            delete_button.Visible = false;

        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            Bd baseD = new Bd();
            //Update
            if (e.ColumnIndex == 3)
            {
                object Designation = tabledata.Rows[e.RowIndex].Cells["Designation"].Value;
                object code = tabledata.Rows[e.RowIndex].Cells["Code"].Value;
                id = tabledata.Rows[e.RowIndex].Cells["Id"].Value;
                update.Visible = true;        
                Cd.Text = Designation.ToString();
                Cf.Text = code.ToString();
                delete_button.Visible = true;
            }
            //Delete
            if (e.ColumnIndex == 4)
            {
                object id = tabledata.Rows[e.RowIndex].Cells["Id"].Value;
                string query = "delete from famille where Id = @Id";
                bool sup = showpopup();
                if (sup)
                    delete(query, id.ToString());

                LoadFamille();
            }
            
        }

        private void Updated(string id)
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {
                
                string UpdatedCode = Cf.Text;
                string UpdatedDesg = Cd.Text;
                string query = "UPDATE famille SET Code = @code2, Designation = @desg WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                cmd.Parameters.AddWithValue("code2", UpdatedCode);
                cmd.Parameters.AddWithValue("desg", UpdatedDesg);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("product updated");
            }
            catch(Exception ex) 
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
            delete_button.Visible = false;
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
            DialogResult result = MessageBox.Show("Do you want to confirm ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
