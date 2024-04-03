namespace Intelektika_2_uzduotis
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
            this.startButton = new System.Windows.Forms.Button();
            this.correctListBox = new System.Windows.Forms.ListBox();
            this.knnListBox = new System.Windows.Forms.ListBox();
            this.svmListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sampleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.startBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.testStartBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.testSampleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(37, 710);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Classify";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // correctListBox
            // 
            this.correctListBox.FormattingEnabled = true;
            this.correctListBox.ItemHeight = 20;
            this.correctListBox.Location = new System.Drawing.Point(38, 40);
            this.correctListBox.Name = "correctListBox";
            this.correctListBox.Size = new System.Drawing.Size(251, 404);
            this.correctListBox.TabIndex = 1;
            // 
            // knnListBox
            // 
            this.knnListBox.FormattingEnabled = true;
            this.knnListBox.ItemHeight = 20;
            this.knnListBox.Location = new System.Drawing.Point(367, 40);
            this.knnListBox.Name = "knnListBox";
            this.knnListBox.Size = new System.Drawing.Size(251, 404);
            this.knnListBox.TabIndex = 2;
            // 
            // svmListBox
            // 
            this.svmListBox.FormattingEnabled = true;
            this.svmListBox.ItemHeight = 20;
            this.svmListBox.Location = new System.Drawing.Point(703, 40);
            this.svmListBox.Name = "svmListBox";
            this.svmListBox.Size = new System.Drawing.Size(251, 404);
            this.svmListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "KNN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "SVM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Correct outputs";
            // 
            // sampleBox
            // 
            this.sampleBox.Location = new System.Drawing.Point(38, 477);
            this.sampleBox.Name = "sampleBox";
            this.sampleBox.Size = new System.Drawing.Size(251, 27);
            this.sampleBox.TabIndex = 11;
            this.sampleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Input training sample size(35000=>):";
            // 
            // startBox
            // 
            this.startBox.Location = new System.Drawing.Point(38, 532);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(251, 27);
            this.startBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Input training sample start:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Input testing sample start:";
            // 
            // testStartBox
            // 
            this.testStartBox.Location = new System.Drawing.Point(38, 660);
            this.testStartBox.Name = "testStartBox";
            this.testStartBox.Size = new System.Drawing.Size(251, 27);
            this.testStartBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Input testing sample size:";
            // 
            // testSampleBox
            // 
            this.testSampleBox.Location = new System.Drawing.Point(38, 605);
            this.testSampleBox.Name = "testSampleBox";
            this.testSampleBox.Size = new System.Drawing.Size(251, 27);
            this.testSampleBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 761);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.testStartBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.testSampleBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sampleBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.svmListBox);
            this.Controls.Add(this.knnListBox);
            this.Controls.Add(this.correctListBox);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private ListBox correctListBox;
        private ListBox knnListBox;
        private ListBox svmListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox sampleBox;
        private Label label8;
        private TextBox startBox;
        private Label label9;
        private Label label10;
        private TextBox testStartBox;
        private Label label11;
        private TextBox testSampleBox;
    }
}