using ScreenTimeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTimeBackend.Controller
{
    public class OpenTimeController
    {
        public static async void addOpenTimeAsync(Processus processus)
        {
            await Task.Run(() =>
            {
                if (processus.OpenTimes == null)
                    processus.OpenTimes = new List<OpenTime>();
                processus.OpenTimes.Add(new OpenTime { Day = DateTime.Now, TimeOpen = TimeSpan.Zero });
            });
        }

        public static async void addOpenTimeAsync(Processus processus, DateTime begin)
        {
            await Task.Run(() =>
            {
                if (processus.OpenTimes == null)
                    processus.OpenTimes = new List<OpenTime>();
                processus.OpenTimes.Add(new OpenTime { Day = begin, TimeOpen = TimeSpan.Zero });
            });
        }
        public static async void stepOpenTimeAsync(Processus processus)
        {
            await Task.Run(() =>
            {
                DateTime dateNow = DateTime.Now;
                if (processus.OpenTimes.Last().Day.Day < DateTime.Now.Day)
                {
                    DateTime midnight = new DateTime(dateNow.Year, dateNow.Month, processus.OpenTimes.Last().Day.Day + 1, 0, 0, 0);
                    TimeSpan timeSpent = midnight.Subtract(processus.OpenTimes.Last().Day);
                    processus.OpenTimes.Last().TimeOpen = timeSpent;
                    addOpenTimeAsync(processus, midnight);
                    stepOpenTimeAsync(processus);

                }
                processus.OpenTimes.Last().TimeOpen = dateNow.Subtract(processus.OpenTimes.Last().Day);
            });
        }
    }
}
