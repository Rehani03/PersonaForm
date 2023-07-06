
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DirecciontextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonomaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Cancelarbutton1 = new System.Windows.Forms.Button();
            this.Guardarbutton2 = new System.Windows.Forms.Button();
            this.MyerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(353, 226);
            this.panel1.TabIndex = 0;
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
            // IDnumericUpDown1
            // 
            this.IDnumericUpDown1.Location = new System.Drawing.Point(98, 11);
            this.IDnumericUpDown1.Name = "IDnumericUpDown1";
            this.IDnumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.IDnumericUpDown1.TabIndex = 1;
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
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(98, 49);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(233, 20);
            this.NombretextBox1.TabIndex = 3;
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
            // DirecciontextBox2
            // 
            this.DirecciontextBox2.Location = new System.Drawing.Point(98, 88);
            this.DirecciontextBox2.Name = "DirecciontextBox2";
            this.DirecciontextBox2.Size = new System.Drawing.Size(233, 20);
            this.DirecciontextBox2.TabIndex = 5;
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
            // telefonomaskedTextBox1
            // 
            this.telefonomaskedTextBox1.Location = new System.Drawing.Point(98, 124);
            this.telefonomaskedTextBox1.Mask = "(999) 000-0000";
            this.telefonomaskedTextBox1.Name = "telefonomaskedTextBox1";
            this.telefonomaskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.telefonomaskedTextBox1.TabIndex = 7;
            // 
            // Cancelarbutton1
            // 
            this.Cancelarbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancelarbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelarbutton1.Location = new System.Drawing.Point(48, 168);
            this.Cancelarbutton1.Name = "Cancelarbutton1";
            this.Cancelarbutton1.Size = new System.Drawing.Size(109, 44);
            this.Cancelarbutton1.TabIndex = 8;
            this.Cancelarbutton1.Text = "CANCELAR";
            this.Cancelarbutton1.UseVisualStyleBackColor = false;
            this.Cancelarbutton1.Click += new System.EventHandler(this.Cancelarbutton1_Click);
            // 
            // Guardarbutton2
            // 
            this.Guardarbutton2.BackColor = System.Drawing.Color.Green;
            this.Guardarbutton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton2.Location = new System.Drawing.Point(194, 168);
            this.Guardarbutton2.Name = "Guardarbutton2";
            this.Guardarbutton2.Size = new System.Drawing.Size(120, 44);
            this.Guardarbutton2.TabIndex = 9;
            this.Guardarbutton2.Text = "GUARDAR";
            this.Guardarbutton2.UseVisualStyleBackColor = false;
            this.Guardarbutton2.Click += new System.EventHandler(this.Guardarbutton2_Click);
            // 
            // MyerrorProvider1
            // 
            this.MyerrorProvider1.ContainerControl = this;
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
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 250);
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
    }
}

