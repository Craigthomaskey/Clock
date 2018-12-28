using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Notification : Form
    {
        /* 
        NOTIFICATION CODES
        0 = LOGO
        1 = WARNING
        2 = DATE
        3 = EVENT
        4 = BDAY
        5 = SUNNY
        6 = CLOUDY
        7 = PARTLY CLOUDY
        8 = RAIN
        9 = SNOW
        10 = FOG
        11 = THUNDER
        */


        Form1 MainForm;
        int Icon = 0;
        public Notification() => InitializeComponent();
        public void Init(Form1 f, string s, int time, int icon, Color BGC, Color FC)
        {
            Icon = icon; ColorChange(BGC, FC); 
            ShowInTaskbar = false; BringToFront(); TopMost = Properties.Settings.Default.TopMost;
            MainForm = f; MainLabel.Text = s;
          DisplayTimer.Interval = time;
        }
        private void Notification_Load(object sender, EventArgs e) {  DisplayTimer.Start(); }
        private void ShowControls_MouseHover(object sender, EventArgs e) { CloseButton.Visible = true; HoverTimer.Start(); }
        private void HoverTimer_Tick(object sender, EventArgs e) { if (!ClientRectangle.Contains(PointToClient(Control.MousePosition)) && Control.MouseButtons != MouseButtons.Left) { CloseButton.Visible = false; HoverTimer.Stop(); } }
        private void DisplayTimer_Tick(object sender, EventArgs e) => DisposeLogic();
        private void CloseButton_Click(object sender, EventArgs e) { HoverTimer.Stop(); DisposeLogic(); }
        public void DisposeLogic() { MainForm.NoteList.Remove(this); MainForm.NotificationPlacement(); Dispose(); }
        public void ColorChange(Color BGC, Color FC)
        {

            ForeColor = FC;

            if (Properties.Settings.Default.Transparent)
            {
                BackColor = ControlPaint.Dark(ForeColor);
                TransparencyKey = ControlPaint.Dark(ForeColor);
                AllowTransparency = true;
            }
            else
            {
                AllowTransparency = false;
                BackColor = BGC;
            }


            if (ForeColor.R + ForeColor.B + ForeColor.G > 382)
            {
                MainLabel.ForeColor = FC; CloseButton.BackgroundImage = Properties.Resources.CloseWhite;
                if (Icon == 1) SideImage.Image = Properties.Resources.WarningWhite;
                else if (Icon == 2) SideImage.Image = Properties.Resources.DateWhite;
                else if (Icon == 3) SideImage.Image = Properties.Resources.EventWhite;
                else if (Icon == 4) SideImage.Image = Properties.Resources.BDayWhite;
                else if (Icon == 5) SideImage.Image = Properties.Resources.SunnyWhite;
                else if (Icon == 6) SideImage.Image = Properties.Resources.CloudyWhite;
                else if (Icon == 7) SideImage.Image = Properties.Resources.PArtlyCloudyWhite;
                else if (Icon == 8) SideImage.Image = Properties.Resources.RainWhite;
                else if (Icon == 9) SideImage.Image = Properties.Resources.SnowWhite;
                else if (Icon == 10) SideImage.Image = Properties.Resources.FogWhite;
                else if (Icon == 11) SideImage.Image = Properties.Resources.ThunderWhite;
                else SideImage.Image = Properties.Resources.LogoWhite;
            }
            else
            {
                MainLabel.ForeColor = FC; CloseButton.BackgroundImage = Properties.Resources.CloseBlack;
                if (Icon == 1) SideImage.Image = Properties.Resources.WarningBlack;
                else if (Icon == 2) SideImage.Image = Properties.Resources.DateBlack;
                else if (Icon == 3) SideImage.Image = Properties.Resources.EventBlack;
                else if (Icon == 4) SideImage.Image = Properties.Resources.BDayBlack;
                else if (Icon == 5) SideImage.Image = Properties.Resources.SunnyBlack;
                else if (Icon == 6) SideImage.Image = Properties.Resources.CloudyBlack;
                else if (Icon == 7) SideImage.Image = Properties.Resources.PartlyCloudyBlack;
                else if (Icon == 8) SideImage.Image = Properties.Resources.RainBlack;
                else if (Icon == 9) SideImage.Image = Properties.Resources.SnowBlack;
                else if (Icon == 10) SideImage.Image = Properties.Resources.FogBlack;
                else if (Icon == 11) SideImage.Image = Properties.Resources.ThunderBlack;
                else SideImage.Image = Properties.Resources.LogoBlack;
            }
        }




    }
}
