using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Ensuring that all user input is valid.
      bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded);
      bool costOneParkWithCardValid = Double.TryParse(txtOneParkWithCard.Text, out double costOneParkWithCard);
      bool costOneParkWithoutCardValid = Double.TryParse(txtOneParkNoCard.Text, out double costOneParkWithoutCard);

      if (creditValid && costOneParkWithCardValid && costOneParkWithoutCardValid)
      {
        //Does the math
        int daysParking = (int)(creditAdded / costOneParkWithCard);
        double creditRemaining = creditAdded % costOneParkWithCard;
        double savingsCalc = (costOneParkWithoutCard * daysParking) - (costOneParkWithCard * daysParking);

        //Desplays all the caculated values
        txtDaysParking.Text = daysParking.ToString();
        txtCreditRemaining.Text = creditRemaining.ToString("c");
        txtSavings.Text = savingsCalc.ToString("c");
      }
      else
      {
        MessageBox.Show("Please enter numbers", "Error");
      }

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
