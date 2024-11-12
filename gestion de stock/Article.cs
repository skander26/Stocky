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
using static Telerik.WinControls.VirtualKeyboard.VirtualKeyboardNativeMethods;

namespace gestion_de_stock
{
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
            select_unite();

        }

        private void insert()
        {
            Bd baseD = new Bd();

            try
            {


                string codeValue = code.Text.Trim();
                string desValue = designation.Text.Trim();
                string quantiteValue = quantite.Text.Trim();
                string prix_uValue = prix_u.Text.Trim();
                string referenceValue = reference.Text.Trim();
                string minValue = minS.Text.Trim();
                string maxValue = maxS.Text.Trim();

                if (string.IsNullOrEmpty(codeValue) || string.IsNullOrEmpty(desValue) || string.IsNullOrEmpty(quantiteValue) || string.IsNullOrEmpty(prix_uValue) || string.IsNullOrEmpty(radDropDownList1.Text) || string.IsNullOrEmpty(referenceValue) || string.IsNullOrEmpty(maxValue))
                {
                    MessageBox.Show("Check Your Input ");

                }
                else if (!double.TryParse(prix_uValue, out double prix_uu))
                {
                    MessageBox.Show("Erreur : le champ prix doit contenir un nombre réel valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!double.TryParse(quantiteValue, out double qt))
                {
                    MessageBox.Show("Erreur : le champ quantite doit contenir un nombre réel valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int uniteValue = Convert.ToInt32(radDropDownList1.SelectedItem.Tag);


                    string query = "INSERT INTO produit(code,designation,quantite,prix_u,unite,reference,stock_min,stock_max) VALUES ( @num, @mat,@tel, @add, @ville,@ref,@min,@max)";
                    SqlCommand cmd = new SqlCommand(query, baseD.cnn);
                    cmd.Parameters.Add("num", SqlDbType.VarChar).Value = codeValue;
                    cmd.Parameters.Add("mat", SqlDbType.VarChar).Value = desValue;
                    cmd.Parameters.Add("tel", SqlDbType.Real).Value = quantiteValue;
                    cmd.Parameters.Add("add", SqlDbType.Real).Value = prix_uValue;
                    cmd.Parameters.Add("ville", SqlDbType.Int).Value = uniteValue;
                    cmd.Parameters.Add("ref", SqlDbType.VarChar).Value = referenceValue;
                    cmd.Parameters.Add("min", SqlDbType.Real).Value = minValue;
                    cmd.Parameters.Add("max", SqlDbType.Real).Value = maxValue;


                    baseD.ouverture_bd(baseD.cnn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data successfully inserted.");
                    code.Clear();
                    designation.Clear();
                    quantite.Clear();
                    prix_u.Clear();
                    radDropDownList1.SelectedItem = null;
                    reference.Clear();
                    minS.Clear();
                    maxS.Clear();
                    baseD.cnn.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
               
            }
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            insert();
        }
        public static bool IsRealNumber(string input)
        {
            double result;
            return double.TryParse(input, out result);
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
        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
