namespace FlyingBeaverIDE.UI
{
    partial class WordAccentuationSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            suggestionsPanel = new Panel();
            CurrentWord = new Label();
            middlePanel = new Panel();
            submitButton = new Button();
            suggestionsComboBox = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            suggestionsPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 44);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(644, 44);
            label1.TabIndex = 0;
            label1.Text = "Наголошення слова";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // suggestionsPanel
            // 
            suggestionsPanel.Controls.Add(CurrentWord);
            suggestionsPanel.Dock = DockStyle.Top;
            suggestionsPanel.Location = new Point(0, 44);
            suggestionsPanel.Margin = new Padding(3, 4, 3, 4);
            suggestionsPanel.Name = "suggestionsPanel";
            suggestionsPanel.Size = new Size(644, 50);
            suggestionsPanel.TabIndex = 1;
            // 
            // CurrentWord
            // 
            CurrentWord.Dock = DockStyle.Top;
            CurrentWord.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentWord.Location = new Point(0, 0);
            CurrentWord.Name = "CurrentWord";
            CurrentWord.Size = new Size(644, 46);
            CurrentWord.TabIndex = 5;
            CurrentWord.Text = "Поточне слово";
            CurrentWord.TextAlign = ContentAlignment.TopCenter;
            // 
            // middlePanel
            // 
            middlePanel.Controls.Add(submitButton);
            middlePanel.Controls.Add(suggestionsComboBox);
            middlePanel.Controls.Add(label2);
            middlePanel.Dock = DockStyle.Top;
            middlePanel.Location = new Point(0, 94);
            middlePanel.Margin = new Padding(3, 4, 3, 4);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(644, 58);
            middlePanel.TabIndex = 4;
            // 
            // submitButton
            // 
            submitButton.Dock = DockStyle.Right;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(453, 0);
            submitButton.Margin = new Padding(10, 4, 10, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(191, 58);
            submitButton.TabIndex = 12;
            submitButton.Text = "Наголосити";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // suggestionsComboBox
            // 
            suggestionsComboBox.BackColor = SystemColors.WindowFrame;
            suggestionsComboBox.Dock = DockStyle.Left;
            suggestionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            suggestionsComboBox.FlatStyle = FlatStyle.Flat;
            suggestionsComboBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            suggestionsComboBox.FormattingEnabled = true;
            suggestionsComboBox.ItemHeight = 29;
            suggestionsComboBox.Location = new Point(222, 0);
            suggestionsComboBox.Margin = new Padding(0);
            suggestionsComboBox.MaxDropDownItems = 15;
            suggestionsComboBox.Name = "suggestionsComboBox";
            suggestionsComboBox.Size = new Size(221, 37);
            suggestionsComboBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 58);
            label2.TabIndex = 6;
            label2.Text = "Виберіть наголос:";
            // 
            // WordAccentuationSettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 68, 68);
            ClientSize = new Size(644, 150);
            Controls.Add(middlePanel);
            Controls.Add(suggestionsPanel);
            Controls.Add(panel1);
            ForeColor = Color.LightGray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WordAccentuationSettingForm";
            Text = "Наголошення слова";
            panel1.ResumeLayout(false);
            suggestionsPanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel suggestionsPanel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Label CurrentWord;
        private System.Windows.Forms.ComboBox suggestionsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
    }
}