using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardcodingControls
{
    public partial class Form1 : Form
    {
        private int rows = 5;
        private int cols = 5;
        private Button[,] buttons;
        private int size = 100;
        private int distance = 10;
        private int currentX = 10;
        private int currentY = 10;
        private Random random = new Random();
        private int number = 1;
        private void OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            button.Hide();
        }
        public Form1()
        {
            buttons = new Button[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(size, size);
                    buttons[i, j].Location = new Point(currentX, currentY);
                    buttons[i, j].BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    buttons[i, j].Text = number.ToString();
                    buttons[i, j].Click += new EventHandler(OnClick);
                    Controls.Add(buttons[i, j]);
                    currentX += distance + size;
                    number++;
                }
                currentX = 10;
                currentY += distance + size;
            }
            InitializeComponent();
        }
    }
}
