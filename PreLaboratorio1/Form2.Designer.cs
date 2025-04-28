namespace PreLaboratorio1
{
    partial class Form2
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            prof = new DataGridViewTextBoxColumn();
            clases = new DataGridViewTextBoxColumn();
            mater = new DataGridViewTextBoxColumn();
            unim = new DataGridViewTextBoxColumn();
            llev = new DataGridViewTextBoxColumn();
            teg = new DataGridViewTextBoxColumn();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(441, 304);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 29;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(327, 304);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 28;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 304);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(110, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(723, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(723, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(723, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(723, 24);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 23);
            textBox4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(598, 152);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 20;
            label5.Text = "Grado y Seccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 108);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 19;
            label4.Text = "Profesor Guia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 71);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 17;
            label2.Text = "Nombre y Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 24);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 16;
            label1.Text = "NO.";
            // 
            // button5
            // 
            button5.Location = new Point(5, 304);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 30;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, prof, clases, mater, unim, llev, teg });
            dataGridView1.Location = new Point(5, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 263);
            dataGridView1.TabIndex = 15;
            // 
            // nombre
            // 
            nombre.HeaderText = "NO.";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "NOMBRE Y APELLIDO";
            apellido.Name = "apellido";
            // 
            // prof
            // 
            prof.HeaderText = "PROF GUIA";
            prof.Name = "prof";
            // 
            // clases
            // 
            clases.HeaderText = "GRADO Y SECCION";
            clases.Name = "clases";
            // 
            // mater
            // 
            mater.HeaderText = "Materia favorita";
            mater.Name = "mater";
            // 
            // unim
            // 
            unim.HeaderText = "uniforme favorito";
            unim.Name = "unim";
            // 
            // llev
            // 
            llev.HeaderText = "llevas refaccion";
            llev.Name = "llev";
            // 
            // teg
            // 
            teg.HeaderText = "te gusta el colegio";
            teg.Name = "teg";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(723, 189);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 38;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(723, 229);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(166, 23);
            textBox6.TabIndex = 37;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(723, 271);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(166, 23);
            textBox7.TabIndex = 36;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(723, 305);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(166, 23);
            textBox8.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 274);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 34;
            label3.Text = "llevas refaccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(598, 234);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 33;
            label6.Text = "uniforme favorito";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 197);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 32;
            label7.Text = "materia favorita";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(598, 313);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 31;
            label8.Text = "te gusta el colegio";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 352);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button button5;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn prof;
        private DataGridViewTextBoxColumn clases;
        private DataGridViewTextBoxColumn mater;
        private DataGridViewTextBoxColumn unim;
        private DataGridViewTextBoxColumn llev;
        private DataGridViewTextBoxColumn teg;
    }
}