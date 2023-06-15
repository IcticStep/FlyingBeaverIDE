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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.suggestionsPanel = new System.Windows.Forms.Panel();
            this.CurrentSyllables = new System.Windows.Forms.Label();
            this.CurrentWord = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.AddAccentuationButton = new System.Windows.Forms.Button();
            this.syllablesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearAccentuationsButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.suggestionsPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наголошення слова";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // suggestionsPanel
            // 
            this.suggestionsPanel.Controls.Add(this.CurrentSyllables);
            this.suggestionsPanel.Controls.Add(this.CurrentWord);
            this.suggestionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.suggestionsPanel.Location = new System.Drawing.Point(0, 35);
            this.suggestionsPanel.Name = "suggestionsPanel";
            this.suggestionsPanel.Size = new System.Drawing.Size(644, 83);
            this.suggestionsPanel.TabIndex = 1;
            // 
            // CurrentSyllables
            // 
            this.CurrentSyllables.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentSyllables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentSyllables.Location = new System.Drawing.Point(0, 44);
            this.CurrentSyllables.Name = "CurrentSyllables";
            this.CurrentSyllables.Size = new System.Drawing.Size(644, 37);
            this.CurrentSyllables.TabIndex = 6;
            this.CurrentSyllables.Text = "Поточні наголоси:";
            this.CurrentSyllables.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentWord
            // 
            this.CurrentWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentWord.Location = new System.Drawing.Point(0, 0);
            this.CurrentWord.Name = "CurrentWord";
            this.CurrentWord.Size = new System.Drawing.Size(644, 44);
            this.CurrentWord.TabIndex = 5;
            this.CurrentWord.Text = "Поточне слово";
            this.CurrentWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.AddAccentuationButton);
            this.middlePanel.Controls.Add(this.syllablesComboBox);
            this.middlePanel.Controls.Add(this.label2);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlePanel.Location = new System.Drawing.Point(0, 118);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(644, 50);
            this.middlePanel.TabIndex = 4;
            // 
            // AddAccentuationButton
            // 
            this.AddAccentuationButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddAccentuationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccentuationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAccentuationButton.Location = new System.Drawing.Point(453, 0);
            this.AddAccentuationButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.AddAccentuationButton.Name = "AddAccentuationButton";
            this.AddAccentuationButton.Size = new System.Drawing.Size(191, 50);
            this.AddAccentuationButton.TabIndex = 12;
            this.AddAccentuationButton.Text = "Наголосити";
            this.AddAccentuationButton.UseVisualStyleBackColor = true;
            this.AddAccentuationButton.Click += new System.EventHandler(this.AddAccentuation);
            // 
            // syllablesComboBox
            // 
            this.syllablesComboBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.syllablesComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.syllablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syllablesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syllablesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.syllablesComboBox.FormattingEnabled = true;
            this.syllablesComboBox.ItemHeight = 29;
            this.syllablesComboBox.Location = new System.Drawing.Point(222, 0);
            this.syllablesComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.syllablesComboBox.MaxDropDownItems = 15;
            this.syllablesComboBox.Name = "syllablesComboBox";
            this.syllablesComboBox.Size = new System.Drawing.Size(221, 37);
            this.syllablesComboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Виберіть наголос:";
            // 
            // ClearAccentuationsButton
            // 
            this.ClearAccentuationsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClearAccentuationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAccentuationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAccentuationsButton.Location = new System.Drawing.Point(0, 168);
            this.ClearAccentuationsButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.ClearAccentuationsButton.Name = "ClearAccentuationsButton";
            this.ClearAccentuationsButton.Size = new System.Drawing.Size(324, 48);
            this.ClearAccentuationsButton.TabIndex = 13;
            this.ClearAccentuationsButton.Text = "Очистити";
            this.ClearAccentuationsButton.UseVisualStyleBackColor = true;
            this.ClearAccentuationsButton.Click += new System.EventHandler(this.ClearAccentuations);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.Location = new System.Drawing.Point(324, 168);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(320, 48);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Зберегти";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SaveAccentuations);
            // 
            // WordAccentuationSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(644, 216);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ClearAccentuationsButton);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.suggestionsPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WordAccentuationSettingForm";
            this.Text = "Наголошення слова";
            this.panel1.ResumeLayout(false);
            this.suggestionsPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel suggestionsPanel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Label CurrentWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAccentuationButton;
        private System.Windows.Forms.Label CurrentSyllables;
        private System.Windows.Forms.ComboBox syllablesComboBox;
        private System.Windows.Forms.Button ClearAccentuationsButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}