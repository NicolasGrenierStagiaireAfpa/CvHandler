namespace CvHandlerForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnPeuplerLaBDD = new System.Windows.Forms.Button();
            this.btnEffacerLaBDD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExportGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCvPDF = new System.Windows.Forms.Button();
            this.btnCvWORD = new System.Windows.Forms.Button();
            this.btnEffacerLigne = new System.Windows.Forms.Button();
            this.btnEditerLigne = new System.Windows.Forms.Button();
            this.btnInsererLigne = new System.Windows.Forms.Button();
            this.lblCompetences = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(1671, 893);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tester fonction BONFORMAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPeuplerLaBDD
            // 
            this.btnPeuplerLaBDD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPeuplerLaBDD.Location = new System.Drawing.Point(2321, 834);
            this.btnPeuplerLaBDD.Margin = new System.Windows.Forms.Padding(6);
            this.btnPeuplerLaBDD.Name = "btnPeuplerLaBDD";
            this.btnPeuplerLaBDD.Size = new System.Drawing.Size(345, 64);
            this.btnPeuplerLaBDD.TabIndex = 1;
            this.btnPeuplerLaBDD.Text = "Peupler la BDD";
            this.btnPeuplerLaBDD.UseVisualStyleBackColor = true;
            this.btnPeuplerLaBDD.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEffacerLaBDD
            // 
            this.btnEffacerLaBDD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEffacerLaBDD.Location = new System.Drawing.Point(2321, 757);
            this.btnEffacerLaBDD.Margin = new System.Windows.Forms.Padding(6);
            this.btnEffacerLaBDD.Name = "btnEffacerLaBDD";
            this.btnEffacerLaBDD.Size = new System.Drawing.Size(345, 64);
            this.btnEffacerLaBDD.TabIndex = 2;
            this.btnEffacerLaBDD.Text = "Effacer la BDD";
            this.btnEffacerLaBDD.UseVisualStyleBackColor = true;
            this.btnEffacerLaBDD.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(2689, 723);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(1066, 757);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(416, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "Voir les postulants";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Location = new System.Drawing.Point(1066, 836);
            this.btnExportGrid.Margin = new System.Windows.Forms.Padding(6);
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.Size = new System.Drawing.Size(416, 62);
            this.btnExportGrid.TabIndex = 9;
            this.btnExportGrid.Text = "Exporter la vue dans Excel";
            this.btnExportGrid.UseVisualStyleBackColor = true;
            this.btnExportGrid.Click += new System.EventHandler(this.btnExportGrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(87, 727);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Postulant Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 765);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 40);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCvPDF
            // 
            this.btnCvPDF.Location = new System.Drawing.Point(2143, 773);
            this.btnCvPDF.Name = "btnCvPDF";
            this.btnCvPDF.Size = new System.Drawing.Size(146, 46);
            this.btnCvPDF.TabIndex = 12;
            this.btnCvPDF.Text = "Voir le CV";
            this.btnCvPDF.UseVisualStyleBackColor = true;
            this.btnCvPDF.Click += new System.EventHandler(this.btnCvPDF_Click);
            // 
            // btnCvWORD
            // 
            this.btnCvWORD.Location = new System.Drawing.Point(2139, 836);
            this.btnCvWORD.Name = "btnCvWORD";
            this.btnCvWORD.Size = new System.Drawing.Size(150, 46);
            this.btnCvWORD.TabIndex = 13;
            this.btnCvWORD.Text = "Editer le CV";
            this.btnCvWORD.UseVisualStyleBackColor = true;
            this.btnCvWORD.Click += new System.EventHandler(this.btnCvWORD_Click);
            // 
            // btnEffacerLigne
            // 
            this.btnEffacerLigne.Location = new System.Drawing.Point(12, 806);
            this.btnEffacerLigne.Name = "btnEffacerLigne";
            this.btnEffacerLigne.Size = new System.Drawing.Size(314, 46);
            this.btnEffacerLigne.TabIndex = 14;
            this.btnEffacerLigne.Text = "Effacer la ligne de la BDD";
            this.btnEffacerLigne.UseVisualStyleBackColor = true;
            this.btnEffacerLigne.Click += new System.EventHandler(this.btnEffacerLigne_Click);
            // 
            // btnEditerLigne
            // 
            this.btnEditerLigne.Location = new System.Drawing.Point(12, 858);
            this.btnEditerLigne.Name = "btnEditerLigne";
            this.btnEditerLigne.Size = new System.Drawing.Size(314, 46);
            this.btnEditerLigne.TabIndex = 15;
            this.btnEditerLigne.Text = "Editer la ligne";
            this.btnEditerLigne.UseVisualStyleBackColor = true;
            // 
            // btnInsererLigne
            // 
            this.btnInsererLigne.Location = new System.Drawing.Point(1131, 907);
            this.btnInsererLigne.Name = "btnInsererLigne";
            this.btnInsererLigne.Size = new System.Drawing.Size(278, 46);
            this.btnInsererLigne.TabIndex = 16;
            this.btnInsererLigne.Text = "Inserer une ligne";
            this.btnInsererLigne.UseVisualStyleBackColor = true;
            // 
            // lblCompetences
            // 
            this.lblCompetences.AutoSize = true;
            this.lblCompetences.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCompetences.Location = new System.Drawing.Point(420, 727);
            this.lblCompetences.Name = "lblCompetences";
            this.lblCompetences.Size = new System.Drawing.Size(160, 32);
            this.lblCompetences.TabIndex = 17;
            this.lblCompetences.Text = "Compétences";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(351, 762);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(294, 40);
            this.comboBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(2689, 960);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblCompetences);
            this.Controls.Add(this.btnInsererLigne);
            this.Controls.Add(this.btnEditerLigne);
            this.Controls.Add(this.btnEffacerLigne);
            this.Controls.Add(this.btnCvWORD);
            this.Controls.Add(this.btnCvPDF);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEffacerLaBDD);
            this.Controls.Add(this.btnPeuplerLaBDD);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnPeuplerLaBDD;
        private Button btnEffacerLaBDD;
        private DataGridView dataGridView1;
        private Button button4;
        private Button btnExportGrid;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnCvPDF;
        private Button btnCvWORD;
        private Button btnEffacerLigne;
        private Button btnEditerLigne;
        private Button btnInsererLigne;
        private Label lblCompetences;
        private ComboBox comboBox2;
    }
}