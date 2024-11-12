namespace gestion_de_stock
{
    partial class voiresortie
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
            this.entreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_debut = new Telerik.WinControls.UI.RadDateTimePicker();
            this.date_fin = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btn_actualiser = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titel = new System.Windows.Forms.Label();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.tabledata = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.entreBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_debut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_fin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // entreBindingSource
            // 
            this.entreBindingSource.DataMember = "Entre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_debut);
            this.panel1.Controls.Add(this.date_fin);
            this.panel1.Controls.Add(this.btn_actualiser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1637, 133);
            this.panel1.TabIndex = 25;
            // 
            // date_debut
            // 
            this.date_debut.CalendarSize = new System.Drawing.Size(290, 320);
            this.date_debut.CustomFormat = "yyyy-MM-dd";
            this.date_debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_debut.Location = new System.Drawing.Point(120, 82);
            this.date_debut.Name = "date_debut";
            this.date_debut.Size = new System.Drawing.Size(246, 39);
            this.date_debut.TabIndex = 16;
            this.date_debut.TabStop = false;
            this.date_debut.Text = "2024-06-27";
            this.date_debut.ThemeName = "Crystal";
            this.date_debut.Value = new System.DateTime(2024, 6, 27, 0, 0, 0, 0);
            ((Telerik.WinControls.UI.RadDateTimePickerElement)(this.date_debut.GetChildAt(0))).CalendarSize = new System.Drawing.Size(290, 320);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ((Telerik.WinControls.UI.RadMaskedEditBoxElement)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "2024-06-27";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(5))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_debut.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(5))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            // 
            // date_fin
            // 
            this.date_fin.CalendarSize = new System.Drawing.Size(290, 320);
            this.date_fin.CustomFormat = "yyyy-MM-dd";
            this.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_fin.Location = new System.Drawing.Point(489, 75);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(246, 39);
            this.date_fin.TabIndex = 16;
            this.date_fin.TabStop = false;
            this.date_fin.Text = "2024-06-27";
            this.date_fin.ThemeName = "Crystal";
            this.date_fin.Value = new System.DateTime(2024, 6, 27, 0, 0, 0, 0);
            ((Telerik.WinControls.UI.RadDateTimePickerElement)(this.date_fin.GetChildAt(0))).CalendarSize = new System.Drawing.Size(290, 320);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ((Telerik.WinControls.UI.RadMaskedEditBoxElement)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "2024-06-27";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(5))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.date_fin.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(5))).Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            // 
            // btn_actualiser
            // 
            this.btn_actualiser.BackColor = System.Drawing.SystemColors.Control;
            this.btn_actualiser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualiser.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btn_actualiser.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualiser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_actualiser.Location = new System.Drawing.Point(756, 82);
            this.btn_actualiser.Name = "btn_actualiser";
            this.btn_actualiser.Size = new System.Drawing.Size(41, 32);
            this.btn_actualiser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_actualiser.TabIndex = 19;
            this.btn_actualiser.TabStop = false;
            this.btn_actualiser.Click += new System.EventHandler(this.btn_actualiser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date De Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date De Debut";
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.titel.Location = new System.Drawing.Point(0, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(231, 40);
            this.titel.TabIndex = 11;
            this.titel.Text = "Liste d\'entre";
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.Gray;
            this.underlinePanel.Location = new System.Drawing.Point(12, 43);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(925, 3);
            this.underlinePanel.TabIndex = 12;
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
            this.tabledata.Location = new System.Drawing.Point(0, 133);
            this.tabledata.Margin = new System.Windows.Forms.Padding(48);
            // 
            // 
            // 
            this.tabledata.MasterTemplate.AllowAddNewRow = false;
            this.tabledata.MasterTemplate.AllowColumnReorder = false;
            this.tabledata.MasterTemplate.AllowDragToGroup = false;
            this.tabledata.MasterTemplate.AllowEditRow = false;
            this.tabledata.MasterTemplate.AllowSearchRow = true;
            this.tabledata.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.MinWidth = 27;
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.Width = 252;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Client";
            gridViewTextBoxColumn2.MinWidth = 27;
            gridViewTextBoxColumn2.Name = "client";
            gridViewTextBoxColumn2.Width = 333;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "date";
            gridViewTextBoxColumn3.MinWidth = 27;
            gridViewTextBoxColumn3.Name = "date";
            gridViewTextBoxColumn3.Width = 333;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "devise";
            gridViewTextBoxColumn4.MinWidth = 8;
            gridViewTextBoxColumn4.Name = "devise";
            gridViewTextBoxColumn4.Width = 106;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "reglement";
            gridViewTextBoxColumn5.MinWidth = 27;
            gridViewTextBoxColumn5.Name = "reglement";
            gridViewTextBoxColumn5.Width = 333;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "num";
            gridViewTextBoxColumn6.MinWidth = 18;
            gridViewTextBoxColumn6.Name = "num";
            gridViewTextBoxColumn6.Width = 224;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.MinWidth = 8;
            gridViewImageColumn1.Name = "facture";
            gridViewImageColumn1.Width = 61;
            gridViewImageColumn2.EnableExpressionEditor = false;
            gridViewImageColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn2.MinWidth = 18;
            gridViewImageColumn2.Name = "I2";
            gridViewImageColumn2.Width = 215;
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
            this.tabledata.Size = new System.Drawing.Size(1637, 654);
            this.tabledata.TabIndex = 26;
            this.tabledata.ThemeName = "Crystal";
            // 
            // voiresortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 787);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.panel1);
            this.Name = "voiresortie";
            this.Text = "voiresortie";
            ((System.ComponentModel.ISupportInitialize)(this.entreBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_debut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_fin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource entreBindingSource;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadDateTimePicker date_debut;
        private Telerik.WinControls.UI.RadDateTimePicker date_fin;
        private FontAwesome.Sharp.IconPictureBox btn_actualiser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Panel underlinePanel;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadGridView tabledata;
    }
}