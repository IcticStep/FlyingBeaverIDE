namespace FlyingBeaverIDE.UI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            backStageView = new Syncfusion.Windows.Forms.BackStageView(components);
            backStage = new Syncfusion.Windows.Forms.BackStage();
            NewFileButton = new Syncfusion.Windows.Forms.BackStageButton();
            OpenFileButton = new Syncfusion.Windows.Forms.BackStageButton();
            SaveFileButton = new Syncfusion.Windows.Forms.BackStageButton();
            SaveFileAsButton = new Syncfusion.Windows.Forms.BackStageButton();
            ExitButton = new Syncfusion.Windows.Forms.BackStageButton();
            MainTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            CurrentPoemToolStripGroup = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            RhythmsComboBox = new ToolStripComboBox();
            PersonalDictionaryPanel = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            toolStripLabel3 = new ToolStripLabel();
            personalDictionaryStatus = new ToolStripLabel();
            openPersonalDictionaryButton = new ToolStripButton();
            analyzeFilterChooserPanel = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            toolStripLabel4 = new ToolStripLabel();
            toolStripLabel5 = new ToolStripLabel();
            analyzerComboBox = new ToolStripComboBox();
            SettingsTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            OptimizationSettings = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            toolStripLabel6 = new ToolStripLabel();
            toolStripLabel7 = new ToolStripLabel();
            UpdateSpeedSelector = new ToolStripComboBox();
            PoemTextBox = new RichTextBox();
            saveFileDialog = new SaveFileDialog();
            toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControlAdv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backStage).BeginInit();
            backStage.SuspendLayout();
            MainTab.Panel.SuspendLayout();
            CurrentPoemToolStripGroup.SuspendLayout();
            PersonalDictionaryPanel.SuspendLayout();
            analyzeFilterChooserPanel.SuspendLayout();
            SettingsTab.Panel.SuspendLayout();
            OptimizationSettings.SuspendLayout();
            SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            ribbonControlAdv1.AllowCollapse = false;
            ribbonControlAdv1.BackColor = SystemColors.ButtonShadow;
            ribbonControlAdv1.BackStageView = backStageView;
            ribbonControlAdv1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ribbonControlAdv1.Location = new Point(1, 0);
            ribbonControlAdv1.MenuButtonFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ribbonControlAdv1.MenuButtonText = "Файл";
            ribbonControlAdv1.MenuButtonWidth = 65;
            ribbonControlAdv1.MenuColor = Color.FromArgb(54, 54, 54);
            ribbonControlAdv1.Name = "ribbonControlAdv1";
            ribbonControlAdv1.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            ribbonControlAdv1.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // 
            // 
            ribbonControlAdv1.OfficeMenu.ImageScalingSize = new Size(20, 20);
            ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            ribbonControlAdv1.OfficeMenu.Size = new Size(12, 65);
            ribbonControlAdv1.QuickPanelImageLayout = PictureBoxSizeMode.StretchImage;
            ribbonControlAdv1.QuickPanelVisible = false;
            ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            ribbonControlAdv1.SelectedTab = MainTab;
            ribbonControlAdv1.ShowMinimizeButton = false;
            ribbonControlAdv1.ShowQuickItemsDropDownButton = false;
            ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            ribbonControlAdv1.Size = new Size(982, 183);
            ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            ribbonControlAdv1.TabIndex = 0;
            ribbonControlAdv1.Text = "ribbonControlAdv1";
            ribbonControlAdv1.ThemeName = "Office2016";
            ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = Color.FromArgb(171, 171, 171);
            ribbonControlAdv1.TitleColor = Color.Black;
            ribbonControlAdv1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // backStageView
            // 
            backStageView.BackStage = backStage;
            backStageView.HostControl = null;
            backStageView.HostForm = this;
            // 
            // backStage
            // 
            backStage.AllowDrop = true;
            backStage.BackStagePanelWidth = 160;
            backStage.BeforeTouchSize = new Size(978, 748);
            backStage.BorderStyle = BorderStyle.None;
            backStage.ChildItemSize = new Size(80, 140);
            backStage.Controls.Add(NewFileButton);
            backStage.Controls.Add(OpenFileButton);
            backStage.Controls.Add(SaveFileButton);
            backStage.Controls.Add(SaveFileAsButton);
            backStage.Controls.Add(ExitButton);
            backStage.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            backStage.ItemSize = new Size(160, 40);
            backStage.Location = new Point(0, 0);
            backStage.MinimumSize = new Size(100, 20);
            backStage.Name = "backStage";
            backStage.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            backStage.Size = new Size(978, 748);
            backStage.TabIndex = 1;
            backStage.TabStyle = typeof(Syncfusion.Windows.Forms.BackStageRenderer);
            backStage.ThemeName = "BackStage2016Renderer";
            backStage.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            backStage.Visible = false;
            // 
            // NewFileButton
            // 
            NewFileButton.Accelerator = "";
            NewFileButton.BackColor = Color.Transparent;
            NewFileButton.Location = new Point(25, 10);
            NewFileButton.Name = "NewFileButton";
            NewFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            NewFileButton.Size = new Size(158, 31);
            NewFileButton.TabIndex = 2;
            NewFileButton.Text = "Новий";
            NewFileButton.Click += CreateNewFile;
            // 
            // OpenFileButton
            // 
            OpenFileButton.Accelerator = "";
            OpenFileButton.BackColor = Color.Transparent;
            OpenFileButton.Location = new Point(25, 35);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            OpenFileButton.Size = new Size(158, 31);
            OpenFileButton.TabIndex = 3;
            OpenFileButton.Text = "Відкрити";
            OpenFileButton.Click += OpenFile;
            // 
            // SaveFileButton
            // 
            SaveFileButton.Accelerator = "";
            SaveFileButton.BackColor = Color.Transparent;
            SaveFileButton.Location = new Point(25, 60);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            SaveFileButton.Size = new Size(158, 31);
            SaveFileButton.TabIndex = 4;
            SaveFileButton.Text = "Зберегти";
            SaveFileButton.Click += SaveFile;
            // 
            // SaveFileAsButton
            // 
            SaveFileAsButton.Accelerator = "";
            SaveFileAsButton.BackColor = Color.Transparent;
            SaveFileAsButton.Location = new Point(25, 85);
            SaveFileAsButton.Name = "SaveFileAsButton";
            SaveFileAsButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            SaveFileAsButton.Size = new Size(158, 31);
            SaveFileAsButton.TabIndex = 5;
            SaveFileAsButton.Text = "Зберегти як";
            SaveFileAsButton.Click += SaveFileAs;
            // 
            // ExitButton
            // 
            ExitButton.Accelerator = "";
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Location = new Point(25, 110);
            ExitButton.Name = "ExitButton";
            ExitButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            ExitButton.Size = new Size(158, 31);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Закрити";
            ExitButton.Click += ExitProgram;
            // 
            // MainTab
            // 
            MainTab.Name = "MainTab";
            // 
            // 
            // 
            MainTab.Panel.Controls.Add(CurrentPoemToolStripGroup);
            MainTab.Panel.Controls.Add(PersonalDictionaryPanel);
            MainTab.Panel.Controls.Add(analyzeFilterChooserPanel);
            MainTab.Panel.Name = "ribbonPanel1";
            MainTab.Panel.ScrollPosition = 0;
            MainTab.Panel.TabIndex = 2;
            MainTab.Panel.Text = "Головна";
            MainTab.Position = 0;
            MainTab.Size = new Size(109, 41);
            MainTab.Tag = "1";
            MainTab.Text = "Головна";
            // 
            // CurrentPoemToolStripGroup
            // 
            CurrentPoemToolStripGroup.AllowMerge = false;
            CurrentPoemToolStripGroup.AutoSize = false;
            CurrentPoemToolStripGroup.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center;
            CurrentPoemToolStripGroup.Dock = DockStyle.Left;
            CurrentPoemToolStripGroup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentPoemToolStripGroup.ForeColor = Color.Black;
            CurrentPoemToolStripGroup.GripStyle = ToolStripGripStyle.Hidden;
            CurrentPoemToolStripGroup.Image = null;
            CurrentPoemToolStripGroup.ImageScalingSize = new Size(20, 20);
            CurrentPoemToolStripGroup.ImeMode = ImeMode.On;
            CurrentPoemToolStripGroup.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripLabel1, RhythmsComboBox });
            CurrentPoemToolStripGroup.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            CurrentPoemToolStripGroup.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            CurrentPoemToolStripGroup.Location = new Point(0, 1);
            CurrentPoemToolStripGroup.Name = "CurrentPoemToolStripGroup";
            CurrentPoemToolStripGroup.Office12Mode = false;
            CurrentPoemToolStripGroup.Padding = new Padding(3, 0, 0, 0);
            CurrentPoemToolStripGroup.RightToLeft = RightToLeft.No;
            CurrentPoemToolStripGroup.ShowCaption = false;
            CurrentPoemToolStripGroup.Size = new Size(178, 95);
            CurrentPoemToolStripGroup.TabIndex = 0;
            CurrentPoemToolStripGroup.ThemeName = "Office2016Black";
            ribbonControlAdv1.SetUseInCustomQuickAccessDialog(CurrentPoemToolStripGroup, false);
            CurrentPoemToolStripGroup.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(171, 28);
            toolStripLabel2.Text = "Поточний вірш";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(171, 28);
            toolStripLabel1.Text = "Ритм вірша";
            // 
            // RhythmsComboBox
            // 
            RhythmsComboBox.BackColor = Color.Black;
            RhythmsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RhythmsComboBox.ForeColor = SystemColors.InactiveCaption;
            RhythmsComboBox.Margin = new Padding(2, 2, 0, 2);
            RhythmsComboBox.MaxDropDownItems = 20;
            RhythmsComboBox.Name = "RhythmsComboBox";
            RhythmsComboBox.Size = new Size(169, 28);
            // 
            // PersonalDictionaryPanel
            // 
            PersonalDictionaryPanel.Dock = DockStyle.Left;
            PersonalDictionaryPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PersonalDictionaryPanel.ForeColor = Color.Black;
            PersonalDictionaryPanel.GripStyle = ToolStripGripStyle.Hidden;
            PersonalDictionaryPanel.Image = null;
            PersonalDictionaryPanel.ImageScalingSize = new Size(20, 20);
            PersonalDictionaryPanel.Items.AddRange(new ToolStripItem[] { toolStripLabel3, personalDictionaryStatus, openPersonalDictionaryButton });
            PersonalDictionaryPanel.Location = new Point(180, 1);
            PersonalDictionaryPanel.Name = "PersonalDictionaryPanel";
            PersonalDictionaryPanel.Office12Mode = false;
            PersonalDictionaryPanel.Padding = new Padding(3, 0, 0, 0);
            PersonalDictionaryPanel.RightToLeft = RightToLeft.No;
            PersonalDictionaryPanel.ShowCaption = false;
            PersonalDictionaryPanel.Size = new Size(229, 95);
            PersonalDictionaryPanel.TabIndex = 1;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(218, 28);
            toolStripLabel3.Text = "Особистий словничок";
            // 
            // personalDictionaryStatus
            // 
            personalDictionaryStatus.Name = "personalDictionaryStatus";
            personalDictionaryStatus.Size = new Size(218, 28);
            personalDictionaryStatus.Text = "Незнайомі слова: 0";
            // 
            // openPersonalDictionaryButton
            // 
            openPersonalDictionaryButton.AutoSize = false;
            openPersonalDictionaryButton.Image = Properties.Resources.DictionaryTransperentIcon;
            openPersonalDictionaryButton.ImageTransparentColor = Color.Magenta;
            openPersonalDictionaryButton.Name = "openPersonalDictionaryButton";
            openPersonalDictionaryButton.Size = new Size(218, 30);
            openPersonalDictionaryButton.Text = "Редагувати";
            openPersonalDictionaryButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            openPersonalDictionaryButton.Click += OpenPersonalDictionary;
            // 
            // analyzeFilterChooserPanel
            // 
            analyzeFilterChooserPanel.Dock = DockStyle.Left;
            analyzeFilterChooserPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            analyzeFilterChooserPanel.ForeColor = Color.Black;
            analyzeFilterChooserPanel.GripStyle = ToolStripGripStyle.Hidden;
            analyzeFilterChooserPanel.Image = null;
            analyzeFilterChooserPanel.ImageScalingSize = new Size(20, 20);
            analyzeFilterChooserPanel.Items.AddRange(new ToolStripItem[] { toolStripLabel4, toolStripLabel5, analyzerComboBox });
            analyzeFilterChooserPanel.Location = new Point(411, 1);
            analyzeFilterChooserPanel.Name = "analyzeFilterChooserPanel";
            analyzeFilterChooserPanel.Office12Mode = false;
            analyzeFilterChooserPanel.Padding = new Padding(3, 0, 0, 0);
            analyzeFilterChooserPanel.RightToLeft = RightToLeft.No;
            analyzeFilterChooserPanel.ShowCaption = false;
            analyzeFilterChooserPanel.ShowLauncher = false;
            analyzeFilterChooserPanel.Size = new Size(165, 95);
            analyzeFilterChooserPanel.TabIndex = 2;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(154, 28);
            toolStripLabel4.Text = "Аналіз";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(154, 28);
            toolStripLabel5.Text = "Аналізатор";
            // 
            // analyzerComboBox
            // 
            analyzerComboBox.BackColor = Color.Black;
            analyzerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            analyzerComboBox.ForeColor = SystemColors.InactiveCaption;
            analyzerComboBox.Margin = new Padding(2, 2, 0, 2);
            analyzerComboBox.MaxDropDownItems = 20;
            analyzerComboBox.Name = "analyzerComboBox";
            analyzerComboBox.Size = new Size(152, 28);
            // 
            // SettingsTab
            // 
            SettingsTab.Name = "SettingsTab";
            // 
            // 
            // 
            SettingsTab.Panel.Controls.Add(OptimizationSettings);
            SettingsTab.Panel.Name = "ribbonPanel2";
            SettingsTab.Panel.ScrollPosition = 0;
            SettingsTab.Panel.TabIndex = 3;
            SettingsTab.Panel.Text = "Налаштування";
            SettingsTab.Position = 1;
            SettingsTab.Size = new Size(166, 41);
            SettingsTab.Tag = "1";
            SettingsTab.Text = "Налаштування";
            // 
            // OptimizationSettings
            // 
            OptimizationSettings.AllowMerge = false;
            OptimizationSettings.AutoSize = false;
            OptimizationSettings.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center;
            OptimizationSettings.Dock = DockStyle.Left;
            OptimizationSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OptimizationSettings.ForeColor = Color.Black;
            OptimizationSettings.GripStyle = ToolStripGripStyle.Hidden;
            OptimizationSettings.Image = null;
            OptimizationSettings.ImageScalingSize = new Size(20, 20);
            OptimizationSettings.ImeMode = ImeMode.On;
            OptimizationSettings.Items.AddRange(new ToolStripItem[] { toolStripLabel6, toolStripLabel7, UpdateSpeedSelector });
            OptimizationSettings.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            OptimizationSettings.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            OptimizationSettings.Location = new Point(0, 1);
            OptimizationSettings.Name = "OptimizationSettings";
            OptimizationSettings.Office12Mode = false;
            OptimizationSettings.Padding = new Padding(3, 0, 0, 0);
            OptimizationSettings.RightToLeft = RightToLeft.No;
            OptimizationSettings.ShowCaption = false;
            OptimizationSettings.Size = new Size(273, 95);
            OptimizationSettings.TabIndex = 1;
            OptimizationSettings.ThemeName = "Office2016Black";
            ribbonControlAdv1.SetUseInCustomQuickAccessDialog(OptimizationSettings, false);
            OptimizationSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(269, 28);
            toolStripLabel6.Text = "Оптимізація";
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(269, 28);
            toolStripLabel7.Text = "Швидкість оновлення(мс)";
            // 
            // UpdateSpeedSelector
            // 
            UpdateSpeedSelector.BackColor = Color.Black;
            UpdateSpeedSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateSpeedSelector.ForeColor = SystemColors.InactiveCaption;
            UpdateSpeedSelector.Margin = new Padding(2, 2, 0, 2);
            UpdateSpeedSelector.MaxDropDownItems = 20;
            UpdateSpeedSelector.Name = "UpdateSpeedSelector";
            UpdateSpeedSelector.Size = new Size(267, 28);
            // 
            // PoemTextBox
            // 
            PoemTextBox.BackColor = Color.FromArgb(68, 68, 68);
            PoemTextBox.BorderStyle = BorderStyle.None;
            PoemTextBox.DetectUrls = false;
            PoemTextBox.Dock = DockStyle.Fill;
            PoemTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PoemTextBox.ForeColor = Color.LightGray;
            PoemTextBox.HideSelection = false;
            PoemTextBox.Location = new Point(1, 183);
            PoemTextBox.Name = "PoemTextBox";
            PoemTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            PoemTextBox.Size = new Size(978, 337);
            PoemTextBox.TabIndex = 3;
            PoemTextBox.Text = "";
            PoemTextBox.TextChanged += HandleTextChanged;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "beaverpoem";
            saveFileDialog.Filter = "\"Flying Beaver poem files|*beaverpoem|All files|*.*\"";
            saveFileDialog.Title = "Зберегти вірш";
            // 
            // toolStripPanelItem1
            // 
            toolStripPanelItem1.CausesValidation = false;
            toolStripPanelItem1.ForeColor = Color.MidnightBlue;
            toolStripPanelItem1.Name = "toolStripPanelItem1";
            toolStripPanelItem1.Size = new Size(23, 23);
            toolStripPanelItem1.Text = "toolStripPanelItem1";
            toolStripPanelItem1.Transparent = true;
            toolStripPanelItem1.UseStandardLayout = true;
            // 
            // toolStripPanelItem2
            // 
            toolStripPanelItem2.CausesValidation = false;
            toolStripPanelItem2.ForeColor = Color.MidnightBlue;
            toolStripPanelItem2.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStripPanelItem2.Name = "toolStripPanelItem2";
            toolStripPanelItem2.Size = new Size(23, 23);
            toolStripPanelItem2.Text = "toolStripPanelItem2";
            toolStripPanelItem2.Transparent = true;
            toolStripPanelItem2.UseStandardLayout = true;
            // 
            // toolStripPanelItem3
            // 
            toolStripPanelItem3.CausesValidation = false;
            toolStripPanelItem3.ForeColor = Color.MidnightBlue;
            toolStripPanelItem3.Name = "toolStripPanelItem3";
            toolStripPanelItem3.Size = new Size(23, 23);
            toolStripPanelItem3.Text = "toolStripPanelItem3";
            toolStripPanelItem3.Transparent = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(980, 521);
            ColorScheme = ColorSchemeType.Black;
            Controls.Add(backStage);
            Controls.Add(PoemTextBox);
            Controls.Add(ribbonControlAdv1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(457, 450);
            Name = "MainForm";
            Padding = new Padding(1, 0, 1, 1);
            ShowApplicationIcon = false;
            Text = "Flying Beaver IDE";
            ((System.ComponentModel.ISupportInitialize)ribbonControlAdv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backStage).EndInit();
            backStage.ResumeLayout(false);
            MainTab.Panel.ResumeLayout(false);
            MainTab.Panel.PerformLayout();
            CurrentPoemToolStripGroup.ResumeLayout(false);
            CurrentPoemToolStripGroup.PerformLayout();
            PersonalDictionaryPanel.ResumeLayout(false);
            PersonalDictionaryPanel.PerformLayout();
            analyzeFilterChooserPanel.ResumeLayout(false);
            analyzeFilterChooserPanel.PerformLayout();
            SettingsTab.Panel.ResumeLayout(false);
            OptimizationSettings.ResumeLayout(false);
            OptimizationSettings.PerformLayout();
            ResumeLayout(false);
        }

        private Syncfusion.Windows.Forms.BackStageView backStageView;

        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem SettingsTab;

        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem MainTab;

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;

        #endregion

        private Syncfusion.Windows.Forms.BackStage backStage;
        private Syncfusion.Windows.Forms.BackStageButton NewFileButton;
        private Syncfusion.Windows.Forms.BackStageButton OpenFileButton;
        private Syncfusion.Windows.Forms.BackStageButton SaveFileButton;
        private Syncfusion.Windows.Forms.BackStageButton SaveFileAsButton;
        private Syncfusion.Windows.Forms.BackStageButton ExitButton;
        private System.Windows.Forms.RichTextBox PoemTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx CurrentPoemToolStripGroup;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox RhythmsComboBox;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx PersonalDictionaryPanel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel personalDictionaryStatus;
        private System.Windows.Forms.ToolStripButton openPersonalDictionaryButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx analyzeFilterChooserPanel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox analyzerComboBox;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx OptimizationSettings;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox UpdateSpeedSelector;
    }
}