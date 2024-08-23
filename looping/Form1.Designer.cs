namespace looping
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBox = new TextBox();
            btnFor = new Button();
            btnWhile = new Button();
            btnDoWhile = new Button();
            btnClose = new Button();
            btnOdd = new Button();
            btnFibo = new Button();
            btnEven = new Button();
            LabFstring = new Label();
            laSstring = new Label();
            txtFstring = new TextBox();
            txtSstring = new TextBox();
            btnLength = new Button();
            btnSubString = new Button();
            btnCompare = new Button();
            btnClear = new Button();
            btnLower = new Button();
            btnUpper = new Button();
            btnTrim = new Button();
            btnStarts = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Location = new Point(194, 12);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.ScrollBars = ScrollBars.Vertical;
            txtBox.Size = new Size(647, 160);
            txtBox.TabIndex = 0;
            txtBox.TextChanged += txtBox_TextChanged;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(177, 190);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(141, 50);
            btnFor.TabIndex = 1;
            btnFor.Text = "For Loop";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(424, 190);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(141, 50);
            btnWhile.TabIndex = 2;
            btnWhile.Text = "While Loop";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(683, 190);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(141, 50);
            btnDoWhile.TabIndex = 3;
            btnDoWhile.Text = "Do While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(424, 332);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 50);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOdd
            // 
            btnOdd.Location = new Point(177, 262);
            btnOdd.Name = "btnOdd";
            btnOdd.Size = new Size(141, 50);
            btnOdd.TabIndex = 5;
            btnOdd.Text = "Sum Odd";
            btnOdd.UseVisualStyleBackColor = true;
            btnOdd.Click += btnOdd_Click;
            // 
            // btnFibo
            // 
            btnFibo.Location = new Point(683, 262);
            btnFibo.Name = "btnFibo";
            btnFibo.Size = new Size(141, 50);
            btnFibo.TabIndex = 6;
            btnFibo.Text = "Fibonacci";
            btnFibo.UseVisualStyleBackColor = true;
            btnFibo.Click += btnFibo_Click;
            // 
            // btnEven
            // 
            btnEven.Location = new Point(424, 262);
            btnEven.Name = "btnEven";
            btnEven.Size = new Size(141, 50);
            btnEven.TabIndex = 7;
            btnEven.Text = "Sum Even";
            btnEven.UseVisualStyleBackColor = true;
            btnEven.Click += btnEven_Click;
            // 
            // LabFstring
            // 
            LabFstring.AutoSize = true;
            LabFstring.Location = new Point(216, 440);
            LabFstring.Name = "LabFstring";
            LabFstring.Size = new Size(96, 25);
            LabFstring.TabIndex = 8;
            LabFstring.Text = "First String";
            // 
            // laSstring
            // 
            laSstring.AutoSize = true;
            laSstring.Location = new Point(216, 504);
            laSstring.Name = "laSstring";
            laSstring.Size = new Size(122, 25);
            laSstring.TabIndex = 9;
            laSstring.Text = "Second String";
            // 
            // txtFstring
            // 
            txtFstring.Location = new Point(361, 440);
            txtFstring.Name = "txtFstring";
            txtFstring.Size = new Size(377, 31);
            txtFstring.TabIndex = 10;
            // 
            // txtSstring
            // 
            txtSstring.Location = new Point(361, 504);
            txtSstring.Name = "txtSstring";
            txtSstring.Size = new Size(377, 31);
            txtSstring.TabIndex = 11;
            txtSstring.TextChanged += textBox2_TextChanged;
            // 
            // btnLength
            // 
            btnLength.Location = new Point(216, 574);
            btnLength.Name = "btnLength";
            btnLength.Size = new Size(141, 50);
            btnLength.TabIndex = 12;
            btnLength.Text = "Length";
            btnLength.UseVisualStyleBackColor = true;
            btnLength.Click += btnLength_Click;
            // 
            // btnSubString
            // 
            btnSubString.Location = new Point(384, 574);
            btnSubString.Name = "btnSubString";
            btnSubString.Size = new Size(141, 50);
            btnSubString.TabIndex = 13;
            btnSubString.Text = "SubString";
            btnSubString.UseVisualStyleBackColor = true;
            btnSubString.Click += btnSubString_Click;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(549, 574);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(141, 50);
            btnCompare.TabIndex = 14;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(712, 574);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 50);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLower
            // 
            btnLower.Location = new Point(216, 658);
            btnLower.Name = "btnLower";
            btnLower.Size = new Size(141, 50);
            btnLower.TabIndex = 16;
            btnLower.Text = "To Lower";
            btnLower.UseVisualStyleBackColor = true;
            btnLower.Click += btnLower_Click;
            // 
            // btnUpper
            // 
            btnUpper.Location = new Point(384, 658);
            btnUpper.Name = "btnUpper";
            btnUpper.Size = new Size(141, 50);
            btnUpper.TabIndex = 17;
            btnUpper.Text = "To Upper";
            btnUpper.UseVisualStyleBackColor = true;
            btnUpper.Click += btnUpper_Click;
            // 
            // btnTrim
            // 
            btnTrim.Location = new Point(549, 658);
            btnTrim.Name = "btnTrim";
            btnTrim.Size = new Size(141, 50);
            btnTrim.TabIndex = 18;
            btnTrim.Text = "Trim";
            btnTrim.UseVisualStyleBackColor = true;
            btnTrim.Click += btnTrim_Click;
            // 
            // btnStarts
            // 
            btnStarts.Location = new Point(712, 658);
            btnStarts.Name = "btnStarts";
            btnStarts.Size = new Size(141, 50);
            btnStarts.TabIndex = 19;
            btnStarts.Text = "Starts";
            btnStarts.UseVisualStyleBackColor = true;
            btnStarts.Click += btnStarts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 863);
            Controls.Add(btnStarts);
            Controls.Add(btnTrim);
            Controls.Add(btnUpper);
            Controls.Add(btnLower);
            Controls.Add(btnClear);
            Controls.Add(btnCompare);
            Controls.Add(btnSubString);
            Controls.Add(btnLength);
            Controls.Add(txtSstring);
            Controls.Add(txtFstring);
            Controls.Add(laSstring);
            Controls.Add(LabFstring);
            Controls.Add(btnEven);
            Controls.Add(btnFibo);
            Controls.Add(btnOdd);
            Controls.Add(btnClose);
            Controls.Add(btnDoWhile);
            Controls.Add(btnWhile);
            Controls.Add(btnFor);
            Controls.Add(txtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btnFor;
        private Button btnWhile;
        private Button btnDoWhile;
        private Button btnClose;
        private Button btnOdd;
        private Button btnFibo;
        private Button btnEven;
        private Label LabFstring;
        private Label laSstring;
        private TextBox txtFstring;
        private TextBox txtSstring;
        private Button btnLength;
        private Button btnSubString;
        private Button btnCompare;
        private Button btnClear;
        private Button btnLower;
        private Button btnUpper;
        private Button btnTrim;
        private Button btnStarts;
    }
}
