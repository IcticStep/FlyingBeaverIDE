namespace FlyingBeaverIDE.UI
{
    public partial class MainForm
    {
        private void FinishInitializingCoreComponents()
        {
            FormClosing += HandleClosingAttempt;
        }
    }
}