namespace Database
{
    partial class Form1
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
            this.txbParkID = new System.Windows.Forms.TextBox();
            this.txbParkNaam = new System.Windows.Forms.TextBox();
            this.txbLocatie = new System.Windows.Forms.TextBox();
            this.txbOpeningsDagen = new System.Windows.Forms.TextBox();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.dataGridView_USERS = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPrijzen = new System.Windows.Forms.TextBox();
            this.txbLeeftijden = new System.Windows.Forms.TextBox();
            this.txbTags = new System.Windows.Forms.TextBox();
            this.rtbBeschrijving = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbOpeningsTijden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_USERS)).BeginInit();
            this.SuspendLayout();
            // 
            // txbParkID
            // 
            this.txbParkID.Location = new System.Drawing.Point(68, 44);
            this.txbParkID.Name = "txbParkID";
            this.txbParkID.Size = new System.Drawing.Size(235, 20);
            this.txbParkID.TabIndex = 0;
            // 
            // txbParkNaam
            // 
            this.txbParkNaam.Location = new System.Drawing.Point(72, 74);
            this.txbParkNaam.Name = "txbParkNaam";
            this.txbParkNaam.Size = new System.Drawing.Size(232, 20);
            this.txbParkNaam.TabIndex = 1;
            // 
            // txbLocatie
            // 
            this.txbLocatie.Location = new System.Drawing.Point(82, 100);
            this.txbLocatie.Name = "txbLocatie";
            this.txbLocatie.Size = new System.Drawing.Size(222, 20);
            this.txbLocatie.TabIndex = 2;
            // 
            // txbOpeningsDagen
            // 
            this.txbOpeningsDagen.Location = new System.Drawing.Point(124, 126);
            this.txbOpeningsDagen.Name = "txbOpeningsDagen";
            this.txbOpeningsDagen.Size = new System.Drawing.Size(180, 20);
            this.txbOpeningsDagen.TabIndex = 3;
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.Location = new System.Drawing.Point(12, 503);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(75, 23);
            this.BTN_INSERT.TabIndex = 9;
            this.BTN_INSERT.Text = "INSERT";
            this.BTN_INSERT.UseVisualStyleBackColor = true;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Location = new System.Drawing.Point(124, 503);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(75, 23);
            this.BTN_UPDATE.TabIndex = 10;
            this.BTN_UPDATE.Text = "UPDATE";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(229, 503);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(75, 23);
            this.BTN_DELETE.TabIndex = 11;
            this.BTN_DELETE.Text = "DELETE";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // dataGridView_USERS
            // 
            this.dataGridView_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_USERS.Location = new System.Drawing.Point(310, 25);
            this.dataGridView_USERS.Name = "dataGridView_USERS";
            this.dataGridView_USERS.Size = new System.Drawing.Size(947, 423);
            this.dataGridView_USERS.TabIndex = 0;
            this.dataGridView_USERS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_USERS_MouseClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 3;
            this.label.Text = "ParkID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ParkNaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ParkLocatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ParkOpeningsDagen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "ParkPrijzen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ParkLeeftijden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ParkTags";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ParkBeschrijving";
            // 
            // txbPrijzen
            // 
            this.txbPrijzen.Location = new System.Drawing.Point(71, 180);
            this.txbPrijzen.Name = "txbPrijzen";
            this.txbPrijzen.Size = new System.Drawing.Size(232, 20);
            this.txbPrijzen.TabIndex = 5;
            // 
            // txbLeeftijden
            // 
            this.txbLeeftijden.Location = new System.Drawing.Point(92, 205);
            this.txbLeeftijden.Name = "txbLeeftijden";
            this.txbLeeftijden.Size = new System.Drawing.Size(211, 20);
            this.txbLeeftijden.TabIndex = 6;
            // 
            // txbTags
            // 
            this.txbTags.Location = new System.Drawing.Point(71, 230);
            this.txbTags.Name = "txbTags";
            this.txbTags.Size = new System.Drawing.Size(232, 20);
            this.txbTags.TabIndex = 7;
            // 
            // rtbBeschrijving
            // 
            this.rtbBeschrijving.Location = new System.Drawing.Point(12, 318);
            this.rtbBeschrijving.Name = "rtbBeschrijving";
            this.rtbBeschrijving.Size = new System.Drawing.Size(292, 179);
            this.rtbBeschrijving.TabIndex = 8;
            this.rtbBeschrijving.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ParkOpeningsTijden";
            // 
            // txbOpeningsTijden
            // 
            this.txbOpeningsTijden.Location = new System.Drawing.Point(124, 152);
            this.txbOpeningsTijden.Name = "txbOpeningsTijden";
            this.txbOpeningsTijden.Size = new System.Drawing.Size(179, 20);
            this.txbOpeningsTijden.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 649);
            this.Controls.Add(this.txbOpeningsTijden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbBeschrijving);
            this.Controls.Add(this.txbTags);
            this.Controls.Add(this.txbLeeftijden);
            this.Controls.Add(this.txbPrijzen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView_USERS);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.BTN_INSERT);
            this.Controls.Add(this.txbOpeningsDagen);
            this.Controls.Add(this.txbLocatie);
            this.Controls.Add(this.txbParkNaam);
            this.Controls.Add(this.txbParkID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_USERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbParkID;
        private System.Windows.Forms.TextBox txbParkNaam;
        private System.Windows.Forms.TextBox txbLocatie;
        private System.Windows.Forms.TextBox txbOpeningsDagen;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.DataGridView dataGridView_USERS;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPrijzen;
        private System.Windows.Forms.TextBox txbLeeftijden;
        private System.Windows.Forms.TextBox txbTags;
        private System.Windows.Forms.RichTextBox rtbBeschrijving;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbOpeningsTijden;
    }
}

