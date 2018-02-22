using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class TicketPurchasingGUI : Form
    {
        public TicketPurchasingGUI()
        {
            InitializeComponent();
        }
        private int unitPrice = 30;
        string CoustomerName;
        int TotalPrice;
       
        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            Populate();
           
            string MessageOutput = CoustomerName + ", You have to pay " + TotalPrice + " Taka";
            MessageBox.Show(MessageOutput);

        }

        private void Populate()
        {
            CoustomerName = CoustomerNameTextBox.Text;
            int NumberOfTickets = Convert.ToInt32(NumberOfTicketsTextBox.Text);
            TotalPrice = NumberOfTickets * unitPrice;
        }

     

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Populate();
            string messageoutput = "Coustomer Name : " + CoustomerName + Environment.NewLine + "Total Price : " + TotalPrice;
            MessageBox.Show(messageoutput);
        }
       
    }
}
