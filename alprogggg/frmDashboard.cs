using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace alprogggg
{
    public partial class frmDashboard : Form
    {
        // Simulate EEG Data
        private Thread dataThread;
        private bool isRunning = false;
        private Random rand = new Random();

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            InitializeChart();
            StartDataSimulation();
        }

        private void InitializeChart()
        {
            // Configure Chart Appearance
            chartSignal.Series["EEG_Signal"].BorderWidth = 2;
            chartSignal.ChartAreas[0].AxisX.LabelStyle.Enabled = false; // Hide X-axis labels
        }

        private void StartDataSimulation()
        {
            isRunning = true;
            dataThread = new Thread(GenerateSimulatedData);
            dataThread.Start();
        }

        private void GenerateSimulatedData()
        {
            while (isRunning)
            {
                // Simulate EEG Alpha Wave (8-13 Hz)
                double[] data = new double[50];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = Math.Sin(2 * Math.PI * 10 * i / 250) + (rand.NextDouble() - 0.5) * 0.2;
                }

                // Update UI (Thread-Safe)
                this.Invoke((MethodInvoker)delegate
                {
                    UpdateSignalChart(data);
                    UpdateVoltage(data[data.Length - 1] * 100); // Convert to μV
                });

                Thread.Sleep(100); // 10 FPS
            }
        }

        private void UpdateSignalChart(double[] values)
        {
            chartSignal.Series["EEG_Signal"].Points.Clear();
            chartSignal.Series["EEG_Signal"].Points.DataBindY(values);
        }

        private void UpdateVoltage(double voltage)
        {
            lblVoltageValue.Text = $"{voltage:F2} μV";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home Button Clicked!");
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            isRunning = false;
            base.OnFormClosing(e);
        }

        private void chartSignal_Click(object sender, EventArgs e)
        {

        }

        private void lblVoltageValue_Click(object sender, EventArgs e)
        {

        }
    }
}