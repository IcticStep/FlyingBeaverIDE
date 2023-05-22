namespace HtmlParserSlovnykUI;

partial class MainForm
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
        panel1 = new Panel();
        panel14 = new Panel();
        ProgressOperationsCounter = new Label();
        ProgressBar = new ProgressBar();
        panel8 = new Panel();
        CurrentOperationName = new Label();
        label6 = new Label();
        Header = new Label();
        LettersPanel = new Panel();
        panel3 = new Panel();
        tableLayoutPanel1 = new TableLayoutPanel();
        LettersSaveButton = new Button();
        LettersOpenButton = new Button();
        LettersParseButton = new Button();
        panel2 = new Panel();
        LettersDataRows = new Label();
        label1 = new Label();
        panel4 = new Panel();
        panel5 = new Panel();
        tableLayoutPanel2 = new TableLayoutPanel();
        button1 = new Button();
        button2 = new Button();
        panel6 = new Panel();
        panel7 = new Panel();
        tableLayoutPanel3 = new TableLayoutPanel();
        button3 = new Button();
        button4 = new Button();
        SublettersPanel = new Panel();
        panel9 = new Panel();
        tableLayoutPanel4 = new TableLayoutPanel();
        SublettersSaveButton = new Button();
        SublettersOpenButton = new Button();
        SublettersParseButton = new Button();
        panel10 = new Panel();
        SublettersDataRows = new Label();
        label4 = new Label();
        WordinksPanel = new Panel();
        panel11 = new Panel();
        tableLayoutPanel5 = new TableLayoutPanel();
        WordsLinksSaveButton = new Button();
        WordsLinksOpenButton = new Button();
        WordsLinksParseButton = new Button();
        panel12 = new Panel();
        WordLinksDataRows = new Label();
        label3 = new Label();
        WordsParsing = new Panel();
        panel13 = new Panel();
        tableLayoutPanel6 = new TableLayoutPanel();
        WordsSaveButton = new Button();
        WordsOpenButton = new Button();
        WordsParseButton = new Button();
        Panel15 = new Panel();
        WordsDataRows = new Label();
        label5 = new Label();
        panel1.SuspendLayout();
        panel14.SuspendLayout();
        panel8.SuspendLayout();
        LettersPanel.SuspendLayout();
        panel3.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SublettersPanel.SuspendLayout();
        panel9.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        panel10.SuspendLayout();
        WordinksPanel.SuspendLayout();
        panel11.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        panel12.SuspendLayout();
        WordsParsing.SuspendLayout();
        panel13.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        Panel15.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(panel14);
        panel1.Controls.Add(panel8);
        panel1.Controls.Add(Header);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(915, 102);
        panel1.TabIndex = 0;
        // 
        // panel14
        // 
        panel14.Controls.Add(ProgressOperationsCounter);
        panel14.Controls.Add(ProgressBar);
        panel14.Dock = DockStyle.Fill;
        panel14.Location = new Point(209, 41);
        panel14.Name = "panel14";
        panel14.Size = new Size(706, 61);
        panel14.TabIndex = 4;
        // 
        // ProgressOperationsCounter
        // 
        ProgressOperationsCounter.Dock = DockStyle.Top;
        ProgressOperationsCounter.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
        ProgressOperationsCounter.Location = new Point(0, 0);
        ProgressOperationsCounter.Name = "ProgressOperationsCounter";
        ProgressOperationsCounter.Size = new Size(706, 33);
        ProgressOperationsCounter.TabIndex = 4;
        ProgressOperationsCounter.Text = "0/0";
        ProgressOperationsCounter.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ProgressBar
        // 
        ProgressBar.Anchor = AnchorStyles.Top;
        ProgressBar.Location = new Point(36, 33);
        ProgressBar.Name = "ProgressBar";
        ProgressBar.Size = new Size(636, 28);
        ProgressBar.TabIndex = 1;
        // 
        // panel8
        // 
        panel8.Controls.Add(CurrentOperationName);
        panel8.Controls.Add(label6);
        panel8.Dock = DockStyle.Left;
        panel8.Location = new Point(0, 41);
        panel8.Name = "panel8";
        panel8.Size = new Size(209, 61);
        panel8.TabIndex = 3;
        // 
        // CurrentOperationName
        // 
        CurrentOperationName.Dock = DockStyle.Fill;
        CurrentOperationName.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
        CurrentOperationName.Location = new Point(0, 30);
        CurrentOperationName.Name = "CurrentOperationName";
        CurrentOperationName.Size = new Size(209, 31);
        CurrentOperationName.TabIndex = 3;
        CurrentOperationName.Text = "Нічого не робимо";
        // 
        // label6
        // 
        label6.Dock = DockStyle.Top;
        label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label6.Location = new Point(0, 0);
        label6.Name = "label6";
        label6.Size = new Size(209, 30);
        label6.TabIndex = 2;
        label6.Text = "Поточна операція";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        Header.Location = new Point(0, 0);
        Header.Name = "Header";
        Header.Size = new Size(915, 41);
        Header.TabIndex = 0;
        Header.Text = "Парсинг сайту Slovnyk UA";
        Header.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LettersPanel
        // 
        LettersPanel.Controls.Add(panel3);
        LettersPanel.Controls.Add(panel2);
        LettersPanel.Dock = DockStyle.Top;
        LettersPanel.Location = new Point(0, 102);
        LettersPanel.Name = "LettersPanel";
        LettersPanel.Size = new Size(915, 60);
        LettersPanel.TabIndex = 1;
        // 
        // panel3
        // 
        panel3.Controls.Add(tableLayoutPanel1);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(482, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(433, 60);
        panel3.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82818F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17182F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
        tableLayoutPanel1.Controls.Add(LettersSaveButton, 2, 0);
        tableLayoutPanel1.Controls.Add(LettersOpenButton, 1, 0);
        tableLayoutPanel1.Controls.Add(LettersParseButton, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(433, 60);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // LettersSaveButton
        // 
        LettersSaveButton.Dock = DockStyle.Fill;
        LettersSaveButton.Location = new Point(294, 3);
        LettersSaveButton.Name = "LettersSaveButton";
        LettersSaveButton.Size = new Size(136, 54);
        LettersSaveButton.TabIndex = 2;
        LettersSaveButton.Text = "Зберегти";
        LettersSaveButton.UseVisualStyleBackColor = true;
        LettersSaveButton.Click += SaveLettersLinksData;
        // 
        // LettersOpenButton
        // 
        LettersOpenButton.Dock = DockStyle.Fill;
        LettersOpenButton.Location = new Point(148, 3);
        LettersOpenButton.Name = "LettersOpenButton";
        LettersOpenButton.Size = new Size(140, 54);
        LettersOpenButton.TabIndex = 1;
        LettersOpenButton.Text = "Відкрити";
        LettersOpenButton.UseVisualStyleBackColor = true;
        LettersOpenButton.Click += LoadLettersData;
        // 
        // LettersParseButton
        // 
        LettersParseButton.Dock = DockStyle.Fill;
        LettersParseButton.Location = new Point(3, 3);
        LettersParseButton.Name = "LettersParseButton";
        LettersParseButton.Size = new Size(139, 54);
        LettersParseButton.TabIndex = 0;
        LettersParseButton.Text = "Парсити";
        LettersParseButton.UseVisualStyleBackColor = true;
        LettersParseButton.Click += ParseLetters;
        // 
        // panel2
        // 
        panel2.Controls.Add(LettersDataRows);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Left;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(482, 60);
        panel2.TabIndex = 0;
        // 
        // LettersDataRows
        // 
        LettersDataRows.Dock = DockStyle.Fill;
        LettersDataRows.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        LettersDataRows.Location = new Point(0, 29);
        LettersDataRows.Name = "LettersDataRows";
        LettersDataRows.Size = new Size(482, 31);
        LettersDataRows.TabIndex = 2;
        LettersDataRows.Text = "Кількість записів: 0";
        LettersDataRows.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label1
        // 
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(482, 29);
        label1.TabIndex = 1;
        label1.Text = "Посилання на букви";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel4
        // 
        panel4.Location = new Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new Size(200, 100);
        panel4.TabIndex = 0;
        // 
        // panel5
        // 
        panel5.Location = new Point(482, 0);
        panel5.Name = "panel5";
        panel5.Size = new Size(433, 65);
        panel5.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82818F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17182F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
        tableLayoutPanel2.Controls.Add(button1, 2, 0);
        tableLayoutPanel2.Location = new Point(0, 0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.Size = new Size(200, 100);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // button1
        // 
        button1.Dock = DockStyle.Fill;
        button1.Location = new Point(61, 3);
        button1.Name = "button1";
        button1.Size = new Size(136, 94);
        button1.TabIndex = 2;
        button1.Text = "Зберегти";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Dock = DockStyle.Fill;
        button2.Location = new Point(148, 3);
        button2.Name = "button2";
        button2.Size = new Size(140, 59);
        button2.TabIndex = 1;
        button2.Text = "Відкрити";
        button2.UseVisualStyleBackColor = true;
        // 
        // panel6
        // 
        panel6.Location = new Point(0, 0);
        panel6.Name = "panel6";
        panel6.Size = new Size(200, 100);
        panel6.TabIndex = 0;
        // 
        // panel7
        // 
        panel7.Location = new Point(482, 0);
        panel7.Name = "panel7";
        panel7.Size = new Size(433, 59);
        panel7.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 3;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82818F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17182F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
        tableLayoutPanel3.Controls.Add(button3, 2, 0);
        tableLayoutPanel3.Location = new Point(0, 0);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.Size = new Size(200, 100);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // button3
        // 
        button3.Dock = DockStyle.Fill;
        button3.Location = new Point(61, 3);
        button3.Name = "button3";
        button3.Size = new Size(136, 94);
        button3.TabIndex = 2;
        button3.Text = "Зберегти";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Dock = DockStyle.Fill;
        button4.Location = new Point(148, 3);
        button4.Name = "button4";
        button4.Size = new Size(140, 53);
        button4.TabIndex = 1;
        button4.Text = "Відкрити";
        button4.UseVisualStyleBackColor = true;
        // 
        // SublettersPanel
        // 
        SublettersPanel.Controls.Add(panel9);
        SublettersPanel.Controls.Add(panel10);
        SublettersPanel.Dock = DockStyle.Top;
        SublettersPanel.Location = new Point(0, 162);
        SublettersPanel.Name = "SublettersPanel";
        SublettersPanel.Size = new Size(915, 60);
        SublettersPanel.TabIndex = 2;
        // 
        // panel9
        // 
        panel9.Controls.Add(tableLayoutPanel4);
        panel9.Dock = DockStyle.Fill;
        panel9.Location = new Point(482, 0);
        panel9.Name = "panel9";
        panel9.Size = new Size(433, 60);
        panel9.TabIndex = 1;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 3;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82818F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17182F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
        tableLayoutPanel4.Controls.Add(SublettersSaveButton, 2, 0);
        tableLayoutPanel4.Controls.Add(SublettersOpenButton, 1, 0);
        tableLayoutPanel4.Controls.Add(SublettersParseButton, 0, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(0, 0);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new Size(433, 60);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // SublettersSaveButton
        // 
        SublettersSaveButton.Dock = DockStyle.Fill;
        SublettersSaveButton.Location = new Point(294, 3);
        SublettersSaveButton.Name = "SublettersSaveButton";
        SublettersSaveButton.Size = new Size(136, 54);
        SublettersSaveButton.TabIndex = 2;
        SublettersSaveButton.Text = "Зберегти";
        SublettersSaveButton.UseVisualStyleBackColor = true;
        SublettersSaveButton.Click += SaveSublettersData;
        // 
        // SublettersOpenButton
        // 
        SublettersOpenButton.Dock = DockStyle.Fill;
        SublettersOpenButton.Location = new Point(148, 3);
        SublettersOpenButton.Name = "SublettersOpenButton";
        SublettersOpenButton.Size = new Size(140, 54);
        SublettersOpenButton.TabIndex = 1;
        SublettersOpenButton.Text = "Відкрити";
        SublettersOpenButton.UseVisualStyleBackColor = true;
        SublettersOpenButton.Click += LoadSublettersData;
        // 
        // SublettersParseButton
        // 
        SublettersParseButton.Dock = DockStyle.Fill;
        SublettersParseButton.Location = new Point(3, 3);
        SublettersParseButton.Name = "SublettersParseButton";
        SublettersParseButton.Size = new Size(139, 54);
        SublettersParseButton.TabIndex = 0;
        SublettersParseButton.Text = "Парсити";
        SublettersParseButton.UseVisualStyleBackColor = true;
        SublettersParseButton.Click += ParseSubletters;
        // 
        // panel10
        // 
        panel10.Controls.Add(SublettersDataRows);
        panel10.Controls.Add(label4);
        panel10.Dock = DockStyle.Left;
        panel10.Location = new Point(0, 0);
        panel10.Name = "panel10";
        panel10.Size = new Size(482, 60);
        panel10.TabIndex = 0;
        // 
        // SublettersDataRows
        // 
        SublettersDataRows.Dock = DockStyle.Fill;
        SublettersDataRows.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        SublettersDataRows.Location = new Point(0, 29);
        SublettersDataRows.Name = "SublettersDataRows";
        SublettersDataRows.Size = new Size(482, 31);
        SublettersDataRows.TabIndex = 2;
        SublettersDataRows.Text = "Кількість записів: 0";
        SublettersDataRows.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label4
        // 
        label4.Dock = DockStyle.Top;
        label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Location = new Point(0, 0);
        label4.Name = "label4";
        label4.Size = new Size(482, 29);
        label4.TabIndex = 1;
        label4.Text = "Посилання на підрозділи букв";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // WordinksPanel
        // 
        WordinksPanel.Controls.Add(panel11);
        WordinksPanel.Controls.Add(panel12);
        WordinksPanel.Dock = DockStyle.Top;
        WordinksPanel.Location = new Point(0, 222);
        WordinksPanel.Name = "WordinksPanel";
        WordinksPanel.Size = new Size(915, 60);
        WordinksPanel.TabIndex = 3;
        // 
        // panel11
        // 
        panel11.Controls.Add(tableLayoutPanel5);
        panel11.Dock = DockStyle.Fill;
        panel11.Location = new Point(482, 0);
        panel11.Name = "panel11";
        panel11.Size = new Size(433, 60);
        panel11.TabIndex = 1;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 3;
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82818F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17182F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
        tableLayoutPanel5.Controls.Add(WordsLinksSaveButton, 2, 0);
        tableLayoutPanel5.Controls.Add(WordsLinksOpenButton, 1, 0);
        tableLayoutPanel5.Controls.Add(WordsLinksParseButton, 0, 0);
        tableLayoutPanel5.Dock = DockStyle.Fill;
        tableLayoutPanel5.Location = new Point(0, 0);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 1;
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new Size(433, 60);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // WordsLinksSaveButton
        // 
        WordsLinksSaveButton.Dock = DockStyle.Fill;
        WordsLinksSaveButton.Location = new Point(294, 3);
        WordsLinksSaveButton.Name = "WordsLinksSaveButton";
        WordsLinksSaveButton.Size = new Size(136, 54);
        WordsLinksSaveButton.TabIndex = 2;
        WordsLinksSaveButton.Text = "Зберегти";
        WordsLinksSaveButton.UseVisualStyleBackColor = true;
        WordsLinksSaveButton.Click += SaveWordLinksData;
        // 
        // WordsLinksOpenButton
        // 
        WordsLinksOpenButton.Dock = DockStyle.Fill;
        WordsLinksOpenButton.Location = new Point(148, 3);
        WordsLinksOpenButton.Name = "WordsLinksOpenButton";
        WordsLinksOpenButton.Size = new Size(140, 54);
        WordsLinksOpenButton.TabIndex = 1;
        WordsLinksOpenButton.Text = "Відкрити";
        WordsLinksOpenButton.UseVisualStyleBackColor = true;
        WordsLinksOpenButton.Click += LoadWordsLinksData;
        // 
        // WordsLinksParseButton
        // 
        WordsLinksParseButton.Dock = DockStyle.Fill;
        WordsLinksParseButton.Location = new Point(3, 3);
        WordsLinksParseButton.Name = "WordsLinksParseButton";
        WordsLinksParseButton.Size = new Size(139, 54);
        WordsLinksParseButton.TabIndex = 0;
        WordsLinksParseButton.Text = "Парсити";
        WordsLinksParseButton.UseVisualStyleBackColor = true;
        WordsLinksParseButton.Click += ParseWordsLinks;
        // 
        // panel12
        // 
        panel12.Controls.Add(WordLinksDataRows);
        panel12.Controls.Add(label3);
        panel12.Dock = DockStyle.Left;
        panel12.Location = new Point(0, 0);
        panel12.Name = "panel12";
        panel12.Size = new Size(482, 60);
        panel12.TabIndex = 0;
        // 
        // WordLinksDataRows
        // 
        WordLinksDataRows.Dock = DockStyle.Top;
        WordLinksDataRows.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        WordLinksDataRows.Location = new Point(0, 29);
        WordLinksDataRows.Name = "WordLinksDataRows";
        WordLinksDataRows.Size = new Size(482, 30);
        WordLinksDataRows.TabIndex = 2;
        WordLinksDataRows.Text = "Кількість записів: 0";
        WordLinksDataRows.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label3
        // 
        label3.Dock = DockStyle.Top;
        label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(0, 0);
        label3.Name = "label3";
        label3.Size = new Size(482, 29);
        label3.TabIndex = 1;
        label3.Text = "Посилання на слова";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // WordsParsing
        // 
        WordsParsing.Controls.Add(panel13);
        WordsParsing.Controls.Add(Panel15);
        WordsParsing.Dock = DockStyle.Top;
        WordsParsing.Location = new Point(0, 282);
        WordsParsing.Name = "WordsParsing";
        WordsParsing.Size = new Size(915, 60);
        WordsParsing.TabIndex = 4;
        // 
        // panel13
        // 
        panel13.Controls.Add(tableLayoutPanel6);
        panel13.Dock = DockStyle.Fill;
        panel13.Location = new Point(482, 0);
        panel13.Name = "panel13";
        panel13.Size = new Size(433, 60);
        panel13.TabIndex = 1;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 3;
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82818F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17182F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
        tableLayoutPanel6.Controls.Add(WordsSaveButton, 2, 0);
        tableLayoutPanel6.Controls.Add(WordsOpenButton, 1, 0);
        tableLayoutPanel6.Controls.Add(WordsParseButton, 0, 0);
        tableLayoutPanel6.Dock = DockStyle.Fill;
        tableLayoutPanel6.Location = new Point(0, 0);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 1;
        tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel6.Size = new Size(433, 60);
        tableLayoutPanel6.TabIndex = 0;
        // 
        // WordsSaveButton
        // 
        WordsSaveButton.Dock = DockStyle.Fill;
        WordsSaveButton.Location = new Point(294, 3);
        WordsSaveButton.Name = "WordsSaveButton";
        WordsSaveButton.Size = new Size(136, 54);
        WordsSaveButton.TabIndex = 2;
        WordsSaveButton.Text = "Зберегти";
        WordsSaveButton.UseVisualStyleBackColor = true;
        WordsSaveButton.Click += SaveWordsData;
        // 
        // WordsOpenButton
        // 
        WordsOpenButton.Dock = DockStyle.Fill;
        WordsOpenButton.Location = new Point(148, 3);
        WordsOpenButton.Name = "WordsOpenButton";
        WordsOpenButton.Size = new Size(140, 54);
        WordsOpenButton.TabIndex = 1;
        WordsOpenButton.Text = "Відкрити";
        WordsOpenButton.UseVisualStyleBackColor = true;
        WordsOpenButton.Click += LoadWordsData;
        // 
        // WordsParseButton
        // 
        WordsParseButton.Dock = DockStyle.Fill;
        WordsParseButton.Location = new Point(3, 3);
        WordsParseButton.Name = "WordsParseButton";
        WordsParseButton.Size = new Size(139, 54);
        WordsParseButton.TabIndex = 0;
        WordsParseButton.Text = "Парсити";
        WordsParseButton.UseVisualStyleBackColor = true;
        WordsParseButton.Click += ParseWords;
        // 
        // Panel15
        // 
        Panel15.Controls.Add(WordsDataRows);
        Panel15.Controls.Add(label5);
        Panel15.Dock = DockStyle.Left;
        Panel15.Location = new Point(0, 0);
        Panel15.Name = "Panel15";
        Panel15.Size = new Size(482, 60);
        Panel15.TabIndex = 0;
        // 
        // WordsDataRows
        // 
        WordsDataRows.Dock = DockStyle.Top;
        WordsDataRows.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        WordsDataRows.Location = new Point(0, 29);
        WordsDataRows.Name = "WordsDataRows";
        WordsDataRows.Size = new Size(482, 30);
        WordsDataRows.TabIndex = 2;
        WordsDataRows.Text = "Кількість записів: 0";
        WordsDataRows.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label5
        // 
        label5.Dock = DockStyle.Top;
        label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Location = new Point(0, 0);
        label5.Name = "label5";
        label5.Size = new Size(482, 29);
        label5.TabIndex = 1;
        label5.Text = "Парсинг самих слів";
        label5.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(915, 342);
        Controls.Add(WordsParsing);
        Controls.Add(WordinksPanel);
        Controls.Add(SublettersPanel);
        Controls.Add(LettersPanel);
        Controls.Add(panel1);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(5);
        Name = "MainForm";
        Text = "Парсинг Slovnyk.UA";
        panel1.ResumeLayout(false);
        panel14.ResumeLayout(false);
        panel8.ResumeLayout(false);
        LettersPanel.ResumeLayout(false);
        panel3.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        SublettersPanel.ResumeLayout(false);
        panel9.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        panel10.ResumeLayout(false);
        WordinksPanel.ResumeLayout(false);
        panel11.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        panel12.ResumeLayout(false);
        WordsParsing.ResumeLayout(false);
        panel13.ResumeLayout(false);
        tableLayoutPanel6.ResumeLayout(false);
        Panel15.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label Header;
    private Panel LettersPanel;
    private Panel panel3;
    private TableLayoutPanel tableLayoutPanel1;
    private Button LettersSaveButton;
    private Button LettersOpenButton;
    private Button LettersParseButton;
    private Panel panel2;
    private Label LettersDataRows;
    private Label label1;
    private Panel panel4;
    private Panel panel5;
    private TableLayoutPanel tableLayoutPanel2;
    private Button button1;
    private Button button2;
    private Panel panel6;
    private Panel panel7;
    private TableLayoutPanel tableLayoutPanel3;
    private Button button3;
    private Button button4;
    private Panel SublettersPanel;
    private Panel panel9;
    private TableLayoutPanel tableLayoutPanel4;
    private Button SublettersSaveButton;
    private Button SublettersOpenButton;
    private Button SublettersParseButton;
    private Panel panel10;
    private Label SublettersDataRows;
    private Label label4;
    private Panel WordinksPanel;
    private Panel panel11;
    private TableLayoutPanel tableLayoutPanel5;
    private Button WordsLinksSaveButton;
    private Button WordsLinksOpenButton;
    private Button WordsLinksParseButton;
    private Panel panel12;
    private Label WordLinksDataRows;
    private Label label3;
    private Panel WordsParsing;
    private Panel panel13;
    private TableLayoutPanel tableLayoutPanel6;
    private Button WordsSaveButton;
    private Button WordsOpenButton;
    private Button WordsParseButton;
    private Panel Panel15;
    private Label WordsDataRows;
    private Label label5;
    private Label label6;
    private ProgressBar ProgressBar;
    private Panel panel8;
    private Panel panel14;
    private Label ProgressOperationsCounter;
    private Label CurrentOperationName;
}