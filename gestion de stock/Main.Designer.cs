

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace gestion_de_stock
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vsortie = new FontAwesome.Sharp.IconButton();
            this.voire_artcile = new FontAwesome.Sharp.IconButton();
            this.entre = new FontAwesome.Sharp.IconButton();
            this.pointC = new FontAwesome.Sharp.IconButton();
            this.panel_stock = new System.Windows.Forms.Panel();
            this.article_list = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.sortie = new FontAwesome.Sharp.IconButton();
            this.gestion_stock_btn = new FontAwesome.Sharp.IconButton();
            this.panel_ajout_buttons = new System.Windows.Forms.Panel();
            this.unite = new System.Windows.Forms.Button();
            this.button_Fournisseur = new System.Windows.Forms.Button();
            this.button_reglement = new System.Windows.Forms.Button();
            this.button_devise = new System.Windows.Forms.Button();
            this.button_family = new System.Windows.Forms.Button();
            this.setting_btn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.child_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_stock.SuspendLayout();
            this.panel_ajout_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Vsortie);
            this.panel1.Controls.Add(this.voire_artcile);
            this.panel1.Controls.Add(this.entre);
            this.panel1.Controls.Add(this.pointC);
            this.panel1.Controls.Add(this.panel_stock);
            this.panel1.Controls.Add(this.sortie);
            this.panel1.Controls.Add(this.gestion_stock_btn);
            this.panel1.Controls.Add(this.panel_ajout_buttons);
            this.panel1.Controls.Add(this.setting_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 1370);
            this.panel1.TabIndex = 0;
            // 
            // Vsortie
            // 
            this.Vsortie.Dock = System.Windows.Forms.DockStyle.Top;
            this.Vsortie.FlatAppearance.BorderSize = 0;
            this.Vsortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vsortie.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.Vsortie.IconColor = System.Drawing.Color.Black;
            this.Vsortie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Vsortie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vsortie.Location = new System.Drawing.Point(0, 884);
            this.Vsortie.Name = "Vsortie";
            this.Vsortie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Vsortie.Size = new System.Drawing.Size(293, 60);
            this.Vsortie.TabIndex = 12;
            this.Vsortie.Text = "Voire Sortie";
            this.Vsortie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vsortie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Vsortie.UseVisualStyleBackColor = true;
            this.Vsortie.Click += new System.EventHandler(this.print_Click);
            // 
            // voire_artcile
            // 
            this.voire_artcile.Dock = System.Windows.Forms.DockStyle.Top;
            this.voire_artcile.FlatAppearance.BorderSize = 0;
            this.voire_artcile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voire_artcile.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.voire_artcile.IconColor = System.Drawing.Color.Black;
            this.voire_artcile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.voire_artcile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voire_artcile.Location = new System.Drawing.Point(0, 824);
            this.voire_artcile.Name = "voire_artcile";
            this.voire_artcile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.voire_artcile.Size = new System.Drawing.Size(293, 60);
            this.voire_artcile.TabIndex = 10;
            this.voire_artcile.Text = "Voire Article";
            this.voire_artcile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voire_artcile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.voire_artcile.UseVisualStyleBackColor = true;
            this.voire_artcile.Click += new System.EventHandler(this.voire_artcile_Click);
            // 
            // entre
            // 
            this.entre.Dock = System.Windows.Forms.DockStyle.Top;
            this.entre.FlatAppearance.BorderSize = 0;
            this.entre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entre.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.entre.IconColor = System.Drawing.Color.Black;
            this.entre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.entre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entre.Location = new System.Drawing.Point(0, 764);
            this.entre.Name = "entre";
            this.entre.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.entre.Size = new System.Drawing.Size(293, 60);
            this.entre.TabIndex = 9;
            this.entre.Text = "voire Entre";
            this.entre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.entre.UseVisualStyleBackColor = true;
            this.entre.Click += new System.EventHandler(this.entre_Click);
            // 
            // pointC
            // 
            this.pointC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pointC.FlatAppearance.BorderSize = 0;
            this.pointC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointC.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.pointC.IconColor = System.Drawing.Color.Black;
            this.pointC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pointC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pointC.Location = new System.Drawing.Point(0, 704);
            this.pointC.Name = "pointC";
            this.pointC.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pointC.Size = new System.Drawing.Size(293, 60);
            this.pointC.TabIndex = 8;
            this.pointC.Text = "Point d\'ajout";
            this.pointC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pointC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pointC.UseVisualStyleBackColor = true;
            this.pointC.Click += new System.EventHandler(this.pointC_Click);
            // 
            // panel_stock
            // 
            this.panel_stock.Controls.Add(this.article_list);
            this.panel_stock.Controls.Add(this.add_product);
            this.panel_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stock.Location = new System.Drawing.Point(0, 610);
            this.panel_stock.Name = "panel_stock";
            this.panel_stock.Size = new System.Drawing.Size(293, 94);
            this.panel_stock.TabIndex = 7;
            // 
            // article_list
            // 
            this.article_list.BackColor = System.Drawing.Color.White;
            this.article_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.article_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.article_list.FlatAppearance.BorderSize = 0;
            this.article_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(178)))));
            this.article_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.article_list.Location = new System.Drawing.Point(0, 45);
            this.article_list.Margin = new System.Windows.Forms.Padding(8);
            this.article_list.Name = "article_list";
            this.article_list.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.article_list.Size = new System.Drawing.Size(293, 45);
            this.article_list.TabIndex = 1;
            this.article_list.Text = "lise des article";
            this.article_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.article_list.UseVisualStyleBackColor = false;
            this.article_list.Click += new System.EventHandler(this.article_list_Click);
            // 
            // add_product
            // 
            this.add_product.BackColor = System.Drawing.Color.White;
            this.add_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_product.FlatAppearance.BorderSize = 0;
            this.add_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(178)))));
            this.add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.add_product.Location = new System.Drawing.Point(0, 0);
            this.add_product.Margin = new System.Windows.Forms.Padding(8);
            this.add_product.Name = "add_product";
            this.add_product.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.add_product.Size = new System.Drawing.Size(293, 45);
            this.add_product.TabIndex = 0;
            this.add_product.Text = "ajout produit";
            this.add_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_product.UseVisualStyleBackColor = false;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // sortie
            // 
            this.sortie.Dock = System.Windows.Forms.DockStyle.Top;
            this.sortie.FlatAppearance.BorderSize = 0;
            this.sortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortie.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.sortie.IconColor = System.Drawing.Color.Black;
            this.sortie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sortie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortie.Location = new System.Drawing.Point(0, 550);
            this.sortie.Name = "sortie";
            this.sortie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.sortie.Size = new System.Drawing.Size(293, 60);
            this.sortie.TabIndex = 11;
            this.sortie.Text = "Sortie";
            this.sortie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortie.UseVisualStyleBackColor = true;
            this.sortie.Click += new System.EventHandler(this.sortie_Click);
            // 
            // gestion_stock_btn
            // 
            this.gestion_stock_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gestion_stock_btn.FlatAppearance.BorderSize = 0;
            this.gestion_stock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestion_stock_btn.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.gestion_stock_btn.IconColor = System.Drawing.Color.Black;
            this.gestion_stock_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gestion_stock_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestion_stock_btn.Location = new System.Drawing.Point(0, 490);
            this.gestion_stock_btn.Name = "gestion_stock_btn";
            this.gestion_stock_btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.gestion_stock_btn.Size = new System.Drawing.Size(293, 60);
            this.gestion_stock_btn.TabIndex = 6;
            this.gestion_stock_btn.Text = "Gestion De Stock";
            this.gestion_stock_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestion_stock_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gestion_stock_btn.UseVisualStyleBackColor = true;
            this.gestion_stock_btn.Click += new System.EventHandler(this.gestion_stock_btn_Click);
            // 
            // panel_ajout_buttons
            // 
            this.panel_ajout_buttons.Controls.Add(this.unite);
            this.panel_ajout_buttons.Controls.Add(this.button_Fournisseur);
            this.panel_ajout_buttons.Controls.Add(this.button_reglement);
            this.panel_ajout_buttons.Controls.Add(this.button_devise);
            this.panel_ajout_buttons.Controls.Add(this.button_family);
            this.panel_ajout_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ajout_buttons.Location = new System.Drawing.Point(0, 260);
            this.panel_ajout_buttons.Name = "panel_ajout_buttons";
            this.panel_ajout_buttons.Size = new System.Drawing.Size(293, 230);
            this.panel_ajout_buttons.TabIndex = 5;
            // 
            // unite
            // 
            this.unite.BackColor = System.Drawing.Color.White;
            this.unite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unite.Dock = System.Windows.Forms.DockStyle.Top;
            this.unite.FlatAppearance.BorderSize = 0;
            this.unite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(178)))));
            this.unite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.unite.Location = new System.Drawing.Point(0, 188);
            this.unite.Margin = new System.Windows.Forms.Padding(8);
            this.unite.Name = "unite";
            this.unite.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.unite.Size = new System.Drawing.Size(293, 45);
            this.unite.TabIndex = 4;
            this.unite.Text = "ajout Unite";
            this.unite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unite.UseVisualStyleBackColor = false;
            this.unite.Click += new System.EventHandler(this.unite_Click);
            // 
            // button_Fournisseur
            // 
            this.button_Fournisseur.BackColor = System.Drawing.Color.White;
            this.button_Fournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Fournisseur.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Fournisseur.FlatAppearance.BorderSize = 0;
            this.button_Fournisseur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(178)))));
            this.button_Fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Fournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.button_Fournisseur.Location = new System.Drawing.Point(0, 143);
            this.button_Fournisseur.Margin = new System.Windows.Forms.Padding(8);
            this.button_Fournisseur.Name = "button_Fournisseur";
            this.button_Fournisseur.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_Fournisseur.Size = new System.Drawing.Size(293, 45);
            this.button_Fournisseur.TabIndex = 3;
            this.button_Fournisseur.Text = "ajout Fournisseur";
            this.button_Fournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Fournisseur.UseVisualStyleBackColor = false;
            this.button_Fournisseur.Click += new System.EventHandler(this.button_Fournisseur_Click_1);
            // 
            // button_reglement
            // 
            this.button_reglement.BackColor = System.Drawing.Color.White;
            this.button_reglement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reglement.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reglement.FlatAppearance.BorderSize = 0;
            this.button_reglement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(178)))));
            this.button_reglement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reglement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.button_reglement.Location = new System.Drawing.Point(0, 98);
            this.button_reglement.Margin = new System.Windows.Forms.Padding(8);
            this.button_reglement.Name = "button_reglement";
            this.button_reglement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_reglement.Size = new System.Drawing.Size(293, 45);
            this.button_reglement.TabIndex = 2;
            this.button_reglement.Text = "ajout Reglement";
            this.button_reglement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reglement.UseVisualStyleBackColor = false;
            this.button_reglement.Click += new System.EventHandler(this.button_reglement_Click_1);
            // 
            // button_devise
            // 
            this.button_devise.BackColor = System.Drawing.Color.White;
            this.button_devise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_devise.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_devise.FlatAppearance.BorderSize = 0;
            this.button_devise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(178)))));
            this.button_devise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_devise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.button_devise.Location = new System.Drawing.Point(0, 53);
            this.button_devise.Margin = new System.Windows.Forms.Padding(8);
            this.button_devise.Name = "button_devise";
            this.button_devise.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_devise.Size = new System.Drawing.Size(293, 45);
            this.button_devise.TabIndex = 1;
            this.button_devise.Text = "ajout devise";
            this.button_devise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_devise.UseVisualStyleBackColor = false;
            this.button_devise.Click += new System.EventHandler(this.button_devise_Click_1);
            // 
            // button_family
            // 
            this.button_family.BackColor = System.Drawing.Color.White;
            this.button_family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_family.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_family.FlatAppearance.BorderSize = 0;
            this.button_family.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(178)))));
            this.button_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_family.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.button_family.Location = new System.Drawing.Point(0, 0);
            this.button_family.Margin = new System.Windows.Forms.Padding(8);
            this.button_family.Name = "button_family";
            this.button_family.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_family.Size = new System.Drawing.Size(293, 53);
            this.button_family.TabIndex = 0;
            this.button_family.Text = "ajout famille";
            this.button_family.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_family.UseVisualStyleBackColor = false;
            this.button_family.Click += new System.EventHandler(this.button_family_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.setting_btn.FlatAppearance.BorderSize = 0;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_btn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.setting_btn.IconColor = System.Drawing.Color.Black;
            this.setting_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.setting_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting_btn.Location = new System.Drawing.Point(0, 200);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.setting_btn.Size = new System.Drawing.Size(293, 60);
            this.setting_btn.TabIndex = 2;
            this.setting_btn.Text = "Setting";
            this.setting_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.setting_btn.UseVisualStyleBackColor = true;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 200);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(293, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1394, 194);
            this.panel2.TabIndex = 1;
            // 
            // child_panel
            // 
            this.child_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.child_panel.Location = new System.Drawing.Point(293, 194);
            this.child_panel.Name = "child_panel";
            this.child_panel.Size = new System.Drawing.Size(1394, 1176);
            this.child_panel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 1370);
            this.Controls.Add(this.child_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel_stock.ResumeLayout(false);
            this.panel_ajout_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        GraphicsPath p = new GraphicsPath();
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        public Panel child_panel;
        private Panel panel_ajout_buttons;
        private Button button_Fournisseur;
        private Button button_reglement;
        private Button button_devise;
        private Button button_family;
        private FontAwesome.Sharp.IconButton setting_btn;
        private Button unite;
        private Panel panel_stock;
        private Button article_list;
        private Button add_product;
        private FontAwesome.Sharp.IconButton sortie;

        private FontAwesome.Sharp.IconButton gestion_stock_btn;
        private FontAwesome.Sharp.IconButton pointC;
        private FontAwesome.Sharp.IconButton entre;
        private FontAwesome.Sharp.IconButton voire_artcile;
        private FontAwesome.Sharp.IconButton Vsortie;
    }
   
}

