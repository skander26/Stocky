namespace gestion_de_stock
{
    partial class Entre_Article
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tabledata = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titel = new System.Windows.Forms.Label();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.actualiser = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualiser)).BeginInit();
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
            this.tabledata.Location = new System.Drawing.Point(0, 84);
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
            gridViewTextBoxColumn1.HeaderText = "id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn2.HeaderText = "id";
            gridViewTextBoxColumn2.Name = "reception";
            gridViewTextBoxColumn2.Width = 350;
            gridViewTextBoxColumn3.HeaderText = "id_article";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.Width = 117;
            gridViewTextBoxColumn4.HeaderText = "Qt entre";
            gridViewTextBoxColumn4.Name = "fournisseur";
            gridViewTextBoxColumn4.Width = 350;
            gridViewTextBoxColumn5.HeaderText = "prix u";
            gridViewTextBoxColumn5.Name = "devise";
            gridViewTextBoxColumn5.Width = 350;
            gridViewImageColumn1.HeaderText = "";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.Name = "I1";
            gridViewImageColumn1.Width = 116;
            this.tabledata.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewImageColumn1});
            this.tabledata.MasterTemplate.EnableFiltering = true;
            this.tabledata.MasterTemplate.ShowFilteringRow = false;
            this.tabledata.MasterTemplate.ShowHeaderCellButtons = true;
            this.tabledata.MasterTemplate.ViewDefinition = tableViewDefinition1;
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
            this.tabledata.Size = new System.Drawing.Size(1315, 717);
            this.tabledata.TabIndex = 24;
            this.tabledata.ThemeName = "Crystal";
            this.tabledata.TitlePosition = Telerik.WinControls.Layouts.Dock.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.actualiser);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 84);
            this.panel1.TabIndex = 25;
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
            // actualiser
            // 
            this.actualiser.Location = new System.Drawing.Point(1012, 31);
            this.actualiser.Name = "actualiser";
            this.actualiser.Size = new System.Drawing.Size(165, 36);
            this.actualiser.TabIndex = 13;
            this.actualiser.Text = "Actualiser";
            this.actualiser.ThemeName = "Crystal";
            // 
            // Entre_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 801);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.panel1);
            this.Name = "Entre_Article";
            this.Text = "Entre_Article";
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualiser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView tabledata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Panel underlinePanel;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadButton actualiser;
    }
}