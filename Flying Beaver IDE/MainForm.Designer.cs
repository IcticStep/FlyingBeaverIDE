namespace Flying_Beaver_IDE
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
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.MainTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.SettingsTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonControlAdv1.Header.AddMainItem(MainTab);
            this.ribbonControlAdv1.Header.AddMainItem(SettingsTab);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonControlAdv1.MenuButtonText = "Файл";
            this.ribbonControlAdv1.MenuButtonWidth = 65;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
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
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.SettingsTab;
            this.ribbonControlAdv1.ShowQuickItemsDropDownButton = false;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(658, 145);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            this.ribbonControlAdv1.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(656, 511);
            this.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Black;
            this.Controls.Add(this.ribbonControlAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ShowApplicationIcon = false;
            this.Text = "Flying Beaver IDE";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.ResumeLayout(false);
        }

        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem SettingsTab;

        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem MainTab;

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;

        #endregion
    }
}

