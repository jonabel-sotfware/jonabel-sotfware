namespace registrodeusuario
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNOMBRE1 = new System.Windows.Forms.Button();
            this.dataGridViewListaUsuarios = new System.Windows.Forms.Button();
            this.TXNOMBRE3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXNOMBRE2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboNOMBRE = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.radioNOMBRE2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioNOMBRE = new System.Windows.Forms.RadioButton();
            this.dateNOMBRE = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TXNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro De Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNOMBRE1);
            this.groupBox2.Controls.Add(this.dataGridViewListaUsuarios);
            this.groupBox2.Controls.Add(this.TXNOMBRE3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TXNOMBRE2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboNOMBRE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.radioNOMBRE2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioNOMBRE);
            this.groupBox2.Controls.Add(this.dateNOMBRE);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXNOMBRE);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonNOMBRE1
            // 
            this.buttonNOMBRE1.Location = new System.Drawing.Point(84, 257);
            this.buttonNOMBRE1.Name = "buttonNOMBRE1";
            this.buttonNOMBRE1.Size = new System.Drawing.Size(75, 23);
            this.buttonNOMBRE1.TabIndex = 19;
            this.buttonNOMBRE1.Text = "NUEVO";
            this.buttonNOMBRE1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListaUsuarios
            // 
            this.dataGridViewListaUsuarios.Location = new System.Drawing.Point(207, 257);
            this.dataGridViewListaUsuarios.Name = "dataGridViewListaUsuarios";
            this.dataGridViewListaUsuarios.Size = new System.Drawing.Size(75, 23);
            this.dataGridViewListaUsuarios.TabIndex = 18;
            this.dataGridViewListaUsuarios.Text = "AGREGAR";
            this.dataGridViewListaUsuarios.UseVisualStyleBackColor = true;
            this.dataGridViewListaUsuarios.Click += new System.EventHandler(this.dataGridViewListaUsuarios_Click);
            // 
            // TXNOMBRE3
            // 
            this.TXNOMBRE3.Location = new System.Drawing.Point(125, 176);
            this.TXNOMBRE3.Name = "TXNOMBRE3";
            this.TXNOMBRE3.PasswordChar = '*';
            this.TXNOMBRE3.Size = new System.Drawing.Size(133, 20);
            this.TXNOMBRE3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CONTRASENA:";
            // 
            // TXNOMBRE2
            // 
            this.TXNOMBRE2.Location = new System.Drawing.Point(125, 150);
            this.TXNOMBRE2.Name = "TXNOMBRE2";
            this.TXNOMBRE2.Size = new System.Drawing.Size(133, 20);
            this.TXNOMBRE2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "USUARIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "PERFIL:";
            // 
            // comboNOMBRE
            // 
            this.comboNOMBRE.FormattingEnabled = true;
            this.comboNOMBRE.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO"});
            this.comboNOMBRE.Location = new System.Drawing.Point(125, 205);
            this.comboNOMBRE.Name = "comboNOMBRE";
            this.comboNOMBRE.Size = new System.Drawing.Size(133, 21);
            this.comboNOMBRE.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TELEFONO:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(128, 124);
            this.maskedTextBox1.Mask = "(999)000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // radioNOMBRE2
            // 
            this.radioNOMBRE2.AutoSize = true;
            this.radioNOMBRE2.Location = new System.Drawing.Point(173, 97);
            this.radioNOMBRE2.Name = "radioNOMBRE2";
            this.radioNOMBRE2.Size = new System.Drawing.Size(31, 17);
            this.radioNOMBRE2.TabIndex = 6;
            this.radioNOMBRE2.TabStop = true;
            this.radioNOMBRE2.Text = "F";
            this.radioNOMBRE2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SEXO:";
            // 
            // radioNOMBRE
            // 
            this.radioNOMBRE.AutoSize = true;
            this.radioNOMBRE.Location = new System.Drawing.Point(125, 97);
            this.radioNOMBRE.Name = "radioNOMBRE";
            this.radioNOMBRE.Size = new System.Drawing.Size(34, 17);
            this.radioNOMBRE.TabIndex = 4;
            this.radioNOMBRE.TabStop = true;
            this.radioNOMBRE.Text = "M";
            this.radioNOMBRE.UseVisualStyleBackColor = true;
            // 
            // dateNOMBRE
            // 
            this.dateNOMBRE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNOMBRE.Location = new System.Drawing.Point(125, 60);
            this.dateNOMBRE.Name = "dateNOMBRE";
            this.dateNOMBRE.Size = new System.Drawing.Size(79, 20);
            this.dateNOMBRE.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA:";
            // 
            // TXNOMBRE
            // 
            this.TXNOMBRE.Location = new System.Drawing.Point(125, 28);
            this.TXNOMBRE.Name = "TXNOMBRE";
            this.TXNOMBRE.Size = new System.Drawing.Size(133, 20);
            this.TXNOMBRE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(343, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 356);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(23, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "USUARIO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ROL";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(897, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNOMBRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioNOMBRE2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioNOMBRE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboNOMBRE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonNOMBRE1;
        private System.Windows.Forms.Button dataGridViewListaUsuarios;
        private System.Windows.Forms.TextBox TXNOMBRE3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXNOMBRE2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
    }
}

