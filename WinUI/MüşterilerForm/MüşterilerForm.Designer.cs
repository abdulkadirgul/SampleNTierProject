
namespace WinUI.MüşterilerForm
{
    partial class MüşterilerForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtsirketAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmüsteriAdi = new System.Windows.Forms.TextBox();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.txtTlfNumarasi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMüsteriSayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSehirSayisi = new System.Windows.Forms.Label();
            this.lblsdfsdf = new System.Windows.Forms.Label();
            this.lblSirketSayisi = new System.Windows.Forms.Label();
            this.txtMüsteriID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1072, 384);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri ID";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Şirket Adı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri Adı";
            this.columnHeader3.Width = 249;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Şehir";
            this.columnHeader4.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon Numarası";
            this.columnHeader5.Width = 196;
            // 
            // txtsirketAdi
            // 
            this.txtsirketAdi.Location = new System.Drawing.Point(199, 453);
            this.txtsirketAdi.Name = "txtsirketAdi";
            this.txtsirketAdi.Size = new System.Drawing.Size(177, 22);
            this.txtsirketAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şirket Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(137, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şehir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(62, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "TLF Numarası:";
            // 
            // txtmüsteriAdi
            // 
            this.txtmüsteriAdi.Location = new System.Drawing.Point(199, 481);
            this.txtmüsteriAdi.Name = "txtmüsteriAdi";
            this.txtmüsteriAdi.Size = new System.Drawing.Size(177, 22);
            this.txtmüsteriAdi.TabIndex = 1;
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(199, 509);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(177, 22);
            this.txtSehirAdi.TabIndex = 1;
            // 
            // txtTlfNumarasi
            // 
            this.txtTlfNumarasi.Location = new System.Drawing.Point(199, 537);
            this.txtTlfNumarasi.Name = "txtTlfNumarasi";
            this.txtTlfNumarasi.Size = new System.Drawing.Size(177, 22);
            this.txtTlfNumarasi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(199, 575);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(177, 32);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(199, 613);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(177, 32);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.Location = new System.Drawing.Point(901, 418);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(216, 38);
            this.btnMusteriAra.TabIndex = 4;
            this.btnMusteriAra.Text = "Müşteri Ara";
            this.btnMusteriAra.UseVisualStyleBackColor = true;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(722, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Müşteri Sayısı:";
            // 
            // lblMüsteriSayisi
            // 
            this.lblMüsteriSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMüsteriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMüsteriSayisi.Location = new System.Drawing.Point(742, 547);
            this.lblMüsteriSayisi.Name = "lblMüsteriSayisi";
            this.lblMüsteriSayisi.Size = new System.Drawing.Size(140, 102);
            this.lblMüsteriSayisi.TabIndex = 5;
            this.lblMüsteriSayisi.Text = "0";
            this.lblMüsteriSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(899, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şehir Sayısı:";
            // 
            // lblSehirSayisi
            // 
            this.lblSehirSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSehirSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehirSayisi.Location = new System.Drawing.Point(930, 547);
            this.lblSehirSayisi.Name = "lblSehirSayisi";
            this.lblSehirSayisi.Size = new System.Drawing.Size(140, 102);
            this.lblSehirSayisi.TabIndex = 5;
            this.lblSehirSayisi.Text = "0";
            this.lblSehirSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsdfsdf
            // 
            this.lblsdfsdf.AutoSize = true;
            this.lblsdfsdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsdfsdf.Location = new System.Drawing.Point(549, 502);
            this.lblsdfsdf.Name = "lblsdfsdf";
            this.lblsdfsdf.Size = new System.Drawing.Size(126, 25);
            this.lblsdfsdf.TabIndex = 5;
            this.lblsdfsdf.Text = "Şirket Sayısı:";
            // 
            // lblSirketSayisi
            // 
            this.lblSirketSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSirketSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketSayisi.Location = new System.Drawing.Point(554, 547);
            this.lblSirketSayisi.Name = "lblSirketSayisi";
            this.lblSirketSayisi.Size = new System.Drawing.Size(140, 102);
            this.lblSirketSayisi.TabIndex = 5;
            this.lblSirketSayisi.Text = "0";
            this.lblSirketSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMüsteriID
            // 
            this.txtMüsteriID.Location = new System.Drawing.Point(199, 425);
            this.txtMüsteriID.Name = "txtMüsteriID";
            this.txtMüsteriID.Size = new System.Drawing.Size(177, 22);
            this.txtMüsteriID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Müşteri ID:";
            // 
            // MüşterilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 761);
            this.Controls.Add(this.lblSehirSayisi);
            this.Controls.Add(this.lblSirketSayisi);
            this.Controls.Add(this.lblMüsteriSayisi);
            this.Controls.Add(this.lblsdfsdf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMusteriAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTlfNumarasi);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.txtmüsteriAdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMüsteriID);
            this.Controls.Add(this.txtsirketAdi);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MüşterilerForm";
            this.Text = "MüşterilerForm";
            this.Load += new System.EventHandler(this.MüşterilerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtsirketAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmüsteriAdi;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.TextBox txtTlfNumarasi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMüsteriSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSehirSayisi;
        private System.Windows.Forms.Label lblsdfsdf;
        private System.Windows.Forms.Label lblSirketSayisi;
        private System.Windows.Forms.TextBox txtMüsteriID;
        private System.Windows.Forms.Label label7;
    }
}