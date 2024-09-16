namespace Kosarka
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
            this.utakmiceGrid = new System.Windows.Forms.DataGridView();
            this.PocetakUtakmice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domacin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcitajUtakmicu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timBox = new System.Windows.Forms.ComboBox();
            this.igracBox = new System.Windows.Forms.ComboBox();
            this.pogodakBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.utakmiceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // utakmiceGrid
            // 
            this.utakmiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utakmiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PocetakUtakmice,
            this.Domacin,
            this.Gost,
            this.Rezultat});
            this.utakmiceGrid.Location = new System.Drawing.Point(12, 64);
            this.utakmiceGrid.Name = "utakmiceGrid";
            this.utakmiceGrid.RowHeadersWidth = 51;
            this.utakmiceGrid.RowTemplate.Height = 24;
            this.utakmiceGrid.Size = new System.Drawing.Size(551, 123);
            this.utakmiceGrid.TabIndex = 0;
            this.utakmiceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PocetakUtakmice
            // 
            this.PocetakUtakmice.HeaderText = "PocetakUtakmice";
            this.PocetakUtakmice.MinimumWidth = 6;
            this.PocetakUtakmice.Name = "PocetakUtakmice";
            this.PocetakUtakmice.Width = 125;
            // 
            // Domacin
            // 
            this.Domacin.HeaderText = "Domacin";
            this.Domacin.MinimumWidth = 6;
            this.Domacin.Name = "Domacin";
            this.Domacin.Width = 125;
            // 
            // Gost
            // 
            this.Gost.HeaderText = "Gost";
            this.Gost.MinimumWidth = 6;
            this.Gost.Name = "Gost";
            this.Gost.Width = 125;
            // 
            // Rezultat
            // 
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.MinimumWidth = 6;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Width = 125;
            // 
            // UcitajUtakmicu
            // 
            this.UcitajUtakmicu.Location = new System.Drawing.Point(195, 205);
            this.UcitajUtakmicu.Name = "UcitajUtakmicu";
            this.UcitajUtakmicu.Size = new System.Drawing.Size(148, 26);
            this.UcitajUtakmicu.TabIndex = 1;
            this.UcitajUtakmicu.Text = "UcitajUtakmicu";
            this.UcitajUtakmicu.UseVisualStyleBackColor = true;
            this.UcitajUtakmicu.Click += new System.EventHandler(this.UcitajUtakmicu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IzaberiTim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "IzaberiIgraca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tim pogotka";
            // 
            // timBox
            // 
            this.timBox.FormattingEnabled = true;
            this.timBox.Location = new System.Drawing.Point(38, 316);
            this.timBox.Name = "timBox";
            this.timBox.Size = new System.Drawing.Size(97, 24);
            this.timBox.TabIndex = 5;
            // 
            // igracBox
            // 
            this.igracBox.FormattingEnabled = true;
            this.igracBox.Location = new System.Drawing.Point(181, 316);
            this.igracBox.Name = "igracBox";
            this.igracBox.Size = new System.Drawing.Size(97, 24);
            this.igracBox.TabIndex = 6;
            // 
            // pogodakBox
            // 
            this.pogodakBox.FormattingEnabled = true;
            this.pogodakBox.Location = new System.Drawing.Point(330, 316);
            this.pogodakBox.Name = "pogodakBox";
            this.pogodakBox.Size = new System.Drawing.Size(97, 24);
            this.pogodakBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pogodakBox);
            this.Controls.Add(this.igracBox);
            this.Controls.Add(this.timBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UcitajUtakmicu);
            this.Controls.Add(this.utakmiceGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.utakmiceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView utakmiceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakUtakmice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domacin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.Button UcitajUtakmicu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox timBox;
        private System.Windows.Forms.ComboBox igracBox;
        private System.Windows.Forms.ComboBox pogodakBox;
    }
}

