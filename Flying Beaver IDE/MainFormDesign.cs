using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;

namespace Flying_Beaver_IDE
{
    public partial class MainFormDesign : RibbonForm
    {
        public MainFormDesign()
        {
            InitializeComponent();
        }

        private void CreateNewFile(object sender, EventArgs e)
        {

        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveFile(object sender, EventArgs e)
        {

        }

        private void SaveFileAs(object sender, EventArgs e)
        {

        }

        private void ExitProgram(object sender, EventArgs e)
        {

        }

        private void HandleTextChanged(object sender, EventArgs e)
        {

        }

        private void OpenPersonalDictionary(object sender, EventArgs e)
        {
            new LocalDictionaryForm().Show();
        }
    }
}
