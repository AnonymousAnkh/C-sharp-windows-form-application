namespace looping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                txtBox.Text = txtBox.Text + "\r\n" + i.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                txtBox.Text = "Hello" + "\r\n" + txtBox.Text;
                i++;
            }
            while (i <= 5);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                txtBox.Text = txtBox.Text + "\r\n" + i.ToString();
                i++;
            }
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                txtBox.Text = txtBox.Text + "\r\n" + i.ToString();
                sum += i;
            }
            txtBox.Text = txtBox.Text + "\r\n" + sum.ToString();
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            int i = 1, sum = 0;
            do
            {
                sum += i;
                txtBox.Text = txtBox.Text + "\r\n" + i.ToString();
                i += 2;
            }
            while (i < 100);
            txtBox.Text = txtBox.Text + "\r\n" + sum.ToString();
        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            int F = 1, S = 1, T;
            txtBox.Text = F.ToString() + ", " + S.ToString();
            for (int i = 1; i <= 5; i++)
            {
                T = F + S;
                txtBox.Text = txtBox.Text + ", " + T.ToString();
                F = S;
                S = T;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFstring.Text = "";
            txtSstring.Text = "";
            txtFstring.Focus();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string str = txtFstring.Text;
            txtSstring.Text = str.Length.ToString();
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            txtSstring.Text = txtFstring.Text.Substring(2, 5);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int check;
            check = txtFstring.Text.CompareTo(txtSstring.Text);
            if (check == 0)
            {
                MessageBox.Show("Two strings are the same.", "Compare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show("Two strings are the same.", "Compare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Two strings are not same.", "Compare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            txtSstring.Text = txtFstring.Text.ToLower();
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            txtSstring.Text = txtFstring.Text.ToUpper();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            txtSstring.Text = txtFstring.Text.Trim();
        }

        private void btnStarts_Click(object sender, EventArgs e)
        {
            Boolean str;
            str = txtFstring.Text.StartsWith(txtSstring.Text);
            MessageBox.Show(str.ToString(), "Start With", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
