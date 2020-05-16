﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1, number2, result;

            /* Version 1 (Runtime Error)
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            /* Version 2 (Wert wird 0 gesetzt)
            Int32.TryParse(txtNumber1.Text, out number1);
            Int32.TryParse(txtNumber2.Text, out number2);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 + number2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Summe";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes  and set  focus

            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            lblResultType.Text = "Ergebnis";
            lblResult.Text = "";
            txtNumber1.Focus();
            txtNumber1.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2;
            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                lblResult.Text = Convert.ToString(number1-number2);
                lblResultType.Text = "Differenz";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1, number2;
            double result;
            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                if(number2==0)
                {
                    lblResultType.Text = "Fehler";
                    MessageBox.Show("Division durch 0", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = (double)number1 / number2;
                    lblResult.Text = Convert.ToString(result);
                    lblResultType.Text = "Differenz";
                }
                 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void bntMultiply_Click(object sender, EventArgs e)
        {
            int number1, number2;
            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                lblResult.Text = Convert.ToString(number1 * number2);
                lblResultType.Text = "Produkt";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }
    }
}
