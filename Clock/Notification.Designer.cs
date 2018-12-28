namespace Clock
{
    partial class Notification
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.DisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.HoverTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.SideImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SideImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainLabel.Location = new System.Drawing.Point(41, 7);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(141, 30);
            this.MainLabel.TabIndex = 8;
            this.MainLabel.Text = "Wednesday, August 22nd 2018";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainLabel.MouseHover += new System.EventHandler(this.ShowControls_MouseHover);
            // 
            // DisplayTimer
            // 
            this.DisplayTimer.Interval = 3000;
            this.DisplayTimer.Tick += new System.EventHandler(this.DisplayTimer_Tick);
            // 
            // HoverTimer
            // 
            this.HoverTimer.Interval = 1000;
            this.HoverTimer.Tick += new System.EventHandler(this.HoverTimer_Tick);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackgroundImage = global::Clock.Properties.Resources.CloseBlack;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.Location = new System.Drawing.Point(190, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SideImage
            // 
            this.SideImage.Image = global::Clock.Properties.Resources.ThunderBlack;
            this.SideImage.Location = new System.Drawing.Point(5, 7);
            this.SideImage.Name = "SideImage";
            this.SideImage.Size = new System.Drawing.Size(30, 30);
            this.SideImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SideImage.TabIndex = 6;
            this.SideImage.TabStop = false;
            this.SideImage.MouseHover += new System.EventHandler(this.ShowControls_MouseHover);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 45);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SideImage);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.MouseHover += new System.EventHandler(this.ShowControls_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.SideImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox SideImage;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Timer DisplayTimer;
        private System.Windows.Forms.Timer HoverTimer;
    }
}