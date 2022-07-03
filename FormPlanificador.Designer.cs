namespace ProySistemasOperativos1
{
    partial class FormPlanificador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerPRUN = new System.Windows.Forms.Timer(this.components);
            this.buttonInicio = new System.Windows.Forms.Button();
            this.PRUNtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericColas = new System.Windows.Forms.NumericUpDown();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.dataGridViewProcesos = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPRUN
            // 
            this.timerPRUN.Interval = 1000;
            this.timerPRUN.Tick += new System.EventHandler(this.timerPRUN_Tick);
            // 
            // buttonInicio
            // 
            this.buttonInicio.Font = new System.Drawing.Font("Niagara Solid", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInicio.Location = new System.Drawing.Point(805, 538);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(181, 27);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Iniciar Planificador";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // PRUNtext
            // 
            this.PRUNtext.AutoSize = true;
            this.PRUNtext.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRUNtext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PRUNtext.Location = new System.Drawing.Point(659, 30);
            this.PRUNtext.Name = "PRUNtext";
            this.PRUNtext.Size = new System.Drawing.Size(55, 34);
            this.PRUNtext.TabIndex = 1;
            this.PRUNtext.Text = "PRUN ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "CANTIDAD DE COLAS:";
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDatos.Location = new System.Drawing.Point(18, 88);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.Size = new System.Drawing.Size(444, 422);
            this.dataGridViewDatos.TabIndex = 5;
            this.dataGridViewDatos.Visible = false;
            this.dataGridViewDatos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewDatos_CellBeginEdit);
            this.dataGridViewDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatos_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Colas";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Procesos";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quatums Colas";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quatums Procesos";
            this.Column4.Name = "Column4";
            // 
            // numericColas
            // 
            this.numericColas.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericColas.Location = new System.Drawing.Point(299, 22);
            this.numericColas.Name = "numericColas";
            this.numericColas.Size = new System.Drawing.Size(157, 42);
            this.numericColas.TabIndex = 6;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Font = new System.Drawing.Font("Niagara Solid", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfig.Location = new System.Drawing.Point(12, 538);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(160, 27);
            this.buttonConfig.TabIndex = 7;
            this.buttonConfig.Text = "Configuracion";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.Font = new System.Drawing.Font("Niagara Solid", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonParar.Location = new System.Drawing.Point(299, 534);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(157, 31);
            this.buttonParar.TabIndex = 8;
            this.buttonParar.Text = "Parar Planificador";
            this.buttonParar.UseVisualStyleBackColor = true;
            this.buttonParar.Visible = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // dataGridViewProcesos
            // 
            this.dataGridViewProcesos.AllowUserToAddRows = false;
            this.dataGridViewProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20});
            this.dataGridViewProcesos.Location = new System.Drawing.Point(487, 88);
            this.dataGridViewProcesos.Name = "dataGridViewProcesos";
            this.dataGridViewProcesos.Size = new System.Drawing.Size(498, 422);
            this.dataGridViewProcesos.TabIndex = 9;
            this.dataGridViewProcesos.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cola";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "P1";
            this.Column6.Name = "Column6";
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "P2";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "P3";
            this.Column8.Name = "Column8";
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "P4";
            this.Column9.Name = "Column9";
            this.Column9.Width = 25;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "P5";
            this.Column10.Name = "Column10";
            this.Column10.Width = 25;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "P6";
            this.Column11.Name = "Column11";
            this.Column11.Width = 25;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "P7";
            this.Column12.Name = "Column12";
            this.Column12.Width = 25;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "P8";
            this.Column13.Name = "Column13";
            this.Column13.Width = 25;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "P9";
            this.Column14.Name = "Column14";
            this.Column14.Width = 25;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "P10";
            this.Column15.Name = "Column15";
            this.Column15.Width = 30;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "P11";
            this.Column16.Name = "Column16";
            this.Column16.Width = 30;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "P12";
            this.Column17.Name = "Column17";
            this.Column17.Width = 30;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "P13";
            this.Column18.Name = "Column18";
            this.Column18.Width = 30;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "P14";
            this.Column19.Name = "Column19";
            this.Column19.Width = 30;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "P15";
            this.Column20.Name = "Column20";
            this.Column20.Width = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(485, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "PRUN CORRIENDO: ";
            // 
            // FormPlanificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1002, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProcesos);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.numericColas);
            this.Controls.Add(this.dataGridViewDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PRUNtext);
            this.Controls.Add(this.buttonInicio);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlanificador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Planificador";
            this.Load += new System.EventHandler(this.FormPlanificador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPRUN;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Label PRUNtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown numericColas;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.DataGridView dataGridViewProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.Label label2;
    }
}

