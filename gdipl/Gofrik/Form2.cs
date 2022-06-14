using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gofrik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void setText(String text)
        {
            textBox1.Text = text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void setTable(double[,] data)
        {
            int N = data.GetLength(0);
            int M = data.GetLength(1);
            dataGridView1.RowCount = N;
            dataGridView1.ColumnCount = M;
            int i, j;
            for (i = 0; i < N; ++i)
                for (j = 0; j < M; ++j)
                    dataGridView1.Rows[i].Cells[j].Value = data[i, j];
        }
    }
}
