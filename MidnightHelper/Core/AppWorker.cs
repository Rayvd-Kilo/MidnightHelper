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
        public async void Start(string setedTime)
        {
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
