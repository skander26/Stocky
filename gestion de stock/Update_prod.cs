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
using Telerik.WinForms.UI.Barcode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace gestion_de_stock
{
    public partial class Update_prod : Form
    {
        string id;
        public Update_prod()
        {
            InitializeComponent();
           
        }
        private void select_unite()
        {

            radDropDownList1.Items.Clear();
            string slc = "select id,designation from unite ";
            Bd b = new Bd();
            SqlCommand cmd = new SqlCommand(slc, b.cnn);
            cmd.Parameters.Add("@d", SqlDbType.Int).Value = 0;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    radDropDownList1.Items.Add(dt.Rows[k].ItemArray[1].ToString());
                    radDropDownList1.Items[k].Tag = dt.Rows[k].ItemArray[0].ToString();

                }
            }



        }
        private void LoadFamille()
        {
         
            string slc = " select produit.code,produit.designation,quantite,prix_u,unite,reference,stock_min,stock_max from produit  where produit.id = @v1  ";

            Bd baseD = new Bd();
            SqlCommand sqlCommand = new SqlCommand(slc, baseD.cnn);
            sqlCommand.Parameters.AddWithValue("@v1", id.ToString());
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
         //  


            if (dt.Rows.Count != 0)
            {
                string unite = dt.Rows[0].ItemArray[4].ToString();
                GetItemListe(unite);
                code.Text = dt.Rows[0].ItemArray[0].ToString(); 
                designation.Text = dt.Rows[0].ItemArray[1].ToString(); 
                quantite.Text = dt.Rows[0].ItemArray[2].ToString();
                prix_u.Text = dt.Rows[0].ItemArray[3].ToString();
                reference.Text = dt.Rows[0].ItemArray[5].ToString();
                minS.Text = dt.Rows[0].ItemArray[6].ToString();
                maxS.Text = dt.Rows[0].ItemArray[7].ToString();
                
            }
            




        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            Updated(id.ToString());
            LoadFamille();
            Update_prod.ActiveForm.Close();
            
        }

        private void Update_prod_Load(object sender, EventArgs e)
        {
            id = ListeProduit.id;
            select_unite();
            
            LoadFamille();
        }
        private void GetItemListe(string unite)
        {


            for (int k = 0; k < radDropDownList1.Items.Count; k++)
            {
               
                if (Convert.ToInt32(radDropDownList1.Items[k].Tag) == Convert.ToInt32(unite))
                {

                    radDropDownList1.Items[k].Selected = true;
                    
                }


            }
        }
        private void Updated(string id)
        {
            Bd baseD = new Bd();
            baseD.ouverture_bd(baseD.cnn);

            try
            {

                string codeValue = code.Text.Trim();
                string desValue = designation.Text.Trim();
                string quantiteValue = quantite.Text.Trim();
                string prix_uValue = prix_u.Text.Trim();
                string referenceValue = reference.Text.Trim();
                string minValue = minS.Text.Trim();
                string maxValue = maxS.Text.Trim();
                int uniteValue = Convert.ToInt32(radDropDownList1.SelectedItem.Tag);

                string query = "UPDATE produit SET code = @num, designation = @mat, quantite = @tel, prix_u = @add, unite = @ville, reference = @ref, stock_min = @min, stock_max = @max WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                cmd.Parameters.Add("num", SqlDbType.VarChar).Value = codeValue;
                cmd.Parameters.Add("mat", SqlDbType.VarChar).Value = desValue;
                cmd.Parameters.Add("tel", SqlDbType.Real).Value = quantiteValue;
                cmd.Parameters.Add("add", SqlDbType.Real).Value = prix_uValue;
                cmd.Parameters.Add("ville", SqlDbType.Int).Value = uniteValue;
                cmd.Parameters.Add("ref", SqlDbType.VarChar).Value = referenceValue;
                cmd.Parameters.Add("min", SqlDbType.Real).Value = minValue;
                cmd.Parameters.Add("max", SqlDbType.Real).Value = maxValue;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;



                cmd.ExecuteNonQuery();

                MessageBox.Show("Data successfully inserted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            { baseD.cnn.Close(); }


        }
    }
}
