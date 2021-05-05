using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidnightHelper.Core
{
    class AppWorker
    {
        MainPageSettings pageSettings;
        AppsOpener appsOpener;
        public event Action TimerStarted;
        public event Action JobEnded;
        public async void Start(string setedTime)
        {
            TimerStarted?.Invoke();
            await Worker(setedTime);
        }
        private async Task Worker(string setedTime)
        {
            await Task.Run(() =>
            {
                TimeChecker(setedTime);
                pageSettings = new MainPageSettings();
                pageSettings.PageWorker();

                appsOpener = new AppsOpener();
                appsOpener.OpenApps();
                JobEnded?.Invoke();
            });
        }
        private void TimeChecker(string setedTime)
        {
            string curentTime = DateTime.Now.ToString("HH.mm");
            while (curentTime != setedTime)
                curentTime = DateTime.Now.ToString("HH.mm");
        }
    }
}
