using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace gestion_de_stock
{
    partial class Famille
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
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn2 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.titel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cf = new System.Windows.Forms.TextBox();
            this.Cd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_Button = new Telerik.WinControls.UI.RadButton();
            this.update = new Telerik.WinControls.UI.RadButton();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.delete_button = new Telerik.WinControls.UI.RadButton();
            this.tabledata = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).BeginInit();
            this.add_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.titel.Location = new System.Drawing.Point(70, 14);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(425, 40);
            this.titel.TabIndex = 0;
            this.titel.Text = "Ajouter Famille d\'article";
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.Gray;
            this.underlinePanel.Location = new System.Drawing.Point(80, 64);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(925, 3);
            this.underlinePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Famille";
            // 
            // Cf
            // 
            this.Cf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cf.Location = new System.Drawing.Point(82, 103);
            this.Cf.Name = "Cf";
            this.Cf.Size = new System.Drawing.Size(260, 30);
            this.Cf.TabIndex = 2;
            // 
            // Cd
            // 
            this.Cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cd.Location = new System.Drawing.Point(369, 103);
            this.Cd.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Cd.Name = "Cd";
            this.Cd.Size = new System.Drawing.Size(260, 30);
            this.Cd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code Designation";
            // 
            // add_Button
            // 
            this.add_Button.BackColor = System.Drawing.Color.White;
            this.add_Button.Controls.Add(this.update);
            this.add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Button.Location = new System.Drawing.Point(656, 92);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(165, 46);
            this.add_Button.TabIndex = 5;
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
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.White;
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.Location = new System.Drawing.Point(827, 92);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(165, 46);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Cancel";
            this.delete_button.ThemeName = "Crystal";
            this.delete_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // tabledata
            // 
            this.tabledata.AutoScroll = true;
            this.tabledata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabledata.EnableTheming = false;
            this.tabledata.Location = new System.Drawing.Point(0, 166);
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
            gridViewTextBoxColumn2.HeaderText = "Code";
            gridViewTextBoxColumn2.Name = "Code";
            gridViewTextBoxColumn2.Width = 298;
            gridViewTextBoxColumn3.HeaderText = "Designation";
            gridViewTextBoxColumn3.Name = "Designation";
            gridViewTextBoxColumn3.Width = 497;
            gridViewImageColumn1.HeaderText = "";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.Name = "I1";
            gridViewImageColumn1.Width = 159;
            gridViewImageColumn2.HeaderText = "";
            gridViewImageColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn2.Name = "i2";
            gridViewImageColumn2.Width = 159;
            this.tabledata.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
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
            this.tabledata.Size = new System.Drawing.Size(1145, 583);
            this.tabledata.TabIndex = 8;
            this.tabledata.ThemeName = "Crystal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.add_Button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.Cf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Cd);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 166);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 749);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Famille";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).EndInit();
            this.add_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label titel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel underlinePanel;
        private Label label1;
        private TextBox Cf;
        private TextBox Cd;
        private Label label2;
        private Telerik.WinControls.UI.RadButton add_Button;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton delete_button;
        private Telerik.WinControls.UI.RadGridView tabledata;
        private RadButton update;
        private Panel panel1;
    }
}