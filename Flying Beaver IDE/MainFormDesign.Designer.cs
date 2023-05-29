namespace Flying_Beaver_IDE
{
    partial class MainFormDesign
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
            this.SettingsTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.PoemTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage)).BeginInit();
            this.backStage.SuspendLayout();
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
            this.ribbonControlAdv1.Size = new System.Drawing.Size(982, 160);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
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
            this.backStage.Visible = false;
            // 
            // NewFileButton
            // 
            this.NewFileButton.Accelerator = "";
            this.NewFileButton.BackColor = System.Drawing.Color.Transparent;
            this.NewFileButton.Location = new System.Drawing.Point(10, 10);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.NewFileButton.Size = new System.Drawing.Size(110, 25);
            this.NewFileButton.TabIndex = 2;
            this.NewFileButton.Text = "Новий";
            this.NewFileButton.Click += new System.EventHandler(this.CreateNewFile);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Accelerator = "";
            this.OpenFileButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFileButton.Location = new System.Drawing.Point(10, 35);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.OpenFileButton.Size = new System.Drawing.Size(110, 25);
            this.OpenFileButton.TabIndex = 3;
            this.OpenFileButton.Text = "Відкрити";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Accelerator = "";
            this.SaveFileButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileButton.Location = new System.Drawing.Point(10, 60);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.SaveFileButton.Size = new System.Drawing.Size(110, 25);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Зберегти";
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFile);
            // 
            // SaveFileAsButton
            // 
            this.SaveFileAsButton.Accelerator = "";
            this.SaveFileAsButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileAsButton.Location = new System.Drawing.Point(10, 85);
            this.SaveFileAsButton.Name = "SaveFileAsButton";
            this.SaveFileAsButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.SaveFileAsButton.Size = new System.Drawing.Size(110, 25);
            this.SaveFileAsButton.TabIndex = 5;
            this.SaveFileAsButton.Text = "Зберегти як";
            this.SaveFileAsButton.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // ExitButton
            // 
            this.ExitButton.Accelerator = "";
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(10, 110);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.ExitButton.Size = new System.Drawing.Size(110, 25);
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
            this.MainTab.Panel.Name = "ribbonPanel1";
            this.MainTab.Panel.ScrollPosition = 0;
            this.MainTab.Panel.TabIndex = 2;
            this.MainTab.Panel.Text = "Головна";
            this.MainTab.Position = 0;
            this.MainTab.Size = new System.Drawing.Size(85, 30);
            this.MainTab.Tag = "1";
            this.MainTab.Text = "Головна";
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
            this.SettingsTab.Size = new System.Drawing.Size(131, 30);
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
            this.PoemTextBox.Location = new System.Drawing.Point(0, 160);
            this.PoemTextBox.Name = "PoemTextBox";
            this.PoemTextBox.Size = new System.Drawing.Size(980, 641);
            this.PoemTextBox.TabIndex = 3;
            this.PoemTextBox.Text = "";
            this.PoemTextBox.WordWrap = false;
            this.PoemTextBox.TextChanged += new System.EventHandler(this.HandleTextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "beaverpoem";
            this.saveFileDialog.Filter = "\"Flying Beaver poem files|*beaverpoem|All files|*.*\"";
            this.saveFileDialog.Title = "Зберегти вірш";
            // 
            // MainFormDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(980, 800);
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
    }
}

