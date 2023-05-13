
namespace RealTimeMonitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.CPULabel = new MetroFramework.Controls.MetroLabel();
            this.GPULabel = new MetroFramework.Controls.MetroLabel();
            this.CPUPerfomanceBar = new MetroFramework.Controls.MetroProgressBar();
            this.ThemeToggle = new MetroFramework.Controls.MetroToggle();
            this.DarkThemeLabel = new MetroFramework.Controls.MetroLabel();
            this.LightThemeLabel = new MetroFramework.Controls.MetroLabel();
            this.GPUPerfomanceBar = new MetroFramework.Controls.MetroProgressBar();
            this.CPUPercentLabel = new MetroFramework.Controls.MetroLabel();
            this.GPUPercentLabel = new MetroFramework.Controls.MetroLabel();
            this.DetectedCPULabel = new MetroFramework.Controls.MetroLabel();
            this.CPUTempLabel = new MetroFramework.Controls.MetroLabel();
            this.GPUTempLabel = new MetroFramework.Controls.MetroLabel();
            this.CurrentTempGPULabel = new System.Windows.Forms.Label();
            this.CurrentTempCPULabel = new System.Windows.Forms.Label();
            this.DetectedGPUBox = new MetroFramework.Controls.MetroComboBox();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(20, 17);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CPULabel.Location = new System.Drawing.Point(25, 61);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(80, 19);
            this.CPULabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.CPULabel.TabIndex = 1;
            this.CPULabel.Text = "Процессор:";
            this.CPULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GPULabel.Location = new System.Drawing.Point(25, 157);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(83, 19);
            this.GPULabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.GPULabel.TabIndex = 2;
            this.GPULabel.Text = "Видеокарта:";
            this.GPULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CPUPerfomanceBar
            // 
            this.CPUPerfomanceBar.Location = new System.Drawing.Point(25, 89);
            this.CPUPerfomanceBar.Name = "CPUPerfomanceBar";
            this.CPUPerfomanceBar.Size = new System.Drawing.Size(337, 25);
            this.CPUPerfomanceBar.Step = 1;
            this.CPUPerfomanceBar.TabIndex = 3;
            // 
            // ThemeToggle
            // 
            this.ThemeToggle.AutoSize = true;
            this.ThemeToggle.DisplayStatus = false;
            this.ThemeToggle.Location = new System.Drawing.Point(299, 261);
            this.ThemeToggle.Name = "ThemeToggle";
            this.ThemeToggle.Size = new System.Drawing.Size(50, 19);
            this.ThemeToggle.Style = MetroFramework.MetroColorStyle.Purple;
            this.ThemeToggle.TabIndex = 5;
            this.ThemeToggle.Text = "Off";
            this.ThemeToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ThemeToggle.UseVisualStyleBackColor = true;
            this.ThemeToggle.CheckedChanged += new System.EventHandler(this.ThemeToggle_CheckedChanged);
            // 
            // DarkThemeLabel
            // 
            this.DarkThemeLabel.AutoSize = true;
            this.DarkThemeLabel.Location = new System.Drawing.Point(209, 261);
            this.DarkThemeLabel.Name = "DarkThemeLabel";
            this.DarkThemeLabel.Size = new System.Drawing.Size(84, 19);
            this.DarkThemeLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.DarkThemeLabel.TabIndex = 6;
            this.DarkThemeLabel.Text = "тёмная тема";
            this.DarkThemeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LightThemeLabel
            // 
            this.LightThemeLabel.AutoSize = true;
            this.LightThemeLabel.Location = new System.Drawing.Point(355, 261);
            this.LightThemeLabel.Name = "LightThemeLabel";
            this.LightThemeLabel.Size = new System.Drawing.Size(87, 19);
            this.LightThemeLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.LightThemeLabel.TabIndex = 7;
            this.LightThemeLabel.Text = "светлая тема";
            this.LightThemeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GPUPerfomanceBar
            // 
            this.GPUPerfomanceBar.Location = new System.Drawing.Point(25, 201);
            this.GPUPerfomanceBar.Name = "GPUPerfomanceBar";
            this.GPUPerfomanceBar.Size = new System.Drawing.Size(337, 25);
            this.GPUPerfomanceBar.TabIndex = 8;
            // 
            // CPUPercentLabel
            // 
            this.CPUPercentLabel.AutoSize = true;
            this.CPUPercentLabel.Location = new System.Drawing.Point(381, 95);
            this.CPUPercentLabel.Name = "CPUPercentLabel";
            this.CPUPercentLabel.Size = new System.Drawing.Size(31, 19);
            this.CPUPercentLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.CPUPercentLabel.TabIndex = 9;
            this.CPUPercentLabel.Text = "%%";
            this.CPUPercentLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GPUPercentLabel
            // 
            this.GPUPercentLabel.AutoSize = true;
            this.GPUPercentLabel.Location = new System.Drawing.Point(381, 207);
            this.GPUPercentLabel.Name = "GPUPercentLabel";
            this.GPUPercentLabel.Size = new System.Drawing.Size(31, 19);
            this.GPUPercentLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.GPUPercentLabel.TabIndex = 10;
            this.GPUPercentLabel.Text = "%%";
            this.GPUPercentLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DetectedCPULabel
            // 
            this.DetectedCPULabel.AutoSize = true;
            this.DetectedCPULabel.Location = new System.Drawing.Point(111, 61);
            this.DetectedCPULabel.Name = "DetectedCPULabel";
            this.DetectedCPULabel.Size = new System.Drawing.Size(15, 19);
            this.DetectedCPULabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.DetectedCPULabel.TabIndex = 11;
            this.DetectedCPULabel.Text = "?";
            this.DetectedCPULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CPUTempLabel
            // 
            this.CPUTempLabel.AutoSize = true;
            this.CPUTempLabel.Location = new System.Drawing.Point(25, 124);
            this.CPUTempLabel.Name = "CPUTempLabel";
            this.CPUTempLabel.Size = new System.Drawing.Size(91, 19);
            this.CPUTempLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.CPUTempLabel.TabIndex = 13;
            this.CPUTempLabel.Text = "Температура:";
            this.CPUTempLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GPUTempLabel
            // 
            this.GPUTempLabel.AutoSize = true;
            this.GPUTempLabel.Location = new System.Drawing.Point(25, 238);
            this.GPUTempLabel.Name = "GPUTempLabel";
            this.GPUTempLabel.Size = new System.Drawing.Size(91, 19);
            this.GPUTempLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.GPUTempLabel.TabIndex = 14;
            this.GPUTempLabel.Text = "Температура:";
            this.GPUTempLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CurrentTempGPULabel
            // 
            this.CurrentTempGPULabel.AutoSize = true;
            this.CurrentTempGPULabel.ForeColor = System.Drawing.Color.Lime;
            this.CurrentTempGPULabel.Location = new System.Drawing.Point(122, 242);
            this.CurrentTempGPULabel.Name = "CurrentTempGPULabel";
            this.CurrentTempGPULabel.Size = new System.Drawing.Size(19, 15);
            this.CurrentTempGPULabel.TabIndex = 15;
            this.CurrentTempGPULabel.Text = "40";
            // 
            // CurrentTempCPULabel
            // 
            this.CurrentTempCPULabel.AutoSize = true;
            this.CurrentTempCPULabel.ForeColor = System.Drawing.Color.Lime;
            this.CurrentTempCPULabel.Location = new System.Drawing.Point(122, 128);
            this.CurrentTempCPULabel.Name = "CurrentTempCPULabel";
            this.CurrentTempCPULabel.Size = new System.Drawing.Size(19, 15);
            this.CurrentTempCPULabel.TabIndex = 16;
            this.CurrentTempCPULabel.Text = "40";
            // 
            // DetectedGPUBox
            // 
            this.DetectedGPUBox.FormattingEnabled = true;
            this.DetectedGPUBox.ItemHeight = 23;
            this.DetectedGPUBox.Location = new System.Drawing.Point(111, 154);
            this.DetectedGPUBox.Name = "DetectedGPUBox";
            this.DetectedGPUBox.Size = new System.Drawing.Size(301, 29);
            this.DetectedGPUBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.DetectedGPUBox.TabIndex = 17;
            this.DetectedGPUBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DetectedGPUBox.SelectedIndexChanged += new System.EventHandler(this.DetectedGPUBox_SelectedIndexChanged);
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.ControlBox = false;
            this.Controls.Add(this.DetectedGPUBox);
            this.Controls.Add(this.CurrentTempCPULabel);
            this.Controls.Add(this.CurrentTempGPULabel);
            this.Controls.Add(this.GPUTempLabel);
            this.Controls.Add(this.CPUTempLabel);
            this.Controls.Add(this.DetectedCPULabel);
            this.Controls.Add(this.GPUPercentLabel);
            this.Controls.Add(this.CPUPercentLabel);
            this.Controls.Add(this.GPUPerfomanceBar);
            this.Controls.Add(this.LightThemeLabel);
            this.Controls.Add(this.DarkThemeLabel);
            this.Controls.Add(this.ThemeToggle);
            this.Controls.Add(this.CPUPerfomanceBar);
            this.Controls.Add(this.GPULabel);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.CloseButton);
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "RealTime monitor";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroLabel CPULabel;
        private MetroFramework.Controls.MetroLabel GPULabel;
        private MetroFramework.Controls.MetroProgressBar CPUPerfomanceBar;
        private MetroFramework.Controls.MetroToggle ThemeToggle;
        private MetroFramework.Controls.MetroLabel DarkThemeLabel;
        private MetroFramework.Controls.MetroLabel LightThemeLabel;
        private MetroFramework.Controls.MetroProgressBar GPUPerfomanceBar;
        private MetroFramework.Controls.MetroLabel CPUPercentLabel;
        private MetroFramework.Controls.MetroLabel GPUPercentLabel;
        private MetroFramework.Controls.MetroLabel DetectedCPULabel;
        private MetroFramework.Controls.MetroLabel CPUTempLabel;
        private MetroFramework.Controls.MetroLabel GPUTempLabel;
        private System.Windows.Forms.Label CurrentTempGPULabel;
        private System.Windows.Forms.Label CurrentTempCPULabel;
        private MetroFramework.Controls.MetroComboBox DetectedGPUBox;
        private System.ComponentModel.BackgroundWorker Worker;
    }
}

