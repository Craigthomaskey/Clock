namespace Clock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ResizePanel = new System.Windows.Forms.Panel();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.QuickPanel = new System.Windows.Forms.Panel();
            this.HalfdayButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SettingsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.soundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grainOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snackTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyHighlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWeatherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hourFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countdownDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoverTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTime = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar = new System.Windows.Forms.PictureBox();
            this.CurrentTimerPanel = new System.Windows.Forms.Panel();
            this.CurrentTimerLabel = new System.Windows.Forms.Label();
            this.WeatherUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolumeBox = new System.Windows.Forms.ToolStripComboBox();
            this.ResizePanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.QuickPanel.SuspendLayout();
            this.SettingsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.CurrentTimerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.Location = new System.Drawing.Point(10, 10);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 125);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "12:00:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLabel.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // ResizePanel
            // 
            this.ResizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResizePanel.Controls.Add(this.ResizeButton);
            this.ResizePanel.Location = new System.Drawing.Point(190, 115);
            this.ResizePanel.Name = "ResizePanel";
            this.ResizePanel.Size = new System.Drawing.Size(30, 30);
            this.ResizePanel.TabIndex = 13;
            this.ResizePanel.Visible = false;
            // 
            // ResizeButton
            // 
            this.ResizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResizeButton.BackgroundImage = global::Clock.Properties.Resources.New_Resize_Black;
            this.ResizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResizeButton.FlatAppearance.BorderSize = 0;
            this.ResizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ResizeButton.Location = new System.Drawing.Point(6, 5);
            this.ResizeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(20, 22);
            this.ResizeButton.TabIndex = 11;
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Size_MouseDown);
            this.ResizeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Size_MouseMove);
            this.ResizeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Size_MouseUp);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.Controls.Add(this.CloseButton);
            this.ControlPanel.Controls.Add(this.SettingsButton);
            this.ControlPanel.Controls.Add(this.MoveButton);
            this.ControlPanel.Location = new System.Drawing.Point(137, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(83, 38);
            this.ControlPanel.TabIndex = 14;
            this.ControlPanel.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::Clock.Properties.Resources.CloseBlack;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(56, 8);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 22);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = global::Clock.Properties.Resources.SettingsBlack;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Location = new System.Drawing.Point(32, 6);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(17, 25);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.BackgroundImage = global::Clock.Properties.Resources.MoveBlack;
            this.MoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveButton.FlatAppearance.BorderSize = 0;
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MoveButton.Location = new System.Drawing.Point(7, 8);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(20, 22);
            this.MoveButton.TabIndex = 4;
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocationMouseDown);
            this.MoveButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LocationMouseMove);
            this.MoveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LocationMouseUp);
            // 
            // QuickPanel
            // 
            this.QuickPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuickPanel.Controls.Add(this.HalfdayButton);
            this.QuickPanel.Controls.Add(this.ReportButton);
            this.QuickPanel.Location = new System.Drawing.Point(0, 116);
            this.QuickPanel.Name = "QuickPanel";
            this.QuickPanel.Size = new System.Drawing.Size(163, 30);
            this.QuickPanel.TabIndex = 15;
            this.QuickPanel.Visible = false;
            // 
            // HalfdayButton
            // 
            this.HalfdayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HalfdayButton.Location = new System.Drawing.Point(84, 3);
            this.HalfdayButton.Name = "HalfdayButton";
            this.HalfdayButton.Size = new System.Drawing.Size(75, 23);
            this.HalfdayButton.TabIndex = 16;
            this.HalfdayButton.Text = "Half Day";
            this.HalfdayButton.UseVisualStyleBackColor = true;
            this.HalfdayButton.Click += new System.EventHandler(this.HalfdayButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Location = new System.Drawing.Point(5, 3);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(75, 23);
            this.ReportButton.TabIndex = 16;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.toolStripSeparator1,
            this.soundsToolStripMenuItem,
            this.volumeToolStripMenuItem,
            this.grainOpenToolStripMenuItem,
            this.snackTimeToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.halfDayToolStripMenuItem,
            this.toolStripSeparator3,
            this.backColorToolStripMenuItem,
            this.highlightColorToolStripMenuItem,
            this.weeklyHighlightsToolStripMenuItem,
            this.textColorToolStripMenuItem,
            this.colorPresetsToolStripMenuItem,
            this.toolStripSeparator2,
            this.progressBarToolStripMenuItem,
            this.popupsToolStripMenuItem,
            this.hourFormatToolStripMenuItem,
            this.countdownDisplayToolStripMenuItem,
            this.topMostToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.ShowCheckMargin = true;
            this.SettingsMenu.ShowImageMargin = false;
            this.SettingsMenu.Size = new System.Drawing.Size(182, 440);
            this.SettingsMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.SettingsMenu_Closing);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // soundsToolStripMenuItem
            // 
            this.soundsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.type1ToolStripMenuItem,
            this.type2ToolStripMenuItem});
            this.soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            this.soundsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.soundsToolStripMenuItem.Text = "Sounds";
            this.soundsToolStripMenuItem.Click += new System.EventHandler(this.soundsToolStripMenuItem_Click);
            // 
            // type1ToolStripMenuItem
            // 
            this.type1ToolStripMenuItem.Name = "type1ToolStripMenuItem";
            this.type1ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.type1ToolStripMenuItem.Text = "Type 1";
            this.type1ToolStripMenuItem.Click += new System.EventHandler(this.type1ToolStripMenuItem_Click);
            // 
            // type2ToolStripMenuItem
            // 
            this.type2ToolStripMenuItem.Name = "type2ToolStripMenuItem";
            this.type2ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.type2ToolStripMenuItem.Text = "Type 2";
            this.type2ToolStripMenuItem.Click += new System.EventHandler(this.type2ToolStripMenuItem_Click);
            // 
            // grainOpenToolStripMenuItem
            // 
            this.grainOpenToolStripMenuItem.Name = "grainOpenToolStripMenuItem";
            this.grainOpenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.grainOpenToolStripMenuItem.Text = "Grain Open";
            this.grainOpenToolStripMenuItem.Click += new System.EventHandler(this.grainOpenToolStripMenuItem_Click);
            // 
            // snackTimeToolStripMenuItem
            // 
            this.snackTimeToolStripMenuItem.Name = "snackTimeToolStripMenuItem";
            this.snackTimeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.snackTimeToolStripMenuItem.Text = "Snack Time";
            this.snackTimeToolStripMenuItem.Click += new System.EventHandler(this.snackTimeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // halfDayToolStripMenuItem
            // 
            this.halfDayToolStripMenuItem.Name = "halfDayToolStripMenuItem";
            this.halfDayToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.halfDayToolStripMenuItem.Text = "Half Day";
            this.halfDayToolStripMenuItem.Click += new System.EventHandler(this.halfDayToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.backColorToolStripMenuItem.Text = "Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // highlightColorToolStripMenuItem
            // 
            this.highlightColorToolStripMenuItem.Name = "highlightColorToolStripMenuItem";
            this.highlightColorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.highlightColorToolStripMenuItem.Text = "Highlight Color";
            this.highlightColorToolStripMenuItem.Click += new System.EventHandler(this.highlightColorToolStripMenuItem_Click);
            // 
            // weeklyHighlightsToolStripMenuItem
            // 
            this.weeklyHighlightsToolStripMenuItem.Name = "weeklyHighlightsToolStripMenuItem";
            this.weeklyHighlightsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.weeklyHighlightsToolStripMenuItem.Text = "Weekly Highlights";
            this.weeklyHighlightsToolStripMenuItem.Click += new System.EventHandler(this.weeklyHighlightsToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // colorPresetsToolStripMenuItem
            // 
            this.colorPresetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.blendToolStripMenuItem,
            this.transparentToolStripMenuItem});
            this.colorPresetsToolStripMenuItem.Name = "colorPresetsToolStripMenuItem";
            this.colorPresetsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.colorPresetsToolStripMenuItem.Text = "Color Presets";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // blendToolStripMenuItem
            // 
            this.blendToolStripMenuItem.Name = "blendToolStripMenuItem";
            this.blendToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.blendToolStripMenuItem.Text = "Blend";
            this.blendToolStripMenuItem.Click += new System.EventHandler(this.blendToolStripMenuItem_Click);
            // 
            // transparentToolStripMenuItem
            // 
            this.transparentToolStripMenuItem.Name = "transparentToolStripMenuItem";
            this.transparentToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.transparentToolStripMenuItem.Text = "Transparent";
            this.transparentToolStripMenuItem.Click += new System.EventHandler(this.transparentToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.progressBarToolStripMenuItem.Text = "Progress Bar";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // popupsToolStripMenuItem
            // 
            this.popupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWeatherToolStripMenuItem1});
            this.popupsToolStripMenuItem.Name = "popupsToolStripMenuItem";
            this.popupsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.popupsToolStripMenuItem.Text = "Popups";
            this.popupsToolStripMenuItem.Click += new System.EventHandler(this.popupsToolStripMenuItem_Click);
            // 
            // showWeatherToolStripMenuItem1
            // 
            this.showWeatherToolStripMenuItem1.Name = "showWeatherToolStripMenuItem1";
            this.showWeatherToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.showWeatherToolStripMenuItem1.Text = "Show Weather";
            this.showWeatherToolStripMenuItem1.Click += new System.EventHandler(this.showWeatherToolStripMenuItem_Click);
            // 
            // hourFormatToolStripMenuItem
            // 
            this.hourFormatToolStripMenuItem.Name = "hourFormatToolStripMenuItem";
            this.hourFormatToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hourFormatToolStripMenuItem.Text = "24 Hour Format";
            this.hourFormatToolStripMenuItem.Click += new System.EventHandler(this.hourFormatToolStripMenuItem_Click);
            // 
            // countdownDisplayToolStripMenuItem
            // 
            this.countdownDisplayToolStripMenuItem.Name = "countdownDisplayToolStripMenuItem";
            this.countdownDisplayToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.countdownDisplayToolStripMenuItem.Text = "Countdown Display";
            this.countdownDisplayToolStripMenuItem.Click += new System.EventHandler(this.countdownDisplayToolStripMenuItem_Click);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // HoverTimer
            // 
            this.HoverTimer.Interval = 1500;
            this.HoverTimer.Tick += new System.EventHandler(this.HoverTimer_Tick);
            // 
            // MainTime
            // 
            this.MainTime.Enabled = true;
            this.MainTime.Interval = 500;
            this.MainTime.Tick += new System.EventHandler(this.MainTime_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProgressBar.Location = new System.Drawing.Point(0, 0);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(220, 146);
            this.ProgressBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgressBar.TabIndex = 7;
            this.ProgressBar.TabStop = false;
            this.ProgressBar.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // CurrentTimerPanel
            // 
            this.CurrentTimerPanel.Controls.Add(this.CurrentTimerLabel);
            this.CurrentTimerPanel.Location = new System.Drawing.Point(0, 0);
            this.CurrentTimerPanel.Name = "CurrentTimerPanel";
            this.CurrentTimerPanel.Size = new System.Drawing.Size(65, 23);
            this.CurrentTimerPanel.TabIndex = 14;
            this.CurrentTimerPanel.Visible = false;
            // 
            // CurrentTimerLabel
            // 
            this.CurrentTimerLabel.Location = new System.Drawing.Point(3, 2);
            this.CurrentTimerLabel.Name = "CurrentTimerLabel";
            this.CurrentTimerLabel.Size = new System.Drawing.Size(58, 18);
            this.CurrentTimerLabel.TabIndex = 0;
            this.CurrentTimerLabel.Text = "No timer";
            this.CurrentTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WeatherUpdateTimer
            // 
            this.WeatherUpdateTimer.Interval = 3600000;
            this.WeatherUpdateTimer.Tick += new System.EventHandler(this.WeatherUpdateTimer_Tick);
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VolumeBox});
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.volumeToolStripMenuItem.Text = "Volume";
            this.volumeToolStripMenuItem.DropDownClosed += new System.EventHandler(this.volumeToolStripMenuItem_DropDownClosed);
            // 
            // VolumeBox
            // 
            this.VolumeBox.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10"});
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.Size = new System.Drawing.Size(121, 23);
            this.VolumeBox.DropDownClosed += new System.EventHandler(this.VolumeBox_DropDownClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 145);
            this.Controls.Add(this.CurrentTimerPanel);
            this.Controls.Add(this.ResizePanel);
            this.Controls.Add(this.QuickPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ProgressBar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(220, 145);
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.BackColorChanged += new System.EventHandler(this.Form1_BackColorChanged);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResizePanel.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.QuickPanel.ResumeLayout(false);
            this.SettingsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.CurrentTimerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Panel ResizePanel;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Panel QuickPanel;
        private System.Windows.Forms.Button HalfdayButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ContextMenuStrip SettingsMenu;
        private System.Windows.Forms.Timer HoverTimer;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem soundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grainOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snackTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highlightColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorPresetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popupsToolStripMenuItem;
        private System.Windows.Forms.Timer MainTime;
        private System.Windows.Forms.ToolStripMenuItem weeklyHighlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWeatherToolStripMenuItem1;
        private System.Windows.Forms.PictureBox ProgressBar;
        private System.Windows.Forms.ToolStripMenuItem countdownDisplayToolStripMenuItem;
        private System.Windows.Forms.Panel CurrentTimerPanel;
        private System.Windows.Forms.Label CurrentTimerLabel;
        private System.Windows.Forms.Timer WeatherUpdateTimer;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox VolumeBox;
    }
}

