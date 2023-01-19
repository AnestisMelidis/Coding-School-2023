namespace Session_09 {
    public partial class Form1 : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;

        enum CalcOperation {
            Addition
        }

        public Form1() {
            InitializeComponent();
        }

        //Numbers

        private void bntOne_Click(object sender, EventArgs e) {
            textBox1.Text += "1";

        }

        private void btnTwo_Click(object sender, EventArgs e) {

        }

        private void btnThree_Click(object sender, EventArgs e) {

        }

        private void btnFour_Click(object sender, EventArgs e) {

        }

        private void btnFive_Click(object sender, EventArgs e) {

        }

        private void btnSix_Click(object sender, EventArgs e) {

        }

        private void btnSeven_Click(object sender, EventArgs e) {

        }

        private void btnEight_Click(object sender, EventArgs e) {

        }

        private void btnNine_Click(object sender, EventArgs e) {

        }
       
        //Calculation Symbols

        private void btnEquals_Click(object sender, EventArgs e) {

        }

        private void btnAddition_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void bntSubtraction_Click(object sender, EventArgs e) {

        }

        private void btnMultiplication_Click(object sender, EventArgs e) {

        }

        private void btnDivision_Click(object sender, EventArgs e) {

        }

        private void btnRaisetoPower_Click(object sender, EventArgs e) {

        }

        private void btnSquareRoot_Click(object sender, EventArgs e) {

        }
    }
}