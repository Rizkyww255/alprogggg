namespace alprogggg
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Voltage = new System.Windows.Forms.Panel();
            this.lblVoltageValue = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.DataSignal = new System.Windows.Forms.Panel();
            this.chartSignal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDataSignal = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.Voltage.SuspendLayout();
            this.DataSignal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Controls.Add(this.guna2Button1);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.FillColor = System.Drawing.Color.Navy;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(250, 621);
            this.sidebarPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(37, 548);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(196, 41);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2Button1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(37, 60);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.ExitButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(250, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.ShadowDecoration.Parent = this.headerPanel;
            this.headerPanel.Size = new System.Drawing.Size(779, 60);
            this.headerPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ECG Alpha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(723, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(53, 32);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.Voltage);
            this.mainPanel.Controls.Add(this.DataSignal);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPanel.Location = new System.Drawing.Point(250, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(779, 561);
            this.mainPanel.TabIndex = 2;
            // 
            // Voltage
            // 
            this.Voltage.AccessibleName = "";
            this.Voltage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Voltage.Controls.Add(this.lblVoltageValue);
            this.Voltage.Controls.Add(this.lblVoltage);
            this.Voltage.Location = new System.Drawing.Point(503, 106);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(229, 141);
            this.Voltage.TabIndex = 1;
            // 
            // lblVoltageValue
            // 
            this.lblVoltageValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoltageValue.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltageValue.Location = new System.Drawing.Point(3, 37);
            this.lblVoltageValue.Name = "lblVoltageValue";
            this.lblVoltageValue.Size = new System.Drawing.Size(223, 101);
            this.lblVoltageValue.TabIndex = 2;
            this.lblVoltageValue.Text = "0.00 μV";
            this.lblVoltageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVoltageValue.Click += new System.EventHandler(this.lblVoltageValue_Click);
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltage.Location = new System.Drawing.Point(78, 9);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(85, 25);
            this.lblVoltage.TabIndex = 1;
            this.lblVoltage.Text = "Voltage";
            this.lblVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVoltage.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataSignal
            // 
            this.DataSignal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DataSignal.Controls.Add(this.chartSignal);
            this.DataSignal.Controls.Add(this.lblDataSignal);
            this.DataSignal.Location = new System.Drawing.Point(32, 28);
            this.DataSignal.Name = "DataSignal";
            this.DataSignal.Size = new System.Drawing.Size(416, 285);
            this.DataSignal.TabIndex = 0;
            // 
            // chartSignal
            // 
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.chartSignal.ChartAreas.Add(chartArea2);
            this.chartSignal.Location = new System.Drawing.Point(1, 75);
            this.chartSignal.Name = "chartSignal";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "EEG_Signal";
            this.chartSignal.Series.Add(series2);
            this.chartSignal.Size = new System.Drawing.Size(413, 207);
            this.chartSignal.TabIndex = 1;
            this.chartSignal.Text = "chart1";
            this.chartSignal.Click += new System.EventHandler(this.chartSignal_Click);
            // 
            // lblDataSignal
            // 
            this.lblDataSignal.AutoSize = true;
            this.lblDataSignal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSignal.Location = new System.Drawing.Point(132, 35);
            this.lblDataSignal.Name = "lblDataSignal";
            this.lblDataSignal.Size = new System.Drawing.Size(128, 25);
            this.lblDataSignal.TabIndex = 0;
            this.lblDataSignal.Text = "Data Signal";
            this.lblDataSignal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDataSignal.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 621);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.Voltage.ResumeLayout(false);
            this.Voltage.PerformLayout();
            this.DataSignal.ResumeLayout(false);
            this.DataSignal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel Voltage;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Panel DataSignal;
        private System.Windows.Forms.Label lblDataSignal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSignal;
        private System.Windows.Forms.Label lblVoltageValue;
    }
}