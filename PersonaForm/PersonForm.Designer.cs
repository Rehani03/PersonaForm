
namespace PersonaForm
{
    partial class PersonForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AgetextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthdaydateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Buscarbutton3 = new System.Windows.Forms.Button();
            this.Guardarbutton2 = new System.Windows.Forms.Button();
            this.Cancelarbutton1 = new System.Windows.Forms.Button();
            this.telefonomaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DirecciontextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MyerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FiltrocomboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CriteriotextBox1 = new System.Windows.Forms.TextBox();
            this.ConsultadataGridView1 = new System.Windows.Forms.DataGridView();
            this.Consultarbutton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.AgetextBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BirthdaydateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Buscarbutton3);
            this.panel1.Controls.Add(this.Guardarbutton2);
            this.panel1.Controls.Add(this.Cancelarbutton1);
            this.panel1.Controls.Add(this.telefonomaskedTextBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DirecciontextBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NombretextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IDnumericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 346);
            this.panel1.TabIndex = 0;
            // 
            // AgetextBox1
            // 
            this.AgetextBox1.Enabled = false;
            this.AgetextBox1.Location = new System.Drawing.Point(98, 201);
            this.AgetextBox1.Name = "AgetextBox1";
            this.AgetextBox1.Size = new System.Drawing.Size(120, 20);
            this.AgetextBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "AGE:";
            // 
            // BirthdaydateTimePicker1
            // 
            this.BirthdaydateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdaydateTimePicker1.Location = new System.Drawing.Point(98, 164);
            this.BirthdaydateTimePicker1.Name = "BirthdaydateTimePicker1";
            this.BirthdaydateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.BirthdaydateTimePicker1.TabIndex = 12;
            this.BirthdaydateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BirthdaydateTimePicker1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "BIRTHDAY:";
            // 
            // Buscarbutton3
            // 
            this.Buscarbutton3.BackColor = System.Drawing.Color.Teal;
            this.Buscarbutton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbutton3.Location = new System.Drawing.Point(239, 8);
            this.Buscarbutton3.Name = "Buscarbutton3";
            this.Buscarbutton3.Size = new System.Drawing.Size(75, 32);
            this.Buscarbutton3.TabIndex = 10;
            this.Buscarbutton3.Text = "BUSCAR";
            this.Buscarbutton3.UseVisualStyleBackColor = false;
            this.Buscarbutton3.Click += new System.EventHandler(this.Buscarbutton3_Click);
            // 
            // Guardarbutton2
            // 
            this.Guardarbutton2.BackColor = System.Drawing.Color.Green;
            this.Guardarbutton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton2.Location = new System.Drawing.Point(194, 253);
            this.Guardarbutton2.Name = "Guardarbutton2";
            this.Guardarbutton2.Size = new System.Drawing.Size(120, 44);
            this.Guardarbutton2.TabIndex = 9;
            this.Guardarbutton2.Text = "GUARDAR";
            this.Guardarbutton2.UseVisualStyleBackColor = false;
            this.Guardarbutton2.Click += new System.EventHandler(this.Guardarbutton2_Click);
            // 
            // Cancelarbutton1
            // 
            this.Cancelarbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancelarbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelarbutton1.Location = new System.Drawing.Point(48, 253);
            this.Cancelarbutton1.Name = "Cancelarbutton1";
            this.Cancelarbutton1.Size = new System.Drawing.Size(109, 44);
            this.Cancelarbutton1.TabIndex = 8;
            this.Cancelarbutton1.Text = "CANCELAR";
            this.Cancelarbutton1.UseVisualStyleBackColor = false;
            this.Cancelarbutton1.Click += new System.EventHandler(this.Cancelarbutton1_Click);
            // 
            // telefonomaskedTextBox1
            // 
            this.telefonomaskedTextBox1.Location = new System.Drawing.Point(98, 124);
            this.telefonomaskedTextBox1.Mask = "(999) 000-0000";
            this.telefonomaskedTextBox1.Name = "telefonomaskedTextBox1";
            this.telefonomaskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.telefonomaskedTextBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFONO:";
            // 
            // DirecciontextBox2
            // 
            this.DirecciontextBox2.Location = new System.Drawing.Point(98, 88);
            this.DirecciontextBox2.Name = "DirecciontextBox2";
            this.DirecciontextBox2.Size = new System.Drawing.Size(233, 20);
            this.DirecciontextBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRRECION:";
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(98, 49);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(233, 20);
            this.NombretextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // IDnumericUpDown1
            // 
            this.IDnumericUpDown1.Location = new System.Drawing.Point(98, 11);
            this.IDnumericUpDown1.Name = "IDnumericUpDown1";
            this.IDnumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.IDnumericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // MyerrorProvider1
            // 
            this.MyerrorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Consultarbutton1);
            this.groupBox1.Controls.Add(this.ConsultadataGridView1);
            this.groupBox1.Controls.Add(this.CriteriotextBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.FiltrocomboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(364, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 335);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "FILTRO:";
            // 
            // FiltrocomboBox1
            // 
            this.FiltrocomboBox1.FormattingEnabled = true;
            this.FiltrocomboBox1.Items.AddRange(new object[] {
            "TODO",
            "NOMBRE",
            "TELEFONO"});
            this.FiltrocomboBox1.Location = new System.Drawing.Point(83, 12);
            this.FiltrocomboBox1.Name = "FiltrocomboBox1";
            this.FiltrocomboBox1.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CRITERIO:";
            // 
            // CriteriotextBox1
            // 
            this.CriteriotextBox1.Location = new System.Drawing.Point(83, 45);
            this.CriteriotextBox1.Name = "CriteriotextBox1";
            this.CriteriotextBox1.Size = new System.Drawing.Size(310, 20);
            this.CriteriotextBox1.TabIndex = 3;
            this.CriteriotextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CriteriotextBox1_KeyPress);
            // 
            // ConsultadataGridView1
            // 
            this.ConsultadataGridView1.AllowUserToAddRows = false;
            this.ConsultadataGridView1.AllowUserToDeleteRows = false;
            this.ConsultadataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView1.Location = new System.Drawing.Point(11, 80);
            this.ConsultadataGridView1.Name = "ConsultadataGridView1";
            this.ConsultadataGridView1.ReadOnly = true;
            this.ConsultadataGridView1.Size = new System.Drawing.Size(382, 209);
            this.ConsultadataGridView1.TabIndex = 4;
            // 
            // Consultarbutton1
            // 
            this.Consultarbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Consultarbutton1.Location = new System.Drawing.Point(241, 8);
            this.Consultarbutton1.Name = "Consultarbutton1";
            this.Consultarbutton1.Size = new System.Drawing.Size(94, 31);
            this.Consultarbutton1.TabIndex = 5;
            this.Consultarbutton1.Text = "CONSULTAR";
            this.Consultarbutton1.UseVisualStyleBackColor = false;
            this.Consultarbutton1.Click += new System.EventHandler(this.Consultarbutton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(11, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 363);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PersonForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Persona";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Guardarbutton2;
        private System.Windows.Forms.Button Cancelarbutton1;
        private System.Windows.Forms.MaskedTextBox telefonomaskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DirecciontextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyerrorProvider1;
        private System.Windows.Forms.Button Buscarbutton3;
        private System.Windows.Forms.TextBox AgetextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker BirthdaydateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Consultarbutton1;
        private System.Windows.Forms.DataGridView ConsultadataGridView1;
        private System.Windows.Forms.TextBox CriteriotextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FiltrocomboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

