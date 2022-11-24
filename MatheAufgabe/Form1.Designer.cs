namespace MatheAufgabe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBasisPolynom = new System.Windows.Forms.Button();
            this.textBoxAnzahlderWerten = new System.Windows.Forms.TextBox();
            this.btnStuetzEingebe = new System.Windows.Forms.Button();
            this.dataGridViewWerten = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxLagrange = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWerten)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxLagrange);
            this.panel1.Controls.Add(this.btnBasisPolynom);
            this.panel1.Controls.Add(this.textBoxAnzahlderWerten);
            this.panel1.Controls.Add(this.btnStuetzEingebe);
            this.panel1.Controls.Add(this.dataGridViewWerten);
            this.panel1.Location = new System.Drawing.Point(351, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 777);
            this.panel1.TabIndex = 0;
            // 
            // btnBasisPolynom
            // 
            this.btnBasisPolynom.Location = new System.Drawing.Point(614, 111);
            this.btnBasisPolynom.Name = "btnBasisPolynom";
            this.btnBasisPolynom.Size = new System.Drawing.Size(143, 40);
            this.btnBasisPolynom.TabIndex = 3;
            this.btnBasisPolynom.Text = "Basis Polynom";
            this.btnBasisPolynom.UseVisualStyleBackColor = true;
            this.btnBasisPolynom.Click += new System.EventHandler(this.btnBasisPolynom_Click);
            // 
            // textBoxAnzahlderWerten
            // 
            this.textBoxAnzahlderWerten.Location = new System.Drawing.Point(370, 34);
            this.textBoxAnzahlderWerten.Name = "textBoxAnzahlderWerten";
            this.textBoxAnzahlderWerten.Size = new System.Drawing.Size(116, 23);
            this.textBoxAnzahlderWerten.TabIndex = 2;
            // 
            // btnStuetzEingebe
            // 
            this.btnStuetzEingebe.Location = new System.Drawing.Point(604, 19);
            this.btnStuetzEingebe.Name = "btnStuetzEingebe";
            this.btnStuetzEingebe.Size = new System.Drawing.Size(153, 51);
            this.btnStuetzEingebe.TabIndex = 1;
            this.btnStuetzEingebe.Text = "Stuezstellen eingeben";
            this.btnStuetzEingebe.UseVisualStyleBackColor = true;
            this.btnStuetzEingebe.Click += new System.EventHandler(this.btnStuetzEingebe_Click);
            // 
            // dataGridViewWerten
            // 
            this.dataGridViewWerten.AllowUserToAddRows = false;
            this.dataGridViewWerten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWerten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewWerten.Location = new System.Drawing.Point(38, 19);
            this.dataGridViewWerten.Name = "dataGridViewWerten";
            this.dataGridViewWerten.RowTemplate.Height = 25;
            this.dataGridViewWerten.Size = new System.Drawing.Size(242, 222);
            this.dataGridViewWerten.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // textBoxLagrange
            // 
            this.textBoxLagrange.Location = new System.Drawing.Point(29, 302);
            this.textBoxLagrange.Name = "textBoxLagrange";
            this.textBoxLagrange.Size = new System.Drawing.Size(516, 23);
            this.textBoxLagrange.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 801);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWerten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBoxAnzahlderWerten;
        private Button btnStuetzEingebe;
        private DataGridView dataGridViewWerten;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private Button btnBasisPolynom;
        private TextBox textBoxLagrange;
    }
}