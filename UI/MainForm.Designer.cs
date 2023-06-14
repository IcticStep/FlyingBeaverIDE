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
            this.components = new System.ComponentModel.Container();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage = new Syncfusion.Windows.Forms.BackStage();
            this.NewFileButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.OpenFileButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.SaveFileButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.SaveFileAsButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.ExitButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.MainTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.CurrentPoemToolStripGroup = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.RhythmsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PersonalDictionaryPanel = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.personalDictionaryStatus = new System.Windows.Forms.ToolStripLabel();
            this.SettingsTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.PoemTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.openPersonalDictionaryButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage)).BeginInit();
            this.backStage.SuspendLayout();
            this.MainTab.Panel.SuspendLayout();
            this.CurrentPoemToolStripGroup.SuspendLayout();
            this.PersonalDictionaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.AllowCollapse = false;
            this.ribbonControlAdv1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ribbonControlAdv1.BackStageView = this.backStageView;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonControlAdv1.Header.AddMainItem(MainTab);
            this.ribbonControlAdv1.Header.AddMainItem(SettingsTab);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonControlAdv1.MenuButtonText = "Файл";
            this.ribbonControlAdv1.MenuButtonWidth = 65;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.ribbonControlAdv1.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.QuickPanelVisible = false;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.MainTab;
            this.ribbonControlAdv1.ShowMinimizeButton = false;
            this.ribbonControlAdv1.ShowQuickItemsDropDownButton = false;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(982, 183);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
            this.ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            this.ribbonControlAdv1.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // backStageView
            // 
            this.backStageView.BackStage = this.backStage;
            this.backStageView.HostControl = null;
            this.backStageView.HostForm = this;
            // 
            // backStage
            // 
            this.backStage.ActiveTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.backStage.AllowDrop = true;
            this.backStage.BackStagePanelWidth = 160;
            this.backStage.BeforeTouchSize = new System.Drawing.Size(978, 748);
            this.backStage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage.Controls.Add(this.NewFileButton);
            this.backStage.Controls.Add(this.OpenFileButton);
            this.backStage.Controls.Add(this.SaveFileButton);
            this.backStage.Controls.Add(this.SaveFileAsButton);
            this.backStage.Controls.Add(this.ExitButton);
            this.backStage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backStage.ItemSize = new System.Drawing.Size(160, 40);
            this.backStage.Location = new System.Drawing.Point(0, 0);
            this.backStage.MinimumSize = new System.Drawing.Size(100, 20);
            this.backStage.Name = "backStage1";
            this.backStage.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.backStage.Size = new System.Drawing.Size(978, 748);
            this.backStage.TabIndex = 1;
            this.backStage.ThemeName = "BackStage2016Renderer";
            this.backStage.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.backStage.Visible = false;
            // 
            // NewFileButton
            // 
            this.NewFileButton.Accelerator = "";
            this.NewFileButton.BackColor = System.Drawing.Color.Transparent;
            this.NewFileButton.Location = new System.Drawing.Point(25, 10);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.NewFileButton.Size = new System.Drawing.Size(158, 31);
            this.NewFileButton.TabIndex = 2;
            this.NewFileButton.Text = "Новий";
            this.NewFileButton.Click += new System.EventHandler(this.CreateNewFile);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Accelerator = "";
            this.OpenFileButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFileButton.Location = new System.Drawing.Point(25, 35);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.OpenFileButton.Size = new System.Drawing.Size(158, 31);
            this.OpenFileButton.TabIndex = 3;
            this.OpenFileButton.Text = "Відкрити";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Accelerator = "";
            this.SaveFileButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileButton.Location = new System.Drawing.Point(25, 60);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.SaveFileButton.Size = new System.Drawing.Size(158, 31);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Зберегти";
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFile);
            // 
            // SaveFileAsButton
            // 
            this.SaveFileAsButton.Accelerator = "";
            this.SaveFileAsButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileAsButton.Location = new System.Drawing.Point(25, 85);
            this.SaveFileAsButton.Name = "SaveFileAsButton";
            this.SaveFileAsButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.SaveFileAsButton.Size = new System.Drawing.Size(158, 31);
            this.SaveFileAsButton.TabIndex = 5;
            this.SaveFileAsButton.Text = "Зберегти як";
            this.SaveFileAsButton.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // ExitButton
            // 
            this.ExitButton.Accelerator = "";
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(25, 110);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.ExitButton.Size = new System.Drawing.Size(158, 31);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Закрити";
            this.ExitButton.Click += new System.EventHandler(this.ExitProgram);
            // 
            // MainTab
            // 
            this.MainTab.Name = "MainTab";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.MainTab.Panel.Controls.Add(this.CurrentPoemToolStripGroup);
            this.MainTab.Panel.Controls.Add(this.PersonalDictionaryPanel);
            this.MainTab.Panel.Name = "ribbonPanel1";
            this.MainTab.Panel.ScrollPosition = 0;
            this.MainTab.Panel.TabIndex = 2;
            this.MainTab.Panel.Text = "Головна";
            this.MainTab.Position = 0;
            this.MainTab.Size = new System.Drawing.Size(95, 34);
            this.MainTab.Tag = "1";
            this.MainTab.Text = "Головна";
            // 
            // CurrentPoemToolStripGroup
            // 
            this.CurrentPoemToolStripGroup.AllowMerge = false;
            this.CurrentPoemToolStripGroup.AutoSize = false;
            this.CurrentPoemToolStripGroup.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center;
            this.CurrentPoemToolStripGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentPoemToolStripGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPoemToolStripGroup.ForeColor = System.Drawing.Color.Black;
            this.CurrentPoemToolStripGroup.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CurrentPoemToolStripGroup.Image = null;
            this.CurrentPoemToolStripGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CurrentPoemToolStripGroup.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CurrentPoemToolStripGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.RhythmsComboBox});
            this.CurrentPoemToolStripGroup.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.CurrentPoemToolStripGroup.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.CurrentPoemToolStripGroup.Location = new System.Drawing.Point(0, 1);
            this.CurrentPoemToolStripGroup.Name = "CurrentPoemToolStripGroup";
            this.CurrentPoemToolStripGroup.Office12Mode = false;
            this.CurrentPoemToolStripGroup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CurrentPoemToolStripGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrentPoemToolStripGroup.ShowCaption = false;
            this.CurrentPoemToolStripGroup.Size = new System.Drawing.Size(178, 95);
            this.CurrentPoemToolStripGroup.TabIndex = 0;
            this.CurrentPoemToolStripGroup.ThemeName = "Office2016Black";
            this.ribbonControlAdv1.SetUseInCustomQuickAccessDialog(this.CurrentPoemToolStripGroup, false);
            this.CurrentPoemToolStripGroup.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(171, 28);
            this.toolStripLabel2.Text = "Поточний вірш";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(171, 28);
            this.toolStripLabel1.Text = "Ритм вірша";
            // 
            // RhythmsComboBox
            // 
            this.RhythmsComboBox.BackColor = System.Drawing.Color.Black;
            this.RhythmsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RhythmsComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RhythmsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.RhythmsComboBox.MaxDropDownItems = 20;
            this.RhythmsComboBox.Name = "RhythmsComboBox";
            this.RhythmsComboBox.Size = new System.Drawing.Size(169, 28);
            // 
            // PersonalDictionaryPanel
            // 
            this.PersonalDictionaryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PersonalDictionaryPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalDictionaryPanel.ForeColor = System.Drawing.Color.Black;
            this.PersonalDictionaryPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.PersonalDictionaryPanel.Image = null;
            this.PersonalDictionaryPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PersonalDictionaryPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.personalDictionaryStatus,
            this.openPersonalDictionaryButton});
            this.PersonalDictionaryPanel.Location = new System.Drawing.Point(180, 1);
            this.PersonalDictionaryPanel.Name = "PersonalDictionaryPanel";
            this.PersonalDictionaryPanel.Office12Mode = false;
            this.PersonalDictionaryPanel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PersonalDictionaryPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PersonalDictionaryPanel.ShowCaption = false;
            this.PersonalDictionaryPanel.Size = new System.Drawing.Size(229, 95);
            this.PersonalDictionaryPanel.TabIndex = 1;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(218, 28);
            this.toolStripLabel3.Text = "Особистий словничок";
            // 
            // personalDictionaryStatus
            // 
            this.personalDictionaryStatus.Name = "personalDictionaryStatus";
            this.personalDictionaryStatus.Size = new System.Drawing.Size(218, 28);
            this.personalDictionaryStatus.Text = "Незнайомі слова: 0";
            // 
            // SettingsTab
            // 
            this.SettingsTab.Name = "SettingsTab";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.SettingsTab.Panel.Name = "ribbonPanel2";
            this.SettingsTab.Panel.ScrollPosition = 0;
            this.SettingsTab.Panel.TabIndex = 3;
            this.SettingsTab.Panel.Text = "Налаштування";
            this.SettingsTab.Position = 1;
            this.SettingsTab.Size = new System.Drawing.Size(152, 34);
            this.SettingsTab.Tag = "1";
            this.SettingsTab.Text = "Налаштування";
            // 
            // PoemTextBox
            // 
            this.PoemTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PoemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PoemTextBox.DetectUrls = false;
            this.PoemTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoemTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoemTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.PoemTextBox.HideSelection = false;
            this.PoemTextBox.Location = new System.Drawing.Point(0, 183);
            this.PoemTextBox.Name = "PoemTextBox";
            this.PoemTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PoemTextBox.Size = new System.Drawing.Size(980, 339);
            this.PoemTextBox.TabIndex = 3;
            this.PoemTextBox.Text = "";
            this.PoemTextBox.TextChanged += new System.EventHandler(this.HandleTextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "beaverpoem";
            this.saveFileDialog.Filter = "\"Flying Beaver poem files|*beaverpoem|All files|*.*\"";
            this.saveFileDialog.Title = "Зберегти вірш";
            // 
            // toolStripPanelItem1
            // 
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Size = new System.Drawing.Size(23, 23);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = true;
            this.toolStripPanelItem1.UseStandardLayout = true;
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.Size = new System.Drawing.Size(23, 23);
            this.toolStripPanelItem2.Text = "toolStripPanelItem2";
            this.toolStripPanelItem2.Transparent = true;
            this.toolStripPanelItem2.UseStandardLayout = true;
            // 
            // toolStripPanelItem3
            // 
            this.toolStripPanelItem3.CausesValidation = false;
            this.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem3.Name = "toolStripPanelItem3";
            this.toolStripPanelItem3.Size = new System.Drawing.Size(23, 23);
            this.toolStripPanelItem3.Text = "toolStripPanelItem3";
            this.toolStripPanelItem3.Transparent = true;
            // 
            // openPersonalDictionaryButton
            // 
            this.openPersonalDictionaryButton.AutoSize = false;
            this.openPersonalDictionaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openPersonalDictionaryButton.Image = Properties.Resources.DictionaryTransperentIcon;
            this.openPersonalDictionaryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openPersonalDictionaryButton.Name = "openPersonalDictionaryButton";
            this.openPersonalDictionaryButton.Size = new System.Drawing.Size(218, 30);
            this.openPersonalDictionaryButton.Text = "Редагувати";
            this.openPersonalDictionaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // MainFormDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(980, 521);
            this.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Black;
            this.Controls.Add(this.backStage);
            this.Controls.Add(this.PoemTextBox);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(457, 450);
            this.Name = "MainFormDesign";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ShowApplicationIcon = false;
            this.Text = "Flying Beaver IDE";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage)).EndInit();
            this.backStage.ResumeLayout(false);
            this.MainTab.Panel.ResumeLayout(false);
            this.MainTab.Panel.PerformLayout();
            this.CurrentPoemToolStripGroup.ResumeLayout(false);
            this.CurrentPoemToolStripGroup.PerformLayout();
            this.PersonalDictionaryPanel.ResumeLayout(false);
            this.PersonalDictionaryPanel.PerformLayout();
            this.ResumeLayout(false);

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
    }
}