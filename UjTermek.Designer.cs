namespace Bolt4
{
    partial class UjTermek
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
            this.cbLaktoz = new System.Windows.Forms.CheckBox();
            this.btnMent = new System.Windows.Forms.Button();
            this.rbTermek = new System.Windows.Forms.RadioButton();
            this.rbTejtermek = new System.Windows.Forms.RadioButton();
            this.nudLFJ = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLFJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLaktoz
            // 
            this.cbLaktoz.AutoSize = true;
            this.cbLaktoz.Location = new System.Drawing.Point(234, 336);
            this.cbLaktoz.Name = "cbLaktoz";
            this.cbLaktoz.Size = new System.Drawing.Size(118, 20);
            this.cbLaktoz.TabIndex = 30;
            this.cbLaktoz.Text = "Laktóz tartalmú";
            this.cbLaktoz.UseVisualStyleBackColor = true;
            this.cbLaktoz.Visible = false;
            // 
            // btnMent
            // 
            this.btnMent.Location = new System.Drawing.Point(375, 329);
            this.btnMent.Name = "btnMent";
            this.btnMent.Size = new System.Drawing.Size(98, 35);
            this.btnMent.TabIndex = 29;
            this.btnMent.Text = "Mentés";
            this.btnMent.UseVisualStyleBackColor = true;
            this.btnMent.Click += new System.EventHandler(this.btnMent_Click);
            // 
            // rbTermek
            // 
            this.rbTermek.AutoSize = true;
            this.rbTermek.Checked = true;
            this.rbTermek.Location = new System.Drawing.Point(361, 122);
            this.rbTermek.Name = "rbTermek";
            this.rbTermek.Size = new System.Drawing.Size(112, 20);
            this.rbTermek.TabIndex = 28;
            this.rbTermek.TabStop = true;
            this.rbTermek.Text = "Egyéb termék";
            this.rbTermek.UseVisualStyleBackColor = true;
            // 
            // rbTejtermek
            // 
            this.rbTejtermek.AutoSize = true;
            this.rbTejtermek.Location = new System.Drawing.Point(361, 96);
            this.rbTejtermek.Name = "rbTejtermek";
            this.rbTejtermek.Size = new System.Drawing.Size(89, 20);
            this.rbTejtermek.TabIndex = 27;
            this.rbTejtermek.Text = "Tejtermék";
            this.rbTejtermek.UseVisualStyleBackColor = true;
            this.rbTejtermek.CheckedChanged += new System.EventHandler(this.rbTejtermek_CheckedChanged);
            // 
            // nudLFJ
            // 
            this.nudLFJ.Location = new System.Drawing.Point(15, 336);
            this.nudLFJ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLFJ.Name = "nudLFJ";
            this.nudLFJ.Size = new System.Drawing.Size(213, 22);
            this.nudLFJ.TabIndex = 26;
            this.nudLFJ.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Új termék lejárata";
            this.label4.Visible = false;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(15, 66);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(213, 22);
            this.tbNev.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Új termék neve";
            // 
            // nudAr
            // 
            this.nudAr.Location = new System.Drawing.Point(17, 248);
            this.nudAr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAr.Name = "nudAr";
            this.nudAr.Size = new System.Drawing.Size(213, 22);
            this.nudAr.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Termék ára";
            // 
            // tbKod
            // 
            this.tbKod.Location = new System.Drawing.Point(17, 155);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(213, 22);
            this.tbKod.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Új termék kódja";
            // 
            // UjTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 420);
            this.Controls.Add(this.cbLaktoz);
            this.Controls.Add(this.btnMent);
            this.Controls.Add(this.rbTermek);
            this.Controls.Add(this.rbTejtermek);
            this.Controls.Add(this.nudLFJ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.label1);
            this.Name = "UjTermek";
            this.Text = "UjTermek";
            this.Load += new System.EventHandler(this.UjTermek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLFJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbLaktoz;
        private System.Windows.Forms.Button btnMent;
        private System.Windows.Forms.RadioButton rbTermek;
        private System.Windows.Forms.RadioButton rbTejtermek;
        private System.Windows.Forms.NumericUpDown nudLFJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.Label label1;
    }
}