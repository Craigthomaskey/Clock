using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    class Countdowns
    {
        Form1 MainForm;

        List<int> secondTimers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 30, 40, 50, 60, 70, 80, 90 };
        List<int> minuteTimers = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30, 45 };
        public DateTime CurrentTimer;

        List<DateTime> TimeList = new List<DateTime>()
        {
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 08, 30, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 09, 30, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 30, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 00, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 59, 30),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 00, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 05, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 14, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 15, 00),
             new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 20, 00),
        };
        List<string> PhraseList = new List<string>() { "Markets Open", "Grains Open", "Snack Time!", "Report", "Meat Close", "Done", "Meat Markets Closed", "Grain Close", "No Filter" };
        List<string> SoundOrder = new List<string>();

        DateTime FindTime { get { for (int i = 0; i < TimeList.Count; i++) { if (TimeList[i] > DateTime.Now) return TimeList[i]; } return TimeList[TimeList.Count - 1]; } }
        int TimerIndex { get { if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && TimeList.IndexOf(CurrentTimer) == 1) return 10; return TimeList.IndexOf(CurrentTimer); } }
        public DateTime FindPriorTimer
        {
            get
            {
                int i = TimeList.IndexOf(CurrentTimer) - 1;
                if (i == 3 && !Properties.Settings.Default.Report) i = 2;
                if (i == 2 && !Properties.Settings.Default.SnackTime) i = 1;
                if (i == 1 && !Properties.Settings.Default.GrainOpening) i = 0;
                if (i > -1) return TimeList[i];
                else return TimeList[0];
            }
        }
        public void Init(Form1 f1) { MainForm = f1; PhraseList.Add("Good Night!"); PhraseList.Add("Happy Friday!"); SetUpTimer(); }
        private void SetUpTimer()
        {
            SoundOrder.Clear(); CurrentTimer = FindTime;
            foreach (int i in secondTimers) if (CurrentTimer.Subtract(new TimeSpan(0, 0, i)) >= DateTime.Now) { DateTime timer = CurrentTimer.Subtract(new TimeSpan(0, 0, i)); Task.Factory.StartNew(() => ScheduleTimer(TimerLapse, timer)); SoundOrder.Add(i + " seconds.mp3"); }
            if (CurrentTimer.TimeOfDay != new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 30, 00).TimeOfDay)
                foreach (int i in minuteTimers) if (CurrentTimer.Subtract(new TimeSpan(0, i, 0)) > DateTime.Now) { DateTime timer = CurrentTimer.Subtract(new TimeSpan(0, i, 0)); Task.Factory.StartNew(() => ScheduleTimer(TimerLapse, timer)); SoundOrder.Add(i + " minutes.mp3"); }
        }
        public async void ScheduleTimer(Action action, DateTime ExecutionTime) { try { await Task.Delay((int)ExecutionTime.Subtract(DateTime.Now).TotalMilliseconds); action(); } catch (Exception e) { } }
        void TimerLapse()
        {
            string sound = SoundOrder[SoundOrder.Count - 1]; SoundOrder.RemoveAt(SoundOrder.Count - 1);
            if (CorrectSettings && !Properties.Settings.Default.HalfDay && Properties.Settings.Default.Sounds)
            {
                string FileName = @"C:\Users\" + System.Environment.UserName + @"\Documents\KDM\Sounds\" + Properties.Settings.Default.SoundType + @"\" + sound;
                if (sound == "0 seconds.mp3")
                {
                    MainForm.Countdown(PhraseList[TimerIndex]);
                    FileName = @"C:\Users\" + System.Environment.UserName + @"\Documents\KDM\Sounds\Buzzers\" + Properties.Settings.Default.SoundType + @"\" + "Buzzer " + TimerIndex.ToString() + ".mp3";
                    GC.Collect(); GC.WaitForPendingFinalizers();
                    SetUpTimer();
                }
                else { MainForm.Countdown(sound.Substring(0, sound.Length - 4)); }
                Mp3FileReader reader = new Mp3FileReader(FileName); var waveOut = new WaveOut(); waveOut.Init(reader); waveOut.Volume = Properties.Settings.Default.Volume; waveOut.Play();
            }
            else if (Properties.Settings.Default.HalfDay) { if (sound == "0 seconds.mp3") { SetUpTimer(); MainForm.Countdown(PhraseList[TimerIndex]); } else MainForm.Countdown(sound.Substring(0, sound.Length - 4)); }
            else { if (sound == "0 seconds.mp3") SetUpTimer(); }
        }
        bool CorrectSettings
        {
            get
            {
                if (CurrentTimer == new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 00, 00))
                    if (Properties.Settings.Default.Report) return true; else return false;
                else if (CurrentTimer == new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 00))
                    if (Properties.Settings.Default.GrainOpening) return true; else return false;
                else if (CurrentTimer == new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 30, 00))
                    if (Properties.Settings.Default.SnackTime) return true; else return false;
                else return true;
            }
        }
    }
}
