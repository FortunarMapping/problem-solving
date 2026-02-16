using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightedGraph
{
    public partial class Form1 : Form
    {
        string[] vertex_list = new string[] { "A", "B", "C", "D", "E", "F" };
        int[,] adj_list = new int[,] { { 0, 523, 345, 0, 0, 0 }, { 523, 0, 200, 548, 0, 0 }, { 345, 200, 0, 360, 467, 0 }, { 0, 548, 360, 0, 245, 320 }, { 0, 0, 467, 245, 0, 555 }, { 0, 0, 0, 320, 555, 0 } };
        public Form1()
        {
            InitializeComponent();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            int src_index = srcComboBox.SelectedIndex;
            int desc_index = descComboBox.SelectedIndex;
            distanceTextBox.Text = adj_list[src_index, desc_index].ToString();
        }
    }
}
