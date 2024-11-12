using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_de_stock;

namespace gestion_de_stock
{
    public partial class Main : Form
    {
        private Button lastClickedButton = null;

        public Main()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;


            InitializeComponent();
            panel_ajout_buttons.Visible = false;
            panel_stock.Visible = false;

            

        }

        private bool Enabledbuttons(Panel panel, Button button )
        {
            panel.Visible = !panel.Visible; 

            bool text_pos = panel.Visible;
            if (text_pos)
            {
                text_pos = !text_pos;
                button.TextImageRelation = TextImageRelation.TextBeforeImage;
            }
            else
            {
                text_pos = !text_pos;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            return button.Visible;
        }



        
        private Form activeform = null;
        //create a new form
        private void openChiledForm(Form childform)
        {
            if (childform != null)
            {
                if (activeform != null)
                {
                    activeform.Close();
                }
                activeform = childform;
                childform.TopLevel = false;
                //style of the form 

                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                child_panel.Controls.Add(childform);
                child_panel.Tag = childform;
                childform.BringToFront();
                childform.Show();
            }
        }



        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        //private void pointC_Click(object sender, EventArgs e)
        //{
        //    var Point_d = new Point_dAjout();
        //    Point_d.Show();
        //    this.Hide();
        //}
       

        private void Point_d_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_devise_Click_1(object sender, EventArgs e)
        {
            openChiledForm(new Devise());
        }

        private void button_reglement_Click_1(object sender, EventArgs e)
        {
            openChiledForm(new Reglement());
        }

        private void button_Fournisseur_Click_1(object sender, EventArgs e)
        {
            openChiledForm(new Fournissuer());
        }

        private void button_family_Click(object sender, EventArgs e)
        {
            openChiledForm(new Famille());
        }

        private void unite_Click(object sender, EventArgs e)
        {
            openChiledForm(new Unite());
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            Enabledbuttons(panel_ajout_buttons, setting_btn);
        }

        private void gestion_stock_btn_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            Enabledbuttons(panel_stock, gestion_stock_btn);
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            openChiledForm(new Article());
        }

        private void article_list_Click(object sender, EventArgs e)
        {
            openChiledForm(new ListeProduit());
        }

        private void pointC_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            var point_d = new Point_dAjout();
            point_d.Show();
            point_d.FormClosed += new FormClosedEventHandler(Point_d_FormClosed);
            point_d.Show();
            this.Hide();
        }

        private void entre_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            openChiledForm(new Entre());
        }

        private void voire_artcile_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            openChiledForm(new Entre_Article());
        }

        private void sortie_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            openChiledForm(new addSortie());
        }


        private void HighlightButton(Button clickedButton)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.FromArgb(155, 201, 255); // Reset color of last clicked button
            }

            clickedButton.BackColor = Color.Azure; ; // Set new color for clicked button
            lastClickedButton = clickedButton; // Store the clicked button for future reference
        }

        private void print_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            openChiledForm(new voiresortie());
        }


        //----------------------



    }
}
