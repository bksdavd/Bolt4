namespace Bolt4
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
            this.labLak = new System.Windows.Forms.Label();
            this.tbLFJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKosar = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újElemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labLak
            // 
            this.labLak.AutoSize = true;
            this.labLak.Location = new System.Drawing.Point(399, 308);
            this.labLak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLak.Name = "labLak";
            this.labLak.Size = new System.Drawing.Size(46, 16);
            this.labLak.TabIndex = 30;
            this.labLak.Text = "Laktóz";
            this.labLak.Visible = false;
            // 
            // tbLFJ
            // 
            this.tbLFJ.Location = new System.Drawing.Point(403, 276);
            this.tbLFJ.Margin = new System.Windows.Forms.Padding(4);
            this.tbLFJ.Name = "tbLFJ";
            this.tbLFJ.Size = new System.Drawing.Size(196, 22);
            this.tbLFJ.TabIndex = 29;
            this.tbLFJ.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Termék lejárata:";
            this.label5.Visible = false;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(403, 95);
            this.tbNev.Margin = new System.Windows.Forms.Padding(4);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(196, 22);
            this.tbNev.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Termék neve:";
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(403, 218);
            this.tbAr.Margin = new System.Windows.Forms.Padding(4);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(196, 22);
            this.tbAr.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Termék ár:";
            // 
            // tbKod
            // 
            this.tbKod.Location = new System.Drawing.Point(403, 158);
            this.tbKod.Margin = new System.Windows.Forms.Padding(4);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(196, 22);
            this.tbKod.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Termék kód:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kosár";
            // 
            // lbKosar
            // 
            this.lbKosar.FormattingEnabled = true;
            this.lbKosar.ItemHeight = 16;
            this.lbKosar.Location = new System.Drawing.Point(17, 69);
            this.lbKosar.Margin = new System.Windows.Forms.Padding(4);
            this.lbKosar.Name = "lbKosar";
            this.lbKosar.Size = new System.Drawing.Size(360, 324);
            this.lbKosar.TabIndex = 20;
            this.lbKosar.SelectedIndexChanged += new System.EventHandler(this.lbKosar_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újElemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újElemToolStripMenuItem
            // 
            this.újElemToolStripMenuItem.Name = "újElemToolStripMenuItem";
            this.újElemToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.újElemToolStripMenuItem.Text = "Új elem";
            this.újElemToolStripMenuItem.Click += new System.EventHandler(this.újElemToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labLak);
            this.Controls.Add(this.tbLFJ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKosar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLak;
        private System.Windows.Forms.TextBox tbLFJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKosar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újElemToolStripMenuItem;
    }
}

