namespace gestion_de_stock
{
    partial class Unite
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
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn2 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tabledata = new Telerik.WinControls.UI.RadGridView();
            this.titel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.update = new Telerik.WinControls.UI.RadButton();
            this.add_Button = new Telerik.WinControls.UI.RadButton();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.designation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.cancel_button = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_button)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabledata
            // 
            this.tabledata.AutoScroll = true;
            this.tabledata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabledata.EnableTheming = false;
            this.tabledata.Location = new System.Drawing.Point(0, 177);
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
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 97;
            gridViewTextBoxColumn2.HeaderText = "Designation";
            gridViewTextBoxColumn2.Name = "Designation";
            gridViewTextBoxColumn2.Width = 830;
            gridViewImageColumn1.HeaderText = "";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.Name = "I1";
            gridViewImageColumn1.Width = 266;
            gridViewImageColumn2.HeaderText = "";
            gridViewImageColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn2.Name = "i2";
            gridViewImageColumn2.Width = 266;
            this.tabledata.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewImageColumn1,
            gridViewImageColumn2});
            this.tabledata.MasterTemplate.EnableFiltering = true;
            this.tabledata.MasterTemplate.ShowFilteringRow = false;
            this.tabledata.MasterTemplate.ShowHeaderCellButtons = true;
            this.tabledata.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.tabledata.Name = "tabledata";
            this.tabledata.ReadOnly = true;
            this.tabledata.ShowHeaderCellButtons = true;
            this.tabledata.ShowItemToolTips = false;
            this.tabledata.Size = new System.Drawing.Size(1394, 534);
            this.tabledata.TabIndex = 19;
            this.tabledata.ThemeName = "Crystal";
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.titel.Location = new System.Drawing.Point(40, 20);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(243, 40);
            this.titel.TabIndex = 9;
            this.titel.Text = "Ajouter Unite";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Location = new System.Drawing.Point(327, 111);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(165, 46);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.ThemeName = "Crystal";
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // add_Button
            // 
            this.add_Button.BackColor = System.Drawing.Color.White;
            this.add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Button.Location = new System.Drawing.Point(327, 111);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(165, 46);
            this.add_Button.TabIndex = 15;
            this.add_Button.Text = "Ajouter";
            this.add_Button.ThemeName = "Crystal";
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click_1);
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.Gray;
            this.underlinePanel.Location = new System.Drawing.Point(47, 77);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(925, 3);
            this.underlinePanel.TabIndex = 10;
            // 
            // designation
            // 
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.Location = new System.Drawing.Point(52, 122);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(260, 30);
            this.designation.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Designation";
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.White;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.Location = new System.Drawing.Point(498, 111);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(165, 46);
            this.cancel_button.TabIndex = 16;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.ThemeName = "Crystal";
            this.cancel_button.Visible = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Controls.Add(this.designation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 177);
            this.panel1.TabIndex = 20;
            // 
            // Unite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 711);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unite";
            this.Text = "Unite";
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_button)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView tabledata;
        private System.Windows.Forms.Label titel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadButton update;
        private Telerik.WinControls.UI.RadButton add_Button;
        private System.Windows.Forms.Panel underlinePanel;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton cancel_button;
        private System.Windows.Forms.Panel panel1;
    }
}