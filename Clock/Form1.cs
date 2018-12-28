using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        //BUILD CONFIGS
        void CheckForConfigs()
        {
            if (!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\KDM\")) Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\KDM\");
            if (!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\KDM\Config\")) Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\KDM\Config\");
        }


        private bool mouseDown; private Point lastLocation;
        private void LocationMouseDown(object sender, MouseEventArgs e) { mouseDown = true; lastLocation = e.Location; }
        private void LocationMouseMove(object sender, MouseEventArgs e) { if (mouseDown) { this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); this.Update(); NotificationPlacement(); } }
        private void LocationMouseUp(object sender, MouseEventArgs e)        {            mouseDown = false;NotificationPlacement();            Properties.Settings.Default.Location = Location;        }
        private bool dragging = false; private Point dragCursorPoint; private Point dragFormPoint;
        private void Size_MouseDown(object sender, MouseEventArgs e) { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; }
        private void Size_MouseMove(object sender, MouseEventArgs e) { if (dragging) { Point dif = Point.Subtract(Cursor.Position, new Size(dragFormPoint)); this.Size = new Size(dif); NotificationPlacement(); } }
        private void Size_MouseUp(object sender, MouseEventArgs e) { dragging = false; Properties.Settings.Default.Size = Size; }
        private void Form1_MouseHover(object sender, EventArgs e) => HoverTrigger();
        public void HoverTrigger() { CurrentTimerPanel.Visible = true; ControlPanel.Visible = true; ResizePanel.Visible = true; QuickPanel.Visible = true; HoverTimer.Start(); }
        private void HoverTimer_Tick(object sender, EventArgs e) { if (!ClientRectangle.Contains(PointToClient(Control.MousePosition)) && Control.MouseButtons != MouseButtons.Left && !SettingsMenu.Visible) { QuickPanel.Visible = false; ControlPanel.Visible = false; CurrentTimerPanel.Visible = false; ResizePanel.Visible = false; HoverTimer.Stop(); } }
        public List<Notification> NoteList = new List<Notification>();               /*         NOTIFICATION CODES        0 = LOGO        1 = WARNING        2 = DATE        3 = EVENT        4 = BDAY        5 = SUNNY        6 = CLOUDY        7 = PARTLY CLOUDY        8 = RAIN        9 = SNOW        10 = FOG        11 = THUNDER        */
        public void BuildNotification(string text, int time, int icon) { if (Properties.Settings.Default.Popups && text != "") { Notification N = new Notification(); N.StartPosition = FormStartPosition.Manual; NoteList.Add(N); N.Show(); NotificationPlacement(); N.Init(this, text, time, icon, BackColor, ForeColor);  } }
        public void NotificationPlacement() { int Stacker = 5; while (NoteList.Count > 3) { Notification N = NoteList[0]; N.DisposeLogic(); } for (int i = NoteList.Count - 1; i >= 0; i--) { Notification N = NoteList[i]; if (N.Visible) { N.Width = Width; var screen = Screen.FromPoint(Location); N.Location = new Point(Location.X, Location.Y - N.Height - Stacker); Stacker += N.Height + 5; } } }
        private void DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e) { if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked) e.Cancel = true; }

        public async void ScheduleTimer(Action action, DateTime ExecutionTime) { try { await Task.Delay((int)ExecutionTime.Subtract(DateTime.Now).TotalMilliseconds); action(); } catch (Exception e) { } }

        public Form1() => InitializeComponent();
        HDCountdowns HDCDs;
        Countdowns CDs;
        Weather Weth;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed) versionToolStripMenuItem.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            Location = Properties.Settings.Default.Location;
            Size = Properties.Settings.Default.Size;
            countdownDisplayToolStripMenuItem.Checked = Properties.Settings.Default.CountdownDisplay;
            popupsToolStripMenuItem.Checked = Properties.Settings.Default.Popups;
            soundsToolStripMenuItem.Checked = Properties.Settings.Default.Sounds;
            grainOpenToolStripMenuItem.Checked = Properties.Settings.Default.GrainOpening;
            snackTimeToolStripMenuItem.Checked = Properties.Settings.Default.SnackTime;
            reportToolStripMenuItem.Checked = Properties.Settings.Default.Report;
            halfDayToolStripMenuItem.Checked = Properties.Settings.Default.HalfDay;
            TopMost = topMostToolStripMenuItem.Checked = Properties.Settings.Default.TopMost;
            ProgressBar.Visible = progressBarToolStripMenuItem.Checked = Properties.Settings.Default.ProgressBar;
            hourFormatToolStripMenuItem.Checked = Properties.Settings.Default.HourFormat;
            weeklyHighlightsToolStripMenuItem.Checked = Properties.Settings.Default.WeeklyHighlights;
            if (Properties.Settings.Default.WeeklyHighlights && DateTime.Now.DayOfWeek == DayOfWeek.Monday) { Random rnd = new Random(); Properties.Settings.Default.HighlightColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); }
            if (Properties.Settings.Default.SoundType == 1) type1ToolStripMenuItem.Checked = true; else type2ToolStripMenuItem.Checked = true;
            VolumeBox.Text = (Properties.Settings.Default.Volume * 100).ToString();

            soundsToolStripMenuItem.DropDown.Closing += DropDown_Closing;
            colorPresetsToolStripMenuItem.DropDown.Closing += DropDown_Closing;

            BuildNotification(BDayNotificationTexts(), 300000, 4);
            BuildNotification(DateTime.Now.ToString("dddd, MMMM dd yyyy"), 300000, 2);
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday) BuildNotification("HAPPY FRIDAY!", 300000, 3);

            HDCDs = new HDCountdowns(); HDCDs.Init(this); CDs = new Countdowns(); CDs.Init(this);
            Weth = new Weather(); Weth.DownloadWeather("Chicago"); BuildNotification(Weth.GetCityWeather(), 300000, Weth.WeatherIcon());

            CheckForConfigs();
            ScheduleTimer(EODWeather, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 20, 00));
            Startup = DateTime.Now;
        }
        void EODWeather() { Weth.DownloadWeather("Chicago"); BuildNotification(Weth.GetCityWeather(), 1000000000, Weth.WeatherIcon()); }


        string BDayNotificationTexts()
        {
            if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 6, 11)) return "HAPPY BIRTHDAY JEFF!"; //611
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 6, 29)) return "HAPPY BIRTHDAY CLINT!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 7, 20)) return "HAPPY BIRTHDAY JOE!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 8, 7)) return "HAPPY BIRTHDAY TOM!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 8, 18)) return "HAPPY BIRTHDAY KEVIN!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 8, 22)) return "HAPPY BIRTHDAY WILLIAM!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 10, 26)) return "HAPPY BIRTHDAY ANNIE!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 2, 28)) return "HAPPY BIRTHDAY DAN!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 5, 15)) return "HAPPY BIRTHDAY DOUG!";
            else if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 3, 29)) return "HAPPY BIRTHDAY MARK!";
            else return "";
        }

        public void Countdown(string Time)
        {
            if (Properties.Settings.Default.CountdownDisplay)
            {

                BeginInvoke(new MethodInvoker(delegate
                {
                    BuildNotification(Time, 5000, 0);
                }));

                //ChokeCount = 10;
                //TimeLabel.Invoke((MethodInvoker)(() => TimeLabel.Text = Time));
                //SizeText(TimeLabel);
                MoveProgressBar();
            }
        }
        int ChokeCount = 0;
        private void MainTime_Tick(object sender, EventArgs e) { if (ChokeCount > 0) { ChokeCount--; return; } if (Properties.Settings.Default.HourFormat) TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss"); else TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss"); SizeText(TimeLabel); MoveProgressBar(); if (Properties.Settings.Default.HalfDay) CurrentTimerLabel.Text = HDCDs.CurrentTimer.ToString("HH:mm:ss"); else CurrentTimerLabel.Text = CDs.CurrentTimer.ToString("HH:mm:ss"); }
        void SizeText(Label lbl)
        {
            try
            {
                string txt = lbl.Text;
                if (txt.Length > 0)
                {
                    int best_size = 200; int wid = TimeLabel.DisplayRectangle.Width - 5; int hgt = TimeLabel.DisplayRectangle.Height;
                    using (Graphics gr = lbl.CreateGraphics())
                    {
                        for (int i = 1; i <= 200; i++)
                        {
                            using (Font test_font = new Font(lbl.Font.FontFamily, i))
                            {
                                SizeF text_size = gr.MeasureString(txt, test_font);
                                if ((text_size.Width > wid) || (text_size.Height > hgt)) { best_size = i - 1; break; }
                            }
                        }
                    }
                    lbl.Font = new Font(lbl.Font.FontFamily, best_size);
                }
            }
            catch { }
        }

        private void ReportButton_Click(object sender, EventArgs e) { reportToolStripMenuItem.PerformClick(); }
        private void HalfdayButton_Click(object sender, EventArgs e) { halfDayToolStripMenuItem.PerformClick(); }
        private void SettingsButton_Click(object sender, EventArgs e) => SettingsMenu.Show(Cursor.Position);
        private void SettingsMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e) { if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked) e.Cancel = true; }
        private void CloseButton_Click(object sender, EventArgs e) { Properties.Settings.Default.Save(); Application.Exit(); }

        string ReleaseNotes = @"C:\Users\" + Environment.UserName + @"\Documents\KDM\Config\Clock-ReleaseNotes.txt";
        private void versionToolStripMenuItem_Click(object sender, EventArgs e) { if (ApplicationDeployment.IsNetworkDeployed) { string path = Directory.GetCurrentDirectory(); File.Copy(System.IO.Path.Combine(path, "ReleaseNotes - Clock.txt"), ReleaseNotes, true); Process.Start("notepad.exe", ReleaseNotes); } }
        private void soundsToolStripMenuItem_Click(object sender, EventArgs e) { soundsToolStripMenuItem.Checked = Properties.Settings.Default.Sounds ^= true; }
        private void grainOpenToolStripMenuItem_Click(object sender, EventArgs e) { grainOpenToolStripMenuItem.Checked = Properties.Settings.Default.GrainOpening ^= true; }
        private void snackTimeToolStripMenuItem_Click(object sender, EventArgs e) { snackTimeToolStripMenuItem.Checked = Properties.Settings.Default.SnackTime ^= true; }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e) { reportToolStripMenuItem.Checked = Properties.Settings.Default.Report ^= true; if (Properties.Settings.Default.Report) ReportButton.BackColor = Properties.Settings.Default.HighlightColor; else ReportButton.BackColor = Properties.Settings.Default.BackColor; }
        private void halfDayToolStripMenuItem_Click(object sender, EventArgs e) { halfDayToolStripMenuItem.Checked = Properties.Settings.Default.HalfDay ^= true; if (Properties.Settings.Default.HalfDay) HalfdayButton.BackColor = Properties.Settings.Default.HighlightColor; else HalfdayButton.BackColor = Properties.Settings.Default.BackColor; }
        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e) { ProgressBar.Visible = progressBarToolStripMenuItem.Checked = Properties.Settings.Default.ProgressBar ^= true; }
        private void hourFormatToolStripMenuItem_Click(object sender, EventArgs e) { hourFormatToolStripMenuItem.Checked = Properties.Settings.Default.HourFormat ^= true; }
        private void topMostToolStripMenuItem_Click(object sender, EventArgs e) { TopMost = topMostToolStripMenuItem.Checked = Properties.Settings.Default.TopMost ^= true; foreach (Notification N in NoteList) N.TopMost = Properties.Settings.Default.TopMost; }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e) { Properties.Settings.Default.Reset(); Properties.Settings.Default.Save(); Application.Exit(); }
        private void popupsToolStripMenuItem_Click(object sender, EventArgs e) { popupsToolStripMenuItem.Checked = Properties.Settings.Default.Popups ^= true; }
        private void showWeatherToolStripMenuItem_Click(object sender, EventArgs e) { Weth.DownloadWeather("Chicago"); BuildNotification(Weth.GetCityWeather(), 3600000, Weth.WeatherIcon()); WeatherUpdateTimer.Start(); }
        private void WeatherUpdateTimer_Tick(object sender, EventArgs e) { if (Properties.Settings.Default.Popups && NoteList.Count > 0) { Weth.DownloadWeather("Chicago"); BuildNotification(Weth.GetCityWeather(), 3600000, Weth.WeatherIcon()); } else WeatherUpdateTimer.Stop(); }
        private void weeklyHighlightsToolStripMenuItem_Click(object sender, EventArgs e) { weeklyHighlightsToolStripMenuItem.Checked = Properties.Settings.Default.WeeklyHighlights ^= true; }
        private void type1ToolStripMenuItem_Click(object sender, EventArgs e) { type1ToolStripMenuItem.Checked = true; type2ToolStripMenuItem.Checked = false; Properties.Settings.Default.SoundType = 1; }
        private void type2ToolStripMenuItem_Click(object sender, EventArgs e) { type2ToolStripMenuItem.Checked = true; type1ToolStripMenuItem.Checked = false; Properties.Settings.Default.SoundType = 2; }
        private void backColorToolStripMenuItem_Click(object sender, EventArgs e) { int i = ColorPicker(); if (i != 0) BackColor = Properties.Settings.Default.BackColor = Color.FromArgb(i); }
        private void highlightColorToolStripMenuItem_Click(object sender, EventArgs e) { int i = ColorPicker(); if (i != 0) Properties.Settings.Default.HighlightColor = Color.FromArgb(i); if (Properties.Settings.Default.Report) ReportButton.BackColor = Properties.Settings.Default.HighlightColor; else ReportButton.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor); if (Properties.Settings.Default.HalfDay) HalfdayButton.BackColor = Properties.Settings.Default.HighlightColor; else HalfdayButton.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor); }
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e) { int i = ColorPicker(); if (i != 0) ForeColor = Properties.Settings.Default.TextColor = Color.FromArgb(i); foreach (Notification N in NoteList) { N.ColorChange(BackColor, ForeColor); } }
        private void countdownDisplayToolStripMenuItem_Click(object sender, EventArgs e) { countdownDisplayToolStripMenuItem.Checked = Properties.Settings.Default.CountdownDisplay ^= true; }

        ColorDialog ColorDialog = new ColorDialog() { AllowFullOpen = true, ShowHelp = true, Color = Color.Black, };
        int ColorPicker()
        {
            ColorDialog.CustomColors = GetSustomColors();
            if (ColorDialog.ShowDialog() == DialogResult.OK) { SaveCustomColors(ColorDialog.CustomColors); return ColorDialog.Color.ToArgb(); }
            else return 0;
        }
        string ColorPath = @"C:\Users\" + Environment.UserName + @"\Documents\KDM\Config\KDM-Colors.txt";
        int[] GetSustomColors()
        {
            try
            {
                List<string> list = File.ReadLines(ColorPath).ToList(); List<int> CustomColors = new List<int>();
                for (int i = 0; i < list.Count; i++) CustomColors.Add(Convert.ToInt32(list[i]));
                return CustomColors.ToArray();
            }
            catch { BuildNotification("Path Corrupt : " + ColorPath, 2000, 1); return null; }
        }
        void SaveCustomColors(int[] list) { try { using (TextWriter tw = new StreamWriter(ColorPath)) for (int i = 0; i < list.Length; i++) tw.WriteLine(list[i]); } catch { BuildNotification("Path Missing? : " + ColorPath, 2000, 1); return; } }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e) { BackColor = Properties.Settings.Default.BackColor = SystemColors.ControlDarkDark; ForeColor = Properties.Settings.Default.TextColor = SystemColors.ButtonHighlight; Properties.Settings.Default.HighlightColor = ControlPaint.DarkDark(SystemColors.ControlDarkDark); }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e) { BackColor = Properties.Settings.Default.BackColor = SystemColors.ControlLight; ForeColor = Properties.Settings.Default.TextColor = SystemColors.ControlDarkDark; Properties.Settings.Default.HighlightColor = SystemColors.Control; }
        private void blendToolStripMenuItem_Click(object sender, EventArgs e) { BackColor = Properties.Settings.Default.BackColor = ControlPaint.Dark(SystemColors.Desktop); ForeColor = Properties.Settings.Default.TextColor = ControlPaint.LightLight(SystemColors.Desktop); Properties.Settings.Default.HighlightColor = ControlPaint.Light(SystemColors.Desktop); }
        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = ControlPaint.Dark(ForeColor); TransparencyKey = ControlPaint.Dark(ForeColor); transparentToolStripMenuItem.Checked = Properties.Settings.Default.Transparent = AllowTransparency = true;
            foreach (Notification N in NoteList) { N.ColorChange(ControlPaint.Dark(ForeColor), ForeColor); N.TransparencyKey = ControlPaint.Dark(ForeColor); }
        }

        private void Form1_BackColorChanged(object sender, EventArgs e)
        {
            transparentToolStripMenuItem.Checked = Properties.Settings.Default.Transparent = AllowTransparency = false; foreach (Notification N in NoteList) { N.ColorChange(BackColor, ForeColor); }
            QuickPanel.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor); ResizePanel.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor); ControlPanel.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor); CurrentTimerPanel.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor);
            if (QuickPanel.BackColor.R + QuickPanel.BackColor.B + QuickPanel.BackColor.G < 382)
            {
                CloseButton.BackgroundImage = Properties.Resources.CloseWhite;
                SettingsButton.BackgroundImage = Properties.Resources.SettingsWhite;
                MoveButton.BackgroundImage = Properties.Resources.MoveWhite;
                ResizeButton.BackgroundImage = Properties.Resources.New_Resize_White;
                ReportButton.ForeColor = Color.White; HalfdayButton.ForeColor = Color.White;
            }
            else
            {
                CloseButton.BackgroundImage = Properties.Resources.CloseBlack;
                SettingsButton.BackgroundImage = Properties.Resources.SettingsBlack;
                MoveButton.BackgroundImage = Properties.Resources.MoveBlack;
                ResizeButton.BackgroundImage = Properties.Resources.New_Resize_Black;
                ReportButton.ForeColor = Color.Black; HalfdayButton.ForeColor = Color.Black;
            }
            if (Properties.Settings.Default.Report) ReportButton.BackColor = Properties.Settings.Default.HighlightColor; else ReportButton.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor);
            if (Properties.Settings.Default.HalfDay) HalfdayButton.BackColor = Properties.Settings.Default.HighlightColor; else HalfdayButton.BackColor = ControlPaint.Light(Properties.Settings.Default.BackColor);
        }

        TimeSpan TotalTime = new TimeSpan();
        DateTime ProgressEndTime;
        DateTime ProgressStartTime;
        DateTime Startup;
        void MoveProgressBar()
        {
            try
            {
                if (Properties.Settings.Default.HalfDay) { ProgressStartTime = HDCDs.FindPriorTimer; ProgressEndTime = HDCDs.CurrentTimer; }
                else { ProgressStartTime = CDs.FindPriorTimer; ProgressEndTime = CDs.CurrentTimer; } if (ProgressStartTime == new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 08, 30, 00)) ProgressStartTime = Startup;

                TimeSpan CurrentTime = new TimeSpan();
                TotalTime = ProgressEndTime - ProgressStartTime;
                CurrentTime = ProgressEndTime - DateTime.Now;

                int lbWIDTH = ProgressBar.Width;
                int lbHEIGHT = ProgressBar.Height;
                double lbUnit = lbWIDTH / 100.0;
                Bitmap bmp = new Bitmap(lbWIDTH, lbHEIGHT);

                ProgressBar.Image = null;

                Graphics g = Graphics.FromImage(bmp);
                g.Clear(BackColor);
                double d = (((CurrentTime.TotalMinutes / TotalTime.TotalMinutes) * 100) - 100) * -1;
                int t = 0;
                t = Convert.ToInt32(d * lbUnit);

                if (t > 0)
                {
                    Brush LoadingFront = new SolidBrush(Properties.Settings.Default.HighlightColor);
                    g.FillRectangle(LoadingFront, new Rectangle(0, 0, t, lbHEIGHT));
                    ProgressBar.Image = bmp;
                }
            }
            catch
            {

            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Transparent) { ForeColor = Properties.Settings.Default.TextColor; BackColor = Properties.Settings.Default.BackColor; transparentToolStripMenuItem.PerformClick(); }
            else { ForeColor = Properties.Settings.Default.TextColor; BackColor = Properties.Settings.Default.BackColor; }
        }

        private void volumeToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Volume = (float.Parse(VolumeBox.Text) / 100);
        }

        private void VolumeBox_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Volume = (float.Parse(VolumeBox.Text) / 100);
        }
    }
}
