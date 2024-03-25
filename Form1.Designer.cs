namespace genetic_algorithm_form
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            mainPanel = new Panel();
            resetAnswerButton = new Button();
            resetGraphButton = new Button();
            label7 = new Label();
            answerBox = new ListBox();
            resetButton = new Button();
            startButton = new Button();
            panel1 = new Panel();
            graphOptimizeCombo = new ComboBox();
            graphTypeCombo = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            elitisimNumeric = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            generationNumeric = new NumericUpDown();
            mutationNumeric = new NumericUpDown();
            label1 = new Label();
            crossNumeric = new NumericUpDown();
            populationNumeric = new NumericUpDown();
            label3 = new Label();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)elitisimNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generationNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mutationNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crossNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)populationNumeric).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.LightSeaGreen;
            formsPlot1.DisplayScale = 1.5F;
            formsPlot1.ForeColor = SystemColors.ControlText;
            formsPlot1.Location = new Point(25, 23);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(901, 538);
            formsPlot1.TabIndex = 2;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.SteelBlue;
            mainPanel.Controls.Add(resetAnswerButton);
            mainPanel.Controls.Add(resetGraphButton);
            mainPanel.Controls.Add(label7);
            mainPanel.Controls.Add(answerBox);
            mainPanel.Controls.Add(resetButton);
            mainPanel.Controls.Add(startButton);
            mainPanel.Controls.Add(formsPlot1);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(panel2);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1326, 789);
            mainPanel.TabIndex = 3;
            // 
            // resetAnswerButton
            // 
            resetAnswerButton.Location = new Point(453, 742);
            resetAnswerButton.Name = "resetAnswerButton";
            resetAnswerButton.Size = new Size(94, 29);
            resetAnswerButton.TabIndex = 22;
            resetAnswerButton.Text = "Answer Res";
            resetAnswerButton.UseVisualStyleBackColor = true;
            resetAnswerButton.Click += resetAnswerButton_Click;
            // 
            // resetGraphButton
            // 
            resetGraphButton.Location = new Point(352, 742);
            resetGraphButton.Name = "resetGraphButton";
            resetGraphButton.Size = new Size(94, 29);
            resetGraphButton.TabIndex = 21;
            resetGraphButton.Text = "Graph Res";
            resetGraphButton.UseVisualStyleBackColor = true;
            resetGraphButton.Click += resetGraphButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(955, 69);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 12;
            label7.Text = "Answers:";
            // 
            // answerBox
            // 
            answerBox.FormatString = "E5";
            answerBox.FormattingEnabled = true;
            answerBox.ItemHeight = 20;
            answerBox.Location = new Point(966, 92);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(325, 444);
            answerBox.TabIndex = 20;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(230, 742);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(130, 742);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(graphOptimizeCombo);
            panel1.Controls.Add(graphTypeCombo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(692, 584);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 132);
            panel1.TabIndex = 18;
            // 
            // graphOptimizeCombo
            // 
            graphOptimizeCombo.FormattingEnabled = true;
            graphOptimizeCombo.Items.AddRange(new object[] { "1", "5", "10", "50", "100", "200" });
            graphOptimizeCombo.Location = new Point(44, 85);
            graphOptimizeCombo.Name = "graphOptimizeCombo";
            graphOptimizeCombo.Size = new Size(150, 28);
            graphOptimizeCombo.TabIndex = 16;
            graphOptimizeCombo.Text = "10";
            // 
            // graphTypeCombo
            // 
            graphTypeCombo.FormattingEnabled = true;
            graphTypeCombo.Items.AddRange(new object[] { "Signal", "Scatter" });
            graphTypeCombo.Location = new Point(44, 30);
            graphTypeCombo.Name = "graphTypeCombo";
            graphTypeCombo.Size = new Size(150, 28);
            graphTypeCombo.TabIndex = 17;
            graphTypeCombo.Text = "Scatter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(44, 63);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 15;
            label5.Text = "Optimization:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(44, 7);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 13;
            label6.Text = "Type:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(elitisimNumeric);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(generationNumeric);
            panel2.Controls.Add(mutationNumeric);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(crossNumeric);
            panel2.Controls.Add(populationNumeric);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(25, 584);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 132);
            panel2.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(436, 96);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 15;
            label10.Text = "less than the population.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(424, 76);
            label9.Name = "label9";
            label9.Size = new Size(195, 20);
            label9.TabIndex = 14;
            label9.Text = "* Elitism should be equal or ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(442, 7);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 13;
            label8.Text = "Elitism Count:";
            // 
            // elitisimNumeric
            // 
            elitisimNumeric.Location = new Point(442, 30);
            elitisimNumeric.Name = "elitisimNumeric";
            elitisimNumeric.Size = new Size(150, 27);
            elitisimNumeric.TabIndex = 12;
            elitisimNumeric.Value = new decimal(new int[] { 8, 0, 0, 65536 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(45, 63);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 7;
            label2.Text = "Generation Count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(243, 7);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 9;
            label4.Text = "Crossover Chance:";
            // 
            // generationNumeric
            // 
            generationNumeric.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            generationNumeric.Location = new Point(45, 86);
            generationNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            generationNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            generationNumeric.Name = "generationNumeric";
            generationNumeric.Size = new Size(150, 27);
            generationNumeric.TabIndex = 6;
            generationNumeric.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // mutationNumeric
            // 
            mutationNumeric.DecimalPlaces = 2;
            mutationNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            mutationNumeric.Location = new Point(243, 86);
            mutationNumeric.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            mutationNumeric.Name = "mutationNumeric";
            mutationNumeric.Size = new Size(150, 27);
            mutationNumeric.TabIndex = 10;
            mutationNumeric.Value = new decimal(new int[] { 5, 0, 0, 131072 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(45, 7);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 5;
            label1.Text = "Population Count:";
            // 
            // crossNumeric
            // 
            crossNumeric.DecimalPlaces = 2;
            crossNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            crossNumeric.Location = new Point(243, 30);
            crossNumeric.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            crossNumeric.Name = "crossNumeric";
            crossNumeric.Size = new Size(150, 27);
            crossNumeric.TabIndex = 8;
            crossNumeric.Value = new decimal(new int[] { 8, 0, 0, 65536 });
            // 
            // populationNumeric
            // 
            populationNumeric.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            populationNumeric.Location = new Point(45, 30);
            populationNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            populationNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            populationNumeric.Name = "populationNumeric";
            populationNumeric.Size = new Size(150, 27);
            populationNumeric.TabIndex = 4;
            populationNumeric.Value = new decimal(new int[] { 50, 0, 0, 0 });
            populationNumeric.ValueChanged += populationNumeric_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(243, 63);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 11;
            label3.Text = "Mutation Chance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 813);
            Controls.Add(mainPanel);
            Name = "Form1";
            Text = "Form1";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)elitisimNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)generationNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)mutationNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)crossNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)populationNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Panel mainPanel;
        private NumericUpDown populationNumeric;
        private Label label3;
        private NumericUpDown mutationNumeric;
        private Label label4;
        private NumericUpDown crossNumeric;
        private Label label2;
        private NumericUpDown generationNumeric;
        private Label label1;
        private Label label5;
        private Label label6;
        private ComboBox graphTypeCombo;
        private ComboBox graphOptimizeCombo;
        private Panel panel1;
        private Panel panel2;
        private ListBox answerBox;
        private Label label7;
        private Label label8;
        private NumericUpDown elitisimNumeric;
        private Label label10;
        private Label label9;
        private Button resetAnswerButton;
        private Button resetGraphButton;
        private Button resetButton;
        private Button startButton;
    }
}