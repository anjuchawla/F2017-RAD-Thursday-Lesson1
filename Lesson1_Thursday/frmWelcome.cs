/*
 * Name: Anju Chawla
 * Date: September 14, 2017
 * Purpose: This application displays the message 'Hello World' in English and  Spanish, depending on user choice. Output can be cleared and the form can be printed.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1_Thursday
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Print the message in English
        /// </summary>
        /// <param name="sender">The English button</param>
        /// <param name="e">The event arguments</param>
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello World!!";

        }
        /// <summary>
        /// Print the message in Spanish
        /// </summary>
        /// <param name="sender">The spanish button</param>
        /// <param name="e">The event arguments</param>
        private void btnSpanish_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hola Mundo!!";
        }
        /// <summary>
        /// Clear the message
        /// </summary>
        /// <param name="sender">The Clear button</param>
        /// <param name="e">The event arguments</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty; //""
        }
        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender">The exit button</param>
        /// <param name="e">The event arguments<</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        /// <summary>
        /// This will print the form
        /// </summary>
        /// <param name="sender">The Print Form button</param>
        /// <param name="e">The event arguments<</param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }
    }
}
