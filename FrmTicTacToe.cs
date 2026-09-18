using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class FrmTicTacToe : Form
    {
        private const string Player1 = "Player 1";
        private const string Player2 = "Player 2";

        private int MoveCounter = 0;
        private string Winner = "";

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

        private void CellsEnabled(bool value)
        {
            btnCell1.Enabled = value;
            btnCell2.Enabled = value;
            btnCell3.Enabled = value;
            btnCell4.Enabled = value;
            btnCell5.Enabled = value;
            btnCell6.Enabled = value;
            btnCell7.Enabled = value;
            btnCell8.Enabled = value;
            btnCell9.Enabled = value;
        }
        private void ResetCell(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.Black;
            btn.Tag = "?";
            btn.Image = Resources.question_mark_96;
        }
        private void ResetCells()
        {
            ResetCell(btnCell1);
            ResetCell(btnCell2);
            ResetCell(btnCell3);
            ResetCell(btnCell4);
            ResetCell(btnCell5);
            ResetCell(btnCell6);
            ResetCell(btnCell7);
            ResetCell(btnCell8);
            ResetCell(btnCell9);
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

        private bool IsEqualRaw(Button btn1, Button btn2, Button btn3)
        {
            bool result = false;
            if (btn1.Tag.ToString() == "?")
                return result;

            if(btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.Yellow;
                btn2.BackColor = Color.Yellow;
                btn3.BackColor = Color.Yellow;
                result = true;
            }

            return result;
        }
        private bool IsWin()
        {
            if (
                IsEqualRaw(btnCell1, btnCell2, btnCell3)
                || IsEqualRaw(btnCell4, btnCell5, btnCell6)
                || IsEqualRaw(btnCell7, btnCell8, btnCell9)
                || IsEqualRaw(btnCell1, btnCell4, btnCell7)
                || IsEqualRaw(btnCell2, btnCell5, btnCell8)
                || IsEqualRaw(btnCell3, btnCell6, btnCell9)
                || IsEqualRaw(btnCell1, btnCell5, btnCell9)
                || IsEqualRaw(btnCell3, btnCell5, btnCell7)
                )
                { return true; }
            
            return false;
        }
        private bool IsGameEnd()
        {
            if (IsWin())
            {
                Winner = lblPlayer.Text;
                return true;
            }
            if(MoveCounter == 9)
            {
                Winner = "Draw";
                return true;
            }

            return false;
        }
        private void EndGame()
        {
            lblWinner.Text = Winner;
            lblPlayer.Text = @"Game Over";

            CellsEnabled(false);
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

            if(IsGameEnd())
            {
                EndGame();
                return;
            }

            ChangePlayer();
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            lblPlayer.Text = Player1;
            lblWinner.Text = "In Progress";
            Winner = "";
            MoveCounter = 0;

            ResetCells();
        }
    }
}
