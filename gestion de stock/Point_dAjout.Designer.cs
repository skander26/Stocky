using System.Windows.Forms;

namespace gestion_de_stock
{
    partial class Point_dAjout
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.TextBox();
            this.radDropDownList3 = new Telerik.WinControls.UI.RadDropDownList();
            this.ajouter_btn = new Telerik.WinControls.UI.RadButton();
            this.reglement = new System.Windows.Forms.Label();
            this.devise = new System.Windows.Forms.Label();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.fournissuer = new System.Windows.Forms.Label();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reception = new System.Windows.Forms.TextBox();
            this.titel = new System.Windows.Forms.Label();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.tabledata = new Telerik.WinControls.UI.RadGridView();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.crystalTheme2 = new Telerik.WinControls.Themes.CrystalTheme();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.radDropDownList3);
            this.panel1.Controls.Add(this.ajouter_btn);
            this.panel1.Controls.Add(this.reglement);
            this.panel1.Controls.Add(this.devise);
            this.panel1.Controls.Add(this.radDropDownList2);
            this.panel1.Controls.Add(this.radDateTimePicker1);
            this.panel1.Controls.Add(this.fournissuer);
            this.panel1.Controls.Add(this.radDropDownList1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reception);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1687, 222);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Num";
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(21, 110);
            this.order.Multiline = true;
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.Size = new System.Drawing.Size(100, 38);
            this.order.TabIndex = 36;
            // 
            // radDropDownList3
            // 
            this.radDropDownList3.DropDownAnimationEnabled = true;
            this.radDropDownList3.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList3.ItemHeight = 44;
            this.radDropDownList3.Location = new System.Drawing.Point(1224, 105);
            this.radDropDownList3.Name = "radDropDownList3";
            this.radDropDownList3.Size = new System.Drawing.Size(215, 53);
            this.radDropDownList3.TabIndex = 35;
            this.radDropDownList3.ThemeName = "Crystal";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList3.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            // 
            // ajouter_btn
            // 
            this.ajouter_btn.Location = new System.Drawing.Point(1491, 105);
            this.ajouter_btn.Name = "ajouter_btn";
            this.ajouter_btn.Size = new System.Drawing.Size(193, 38);
            this.ajouter_btn.TabIndex = 34;
            this.ajouter_btn.Text = "Ajouter";
            this.ajouter_btn.ThemeName = "Crystal";
            this.ajouter_btn.Click += new System.EventHandler(this.ajouter_btn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.ajouter_btn.GetChildAt(0))).Text = "Ajouter";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ajouter_btn.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ajouter_btn.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.ajouter_btn.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ajouter_btn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ajouter_btn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ajouter_btn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reglement
            // 
            this.reglement.AutoSize = true;
            this.reglement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reglement.Location = new System.Drawing.Point(1219, 73);
            this.reglement.Name = "reglement";
            this.reglement.Size = new System.Drawing.Size(118, 26);
            this.reglement.TabIndex = 33;
            this.reglement.Text = "Reglement";
            // 
            // devise
            // 
            this.devise.AutoSize = true;
            this.devise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devise.Location = new System.Drawing.Point(969, 73);
            this.devise.Name = "devise";
            this.devise.Size = new System.Drawing.Size(79, 26);
            this.devise.TabIndex = 31;
            this.devise.Text = "Devise";
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.DropDownAnimationEnabled = true;
            this.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList2.ItemHeight = 44;
            this.radDropDownList2.Location = new System.Drawing.Point(974, 105);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(215, 53);
            this.radDropDownList2.TabIndex = 30;
            this.radDropDownList2.ThemeName = "Crystal";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList2.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.CalendarSize = new System.Drawing.Size(290, 320);
            this.radDateTimePicker1.Location = new System.Drawing.Point(443, 105);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(246, 53);
            this.radDateTimePicker1.TabIndex = 29;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "Tuesday, 25 June 2024";
            this.radDateTimePicker1.ThemeName = "Crystal";
            this.radDateTimePicker1.Value = new System.DateTime(2024, 6, 25, 0, 0, 0, 0);
            ((Telerik.WinControls.UI.RadDateTimePickerElement)(this.radDateTimePicker1.GetChildAt(0))).CalendarSize = new System.Drawing.Size(290, 320);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadMaskedEditBoxElement)(this.radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "Tuesday, 25 June 2024";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            // 
            // fournissuer
            // 
            this.fournissuer.AutoSize = true;
            this.fournissuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fournissuer.Location = new System.Drawing.Point(725, 76);
            this.fournissuer.Name = "fournissuer";
            this.fournissuer.Size = new System.Drawing.Size(126, 26);
            this.fournissuer.TabIndex = 28;
            this.fournissuer.Text = "Fournissuer";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.ItemHeight = 44;
            this.radDropDownList1.Location = new System.Drawing.Point(730, 105);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(215, 53);
            this.radDropDownList1.TabIndex = 27;
            this.radDropDownList1.ThemeName = "Crystal";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList1.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reception";
            // 
            // reception
            // 
            this.reception.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reception.Location = new System.Drawing.Point(138, 110);
            this.reception.Multiline = true;
            this.reception.Name = "reception";
            this.reception.Size = new System.Drawing.Size(260, 38);
            this.reception.TabIndex = 21;
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.titel.Location = new System.Drawing.Point(24, 12);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(325, 40);
            this.titel.TabIndex = 13;
            this.titel.Text = "Ajouter bon sortie";
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.Gray;
            this.underlinePanel.Location = new System.Drawing.Point(-5, 67);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(925, 3);
            this.underlinePanel.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radTreeView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 1148);
            this.panel2.TabIndex = 1;
            // 
            // radTreeView1
            // 
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Location = new System.Drawing.Point(0, 78);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(386, 1070);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.radTextBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 78);
            this.panel3.TabIndex = 0;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(21, 6);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Recherche";
            // 
            // 
            // 
            this.radTextBox1.RootElement.StretchVertically = true;
            this.radTextBox1.Size = new System.Drawing.Size(337, 50);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radTextBox1.GetChildAt(0).GetChildAt(0))).NullText = "Recherche";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radTextBox1.GetChildAt(0).GetChildAt(0))).StretchVertically = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radTextBox1.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 18F);
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
            this.tabledata.Location = new System.Drawing.Point(386, 222);
            this.tabledata.Margin = new System.Windows.Forms.Padding(6);
            // 
            // 
            // 
            this.tabledata.MasterTemplate.AllowAddNewRow = false;
            this.tabledata.MasterTemplate.AllowDragToGroup = false;
            this.tabledata.MasterTemplate.AllowSearchRow = true;
            this.tabledata.MasterTemplate.AutoExpandGroups = true;
            this.tabledata.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.MinWidth = 8;
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Code";
            gridViewTextBoxColumn2.MinWidth = 8;
            gridViewTextBoxColumn2.Name = "code";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 163;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Designation";
            gridViewTextBoxColumn3.MinWidth = 8;
            gridViewTextBoxColumn3.Name = "designation";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 195;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Qt Acheter";
            gridViewTextBoxColumn4.MinWidth = 8;
            gridViewTextBoxColumn4.Name = "qtacheter";
            gridViewTextBoxColumn4.UseDataTypeConverterWhenSorting = true;
            gridViewTextBoxColumn4.Width = 195;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "QuantiteStock";
            gridViewTextBoxColumn5.MinWidth = 8;
            gridViewTextBoxColumn5.Name = "quantiteS";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 195;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Prix_U";
            gridViewTextBoxColumn6.MinWidth = 8;
            gridViewTextBoxColumn6.Name = "prix";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 195;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "Unite";
            gridViewTextBoxColumn7.MinWidth = 8;
            gridViewTextBoxColumn7.Name = "unite";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 195;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.MinWidth = 8;
            gridViewImageColumn1.Name = "I2";
            gridViewImageColumn1.Width = 131;
            this.tabledata.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewImageColumn1});
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
            this.tabledata.Size = new System.Drawing.Size(1301, 1148);
            this.tabledata.TabIndex = 21;
            this.tabledata.ThemeName = "Crystal";
            // 
            // Point_dAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 1370);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Point_dAjout";
            this.Text = "Point_dAjout";
            this.Load += new System.EventHandler(this.Point_dAjout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadGridView tabledata;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Panel underlinePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reception;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private System.Windows.Forms.Label fournissuer;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Label reglement;
        private System.Windows.Forms.Label devise;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        private Telerik.WinControls.UI.RadButton ajouter_btn;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList3;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme2;
        private Label label3;
        private TextBox order;
    }
}