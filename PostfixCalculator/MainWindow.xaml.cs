using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Stack.List;
namespace PostfixCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<decimal> _stack = new Stack<decimal>();
        public MainWindow()
        {
            InitializeComponent();
            InputLabel.Content = string.Empty;
            ResultLabel.Content = string.Empty;
        }

        private void EqualsBtn_click(object sender, RoutedEventArgs e)
        {
            _stack.Clear();
            ResultLabel.Content = InputLabel.Content;
            string labelContent = InputLabel.Content.ToString();
            string[] itemsFromLabel = labelContent.Split(' ');

            for (int i = 0; i < itemsFromLabel.Length; i++)
            {
                if (decimal.TryParse(itemsFromLabel[i], out decimal result))
                {
                    _stack.Push(result);
                }
                else
                {
                    decimal result1 = _stack.Pop();
                    decimal result2 = _stack.Pop();
                    decimal numberToAddToTheStack = 0;
                    if (itemsFromLabel[i] == "×")
                    {
                        numberToAddToTheStack = result1 * result2;
                    }
                    else if (itemsFromLabel[i] == "÷")
                    {
                        numberToAddToTheStack = result1 / result2;
                    }
                    else if (itemsFromLabel[i] == "+")
                    {
                        numberToAddToTheStack = result1 + result2;
                    }
                    else if (itemsFromLabel[i] == "-")
                    {
                        numberToAddToTheStack = result1 - result2;
                    }
                    _stack.Push(numberToAddToTheStack);
                }
            }
            string resultToShow = string.Empty;
            foreach (decimal value in _stack)
            {
                resultToShow += value + " ";
            }
            InputLabel.Content = resultToShow;

        }

        private void NumbersBtn_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string pressedNumber = button.Content.ToString();
            InputLabel.Content += pressedNumber;
        }

        private void OperatorsBtn_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string pressedOperatorValue = button.Content.ToString();
            string labelContent = InputLabel.Content.ToString();
            switch (pressedOperatorValue)
            {
                case "⤄":
                    if (labelContent.LastIndexOf(" ") != labelContent.Length - 1)
                    {
                        InputLabel.Content = labelContent + " ";
                    }
                    break;
                case "CE":
                    InputLabel.Content = string.Empty;
                    ResultLabel.Content = string.Empty;
                    break;
                case "C":
                    InputLabel.Content = string.Empty;
                    break;
                case "⌫":
                    if (labelContent.Length != 0)
                    {
                        InputLabel.Content = labelContent.Substring(0, labelContent.Length - 1);
                    }
                    break;
                case "±":
                    if (labelContent.IndexOf(' ') == -1)
                    {
                        if (int.TryParse(labelContent, out int number))
                        {
                            number = number * -1;
                        }
                        else
                        {
                            break;
                        }
                        InputLabel.Content = number;
                    }
                    break;
                default:
                    if (labelContent.Length != 0)
                    {
                        if (labelContent.LastIndexOf(" ") == labelContent.Length - 1)
                        {
                            InputLabel.Content += pressedOperatorValue;
                        }
                        else
                        {
                            InputLabel.Content += " " + pressedOperatorValue + " ";
                        }
                    }
                    break;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            CalculatorControl calculatorControl = new CalculatorControl();
            Button button = new Button();
            string btn = calculatorControl.Btn_Keydown(e);
            if (int.TryParse(btn,out int i))
            {
                button.Content = btn;
                NumbersBtn_click(button, new RoutedEventArgs());
            }
            else if(btn == "=")
            {
                EqualsBtn_click(button, new RoutedEventArgs());
            }
            else
            {
                button.Content = btn;
                OperatorsBtn_click(button, new RoutedEventArgs());
            }
        }
    }
}
