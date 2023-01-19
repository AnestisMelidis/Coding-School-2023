
//using CalculationsLib;

namespace Session_09 {
    public partial class Form1 : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

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
            textBox1.Text += "0";
        }
        private void bntOne_Click(object sender, EventArgs e) {
            textBox1.Text += "1";

        }

        private void btnTwo_Click(object sender, EventArgs e) {
            textBox1.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e) {
            textBox1.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e) {
            textBox1.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e) {
            textBox1.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e) {
            textBox1.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            textBox1.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e) {
            textBox1.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e) {
            textBox1.Text += "9";
        }
       
        //Calculation Symbols

        private void btnEquals_Click(object sender, EventArgs e) {
            textBox1.Text += "=";
        }

        private void btnAddition_Click(object sender, EventArgs e) {
            textBox1.Text += "+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void bntSubtraction_Click(object sender, EventArgs e) {
            textBox1.Text += "-";
        }

        private void btnMultiplication_Click(object sender, EventArgs e) {
            textBox1.Text += "X";
        }

        private void btnDivision_Click(object sender, EventArgs e) {
            textBox1.Text += "/"; 
        }

        private void btnRaisetoPower_Click(object sender, EventArgs e) {
            textBox1.Text += "^"; 
        }

        private void btnSquareRoot_Click(object sender, EventArgs e) {
            textBox1.Text += "SquareRoot";
        }

        
    }
}