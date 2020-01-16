using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Custom Methods Start here

        bool IsValidName(string InText)
        {
            if (InText.Any(char.IsNumber) || InText.Any(char.IsSymbol) || InText.Any(char.IsPunctuation))
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        //Custom methods end here

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void p1_PhoneInput_LostFocus(object sender, EventArgs e)
        {
            //this is for the auto formatting of the phone number on lost focus
            if (p1_PhoneInput.Text.Length == 10 && ulong.TryParse(p1_PhoneInput.Text, out ulong Dummy))
            {
                this.p1_ErrorProvider.Clear();
                p1_PhoneInput.MaxLength = 12; /*450-456-6767 CAD phone format*/

                string Phone = p1_PhoneInput.Text;

                Phone = Phone.Insert(3, "-");
                Phone = Phone.Insert(7, "-");

                p1_PhoneInput.Text = Phone;
            }
            else
            {
                p1_ErrorProvider.SetError(p1_PhoneInput, "Format de téléphone incorrecte");
            }
        }

        private void p1_PhoneInput_GotFocus(object sender, EventArgs e)
        {
            if (p1_PhoneInput.MaxLength == 12)
            {
                p1_PhoneInput.Text = p1_PhoneInput.Text.Replace("-", "");
                p1_PhoneInput.MaxLength = 10;
            }
            this.p1_ErrorProvider.Clear();
        }

        private void p1_NameInput_TextChanged(object sender, EventArgs e)
        {
            if (IsValidName(p1_NameInput.Text))
            {
                p1_ErrorProvider.Clear();
            }
            else
            {
                p1_ErrorProvider.SetError(p1_NameInput, "Nom incorrect, ne peut contenir des symboles ou chiffres");

            }
        }

        private void p1_FirstNameInput_TextChanged(object sender, EventArgs e)
        {
            if (IsValidName(p1_FirstNameInput.Text))
            {
                p1_ErrorProvider.Clear();
            }
            else
            {
                p1_ErrorProvider.SetError(p1_FirstNameInput, "Prénom incorrect, ne peut contenir des symboles ou chiffres");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p2_LeaveBox.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p2_LeaveBox.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form1_PhoneLink.LinkVisited = true;
            System.Diagnostics.Process.Start("tel:6664200969");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form1_WebLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.dominos.ca/");
        }
    }
}
