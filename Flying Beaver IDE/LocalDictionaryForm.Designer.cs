namespace Flying_Beaver_IDE
{
    partial class LocalDictionaryForm
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
            this.suggestionAddButton = new System.Windows.Forms.Button();
            this.suggestionsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.knownWords = new System.Windows.Forms.DataGridView();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteCurrentWordButton = new System.Windows.Forms.Button();
            this.editCurrentWordButton = new System.Windows.Forms.Button();
            this.CurrentWord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newWordInput = new System.Windows.Forms.TextBox();
            this.newWordAddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.suggestionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knownWords)).BeginInit();
            this.middlePanel.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.label1.Text = "Особистий словничок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // suggestionsPanel
            // 
            this.suggestionsPanel.Controls.Add(this.suggestionAddButton);
            this.suggestionsPanel.Controls.Add(this.suggestionsComboBox);
            this.suggestionsPanel.Controls.Add(this.label2);
            this.suggestionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.suggestionsPanel.Location = new System.Drawing.Point(0, 35);
            this.suggestionsPanel.Name = "suggestionsPanel";
            this.suggestionsPanel.Size = new System.Drawing.Size(644, 40);
            this.suggestionsPanel.TabIndex = 1;
            // 
            // suggestionAddButton
            // 
            this.suggestionAddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.suggestionAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suggestionAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suggestionAddButton.Location = new System.Drawing.Point(480, 0);
            this.suggestionAddButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.suggestionAddButton.Name = "suggestionAddButton";
            this.suggestionAddButton.Size = new System.Drawing.Size(164, 40);
            this.suggestionAddButton.TabIndex = 2;
            this.suggestionAddButton.Text = "Додати";
            this.suggestionAddButton.UseVisualStyleBackColor = true;
            this.suggestionAddButton.Click += new System.EventHandler(this.AddSuggestedWord);
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
            this.suggestionsComboBox.Location = new System.Drawing.Point(220, 0);
            this.suggestionsComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.suggestionsComboBox.MaxDropDownItems = 15;
            this.suggestionsComboBox.Name = "suggestionsComboBox";
            this.suggestionsComboBox.Size = new System.Drawing.Size(255, 37);
            this.suggestionsComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Необхідні слова:";
            // 
            // knownWords
            // 
            this.knownWords.AllowUserToAddRows = false;
            this.knownWords.AllowUserToDeleteRows = false;
            this.knownWords.AllowUserToResizeColumns = false;
            this.knownWords.AllowUserToResizeRows = false;
            this.knownWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.knownWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knownWords.Dock = System.Windows.Forms.DockStyle.Left;
            this.knownWords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.knownWords.Location = new System.Drawing.Point(0, 0);
            this.knownWords.MultiSelect = false;
            this.knownWords.Name = "knownWords";
            this.knownWords.ReadOnly = true;
            this.knownWords.RowHeadersWidth = 51;
            this.knownWords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.knownWords.RowTemplate.Height = 24;
            this.knownWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.knownWords.Size = new System.Drawing.Size(407, 250);
            this.knownWords.TabIndex = 2;
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.panel4);
            this.middlePanel.Controls.Add(this.knownWords);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlePanel.Location = new System.Drawing.Point(0, 75);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(644, 250);
            this.middlePanel.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteCurrentWordButton);
            this.panel4.Controls.Add(this.editCurrentWordButton);
            this.panel4.Controls.Add(this.CurrentWord);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(407, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 250);
            this.panel4.TabIndex = 4;
            // 
            // deleteCurrentWordButton
            // 
            this.deleteCurrentWordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteCurrentWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCurrentWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCurrentWordButton.Location = new System.Drawing.Point(0, 77);
            this.deleteCurrentWordButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.deleteCurrentWordButton.Name = "deleteCurrentWordButton";
            this.deleteCurrentWordButton.Size = new System.Drawing.Size(237, 40);
            this.deleteCurrentWordButton.TabIndex = 6;
            this.deleteCurrentWordButton.Text = "Видалити";
            this.deleteCurrentWordButton.UseVisualStyleBackColor = true;
            this.deleteCurrentWordButton.Click += new System.EventHandler(this.DeleteSelectedWord);
            // 
            // editCurrentWordButton
            // 
            this.editCurrentWordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editCurrentWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCurrentWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCurrentWordButton.Location = new System.Drawing.Point(0, 37);
            this.editCurrentWordButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.editCurrentWordButton.Name = "editCurrentWordButton";
            this.editCurrentWordButton.Size = new System.Drawing.Size(237, 40);
            this.editCurrentWordButton.TabIndex = 5;
            this.editCurrentWordButton.Text = "Редагувати";
            this.editCurrentWordButton.UseVisualStyleBackColor = true;
            // 
            // CurrentWord
            // 
            this.CurrentWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentWord.Location = new System.Drawing.Point(0, 0);
            this.CurrentWord.Name = "CurrentWord";
            this.CurrentWord.Size = new System.Drawing.Size(237, 37);
            this.CurrentWord.TabIndex = 4;
            this.CurrentWord.Text = "Поточне слово";
            this.CurrentWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нове слово:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newWordInput
            // 
            this.newWordInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newWordInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.newWordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWordInput.Location = new System.Drawing.Point(167, 325);
            this.newWordInput.Margin = new System.Windows.Forms.Padding(0);
            this.newWordInput.Name = "newWordInput";
            this.newWordInput.Size = new System.Drawing.Size(308, 49);
            this.newWordInput.TabIndex = 6;
            this.newWordInput.WordWrap = false;
            // 
            // newWordAddButton
            // 
            this.newWordAddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.newWordAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newWordAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWordAddButton.Location = new System.Drawing.Point(480, 325);
            this.newWordAddButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.newWordAddButton.Name = "newWordAddButton";
            this.newWordAddButton.Size = new System.Drawing.Size(164, 48);
            this.newWordAddButton.TabIndex = 7;
            this.newWordAddButton.Text = "Додати";
            this.newWordAddButton.UseVisualStyleBackColor = true;
            // 
            // LocalDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(644, 373);
            this.Controls.Add(this.newWordAddButton);
            this.Controls.Add(this.newWordInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.suggestionsPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalDictionaryForm";
            this.Text = "Особистий словничок";
            this.panel1.ResumeLayout(false);
            this.suggestionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.knownWords)).EndInit();
            this.middlePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel suggestionsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox suggestionsComboBox;
        private System.Windows.Forms.Button suggestionAddButton;
        private System.Windows.Forms.DataGridView knownWords;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deleteCurrentWordButton;
        private System.Windows.Forms.Button editCurrentWordButton;
        private System.Windows.Forms.Label CurrentWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newWordInput;
        private System.Windows.Forms.Button newWordAddButton;
    }
}