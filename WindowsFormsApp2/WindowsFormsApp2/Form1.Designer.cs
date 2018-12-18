namespace WindowsFormsApp2
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.Location = new System.Drawing.Point(12, 51);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(400, 360);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox2.Location = new System.Drawing.Point(418, 51);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(400, 360);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 1;
            this.PictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button3);
            this.groupBox1.Controls.Add(this.Button2);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Location = new System.Drawing.Point(824, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAMERA KONTROL";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(7, 89);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "ÇIKIŞ";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(7, 60);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "DURDUR";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(7, 30);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "BAŞLAT";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioButton3);
            this.groupBox2.Controls.Add(this.RadioButton2);
            this.groupBox2.Controls.Add(this.RadioButton1);
            this.groupBox2.Location = new System.Drawing.Point(935, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RENK KONTROL";
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(17, 89);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(53, 17);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "BLUE";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(17, 63);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(63, 17);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "GREEN";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(17, 36);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(48, 17);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "RED";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Location = new System.Drawing.Point(894, 368);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(94, 17);
            this.RadioButton4.TabIndex = 4;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "tek cisim takibi";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(891, 352);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "tek cisim takibi";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripTextBox1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1061, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "toolStrip1";
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(824, 211);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(212, 21);
            this.ComboBox1.TabIndex = 8;
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "COM4",
            "COM5"});
            this.ComboBox2.Location = new System.Drawing.Point(824, 249);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(212, 21);
            this.ComboBox2.TabIndex = 9;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(824, 287);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(212, 23);
            this.Button4.TabIndex = 10;
            this.Button4.Text = "BAĞLAN ";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(824, 316);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(212, 23);
            this.Button5.TabIndex = 11;
            this.Button5.Text = "BAĞLANTIYI KES";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.RadioButton4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
    }
}

