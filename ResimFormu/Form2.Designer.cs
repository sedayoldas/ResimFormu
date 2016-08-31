namespace ResimFormu
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
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.pb2Resim = new System.Windows.Forms.PictureBox();
            this.txt2Model = new System.Windows.Forms.TextBox();
            this.txt2Yil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(25, 37);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(130, 21);
            this.cbMarka.TabIndex = 0;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // pb2Resim
            // 
            this.pb2Resim.Location = new System.Drawing.Point(191, 12);
            this.pb2Resim.Name = "pb2Resim";
            this.pb2Resim.Size = new System.Drawing.Size(150, 86);
            this.pb2Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2Resim.TabIndex = 1;
            this.pb2Resim.TabStop = false;
            // 
            // txt2Model
            // 
            this.txt2Model.Location = new System.Drawing.Point(224, 104);
            this.txt2Model.Multiline = true;
            this.txt2Model.Name = "txt2Model";
            this.txt2Model.Size = new System.Drawing.Size(100, 20);
            this.txt2Model.TabIndex = 2;
            // 
            // txt2Yil
            // 
            this.txt2Yil.Location = new System.Drawing.Point(224, 143);
            this.txt2Yil.Name = "txt2Yil";
            this.txt2Yil.Size = new System.Drawing.Size(100, 20);
            this.txt2Yil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yıl:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2Yil);
            this.Controls.Add(this.txt2Model);
            this.Controls.Add(this.pb2Resim);
            this.Controls.Add(this.cbMarka);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb2Resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.PictureBox pb2Resim;
        private System.Windows.Forms.TextBox txt2Model;
        private System.Windows.Forms.TextBox txt2Yil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}