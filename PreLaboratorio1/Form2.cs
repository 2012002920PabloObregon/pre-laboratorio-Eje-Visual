using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLaboratorio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int cod = 1;
        static int seleccionFila;

        void limpiar()
        {

            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
            textBox4.Text, 
            textBox1.Text,
            textBox2.Text,
            textBox3.Text,
            textBox5.Text,
            textBox6.Text,
            textBox7.Text,
            textBox8.Text
                );
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                DataGridViewRow seleccionFila = dataGridView1.CurrentRow;

                seleccionFila.Cells[0].Value = textBox4.Text;
                seleccionFila.Cells[1].Value = textBox1.Text;
                seleccionFila.Cells[2].Value = textBox2.Text;
                seleccionFila.Cells[3].Value = textBox3.Text;
                seleccionFila.Cells[4].Value = textBox5.Text;
                seleccionFila.Cells[5].Value = textBox6.Text;
                seleccionFila.Cells[6].Value = textBox7.Text;
                seleccionFila.Cells[7].Value = textBox8.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionFila >= 0)
                {
                    dataGridView1.Rows.RemoveAt(seleccionFila);
                    MessageBox.Show("Cita eliminada", "Colegio Salesiano Don Bosco",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("No hay citas", "Colegio Salesiano Don Bosco",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("No hay citas seleccionadas", "Colegio Salesiano Don Bosco",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
