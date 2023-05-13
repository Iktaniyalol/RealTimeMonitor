using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using OpenHardwareMonitor.Hardware;
using System.Threading;
using System.Windows.Forms;

namespace RealTimeMonitor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private int selectedGPU = 0;
        private bool isShowGPU = true;
        public Form1()
        {
            InitializeComponent();
            DetectedGPUBox.Items.Clear();
            Visitor visitor = new Visitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.Accept(visitor);
            DetectedCPULabel.Text = GetCPUName(computer);
            foreach (string gpu in GetGPUNames(computer))
            {
                DetectedGPUBox.Items.Add(gpu);
            }
            if (DetectedGPUBox.Items.Count > 0)
            {
                DetectedGPUBox.SelectedIndex = 0;
            } else
            {
                GPULabel.Visible = false;
                GPUPercentLabel.Visible = false;
                GPUTempLabel.Visible = false;
                CurrentTempGPULabel.Visible = false;
                DetectedGPUBox.Visible = false;
                GPUPerfomanceBar.Visible = false;
                isShowGPU = false;
            }

            ViewCurrentCPULoad(GetCPUPercent(computer));
            if (isShowGPU)
            {
                ViewCurrentGPULoad(GetGPUPercent(computer));
                ViewCurrentGPUTemp(GetGPUTemp(computer));
            }
            ViewCurrentCPUTemp(GetCPUTemp(computer));
            computer.Close();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeToggle.Checked)
            {
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                this.Style = MetroFramework.MetroColorStyle.Blue;
                ThemeToggle.Theme = MetroFramework.MetroThemeStyle.Light;
                ThemeToggle.Style = MetroFramework.MetroColorStyle.Blue;
                CloseButton.Theme = MetroFramework.MetroThemeStyle.Light;
                CloseButton.Style = MetroFramework.MetroColorStyle.Blue;
                DarkThemeLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                DarkThemeLabel.Style = MetroFramework.MetroColorStyle.Blue;
                LightThemeLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                LightThemeLabel.Style = MetroFramework.MetroColorStyle.Blue;
                DetectedCPULabel.Theme = MetroFramework.MetroThemeStyle.Light;
                DetectedCPULabel.Style = MetroFramework.MetroColorStyle.Blue;
                DetectedGPUBox.Theme = MetroFramework.MetroThemeStyle.Light;
                DetectedGPUBox.Style = MetroFramework.MetroColorStyle.Blue;
                CPUPercentLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                CPUPercentLabel.Style = MetroFramework.MetroColorStyle.Blue;
                GPUPercentLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                GPUPercentLabel.Style = MetroFramework.MetroColorStyle.Blue;
                CPULabel.Theme = MetroFramework.MetroThemeStyle.Light;
                CPULabel.Style = MetroFramework.MetroColorStyle.Blue;
                GPULabel.Theme = MetroFramework.MetroThemeStyle.Light;
                GPULabel.Style = MetroFramework.MetroColorStyle.Blue;
                CPUTempLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                CPUTempLabel.Style = MetroFramework.MetroColorStyle.Blue;
                GPUTempLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                GPUTempLabel.Style = MetroFramework.MetroColorStyle.Blue;
                CurrentTempCPULabel.BackColor = this.BackColor;
                CurrentTempGPULabel.BackColor = this.BackColor;
            }
            else
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.Style = MetroFramework.MetroColorStyle.Purple;
                ThemeToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
                ThemeToggle.Style = MetroFramework.MetroColorStyle.Purple;
                CloseButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                CloseButton.Style = MetroFramework.MetroColorStyle.Purple;
                DarkThemeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                DarkThemeLabel.Style = MetroFramework.MetroColorStyle.Purple;
                LightThemeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                LightThemeLabel.Style = MetroFramework.MetroColorStyle.Purple;
                DetectedCPULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                DetectedCPULabel.Style = MetroFramework.MetroColorStyle.Purple;
                DetectedGPUBox.Theme = MetroFramework.MetroThemeStyle.Dark;
                DetectedGPUBox.Style = MetroFramework.MetroColorStyle.Purple;
                CPUPercentLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                CPUPercentLabel.Style = MetroFramework.MetroColorStyle.Purple;
                GPUPercentLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                GPUPercentLabel.Style = MetroFramework.MetroColorStyle.Purple;
                CPULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                CPULabel.Style = MetroFramework.MetroColorStyle.Purple;
                GPULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                GPULabel.Style = MetroFramework.MetroColorStyle.Purple;
                CPUTempLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                CPUTempLabel.Style = MetroFramework.MetroColorStyle.Purple;
                GPUTempLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                GPUTempLabel.Style = MetroFramework.MetroColorStyle.Purple;
                CurrentTempCPULabel.BackColor = this.BackColor;
                CurrentTempGPULabel.BackColor = this.BackColor;
            }

        }

        private int GetCPUPercent(Computer computer)
        {
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Total")
                            {
                                return (int)computer.Hardware[i].Sensors[j].Value;
                            }
                        }
                    }
                }
            }
            return 0;
        }

        private int GetGPUPercent(Computer computer)
        {
            int c = 0;
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia || computer.Hardware[i].HardwareType == HardwareType.GpuAti)
                {
                    if (c == selectedGPU)
                    {
                        for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                        {
                            if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                            {
                                if (computer.Hardware[i].Sensors[j].Name == "GPU Core")
                                {
                                    return (int)computer.Hardware[i].Sensors[j].Value;
                                }
                            }
                        }
                    }
                    c++;
                }
            }
            return 0;
        }

        private string GetCPUName(Computer computer)
        {
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    return computer.Hardware[i].Name;
                }
            }
            return "";
        }

        private List<string> GetGPUNames(Computer computer)
        {
            List<string> gpus = new List<string>();
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    gpus.Add(computer.Hardware[i].Name);
                }
                else if (computer.Hardware[i].HardwareType == HardwareType.GpuAti)
                {
                    gpus.Add(computer.Hardware[i].Name);
                }
            }
            return gpus;
        }

        private double GetCPUTemp(Computer computer)
        {
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Package")
                            {
                                return (double)computer.Hardware[i].Sensors[j].Value;
                            }
                        }
                    }
                }
            }
            return 0;
        }

        private double GetGPUTemp(Computer computer)
        {
            int c = 0;
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia || computer.Hardware[i].HardwareType == HardwareType.GpuAti)
                {
                    if (c == selectedGPU)
                    {
                        for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                        {
                            if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            {
                                if (computer.Hardware[i].Sensors[j].Name == "GPU Core")
                                {
                                    return (double)computer.Hardware[i].Sensors[j].Value;
                                }
                            }
                        }
                    }
                    c++;
                }
            }
            return 0;
        }

        private void ViewCurrentCPUTemp(double temp)
        {
            if (temp < 70)
            {
                CurrentTempCPULabel.ForeColor = Color.Lime;
            }
            else if (temp < 90)
            {
                CurrentTempCPULabel.ForeColor = Color.Orange;
            }
            else
            {
                CurrentTempCPULabel.ForeColor = Color.Red;
            }
            CurrentTempCPULabel.Text = temp.ToString() + " °";
        }

        private void ViewCurrentGPUTemp(double temp)
        {
            if (temp < 70)
            {
                CurrentTempGPULabel.ForeColor = Color.Lime;
            }
            else if (temp < 90)
            {
                CurrentTempGPULabel.ForeColor = Color.Orange;
            }
            else
            {
                CurrentTempGPULabel.ForeColor = Color.Red;
            }
            CurrentTempGPULabel.Text = temp.ToString() + " °";
        }

        private void ViewCurrentCPULoad(int cpu)
        {
            CPUPerfomanceBar.Value = cpu;
            CPUPercentLabel.Text = cpu + "%";
        }

        private void ViewCurrentGPULoad(int gpu)
        {
            GPUPerfomanceBar.Value = gpu;
            GPUPercentLabel.Text = gpu + "%";
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Visitor visitor = new Visitor();
                Computer computer = new Computer();
                computer.Open();
                computer.CPUEnabled = true;
                computer.GPUEnabled = true;
                computer.Accept(visitor);
                int cpu = GetCPUPercent(computer);
                int gpu = 0;
                double gpuTemp = 0;
                if (isShowGPU)
                {
                    gpu = GetGPUPercent(computer);
                    gpuTemp = GetGPUTemp(computer);
                }
                double cpuTemp = GetCPUTemp(computer);
                computer.Close();
                Action act = () =>
                {
                    if (isShowGPU)
                    {
                        ViewCurrentGPUTemp(gpuTemp);
                        ViewCurrentGPULoad(gpu);
                    }
                    ViewCurrentCPUTemp(cpuTemp);
                    ViewCurrentCPULoad(cpu);

                };

                this.Invoke(act);

                Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
        }

        private void DetectedGPUBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGPU = DetectedGPUBox.SelectedIndex;
        }
    }
}
