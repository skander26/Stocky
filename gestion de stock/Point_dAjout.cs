using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.UI.Barcode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static Telerik.WinControls.VirtualKeyboard.VirtualKeyboardNativeMethods;

namespace gestion_de_stock
{
    public partial class Point_dAjout : Form
    {
        private int quantite;
        public int id2;
        public int ID;
        public Point_dAjout()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Size = new System.Drawing.Size(1709, 1426);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            order.Text = "N°"+selectId();
            tabledata.CellClick += CellClick;

            //PopulateTreeView();
            LoadTree();

            radTreeView1.NodeMouseClick += new RadTreeView.TreeViewEventHandler(RadTreeView1_NodeMouseClick);


            //dropdown menu fournisseur
            string queryf = "select id,nom from Fournisseur";
            select_liste(queryf,radDropDownList1);

            //dropdown menu devise
            string queryd = "select id,designation from Devise";
            select_liste(queryd,radDropDownList2);
            
            string queryr = "select id,designation from Reglement";
            select_liste(queryr,radDropDownList3);
            


        }

        private void select_liste(string query, RadDropDownList liste)
        {
            Bd b = new Bd();
            try
            {

                liste.Items.Clear();
                SqlCommand cmd = new SqlCommand(query, b.cnn);
                cmd.Parameters.Add("@d", SqlDbType.Int).Value = 0;


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
                MessageBox.Show("erreur :" + ex.Message);
            }
            finally
            { b.cnn.Close(); }
        }
        private void LoadTree()
        {
            radTreeView1.Nodes.Clear();
            string slc = "SELECT id, designation, quantite FROM produit";

            Bd b = new Bd();
            SqlCommand sqlCommand = new SqlCommand(slc, b.cnn);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RadTreeNode n = new RadTreeNode();
                    n.Tag = Convert.ToString(dt.Rows[i]["id"]);
                    n.Text = Convert.ToString(dt.Rows[i]["designation"]) + " - Qt: " + Convert.ToString(dt.Rows[i]["quantite"]);
                    radTreeView1.Nodes.Add(n);
                }
            }
        }

        private void RadTreeView1_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
           
            RadTreeNode clickedNode = e.Node;
            id2 =Convert.ToInt32( clickedNode.Tag);
            if (CheckExistId(Convert.ToString(id2)))
            {
                Addproduit();

            }
            else{
                MessageBox.Show("produit deja ajoute !!");
            }


            



        }

        private void Addproduit()
        {

            Bd b = new Bd();
            string slc = "select produit.id,produit.code, produit.designation, quantite, Unite.designation as unite,prix_u from produit inner join unite on produit.unite = Unite.id where produit.id = @id";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(slc, b.cnn);

                sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(id2));
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tabledata.Rows.Add(dt.Rows[i]["id"],dt.Rows[i]["code"], dt.Rows[i]["designation"], 0, dt.Rows[i]["quantite"], dt.Rows[i]["prix_u"], dt.Rows[i]["unite"], Properties.Resources.supprimer);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("erreur : " + e.Message);

                
            }
            finally
            {
                b.cnn.Close();
            }
            



        }
        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            Bd baseD = new Bd();
            
            //Delete
            if (e.ColumnIndex == 7)
            {
                bool sup = showpopup();
                if (sup)
                {
                    e.Row.Delete();
                }

                
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

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

            radTreeView1.Filter = radTextBox1.Text;
        }
        private bool CheckExistId(string id)
        {
            bool test = true;
            if (tabledata.Rows.Count != 0)
            {
                
                for (int i = 0; i <= tabledata.Rows.Count-1; i++)
                {
                    if (id ==Convert.ToString(tabledata.Rows[i].Cells[0].Value))
                    {
                        test = false;
                    }
                    
                }
            }
            return test;
        }
        private void getElement()
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);
            try
            {
                string recp = reception.Text.Trim();
                string date = radDateTimePicker1.Text.Trim();
                int posf = radDropDownList1.FindString(radDropDownList1.Text);
                int posd = radDropDownList2.FindString(radDropDownList2.Text);
                int posr = radDropDownList3.FindString(radDropDownList3.Text);
                int fourni = Convert.ToInt32(radDropDownList1.Items[posf].Tag);
                int devise = Convert.ToInt32(radDropDownList2.Items[posd].Tag);
                int regl = Convert.ToInt32(radDropDownList3.Items[posr].Tag);

                if (string.IsNullOrEmpty(recp))
                {
                    MessageBox.Show("Check Your Input ");

                }
                else
                {
                    //string regl = reg.Text.Trim();


                    Console.WriteLine(fourni);


                    string query = "INSERT INTO Entre (receptioniste ,date_entrer, id_fournisseur, id_devise ,id_reglement,num_entre) VALUES (@recp, @date, @fourni, @devis, @regl,@num); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, baseD.cnn);

                    cmd.Parameters.AddWithValue("recp", recp);
                    cmd.Parameters.AddWithValue("date", Convert.ToDateTime(date));

                    cmd.Parameters.AddWithValue("fourni", fourni);
                    cmd.Parameters.AddWithValue("devis", devise); 
                    

                  
                   
                        cmd.Parameters.AddWithValue("regl", regl);
                    cmd.Parameters.AddWithValue("num", "N°" + selectId());

                    ID = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Data successfully inserted.");


                   
                }

                    


            }
            catch (Exception e)
            {

                MessageBox.Show("erreur : "+e.Message);
            }
            

        }

        private void ajouter_btn_Click(object sender, EventArgs e)

        {
            getTableData(tabledata);


        }

        

        private bool isNumber(string str)
        {
            int i;
            try
            {
                i = Convert.ToInt32(str);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
       
        
    private void getTableData(RadGridView table)
    {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);
            StringBuilder dataBuilder = new StringBuilder();
            
            // Loop through each row in the RadGridView
            foreach (GridViewRowInfo row in table.Rows)
            {
                if (row is GridViewDataRowInfo) // Ensure it's a data row
                {
                    // Extract data from specific columns
                    var id = row.Cells["id"].Value?.ToString();
                    var qtAcheter = row.Cells["qtacheter"].Value?.ToString();
                    var prix = row.Cells["prix"].Value?.ToString();
                    var unite = row.Cells["unite"].Value?.ToString();
                   

                        string query = "INSERT INTO Entre_Article (id_entre ,id_article, quantite_entre, prix_u) VALUES (@id, @id_article, @quantite_entre, @prix_u); update produit set quantite = quantite + @qt where id = @id_article;";
                        SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                        cmd.Parameters.AddWithValue("id", ID);
                        cmd.Parameters.AddWithValue("id_article", id);
                        cmd.Parameters.AddWithValue("prix_u", prix);
                        cmd.Parameters.AddWithValue("quantite_entre", qtAcheter);
                        cmd.Parameters.AddWithValue("qt", Convert.ToDouble(qtAcheter));
                        if (int.Parse(qtAcheter) <= 0)
                        {
                            MessageBox.Show("verifier la qunatiter");

                        }
                        else
                        {
                            getElement();

                            cmd.ExecuteNonQuery();

                    }

                }


                
            }




    }
    private int selectId()
    {
        Bd basee = new Bd();
        try
        {
            string query = "SELECT COUNT(id) AS total FROM Entre";
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

        private void Point_dAjout_Load(object sender, EventArgs e)
        {

        }
    }
}

