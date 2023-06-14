namespace Flying_Beaver_IDE
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
            this.middlePanel = new System.Windows.Forms.Panel();
            this.CurrentWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.suggestionsComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
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
            this.suggestionsPanel.Controls.Add(this.CurrentWord);
            this.suggestionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.suggestionsPanel.Location = new System.Drawing.Point(0, 35);
            this.suggestionsPanel.Name = "suggestionsPanel";
            this.suggestionsPanel.Size = new System.Drawing.Size(644, 40);
            this.suggestionsPanel.TabIndex = 1;
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.submitButton);
            this.middlePanel.Controls.Add(this.suggestionsComboBox);
            this.middlePanel.Controls.Add(this.label2);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlePanel.Location = new System.Drawing.Point(0, 75);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(644, 46);
            this.middlePanel.TabIndex = 4;
            // 
            // CurrentWord
            // 
            this.CurrentWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentWord.Location = new System.Drawing.Point(0, 0);
            this.CurrentWord.Name = "CurrentWord";
            this.CurrentWord.Size = new System.Drawing.Size(644, 37);
            this.CurrentWord.TabIndex = 5;
            this.CurrentWord.Text = "Поточне слово";
            this.CurrentWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Виберіть наголос:";
            // 
            // suggestionsComboBox
            // 
            this.suggestionsComboBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.suggestionsComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.suggestionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suggestionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suggestionsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suggestionsComboBox.FormattingEnabled = true;
            this.suggestionsComboBox.ItemHeight = 29;
            this.suggestionsComboBox.Location = new System.Drawing.Point(222, 0);
            this.suggestionsComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.suggestionsComboBox.MaxDropDownItems = 15;
            this.suggestionsComboBox.Name = "suggestionsComboBox";
            this.suggestionsComboBox.Size = new System.Drawing.Size(221, 37);
            this.suggestionsComboBox.TabIndex = 11;
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(453, 0);
            this.submitButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(191, 46);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Наголосити";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // WordAccentuationSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(644, 120);
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
        private System.Windows.Forms.ComboBox suggestionsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
    }
}