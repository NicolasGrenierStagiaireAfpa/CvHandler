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
            this.btnPeuplerLaBDD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExportGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCvPDF = new System.Windows.Forms.Button();
            this.btnCvWORD = new System.Windows.Forms.Button();
            this.btnEffacerLigne = new System.Windows.Forms.Button();
            this.btnInsererLigne = new System.Windows.Forms.Button();
            this.lblCompetences = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPeuplerLaBDD
            // 
            this.btnPeuplerLaBDD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPeuplerLaBDD.Location = new System.Drawing.Point(2288, 889);
            this.btnPeuplerLaBDD.Margin = new System.Windows.Forms.Padding(6);
            this.btnPeuplerLaBDD.Name = "btnPeuplerLaBDD";
            this.btnPeuplerLaBDD.Size = new System.Drawing.Size(386, 64);
            this.btnPeuplerLaBDD.TabIndex = 1;
            this.btnPeuplerLaBDD.Text = "Réinitialiser la BDD";
            this.btnPeuplerLaBDD.UseVisualStyleBackColor = true;
            this.btnPeuplerLaBDD.Click += new System.EventHandler(this.button2_Click);
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
            this.button4.Location = new System.Drawing.Point(1131, 818);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(416, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "Voir tous les postulants";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Location = new System.Drawing.Point(1131, 893);
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
            this.label1.Location = new System.Drawing.Point(90, 726);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Postulant Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 790);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 40);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCvPDF
            // 
            this.btnCvPDF.Location = new System.Drawing.Point(1556, 819);
            this.btnCvPDF.Name = "btnCvPDF";
            this.btnCvPDF.Size = new System.Drawing.Size(402, 61);
            this.btnCvPDF.TabIndex = 12;
            this.btnCvPDF.Text = "Voir les CV";
            this.btnCvPDF.UseVisualStyleBackColor = true;
            this.btnCvPDF.Click += new System.EventHandler(this.btnCvPDF_Click);
            // 
            // btnCvWORD
            // 
            this.btnCvWORD.Location = new System.Drawing.Point(1556, 893);
            this.btnCvWORD.Name = "btnCvWORD";
            this.btnCvWORD.Size = new System.Drawing.Size(402, 60);
            this.btnCvWORD.TabIndex = 13;
            this.btnCvWORD.Text = "Editer le CV";
            this.btnCvWORD.UseVisualStyleBackColor = true;
            this.btnCvWORD.Click += new System.EventHandler(this.btnCvWORD_Click);
            // 
            // btnEffacerLigne
            // 
            this.btnEffacerLigne.Location = new System.Drawing.Point(12, 861);
            this.btnEffacerLigne.Name = "btnEffacerLigne";
            this.btnEffacerLigne.Size = new System.Drawing.Size(336, 92);
            this.btnEffacerLigne.TabIndex = 14;
            this.btnEffacerLigne.Text = "Effacer les informtions de ce postulant";
            this.btnEffacerLigne.UseVisualStyleBackColor = true;
            this.btnEffacerLigne.Click += new System.EventHandler(this.btnEffacerLigne_Click);
            // 
            // btnInsererLigne
            // 
            this.btnInsererLigne.Location = new System.Drawing.Point(728, 819);
            this.btnInsererLigne.Name = "btnInsererLigne";
            this.btnInsererLigne.Size = new System.Drawing.Size(394, 136);
            this.btnInsererLigne.TabIndex = 16;
            this.btnInsererLigne.Text = "Insérer ou Modifier une candidature";
            this.btnInsererLigne.UseVisualStyleBackColor = true;
            this.btnInsererLigne.Click += new System.EventHandler(this.btnInsererLigne_Click);
            // 
            // lblCompetences
            // 
            this.lblCompetences.AutoSize = true;
            this.lblCompetences.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCompetences.Location = new System.Drawing.Point(451, 727);
            this.lblCompetences.Name = "lblCompetences";
            this.lblCompetences.Size = new System.Drawing.Size(160, 32);
            this.lblCompetences.TabIndex = 17;
            this.lblCompetences.Text = "Compétences";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(351, 790);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(368, 40);
            this.comboBox2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 862);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 92);
            this.button2.TabIndex = 19;
            this.button2.Text = "Voir ces postulants";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(2689, 960);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblCompetences);
            this.Controls.Add(this.btnInsererLigne);
            this.Controls.Add(this.btnEffacerLigne);
            this.Controls.Add(this.btnCvWORD);
            this.Controls.Add(this.btnCvPDF);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPeuplerLaBDD);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPeuplerLaBDD;
        private DataGridView dataGridView1;
        private Button button4;
        private Button btnExportGrid;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnCvPDF;
        private Button btnCvWORD;
        private Button btnEffacerLigne;
        private Button btnInsererLigne;
        private Label lblCompetences;
        private ComboBox comboBox2;
        private Button button2;
    }
}