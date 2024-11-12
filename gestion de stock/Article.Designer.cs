namespace gestion_de_stock
{
    partial class Article
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
            this.quantite = new System.Windows.Forms.TextBox();
            this.add_Button = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.designation = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titel = new System.Windows.Forms.Label();
            this.prix_u = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maxS = new System.Windows.Forms.TextBox();
            this.minS = new System.Windows.Forms.TextBox();
            this.reference = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            this.SuspendLayout();
            // 
            // quantite
            // 
            this.quantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantite.Location = new System.Drawing.Point(630, 244);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(400, 44);
            this.quantite.TabIndex = 21;
            // 
            // add_Button
            // 
            this.add_Button.BackColor = System.Drawing.Color.White;
            this.add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Button.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F);
            this.add_Button.Location = new System.Drawing.Point(451, 526);
            this.add_Button.Name = "add_Button";
            // 
            // 
            // 
            this.add_Button.RootElement.AccessibleDescription = "Ajouter";
            this.add_Button.RootElement.AccessibleName = "Ajouter";
            this.add_Button.Size = new System.Drawing.Size(341, 70);
            this.add_Button.TabIndex = 15;
            this.add_Button.Text = "Ajouter";
            this.add_Button.ThemeName = "Crystal";
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 45);
            this.label4.TabIndex = 22;
            this.label4.Text = "Unite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 45);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantite";
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.Gray;
            this.underlinePanel.Location = new System.Drawing.Point(12, 43);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(925, 3);
            this.underlinePanel.TabIndex = 10;
            // 
            // designation
            // 
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.Location = new System.Drawing.Point(630, 147);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(400, 44);
            this.designation.TabIndex = 19;
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(195, 147);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(400, 44);
            this.code.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = "Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 45);
            this.label5.TabIndex = 24;
            this.label5.Text = "prix_u";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code";
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.titel.Location = new System.Drawing.Point(0, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(292, 40);
            this.titel.TabIndex = 9;
            this.titel.Text = "Ajouter d\'article";
            // 
            // prix_u
            // 
            this.prix_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_u.Location = new System.Drawing.Point(195, 351);
            this.prix_u.Name = "prix_u";
            this.prix_u.Size = new System.Drawing.Size(400, 44);
            this.prix_u.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radDropDownList1);
            this.panel1.Controls.Add(this.prix_u);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.code);
            this.panel1.Controls.Add(this.maxS);
            this.panel1.Controls.Add(this.minS);
            this.panel1.Controls.Add(this.reference);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.designation);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.underlinePanel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.add_Button);
            this.panel1.Controls.Add(this.quantite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 655);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maxS
            // 
            this.maxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxS.Location = new System.Drawing.Point(630, 467);
            this.maxS.Name = "maxS";
            this.maxS.Size = new System.Drawing.Size(400, 44);
            this.maxS.TabIndex = 23;
            // 
            // minS
            // 
            this.minS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minS.Location = new System.Drawing.Point(195, 467);
            this.minS.Name = "minS";
            this.minS.Size = new System.Drawing.Size(400, 44);
            this.minS.TabIndex = 23;
            // 
            // reference
            // 
            this.reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reference.Location = new System.Drawing.Point(195, 244);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(400, 44);
            this.reference.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(642, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 45);
            this.label8.TabIndex = 22;
            this.label8.Text = "Stock Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 45);
            this.label7.TabIndex = 22;
            this.label7.Text = "Stock Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 45);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rreference";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.ItemHeight = 44;
            this.radDropDownList1.Location = new System.Drawing.Point(640, 354);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(390, 24);
            this.radDropDownList1.TabIndex = 26;
            this.radDropDownList1.ThemeName = "Crystal";
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 655);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Article";
            this.Text = "Article";
            ((System.ComponentModel.ISupportInitialize)(this.add_Button)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox quantite;
        private Telerik.WinControls.UI.RadButton add_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel underlinePanel;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.TextBox prix_u;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox maxS;
        private System.Windows.Forms.TextBox minS;
        private System.Windows.Forms.TextBox reference;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
    }
}