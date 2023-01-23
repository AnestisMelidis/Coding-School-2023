


using CalculationsLib;

namespace Session_09 {

    //SquareRoot Doesnt work
    public partial class Form1 : Form {

        public decimal? _value1 = null;
        public decimal? _value2 = null;
        public decimal? _result = null;
        public decimal?[] _values = new decimal?[2] ;


        
        SetValue setValue =new SetValue();

        private CalcOperation _calcOperation;

        enum CalcOperation {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            RaisetoPower,
            SquareRoot
        }

        public Form1() {
            InitializeComponent();
        }

        //Numbers

        private void btnZero_Click(object sender, EventArgs e) {


            Set(0);
            textBox1.Text += "0";
        }
        private void bntOne_Click(object sender, EventArgs e) {

            Set(1);
            textBox1.Text += "1";

        }

        private void btnTwo_Click(object sender, EventArgs e) {

            Set(2);
            textBox1.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e) {
            Set(3);
            textBox1.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e) {
            Set(4);
            textBox1.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e) {
            Set(5);
            textBox1.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e) {
            Set(6);
            textBox1.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            Set(7);
            textBox1.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e) {
            Set(8);
            textBox1.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e) {
            Set(9);
            textBox1.Text += "9";
        }
       
        //Calculation Symbols

        private void btnEquals_Click(object sender, EventArgs e) {
            textBox1.Text += "=";
            IMathematicalCal cal;
            SquareRoot squareRoot = new SquareRoot();

            switch (_calcOperation) {
                case CalcOperation.Addition:

                    cal = new Addition();
                    _result = cal.Calculation(_values[0], _values[1]);
              
                    break;
                case CalcOperation.Subtraction:
                    cal = new Subtraction();
                    _result = cal.Calculation(_values[0], _values[1]);

                    break;
                case CalcOperation.Multiplication:
                    cal = new Multiplication();
                    _result = cal.Calculation(_values[0], _values[1]);

                    break;
                case CalcOperation.Division:
                    cal = new Division();
                    _result = cal.Calculation(_values[0], _values[1]);

                    break;
                case CalcOperation.RaisetoPower:
                    cal = new RaisetoPower();
                    _result = cal.Calculation(_values[0], _values[1]);

                    break;
                case CalcOperation.SquareRoot:
                    
                    _result = squareRoot.Calculation(_values[1]);

                    break;

                default:
                    break;
            }

            textBox1.Text += _result;
        }

        private void btnAddition_Click(object sender, EventArgs e) {
            textBox1.Text += "+";
            _calcOperation = CalcOperation.Addition;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void bntSubtraction_Click(object sender, EventArgs e) {
            textBox1.Text += "-";
            _calcOperation = CalcOperation.Subtraction;
        }

        private void btnMultiplication_Click(object sender, EventArgs e) {
            textBox1.Text += "X";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void btnDivision_Click(object sender, EventArgs e) {
            textBox1.Text += "/";
            _calcOperation = CalcOperation.Division;
        }

        private void btnRaisetoPower_Click(object sender, EventArgs e) {
            textBox1.Text += "^";
            _calcOperation = CalcOperation.RaisetoPower;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e) {
            textBox1.Text += "SquareRoot";
            _calcOperation = CalcOperation.RaisetoPower;
        }
        private void EmptyStringText() {


            _values[0] = null;
            _values[1] = null;
            _result = null;
        }
        private void Set(decimal x) {

            if (_result != null) {
                textBox1.Text = string.Empty;
                EmptyStringText();
                _values[setValue.SetInputValue(_values)] = x;
            }
            else {

                _values[setValue.SetInputValue(_values)] = x;

            }

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}