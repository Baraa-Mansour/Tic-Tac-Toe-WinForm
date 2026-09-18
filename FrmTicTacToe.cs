using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class FrmTicTacToe : Form
    {
        private int MoveCounter = 0;
        private static string Player1 = "Player 1";
        private static string Player2 = "Player 2";

        public FrmTicTacToe()
        {
            InitializeComponent();
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


        private void UpdateCellState(Button btn)
        {
            if (lblPlayer.Text == Player1)
            {
                btn.Image = Resources.X;
                btn.Tag = "X";
            }
            else if (lblPlayer.Text == Player2)
            {
                btn.Image = Resources.O;
                btn.Tag = "O";
            }
        }
        private void ChangePlayer()
        {
            if (lblPlayer.Text == Player1)
            {
                lblPlayer.Text = Player2;
                return;
            }
            if (lblPlayer.Text == Player2)
            {
                lblPlayer.Text = Player1;
                return;
            }
        }


        private bool IsValidChoice(Button btn)
        {
            return btn.Tag.ToString() == "?";
        }
        private void ShowInvalidChoiceMessageBox()
        {
            MessageBox.Show(
                    "This Cell Already Chosen",
                    "Invalid Choice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }


        private void btnCell_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!IsValidChoice(btn))
            {
                ShowInvalidChoiceMessageBox();
                return;
            }
            MoveCounter++;

            UpdateCellState(btn);

            ChangePlayer();
        }
    }
}
