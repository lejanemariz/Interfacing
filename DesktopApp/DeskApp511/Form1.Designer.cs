
namespace DeskApp511
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
            this.groupInitialize = new System.Windows.Forms.GroupBox();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Btn_Disconnect = new System.Windows.Forms.Button();
            this.Btn_LoadPorts = new System.Windows.Forms.Button();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.connectionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group12CA = new System.Windows.Forms.GroupBox();
            this.Btn_Led8 = new System.Windows.Forms.Button();
            this.Btn_Led7 = new System.Windows.Forms.Button();
            this.Btn_Led6 = new System.Windows.Forms.Button();
            this.Btn_Led5 = new System.Windows.Forms.Button();
            this.Btn_Led4 = new System.Windows.Forms.Button();
            this.Btn_Led3 = new System.Windows.Forms.Button();
            this.Btn_Led2 = new System.Windows.Forms.Button();
            this.Btn_Led1 = new System.Windows.Forms.Button();
            this.group12CB = new System.Windows.Forms.GroupBox();
            this.Btn_motorCntrClkwise = new System.Windows.Forms.Button();
            this.Btn_motorClkwise = new System.Windows.Forms.Button();
            this.Btn_counterUp = new System.Windows.Forms.Button();
            this.Btn_counterDown = new System.Windows.Forms.Button();
            this.Btn_buzz = new System.Windows.Forms.Button();
            this.group511Control = new System.Windows.Forms.GroupBox();
            this.btn_DispRed = new System.Windows.Forms.Button();
            this.btn_DispBlue = new System.Windows.Forms.Button();
            this.btn_DispGreen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupInitialize.SuspendLayout();
            this.group12CA.SuspendLayout();
            this.group12CB.SuspendLayout();
            this.group511Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInitialize
            // 
            this.groupInitialize.Controls.Add(this.Btn_Connect);
            this.groupInitialize.Controls.Add(this.Btn_Disconnect);
            this.groupInitialize.Controls.Add(this.Btn_LoadPorts);
            this.groupInitialize.Controls.Add(this.comboPorts);
            this.groupInitialize.Controls.Add(this.connectionType);
            this.groupInitialize.Controls.Add(this.label1);
            this.groupInitialize.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupInitialize.Location = new System.Drawing.Point(12, 12);
            this.groupInitialize.Name = "groupInitialize";
            this.groupInitialize.Size = new System.Drawing.Size(356, 220);
            this.groupInitialize.TabIndex = 0;
            this.groupInitialize.TabStop = false;
            this.groupInitialize.Text = "Initialize";
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.BackgroundImage = global::DeskApp511.Properties.Resources.connect;
            this.Btn_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Connect.Location = new System.Drawing.Point(3, 137);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(350, 40);
            this.Btn_Connect.TabIndex = 5;
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_Disconnect
            // 
            this.Btn_Disconnect.BackgroundImage = global::DeskApp511.Properties.Resources.disconnect;
            this.Btn_Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Disconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Disconnect.Location = new System.Drawing.Point(3, 177);
            this.Btn_Disconnect.Name = "Btn_Disconnect";
            this.Btn_Disconnect.Size = new System.Drawing.Size(350, 40);
            this.Btn_Disconnect.TabIndex = 4;
            this.Btn_Disconnect.UseVisualStyleBackColor = true;
            this.Btn_Disconnect.Click += new System.EventHandler(this.Btn_Disconnect_Click);
            // 
            // Btn_LoadPorts
            // 
            this.Btn_LoadPorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Btn_LoadPorts.Location = new System.Drawing.Point(39, 90);
            this.Btn_LoadPorts.Name = "Btn_LoadPorts";
            this.Btn_LoadPorts.Size = new System.Drawing.Size(107, 30);
            this.Btn_LoadPorts.TabIndex = 3;
            this.Btn_LoadPorts.Text = "Load Ports";
            this.Btn_LoadPorts.UseVisualStyleBackColor = true;
            this.Btn_LoadPorts.Click += new System.EventHandler(this.Btn_LoadPorts_Click);
            // 
            // comboPorts
            // 
            this.comboPorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(162, 94);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(164, 25);
            this.comboPorts.TabIndex = 2;
            this.comboPorts.SelectedIndexChanged += new System.EventHandler(this.comboPorts_SelectedIndexChanged);
            // 
            // connectionType
            // 
            this.connectionType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.connectionType.FormattingEnabled = true;
            this.connectionType.Items.AddRange(new object[] {
            "Wired",
            "Wireless"});
            this.connectionType.Location = new System.Drawing.Point(24, 59);
            this.connectionType.Name = "connectionType";
            this.connectionType.Size = new System.Drawing.Size(302, 25);
            this.connectionType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Connection Type";
            // 
            // group12CA
            // 
            this.group12CA.Controls.Add(this.Btn_Led8);
            this.group12CA.Controls.Add(this.Btn_Led7);
            this.group12CA.Controls.Add(this.Btn_Led6);
            this.group12CA.Controls.Add(this.Btn_Led5);
            this.group12CA.Controls.Add(this.Btn_Led4);
            this.group12CA.Controls.Add(this.Btn_Led3);
            this.group12CA.Controls.Add(this.Btn_Led2);
            this.group12CA.Controls.Add(this.Btn_Led1);
            this.group12CA.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.group12CA.Location = new System.Drawing.Point(374, 12);
            this.group12CA.Name = "group12CA";
            this.group12CA.Size = new System.Drawing.Size(159, 352);
            this.group12CA.TabIndex = 1;
            this.group12CA.TabStop = false;
            this.group12CA.Text = "12C A";
            // 
            // Btn_Led8
            // 
            this.Btn_Led8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led8.Location = new System.Drawing.Point(6, 291);
            this.Btn_Led8.Name = "Btn_Led8";
            this.Btn_Led8.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led8.TabIndex = 7;
            this.Btn_Led8.Tag = "1";
            this.Btn_Led8.UseVisualStyleBackColor = true;
            this.Btn_Led8.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn_Led7
            // 
            this.Btn_Led7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led7.Location = new System.Drawing.Point(6, 255);
            this.Btn_Led7.Name = "Btn_Led7";
            this.Btn_Led7.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led7.TabIndex = 6;
            this.Btn_Led7.Tag = "1";
            this.Btn_Led7.UseVisualStyleBackColor = true;
            this.Btn_Led7.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn_Led6
            // 
            this.Btn_Led6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led6.Location = new System.Drawing.Point(6, 219);
            this.Btn_Led6.Name = "Btn_Led6";
            this.Btn_Led6.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led6.TabIndex = 5;
            this.Btn_Led6.Tag = "1";
            this.Btn_Led6.UseVisualStyleBackColor = true;
            this.Btn_Led6.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn_Led5
            // 
            this.Btn_Led5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led5.Location = new System.Drawing.Point(6, 183);
            this.Btn_Led5.Name = "Btn_Led5";
            this.Btn_Led5.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led5.TabIndex = 4;
            this.Btn_Led5.Tag = "1";
            this.Btn_Led5.UseVisualStyleBackColor = true;
            this.Btn_Led5.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn_Led4
            // 
            this.Btn_Led4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led4.Location = new System.Drawing.Point(6, 148);
            this.Btn_Led4.Name = "Btn_Led4";
            this.Btn_Led4.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led4.TabIndex = 3;
            this.Btn_Led4.Tag = "1";
            this.Btn_Led4.UseVisualStyleBackColor = true;
            this.Btn_Led4.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn_Led3
            // 
            this.Btn_Led3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led3.Location = new System.Drawing.Point(6, 115);
            this.Btn_Led3.Name = "Btn_Led3";
            this.Btn_Led3.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led3.TabIndex = 2;
            this.Btn_Led3.Tag = "1";
            this.Btn_Led3.UseVisualStyleBackColor = true;
            this.Btn_Led3.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn_Led2
            // 
            this.Btn_Led2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led2.Location = new System.Drawing.Point(6, 79);
            this.Btn_Led2.Name = "Btn_Led2";
            this.Btn_Led2.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led2.TabIndex = 1;
            this.Btn_Led2.Tag = "1";
            this.Btn_Led2.UseVisualStyleBackColor = true;
            this.Btn_Led2.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn_Led1
            // 
            this.Btn_Led1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Led1.Location = new System.Drawing.Point(6, 43);
            this.Btn_Led1.Name = "Btn_Led1";
            this.Btn_Led1.Size = new System.Drawing.Size(147, 30);
            this.Btn_Led1.TabIndex = 0;
            this.Btn_Led1.Tag = "1";
            this.Btn_Led1.UseVisualStyleBackColor = true;
            this.Btn_Led1.Click += new System.EventHandler(this.buttonClick);
            // 
            // group12CB
            // 
            this.group12CB.Controls.Add(this.Btn_motorCntrClkwise);
            this.group12CB.Controls.Add(this.Btn_motorClkwise);
            this.group12CB.Controls.Add(this.Btn_counterUp);
            this.group12CB.Controls.Add(this.Btn_counterDown);
            this.group12CB.Controls.Add(this.Btn_buzz);
            this.group12CB.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.group12CB.Location = new System.Drawing.Point(550, 12);
            this.group12CB.Name = "group12CB";
            this.group12CB.Size = new System.Drawing.Size(170, 352);
            this.group12CB.TabIndex = 2;
            this.group12CB.TabStop = false;
            this.group12CB.Text = "12C B";
            // 
            // Btn_motorCntrClkwise
            // 
            this.Btn_motorCntrClkwise.BackgroundImage = global::DeskApp511.Properties.Resources.counter_clockwise;
            this.Btn_motorCntrClkwise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_motorCntrClkwise.Location = new System.Drawing.Point(6, 268);
            this.Btn_motorCntrClkwise.Name = "Btn_motorCntrClkwise";
            this.Btn_motorCntrClkwise.Size = new System.Drawing.Size(158, 47);
            this.Btn_motorCntrClkwise.TabIndex = 7;
            this.Btn_motorCntrClkwise.Text = " ";
            this.Btn_motorCntrClkwise.UseVisualStyleBackColor = true;
            this.Btn_motorCntrClkwise.Click += new System.EventHandler(this.Btn_motorCntrClkwise_Click);
            // 
            // Btn_motorClkwise
            // 
            this.Btn_motorClkwise.BackgroundImage = global::DeskApp511.Properties.Resources.clockwise;
            this.Btn_motorClkwise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_motorClkwise.Location = new System.Drawing.Point(6, 215);
            this.Btn_motorClkwise.Name = "Btn_motorClkwise";
            this.Btn_motorClkwise.Size = new System.Drawing.Size(158, 47);
            this.Btn_motorClkwise.TabIndex = 6;
            this.Btn_motorClkwise.Text = " ";
            this.Btn_motorClkwise.UseVisualStyleBackColor = true;
            this.Btn_motorClkwise.Click += new System.EventHandler(this.Btn_motorClkwise_Click);
            // 
            // Btn_counterUp
            // 
            this.Btn_counterUp.BackgroundImage = global::DeskApp511.Properties.Resources.counter_up;
            this.Btn_counterUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_counterUp.Location = new System.Drawing.Point(6, 56);
            this.Btn_counterUp.Name = "Btn_counterUp";
            this.Btn_counterUp.Size = new System.Drawing.Size(158, 47);
            this.Btn_counterUp.TabIndex = 5;
            this.Btn_counterUp.Text = " ";
            this.Btn_counterUp.UseVisualStyleBackColor = true;
            this.Btn_counterUp.Click += new System.EventHandler(this.Btn_counterUp_Click);
            // 
            // Btn_counterDown
            // 
            this.Btn_counterDown.BackgroundImage = global::DeskApp511.Properties.Resources.counter_down;
            this.Btn_counterDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_counterDown.Location = new System.Drawing.Point(6, 109);
            this.Btn_counterDown.Name = "Btn_counterDown";
            this.Btn_counterDown.Size = new System.Drawing.Size(158, 47);
            this.Btn_counterDown.TabIndex = 4;
            this.Btn_counterDown.Text = " ";
            this.Btn_counterDown.UseVisualStyleBackColor = true;
            this.Btn_counterDown.Click += new System.EventHandler(this.Btn_counterDown_Click);
            // 
            // Btn_buzz
            // 
            this.Btn_buzz.BackgroundImage = global::DeskApp511.Properties.Resources.buzzer;
            this.Btn_buzz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buzz.Location = new System.Drawing.Point(6, 162);
            this.Btn_buzz.Name = "Btn_buzz";
            this.Btn_buzz.Size = new System.Drawing.Size(158, 47);
            this.Btn_buzz.TabIndex = 3;
            this.Btn_buzz.Text = " ";
            this.Btn_buzz.UseVisualStyleBackColor = true;
            this.Btn_buzz.Click += new System.EventHandler(this.Btn_buzz_Click);
            // 
            // group511Control
            // 
            this.group511Control.Controls.Add(this.btn_DispRed);
            this.group511Control.Controls.Add(this.btn_DispBlue);
            this.group511Control.Controls.Add(this.btn_DispGreen);
            this.group511Control.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.group511Control.Location = new System.Drawing.Point(12, 238);
            this.group511Control.Name = "group511Control";
            this.group511Control.Size = new System.Drawing.Size(356, 126);
            this.group511Control.TabIndex = 2;
            this.group511Control.TabStop = false;
            this.group511Control.Text = "511 CONTROL";
            // 
            // btn_DispRed
            // 
            this.btn_DispRed.BackColor = System.Drawing.Color.White;
            this.btn_DispRed.Location = new System.Drawing.Point(38, 29);
            this.btn_DispRed.Name = "btn_DispRed";
            this.btn_DispRed.Size = new System.Drawing.Size(90, 90);
            this.btn_DispRed.TabIndex = 2;
            this.btn_DispRed.Text = " ";
            this.btn_DispRed.UseVisualStyleBackColor = false;
            // 
            // btn_DispBlue
            // 
            this.btn_DispBlue.BackColor = System.Drawing.Color.White;
            this.btn_DispBlue.Location = new System.Drawing.Point(230, 29);
            this.btn_DispBlue.Name = "btn_DispBlue";
            this.btn_DispBlue.Size = new System.Drawing.Size(90, 90);
            this.btn_DispBlue.TabIndex = 1;
            this.btn_DispBlue.Text = " ";
            this.btn_DispBlue.UseVisualStyleBackColor = false;
            // 
            // btn_DispGreen
            // 
            this.btn_DispGreen.BackColor = System.Drawing.Color.White;
            this.btn_DispGreen.Location = new System.Drawing.Point(134, 29);
            this.btn_DispGreen.Name = "btn_DispGreen";
            this.btn_DispGreen.Size = new System.Drawing.Size(90, 90);
            this.btn_DispGreen.TabIndex = 0;
            this.btn_DispGreen.Text = " ";
            this.btn_DispGreen.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 376);
            this.Controls.Add(this.group511Control);
            this.Controls.Add(this.group12CB);
            this.Controls.Add(this.group12CA);
            this.Controls.Add(this.groupInitialize);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Project 511 DeskApp";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupInitialize.ResumeLayout(false);
            this.groupInitialize.PerformLayout();
            this.group12CA.ResumeLayout(false);
            this.group12CB.ResumeLayout(false);
            this.group511Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInitialize;
        private System.Windows.Forms.GroupBox group12CA;
        private System.Windows.Forms.GroupBox group12CB;
        private System.Windows.Forms.GroupBox group511Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox connectionType;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Button Btn_Disconnect;
        private System.Windows.Forms.Button Btn_LoadPorts;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Button Btn_Led8;
        private System.Windows.Forms.Button Btn_Led7;
        private System.Windows.Forms.Button Btn_Led6;
        private System.Windows.Forms.Button Btn_Led5;
        private System.Windows.Forms.Button Btn_Led4;
        private System.Windows.Forms.Button Btn_Led3;
        private System.Windows.Forms.Button Btn_Led2;
        private System.Windows.Forms.Button Btn_motorCntrClkwise;
        private System.Windows.Forms.Button Btn_motorClkwise;
        private System.Windows.Forms.Button Btn_counterUp;
        private System.Windows.Forms.Button Btn_counterDown;
        private System.Windows.Forms.Button Btn_buzz;
        private System.Windows.Forms.Button btn_DispRed;
        private System.Windows.Forms.Button btn_DispBlue;
        private System.Windows.Forms.Button btn_DispGreen;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Btn_Led1;
    }
}

