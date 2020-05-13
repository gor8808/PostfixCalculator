using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PostfixCalculator
{
    class CalculatorControl
    {
        public string Btn_Keydown(KeyEventArgs e)
        {
            string BtnContent = string.Empty;
            if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                BtnContent = "0";
            }
            else if (e.Key == Key.OemPlus || e.Key == Key.Add)
            {
                BtnContent = "+";
            }
            else if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
            {
                BtnContent = "-";
            }
            else if (e.Key == Key.Divide)
            {
                BtnContent = "÷";
            }
            else if (e.Key == Key.Multiply)
            {
                BtnContent = "×";
            }
            else if (e.Key == Key.Delete)
            {
                BtnContent = "C";
            }
            else if (e.Key == Key.E)
            {
                BtnContent = "EC";
            }
            else if(e.Key == Key.Space)
            {
                BtnContent = "⤄";
            }
            else if(e.Key == Key.Enter)
            {
                BtnContent = "=";
            }
            else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                BtnContent = "1";
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                BtnContent = "2";
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                BtnContent = "3";
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                BtnContent = "4";
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                BtnContent = "5";
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                BtnContent = "6";
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                BtnContent = "7";
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                BtnContent = "8";
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                BtnContent = "9";
            }
            else if (e.Key == Key.Back)
            {
                BtnContent = "⌫";
            }
            //Button buttonn = new Button();
            //buttonn.Content = BtnContent;
            return BtnContent;
        }

    }
}
