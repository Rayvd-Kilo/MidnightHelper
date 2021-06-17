using MidnightHelper.Core;
using System;
using System.Windows.Forms;

namespace MidnightHelper
{
    public partial class MainForm : Form
    {
        AppWorker appWorker => new AppWorker;
        string setedTime;

        public MainForm()
        {
            InitializeComponent();
            SubscribeToButtonsEvents();
        }

        private void setTimerButton_Click(object sender, EventArgs e)
        {
            setedTime = CorrectSetedTime();
            appWorker.Start(setedTime);
        }

        private void SubscribeToButtonsEvents()
        {
            appWorker.TimerStarted += DisableButton;
            appWorker.JobEnded += EnableButton;
        }

        private void DisableButton()
        {
            setTimerButton.Enabled = false;
            setTimerButton.Text = "Time setted";
        }

        private void EnableButton()
        {
            setTimerButton.Enabled = true;
            setTimerButton.Text = "Set Time";
        }

        private string CorrectSetedTime()
        {
            NumericStringCorrector correctorHours = new NumericStringCorrector(numericHours.Value.ToString());
            NumericStringCorrector correctorMinutes = new NumericStringCorrector(numericMinutes.Value.ToString());
            var correctedTime = $"{correctorHours.Corected}.{correctorMinutes.Corected}";
            return correctedTime;
        }
    }
}
