namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCon = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.rbtnCelcius = new System.Windows.Forms.RadioButton();
            this.rbtnFaranhite = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(300, 167);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(87, 38);
            this.btnCon.TabIndex = 0;
            this.btnCon.Text = "Convert";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(418, 167);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(87, 38);
            this.txtClear.TabIndex = 1;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temparture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(315, 44);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(190, 20);
            this.txtTemp.TabIndex = 5;
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(315, 118);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(190, 20);
            this.txtAns.TabIndex = 6;
            // 
            // rbtnCelcius
            // 
            this.rbtnCelcius.AutoSize = true;
            this.rbtnCelcius.Location = new System.Drawing.Point(315, 86);
            this.rbtnCelcius.Name = "rbtnCelcius";
            this.rbtnCelcius.Size = new System.Drawing.Size(59, 17);
            this.rbtnCelcius.TabIndex = 7;
            this.rbtnCelcius.TabStop = true;
            this.rbtnCelcius.Text = "Celcius";
            this.rbtnCelcius.UseVisualStyleBackColor = true;
            // 
            // rbtnFaranhite
            // 
            this.rbtnFaranhite.AutoSize = true;
            this.rbtnFaranhite.Location = new System.Drawing.Point(420, 86);
            this.rbtnFaranhite.Name = "rbtnFaranhite";
            this.rbtnFaranhite.Size = new System.Drawing.Size(69, 17);
            this.rbtnFaranhite.TabIndex = 8;
            this.rbtnFaranhite.TabStop = true;
            this.rbtnFaranhite.Text = "Faranhite";
            this.rbtnFaranhite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 227);
            this.Controls.Add(this.rbtnFaranhite);
            this.Controls.Add(this.rbtnCelcius);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.btnCon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.RadioButton rbtnCelcius;
        private System.Windows.Forms.RadioButton rbtnFaranhite;
    }
}

