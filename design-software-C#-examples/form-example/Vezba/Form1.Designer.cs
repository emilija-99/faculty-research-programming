namespace Vezba
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxGodine = new System.Windows.Forms.ComboBox();
            this.festivaliBox = new System.Windows.Forms.ComboBox();
            this.daniBox = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.posetiociDataGrid = new System.Windows.Forms.DataGridView();
            this.ImePosetioca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.godinaBoxKarta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.festivalBoxKarta = new System.Windows.Forms.ComboBox();
            this.Festival = new System.Windows.Forms.Label();
            this.posetilacBoxKarta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.daniBoxKarta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unosCene = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.posetiociDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Godina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv festivala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dan:";
            // 
            // BoxGodine
            // 
            this.BoxGodine.FormattingEnabled = true;
            this.BoxGodine.Location = new System.Drawing.Point(43, 53);
            this.BoxGodine.Name = "BoxGodine";
            this.BoxGodine.Size = new System.Drawing.Size(84, 24);
            this.BoxGodine.TabIndex = 3;
            // 
            // festivaliBox
            // 
            this.festivaliBox.FormattingEnabled = true;
            this.festivaliBox.Location = new System.Drawing.Point(150, 53);
            this.festivaliBox.Name = "festivaliBox";
            this.festivaliBox.Size = new System.Drawing.Size(106, 24);
            this.festivaliBox.TabIndex = 4;
            // 
            // daniBox
            // 
            this.daniBox.FormattingEnabled = true;
            this.daniBox.Location = new System.Drawing.Point(288, 53);
            this.daniBox.Name = "daniBox";
            this.daniBox.Size = new System.Drawing.Size(42, 24);
            this.daniBox.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(548, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sql";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(548, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "nosql";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // posetiociDataGrid
            // 
            this.posetiociDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posetiociDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePosetioca});
            this.posetiociDataGrid.Location = new System.Drawing.Point(43, 127);
            this.posetiociDataGrid.Name = "posetiociDataGrid";
            this.posetiociDataGrid.RowHeadersWidth = 51;
            this.posetiociDataGrid.RowTemplate.Height = 24;
            this.posetiociDataGrid.Size = new System.Drawing.Size(164, 162);
            this.posetiociDataGrid.TabIndex = 8;
            // 
            // ImePosetioca
            // 
            this.ImePosetioca.HeaderText = "ImePosetioca";
            this.ImePosetioca.MinimumWidth = 6;
            this.ImePosetioca.Name = "ImePosetioca";
            this.ImePosetioca.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Godina,
            this.Cena,
            this.Dan});
            this.dataGridView1.Location = new System.Drawing.Point(299, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 162);
            this.dataGridView1.TabIndex = 10;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 125;
            // 
            // Godina
            // 
            this.Godina.HeaderText = "Godina";
            this.Godina.MinimumWidth = 6;
            this.Godina.Name = "Godina";
            this.Godina.Width = 125;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.MinimumWidth = 6;
            this.Cena.Name = "Cena";
            this.Cena.Width = 125;
            // 
            // Dan
            // 
            this.Dan.HeaderText = "Dan";
            this.Dan.MinimumWidth = 6;
            this.Dan.Name = "Dan";
            this.Dan.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dodaj kartu";
            // 
            // godinaBoxKarta
            // 
            this.godinaBoxKarta.FormattingEnabled = true;
            this.godinaBoxKarta.Location = new System.Drawing.Point(57, 386);
            this.godinaBoxKarta.Name = "godinaBoxKarta";
            this.godinaBoxKarta.Size = new System.Drawing.Size(87, 24);
            this.godinaBoxKarta.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Godina:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // festivalBoxKarta
            // 
            this.festivalBoxKarta.FormattingEnabled = true;
            this.festivalBoxKarta.Location = new System.Drawing.Point(183, 386);
            this.festivalBoxKarta.Name = "festivalBoxKarta";
            this.festivalBoxKarta.Size = new System.Drawing.Size(87, 24);
            this.festivalBoxKarta.TabIndex = 14;
            // 
            // Festival
            // 
            this.Festival.AutoSize = true;
            this.Festival.Location = new System.Drawing.Point(180, 367);
            this.Festival.Name = "Festival";
            this.Festival.Size = new System.Drawing.Size(57, 16);
            this.Festival.TabIndex = 15;
            this.Festival.Text = "Fastival:";
            // 
            // posetilacBoxKarta
            // 
            this.posetilacBoxKarta.FormattingEnabled = true;
            this.posetilacBoxKarta.Location = new System.Drawing.Point(313, 386);
            this.posetilacBoxKarta.Name = "posetilacBoxKarta";
            this.posetilacBoxKarta.Size = new System.Drawing.Size(87, 24);
            this.posetilacBoxKarta.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Posetilac:";
            // 
            // daniBoxKarta
            // 
            this.daniBoxKarta.FormattingEnabled = true;
            this.daniBoxKarta.Location = new System.Drawing.Point(433, 386);
            this.daniBoxKarta.Name = "daniBoxKarta";
            this.daniBoxKarta.Size = new System.Drawing.Size(62, 24);
            this.daniBoxKarta.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dan:";
            // 
            // unosCene
            // 
            this.unosCene.Location = new System.Drawing.Point(529, 388);
            this.unosCene.Name = "unosCene";
            this.unosCene.Size = new System.Drawing.Size(79, 22);
            this.unosCene.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cena:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 21);
            this.button2.TabIndex = 22;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unosCene);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.daniBoxKarta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.posetilacBoxKarta);
            this.Controls.Add(this.Festival);
            this.Controls.Add(this.festivalBoxKarta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.godinaBoxKarta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.posetiociDataGrid);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.daniBox);
            this.Controls.Add(this.festivaliBox);
            this.Controls.Add(this.BoxGodine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.posetiociDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxGodine;
        private System.Windows.Forms.ComboBox festivaliBox;
        private System.Windows.Forms.ComboBox daniBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView posetiociDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePosetioca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox godinaBoxKarta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox festivalBoxKarta;
        private System.Windows.Forms.Label Festival;
        private System.Windows.Forms.ComboBox posetilacBoxKarta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox daniBoxKarta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unosCene;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

