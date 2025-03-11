using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Tic_Tac_Toe
{
    public partial class Form1: Form
    {
        Boolean checker;
        int plusOne;

        // This methode determine that buttons active or passive 
        void Enable_False() 
        {
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void score()
        {
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X") {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X","TicTAcToe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTAcToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTAcToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTAcToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTAcToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTAcToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTAcToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTAcToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            //PlayerO Possibilities ******************************************************************************************
         
            
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne+1);


                Enable_False();
            }

            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne+1);


                Enable_False();
            }

            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }

            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player 0", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne+1);


                Enable_False();
            }

            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusOne + 1);


                Enable_False();
            }
        }
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // click functons for each button********************************************************************************************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
            
        // function of new game button
        private void btnNewGame_click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                lblPlayerO.Text = "0";
                lblPlayerX.Text = "0";

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

//function of reset button
private void btnReset_Click(object sender, EventArgs e)
        {
            try {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                btnNewGame.Enabled = true;

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

       // function of exit button
        private void btnExıt_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult  iExit;
            iExit = MessageBox.Show("COnfirm if you want to exit", "TicTacToe", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (iExit == DialogResult.Yes);
                    Application.Exit();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "TicTacToe",MessageBoxButtons.OK,MessageBoxIcon.Information );
                    
                    }
        }
    }
}
