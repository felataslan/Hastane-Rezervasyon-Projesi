
namespace HastaneRezervasyonProjesi
{
    partial class FrmRandevuListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.ChbxDurum = new System.Windows.Forms.CheckBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.MskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(821, 587);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 106);
            this.label1.TabIndex = 5;
            this.label1.Text = "Randevu Kontrol \r\n     Paneli";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(159, 496);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(177, 46);
            this.BtnGuncelle.TabIndex = 28;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // ChbxDurum
            // 
            this.ChbxDurum.AutoSize = true;
            this.ChbxDurum.Location = new System.Drawing.Point(159, 462);
            this.ChbxDurum.Name = "ChbxDurum";
            this.ChbxDurum.Size = new System.Drawing.Size(101, 28);
            this.ChbxDurum.TabIndex = 27;
            this.ChbxDurum.Text = "Durum";
            this.ChbxDurum.UseVisualStyleBackColor = true;
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(159, 267);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(177, 30);
            this.MskSaat.TabIndex = 26;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(159, 217);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(177, 30);
            this.MskTarih.TabIndex = 25;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // MskHastaTC
            // 
            this.MskHastaTC.Location = new System.Drawing.Point(159, 417);
            this.MskHastaTC.Mask = "00000000000";
            this.MskHastaTC.Name = "MskHastaTC";
            this.MskHastaTC.Size = new System.Drawing.Size(177, 30);
            this.MskHastaTC.TabIndex = 24;
            this.MskHastaTC.ValidatingType = typeof(int);
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(159, 367);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(177, 32);
            this.CmbDoktor.TabIndex = 23;
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(159, 317);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(177, 32);
            this.CmbBrans.TabIndex = 22;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(159, 167);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(177, 30);
            this.TxtID.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hasta TC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID:";
            // 
            // FrmRandevuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1210, 597);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.ChbxDurum);
            this.Controls.Add(this.MskSaat);
            this.Controls.Add(this.MskTarih);
            this.Controls.Add(this.MskHastaTC);
            this.Controls.Add(this.CmbDoktor);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRandevuListe";
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FrmRandevuListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.CheckBox ChbxDurum;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.MaskedTextBox MskHastaTC;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}