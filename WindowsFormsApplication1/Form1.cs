using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        /**
         * 1. Check for input on radio buttons
         * 2. Show a messagebox with the result of the WinOrLosse method
         * **/
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Choise = null;
            Random ComputerChoice = new Random();
            TotalTxtBx.Text = global.Count.ToString();
            if (RockBtn.Checked == true) {
                Choise = RockBtn.ToString();
                MessageBox.Show(WinOrLoose(RockBtn.ToString(),ComputerChoice.Next(1,3)));
                PointTxtBox.Text = global.Points.ToString();               
                }
            else if (PaperBtn.Checked == true)
                {
                Choise = PaperBtn.ToString();
                MessageBox.Show(WinOrLoose(PaperBtn.ToString(), ComputerChoice.Next(1, 3)));
                PointTxtBox.Text = global.Points.ToString();
            }
            else if (ScissorsBtn.Checked == true)
                {
                Choise = ScissorsBtn.ToString();
                MessageBox.Show(WinOrLoose(ScissorsBtn.ToString(), ComputerChoice.Next(1, 3)));
                PointTxtBox.Text = global.Points.ToString();
            }
            else { MessageBox.Show("Please select one."); }
        }
        /**
         * Set global vars for tracking points and amount of games played
         * We love statistics
         * **/
        public static class global
        {
            public static int Points = 0;
            public static int Count = 0;

        }
        /**
         * Using the input of the user and a random computer decission
         * determine who won and add to the points
         * 
         * **/
        private string WinOrLoose(string UserChoice, int ComputerChoice) {
            //Going for a ugly hardcoded solution here, will think of something better later.
            global.Count++;

            if (!UserChoice.Equals(ComputerChoice))
            {
               
                if (UserChoice == "Rock")
                {
                    switch (ComputerChoice)
                    {
                        case 3:
                            global.Points ++;
                            return "Player has it";
                        case 2: return "Computer has it";
                    }
                }
                else if (UserChoice == "Paper")
                {
                    switch (ComputerChoice)
                    {
                        case 1:
                            global.Points++;
                            return "Player has it";
                        case 3: return "Computer has it";
                    }

                }
                else
                {
                    switch (ComputerChoice)
                    {
                        case 2:
                            global.Points++;
                            return "Player has it";
                        case 1: return "Computer has it";
                    }
                }
            }
            return "Draw !";  
        }
    }
}
