using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class FrmTicTacToe : Form
    {
        public FrmTicTacToe()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTicTacToe_Paint(object sender, PaintEventArgs e)
        {
            int boardSize = 550;
            int startX = lblTitle.Left - 120;
            int startY = lblTitle.Bottom + 15;
            int cellSize = boardSize / 3;

            Pen pen = new Pen(Color.White, 5);

            e.Graphics.DrawLine(pen, startX + cellSize, startY, startX + cellSize, startY + boardSize); 
            e.Graphics.DrawLine(pen, startX + (2 * cellSize), startY, startX + (2 * cellSize), startY + boardSize); 

            e.Graphics.DrawLine(pen, startX, startY + cellSize, startX + boardSize, startY + cellSize); 
            e.Graphics.DrawLine(pen, startX, startY + (2 * cellSize), startX + boardSize, startY + (2 * cellSize)); 
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
}
