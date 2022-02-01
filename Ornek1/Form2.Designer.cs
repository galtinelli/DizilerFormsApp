
namespace Ornek1
{
    partial class Form2
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
            this.btnSonEleman = new System.Windows.Forms.Button();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lbxElemanlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSonEleman
            // 
            this.btnSonEleman.Location = new System.Drawing.Point(28, 30);
            this.btnSonEleman.Name = "btnSonEleman";
            this.btnSonEleman.Size = new System.Drawing.Size(269, 56);
            this.btnSonEleman.TabIndex = 0;
            this.btnSonEleman.Text = "Son Elemanı Göster";
            this.btnSonEleman.UseVisualStyleBackColor = true;
            this.btnSonEleman.Click += new System.EventHandler(this.btnSonEleman_Click);
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(28, 92);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(269, 55);
            this.btnRastgele.TabIndex = 1;
            this.btnRastgele.Text = "Rastgele Eleman Göster";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(28, 153);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(269, 53);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Elemanları ListBoxa Ekle";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lbxElemanlar
            // 
            this.lbxElemanlar.FormattingEnabled = true;
            this.lbxElemanlar.Location = new System.Drawing.Point(28, 212);
            this.lbxElemanlar.Name = "lbxElemanlar";
            this.lbxElemanlar.Size = new System.Drawing.Size(269, 121);
            this.lbxElemanlar.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 349);
            this.Controls.Add(this.lbxElemanlar);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.btnSonEleman);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonEleman;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lbxElemanlar;
    }
}