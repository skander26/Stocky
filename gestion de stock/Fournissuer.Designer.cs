using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using Telerik.WinControls.VirtualKeyboard;

namespace gestion_de_stock
{
    partial class Fournissuer
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn2 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.titel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.add_Button = new Telerik.WinControls.UI.RadButton();
            this.update = new Telerik.WinControls.UI.RadButton();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.cancel_button = new Telerik.WinControls.UI.RadButton();
            this.matricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabledata = new Telerik.WinControls.UI.RadGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).BeginInit();
            this.add_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_button)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.titel.Location = new System.Drawing.Point(12, 9);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(502, 40);
            this.titel.TabIndex = 9;
            this.titel.Text = "Ajouter Fournissuer d\'article";
            // 
            // add_Button
            // 
            this.add_Button.BackColor = System.Drawing.Color.White;
            this.add_Button.Controls.Add(this.update);
            this.add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Button.Location = new System.Drawing.Point(307, 190);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(165, 46);
            this.add_Button.TabIndex = 15;
            this.add_Button.Text = "Ajouter";
            this.add_Button.ThemeName = "Crystal";
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Location = new System.Drawing.Point(0, 0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(165, 46);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.ThemeName = "Crystal";
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(81, 86);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(260, 30);
            this.nom.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nom";
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.Gray;
            this.underlinePanel.Location = new System.Drawing.Point(5, 55);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(925, 3);
            this.underlinePanel.TabIndex = 10;
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.White;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.Location = new System.Drawing.Point(487, 190);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(165, 46);
            this.cancel_button.TabIndex = 16;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.ThemeName = "Crystal";
            this.cancel_button.Visible = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click_1);
            // 
            // matricule
            // 
            this.matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule.Location = new System.Drawing.Point(366, 86);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(260, 30);
            this.matricule.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Matricule";
            // 
            // telephone
            // 
            this.telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone.Location = new System.Drawing.Point(643, 86);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(260, 30);
            this.telephone.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telephone";
            // 
            // ville
            // 
            this.ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ville.Location = new System.Drawing.Point(462, 144);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(260, 30);
            this.ville.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ville";
            // 
            // adresse
            // 
            this.adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse.Location = new System.Drawing.Point(155, 144);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(260, 30);
            this.adresse.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adresse";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adresse);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.ville);
            this.panel1.Controls.Add(this.matricule);
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.add_Button);
            this.panel1.Controls.Add(this.telephone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 254);
            this.panel1.TabIndex = 18;
            // 
            // tabledata
            // 
            this.tabledata.AutoScroll = true;
            this.tabledata.BackColor = System.Drawing.Color.White;
            this.tabledata.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabledata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabledata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabledata.ForeColor = System.Drawing.Color.Black;
            this.tabledata.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabledata.Location = new System.Drawing.Point(0, 254);
            this.tabledata.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.tabledata.MasterTemplate.AllowAddNewRow = false;
            this.tabledata.MasterTemplate.AllowColumnReorder = false;
            this.tabledata.MasterTemplate.AllowDragToGroup = false;
            this.tabledata.MasterTemplate.AllowEditRow = false;
            this.tabledata.MasterTemplate.AllowSearchRow = true;
            this.tabledata.MasterTemplate.AutoExpandGroups = true;
            this.tabledata.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.MinWidth = 8;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 146;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Num";
            gridViewTextBoxColumn2.MinWidth = 8;
            gridViewTextBoxColumn2.Name = "num";
            gridViewTextBoxColumn2.Width = 158;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Matricule";
            gridViewTextBoxColumn3.MinWidth = 8;
            gridViewTextBoxColumn3.Name = "matricule";
            gridViewTextBoxColumn3.Width = 158;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "telephone";
            gridViewTextBoxColumn4.MinWidth = 8;
            gridViewTextBoxColumn4.Name = "telephone";
            gridViewTextBoxColumn4.Width = 158;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Adresse";
            gridViewTextBoxColumn5.MinWidth = 8;
            gridViewTextBoxColumn5.Name = "adresse";
            gridViewTextBoxColumn5.Width = 158;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Ville";
            gridViewTextBoxColumn6.MinWidth = 8;
            gridViewTextBoxColumn6.Name = "ville";
            gridViewTextBoxColumn6.Width = 158;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.MinWidth = 8;
            gridViewImageColumn1.Name = "I1";
            gridViewImageColumn1.Width = 84;
            gridViewImageColumn2.EnableExpressionEditor = false;
            gridViewImageColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn2.MinWidth = 8;
            gridViewImageColumn2.Name = "i2";
            gridViewImageColumn2.Width = 84;
            this.tabledata.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewImageColumn1,
            gridViewImageColumn2});
            this.tabledata.MasterTemplate.EnableFiltering = true;
            this.tabledata.MasterTemplate.ShowFilteringRow = false;
            this.tabledata.MasterTemplate.ShowHeaderCellButtons = true;
            this.tabledata.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.tabledata.Name = "tabledata";
            this.tabledata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.tabledata.RootElement.ClipDrawing = false;
            this.tabledata.RootElement.FocusBorderColor = System.Drawing.Color.White;
            this.tabledata.RootElement.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabledata.ShowHeaderCellButtons = true;
            this.tabledata.ShowItemToolTips = false;
            this.tabledata.Size = new System.Drawing.Size(990, 483);
            this.tabledata.TabIndex = 19;
            this.tabledata.ThemeName = "Crystal";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Fournissuer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 737);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fournissuer";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).EndInit();
            this.add_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_button)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadButton add_Button;
        private Telerik.WinControls.UI.RadButton update;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel underlinePanel;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton cancel_button;
        private System.Windows.Forms.TextBox matricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView tabledata;
        private System.Windows.Forms.ImageList imageList1;
    }
}