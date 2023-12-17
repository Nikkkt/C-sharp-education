using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCalculator
{
    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Power
    }
    public class CalculatorViewModel : ViewModelBase
    {
        private double lastNumber;
        private double result;
        private SelectedOperator selectedOperator;
        private bool isRad = false;

        private string displayText;
        public string DisplayText
        {
            get { return displayText; }
            set { if (displayText != value) { displayText = value; OnPropertyChanged(nameof(DisplayText)); } }
        }

        public ICommand NumberButtonCommand { get; }
        public ICommand OperationButtonCommand { get; }
        public ICommand EqualsButtonCommand { get; }
        public ICommand DeleteButtonCommand { get; }
        public ICommand AllClearButtonCommand { get; }
        public ICommand PiButtonCommand { get; }
        public ICommand EButtonCommand { get; }
        public ICommand LogButtonCommand { get; }
        public ICommand LnButtonCommand { get; }
        public ICommand SqrtButtonCommand { get; }
        public ICommand CommaButtonCommand { get; }
        public ICommand TanButtonCommand { get; }
        public ICommand CosButtonCommand { get; }
        public ICommand SinButtonCommand { get; }
        public ICommand RadButtonCommand { get; }
        public ICommand PowerButtonCommand { get; }
        public ICommand FactorialButtonCommand { get; }
        public ICommand ReciprocalButtonCommand { get; }

        public CalculatorViewModel()
        {
            DisplayText = "0";

            NumberButtonCommand = new RelayCommand<string>(NumberButton_Click);
            OperationButtonCommand = new RelayCommand<string>(OperationButton_Click);
            EqualsButtonCommand = new RelayCommand(EqualsButton_Click);
            DeleteButtonCommand = new RelayCommand(DeleteButton_Click);
            AllClearButtonCommand = new RelayCommand(AllClearButton_Click);
            PiButtonCommand = new RelayCommand(PiButton_Click);
            EButtonCommand = new RelayCommand(EButton_Click);
            LogButtonCommand = new RelayCommand(LogButton_Click);
            LnButtonCommand = new RelayCommand(LnButton_Click);
            SqrtButtonCommand = new RelayCommand(SqrtButton_Click);
            CommaButtonCommand = new RelayCommand(CommaButton_Click);
            TanButtonCommand = new RelayCommand(TanButton_Click);
            CosButtonCommand = new RelayCommand(CosButton_Click);
            SinButtonCommand = new RelayCommand(SinButton_Click);
            RadButtonCommand = new RelayCommand(RadButton_Click);
            PowerButtonCommand = new RelayCommand(PowerButton_Click);
            FactorialButtonCommand = new RelayCommand(FactorialButton_Click);
            ReciprocalButtonCommand = new RelayCommand(ReciprocalButton_Click);
        }

        private void NumberButton_Click(string selectedValue)
        {
            if (DisplayText == "0") DisplayText = selectedValue;
            else DisplayText += selectedValue;
        }

        private void OperationButton_Click(string operation)
        {
            if (double.TryParse(DisplayText, out lastNumber)) DisplayText = "0";

            switch (operation)
            {
                case "multiply":
                    selectedOperator = SelectedOperator.Multiplication;
                    break;
                case "divide":
                    selectedOperator = SelectedOperator.Division;
                    break;
                case "add":
                    selectedOperator = SelectedOperator.Addition;
                    break;
                case "subtract":
                    selectedOperator = SelectedOperator.Subtraction;
                    break;
            }
        }

        private void EqualsButton_Click()
        {
            double newNumber;
            if (double.TryParse(DisplayText, out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = CalculatorMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        result = CalculatorMath.Subtract(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = CalculatorMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = CalculatorMath.Divide(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Power:
                        result = CalculatorMath.Power(lastNumber, newNumber);
                        break;
                }

                DisplayText = result.ToString();
            }
        }

        private void DeleteButton_Click()
        {
            string currentText = DisplayText;
            if (currentText.Length > 0) DisplayText = currentText.Substring(0, currentText.Length - 1);
        }

        private void AllClearButton_Click() { DisplayText = "0"; }

        private void PiButton_Click() { DisplayText = Math.PI.ToString(); }

        private void EButton_Click() { DisplayText = Math.E.ToString(); }

        private void LogButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = Math.Log10(number).ToString();
        }

        private void LnButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = Math.Log(number).ToString();
        }

        private void SqrtButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = Math.Sqrt(number).ToString();
        }

        private void CommaButton_Click() { if (!DisplayText.Contains(",")) DisplayText = $"{DisplayText},"; }

        private void TanButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = isRad ? CalculatorMath.Tan(number).ToString() : CalculatorMath.Tan(DegreeToRadian(number)).ToString();
        }

        private void CosButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = isRad ? CalculatorMath.Cos(number).ToString() : CalculatorMath.Cos(DegreeToRadian(number)).ToString();
        }

        private void SinButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = isRad ? CalculatorMath.Sin(number).ToString() : CalculatorMath.Sin(DegreeToRadian(number)).ToString();
        }

        private void RadButton_Click() { isRad = !isRad; }

        private void PowerButton_Click()
        {
            if (double.TryParse(DisplayText, out lastNumber))
            {
                DisplayText = "0";
                selectedOperator = SelectedOperator.Power;
            }
        }

        private void FactorialButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = CalculatorMath.Factorial(number).ToString();
        }

        private void ReciprocalButton_Click()
        {
            double number;
            if (double.TryParse(DisplayText, out number)) DisplayText = (1 / number).ToString();
        }

        private double DegreeToRadian(double angle) { return Math.PI * angle / 180.0; }
    }
}
