using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public String input { set; get; }
        public String ans { set; get; }
        private String OPERATION_SIMBOLS = "/*+^-";

        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        { 
            Button b = (Button)sender;
            switch (b.Text)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    input = input + b.Text;
                    updateView();
                    break;
                case "-":
                case "^":
                case "/":
                case "+":
                case "*":
                case ".":
                    if (!EndWithOperation())
                    {
                        input = input + b.Text;
                        updateView();
                    }
                    break;
                case "=":
                    ans = CalculatorTool.CalculateExpression(input).ToString();
                    break;
                case "DEL":
                    input = input.Remove(input.Length - 1);
                    updateView();
                    break;
           
            }

        }

        private void updateView()//not the most efficient way to do this
        {
            InputLabel.Text = input;
            OutputLabel.Text = ans;
        }

        private bool EndWithOperation()
        {
            char[] c = OPERATION_SIMBOLS.ToCharArray();
            foreach( char ch in c)
            {
                if (input.EndsWith(ch.ToString())) return true;
            }
            return false;
        }
    }
}
