using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game
{
    public partial class Form1 : Form
    {
        Random roll = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonInitialGame_Click(object sender, EventArgs e)
        {
            decimal initialMoney, AIBet;
            initialMoney =decimal.Parse(textBoxInitial.Text);
            AIBet = initialMoney/5;
            textBoxAICurrentMoney.Text = initialMoney.ToString();
            textBoxAIBet.Text = AIBet.ToString();
            textBoxYourCurrentMoney.Text = initialMoney.ToString();
            textBoxYouBet.Focus();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            try
            {
                //Set Variable
                decimal AIBet, AIBalance, UBet, UBalance;
                int AIRoll, URoll, AISum, USum, AID, UD;

                //Get Variable
                AIBet = decimal.Parse(textBoxAIBet.Text);
                AIBalance = decimal.Parse(textBoxAICurrentMoney.Text);
                UBet = decimal.Parse(textBoxYouBet.Text);
                UBalance = decimal.Parse(textBoxYourCurrentMoney.Text);
                AISum = 0;
                USum = 0;

                //Start Rolling - If you can roll
                if (UBet <= UBalance)
                {
                    int i;
                    for (i = 0; i < 3; i++)
                    {
                        
                        AIRoll=roll.Next(1,6);
                        if (i == 0)
                        {
                            textBoxC1.Text = AIRoll.ToString();
                        }
                        else if (i == 1)
                        {
                            textBoxC2.Text = AIRoll.ToString();
                        }
                        else
                        {
                            textBoxC3.Text = AIRoll.ToString();
                        }
                        AISum += AIRoll;

                        URoll=roll.Next(1,6);
                        if (i == 0)
                        {
                            textBoxU1.Text = URoll.ToString();
                        }
                        else if (i == 1)
                        {
                            textBoxU2.Text = URoll.ToString();
                        }
                        else
                        {
                            textBoxU3.Text = URoll.ToString();
                        }
                        USum = USum + URoll;
                    }

                    textBoxSumAI.Text = AISum.ToString();
                    textBoxSumYou.Text = USum.ToString();
                    AID = Math.Abs(18 - AISum);
                    UD = Math.Abs(18 - USum);
                    if (UD < AID)
                    {
                        textBoxWinner.Text = "You!!!";
                        UBalance = UBalance + AIBet;
                        AIBalance = AIBalance - AIBet;
                    }
                    else if (UD == AID)
                    {
                        textBoxWinner.Text = "Draw!!!";
                    }
                    else
                    {
                        textBoxWinner.Text = "AI!!!";
                        UBalance = UBalance - UBet;
                        AIBalance = AIBalance + UBet;
                    }
                    textBoxAICurrentMoney.Text = AIBalance.ToString();
                    textBoxYourCurrentMoney.Text = UBalance.ToString();
                }
                else
                {
                    MessageBox.Show("Sorry, you do not have sufficient money to roll!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
