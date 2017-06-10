using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class Form1 : Form
    {//Name: Yunhao Fu ID:1255469
        //A class variable to store the current balace
        double currentBalance = 0;
        public Form1()
        {
            InitializeComponent();
            textBoxBalance.Text = currentBalance.ToString("c");
        }
        
        
        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Check Deposit is right
        /// </summary>
        /// <param name="deposit"></param>
        /// <returns></returns>
        private bool CheckDeposit(double deposit)
        {
            if(deposit<20 || deposit>200)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Check Withdraw is right
        /// </summary>
        /// <param name="withdrawal"></param>
        /// <returns></returns>
        private bool CheckWithdrawal(double withdrawal)
        {
            if (withdrawal < 20 || withdrawal > 200)
            {
                MessageBox.Show("Sorry, can not withdrawl this amount!");
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Deposit 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            int depositValue = 0;
            depositValue = int.Parse(textBoxDeposit.Text);
            if(CheckDeposit(depositValue))
            {
                currentBalance += depositValue;
            }            
            textBoxDeposit.Clear();
            textBoxWithdraw.Clear();
            textBoxDeposit.Focus();
            textBoxBalance.Text = currentBalance.ToString("c");
        }
        /// <summary>
        /// Withdraw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            int withdrawValue = 0;
            withdrawValue = int.Parse(textBoxWithdraw.Text);
            if(CheckWithdrawal(withdrawValue))
            {
                currentBalance -= withdrawValue;
            }        
            textBoxWithdraw.Clear();
            textBoxDeposit.Clear();
            textBoxWithdraw.Focus();            
            textBoxBalance.Text = currentBalance.ToString("c");
        }
    }
}
