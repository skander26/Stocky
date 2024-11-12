namespace gestion_de_stock
{
    partial class ListeProduit
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn3 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn4 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tabledata = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actualiser = new Telerik.WinControls.UI.RadButton();
            this.titel = new System.Windows.Forms.Label();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.object_a9c7f0a4_dd62_4e6f_870f_f62d8614933d = new Telerik.WinControls.RootRadElement();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
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
            this.tabledata.Location = new System.Drawing.Point(0, 116);
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
            gridViewTextBoxColumn10.HeaderText = "id";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "id";
            gridViewTextBoxColumn11.HeaderText = "Code";
            gridViewTextBoxColumn11.Name = "code";
            gridViewTextBoxColumn11.Width = 244;
            gridViewTextBoxColumn12.HeaderText = "Designation";
            gridViewTextBoxColumn12.Name = "designation";
            gridViewTextBoxColumn12.Width = 122;
            gridViewTextBoxColumn13.HeaderText = "Quantite";
            gridViewTextBoxColumn13.Name = "quantite";
            gridViewTextBoxColumn13.Width = 122;
            gridViewTextBoxColumn14.HeaderText = "Prix_u";
            gridViewTextBoxColumn14.Name = "prix_u";
            gridViewTextBoxColumn14.Width = 122;
            gridViewTextBoxColumn15.HeaderText = "Unite";
            gridViewTextBoxColumn15.Name = "unite";
            gridViewTextBoxColumn15.Width = 122;
            gridViewTextBoxColumn16.HeaderText = "reference";
            gridViewTextBoxColumn16.Name = "ref";
            gridViewTextBoxColumn16.Width = 122;
            gridViewTextBoxColumn17.HeaderText = "stocke min";
            gridViewTextBoxColumn17.Name = "minS";
            gridViewTextBoxColumn17.Width = 122;
            gridViewTextBoxColumn18.HeaderText = "stock max";
            gridViewTextBoxColumn18.Name = "maxS";
            gridViewTextBoxColumn18.Width = 122;
            gridViewImageColumn3.HeaderText = "";
            gridViewImageColumn3.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn3.Name = "I1";
            gridViewImageColumn3.Width = 122;
            gridViewImageColumn4.HeaderText = "";
            gridViewImageColumn4.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn4.Name = "I2";
            gridViewImageColumn4.Width = 120;
            this.tabledata.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewImageColumn3,
            gridViewImageColumn4});
            this.tabledata.MasterTemplate.EnableFiltering = true;
            this.tabledata.MasterTemplate.ShowFilteringRow = false;
            this.tabledata.MasterTemplate.ShowHeaderCellButtons = true;
            this.tabledata.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.tabledata.Name = "tabledata";
            this.tabledata.ReadOnly = true;
            this.tabledata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.tabledata.RootElement.ClipDrawing = false;
            this.tabledata.RootElement.FocusBorderColor = System.Drawing.Color.White;
            this.tabledata.RootElement.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabledata.ShowHeaderCellButtons = true;
            this.tabledata.ShowItemToolTips = false;
            this.tabledata.Size = new System.Drawing.Size(1372, 1004);
            this.tabledata.TabIndex = 20;
            this.tabledata.ThemeName = "Crystal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Controls.Add(this.actualiser);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 116);
            this.panel1.TabIndex = 21;
            // 
            // actualiser
            // 
            this.actualiser.Location = new System.Drawing.Point(1004, 42);
            this.actualiser.Name = "actualiser";
            this.actualiser.Size = new System.Drawing.Size(165, 36);
            this.actualiser.TabIndex = 13;
            this.actualiser.Text = "Actualise";
            this.actualiser.ThemeName = "Crystal";
            this.actualiser.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.titel.Location = new System.Drawing.Point(50, 9);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(248, 40);
            this.titel.TabIndex = 11;
            this.titel.Text = "Liste d\'article";
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.Gray;
            this.underlinePanel.Location = new System.Drawing.Point(29, 64);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(925, 3);
            this.underlinePanel.TabIndex = 12;
            // 
            // object_a9c7f0a4_dd62_4e6f_870f_f62d8614933d
            // 
            this.object_a9c7f0a4_dd62_4e6f_870f_f62d8614933d.Name = "object_a9c7f0a4_dd62_4e6f_870f_f62d8614933d";
            this.object_a9c7f0a4_dd62_4e6f_870f_f62d8614933d.StretchHorizontally = true;
            this.object_a9c7f0a4_dd62_4e6f_870f_f62d8614933d.StretchVertically = true;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(1175, 42);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(165, 36);
            this.radButton1.TabIndex = 14;
            this.radButton1.Text = "Rapport";
            this.radButton1.ThemeName = "Crystal";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            // 
            // ListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 1120);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListeProduit";
            this.Text = "ListeProduit";
            this.Load += new System.EventHandler(this.ListeProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView tabledata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Panel underlinePanel;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.RootRadElement object_a9c7f0a4_dd62_4e6f_870f_f62d8614933d;
        private Telerik.WinControls.UI.RadButton actualiser;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
} 