using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace DeskApp511
{
    public partial class Form1 : Form
    {
        public int con = 0;
        string str;
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in group12CA.Controls)
            {
                (c as Button).BackgroundImage = Properties.Resources.offled;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            GroupIntitialize(false);
        }

        private void GroupIntitialize(bool checkOn)
        {
            if (checkOn == false)
            {
                foreach (Control c in group12CA.Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = false;
                    }
                }
                foreach (Control c in group12CB.Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = false;
                    }
                }
                Btn_Disconnect.Enabled = false;
                Btn_Connect.Enabled = true;
            }
            else if (checkOn == true)
            {
                foreach (Control c in group12CA.Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = true;
                    }
                }
                foreach (Control c in group12CB.Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = true;
                    }
                }
                Btn_Disconnect.Enabled = true;
                Btn_Connect.Enabled = false;
            }
        }

        private void Btn_LoadPorts_Click(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }
            try
            {
                comboPorts.Items.AddRange(ports);
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);
            }
            catch { MessageBox.Show("No Ports Found!"); }
        }

        private void comboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboPorts.Text;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                GroupIntitialize(true);
                MessageBox.Show("Connected!");
                con = 1;
            }
            catch
            {
                serialPort1.Close();
                MessageBox.Show("Selected Port Unavailable!");
            }
        }

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            GroupIntitialize(false);
            MessageBox.Show("Disconnected!");
            foreach (Control c in group12CA.Controls)
            {
                (c as Button).BackgroundImage = Properties.Resources.offled;
                (c as Button).BackColor = Color.FromName("Control");
            }
            foreach (Control c in group511Control.Controls)
            {
                (c as Button).BackColor = Color.White;
            }
            timer1.Stop();
        }

        //Group 12C A
        private void LED(string name, bool isOn)
        {
            foreach (Control c in group12CA.Controls)
            {
                if ((c as Button).Name == name)
                {
                    if (isOn)
                    {
                        (c as Button).BackgroundImage = Properties.Resources.onled;
                        (c as Button).BackColor = Color.FromArgb(51, 153, 253);
                    }
                    else
                    {
                        (c as Button).BackgroundImage = Properties.Resources.offled;
                        (c as Button).BackColor = Color.FromName("Control");
                    }
                }
            }
        }
        private void buttonClick(object sender, EventArgs e)
        {
            foreach (Control c in group12CA.Controls)
            {
                if (c is Button)
                {
                    if ((sender as Button).Name == "Btn_Led1")
                    {
                        if (Btn_Led1.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led1.Tag = 0;
                            serialPort1.Write("1");
                            break;
                        }
                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led1.Tag = 1;
                            serialPort1.Write("1");
                            break;

                        }
                    }

                    else if ((sender as Button).Name == "Btn_Led2")
                    {
                        if (Btn_Led2.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led2.Tag = 0;
                            serialPort1.Write("2");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led2.Tag = 1;
                            serialPort1.Write("2");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "Btn_Led3")
                    {
                        if (Btn_Led3.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led3.Tag = 0;
                            serialPort1.Write("3");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led3.Tag = 1;
                            serialPort1.Write("3");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "Btn_Led4")
                    {
                        if (Btn_Led4.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led4.Tag = 0;
                            serialPort1.Write("4");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led4.Tag = 1;
                            serialPort1.Write("4");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "Btn_Led5")
                    {
                        if (Btn_Led5.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led5.Tag = 0;
                            serialPort1.Write("5");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led5.Tag = 1;
                            serialPort1.Write("5");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "Btn_Led6")
                    {
                        if (Btn_Led6.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led6.Tag = 0;
                            serialPort1.Write("6");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led6.Tag = 1;
                            serialPort1.Write("6");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "Btn_Led7")
                    {
                        if (Btn_Led7.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led7.Tag = 0;
                            serialPort1.Write("7");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led7.Tag = 1;
                            serialPort1.Write("7");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "Btn_Led8")
                    {
                        if (Btn_Led8.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led8.Tag = 0;
                            serialPort1.Write("8");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led8.Tag = 1;
                            serialPort1.Write("8");
                            break;
                        }
                    }
                }
            }
        }
        
        //Group 12C B
        private void Btn_counterUp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("U");
        }

        private void Btn_counterDown_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
        }

        private void Btn_buzz_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Z");
        }

        private void Btn_motorClkwise_Click(object sender, EventArgs e)
        {
            serialPort1.Write("L");
        }
        private void Btn_motorCntrClkwise_Click(object sender, EventArgs e)
        {
            serialPort1.Write("C");
        }

        //group 511 Control
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            str = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(readData));       
        }

        int i = 0;
        private void readData(object sender, EventArgs e)
        {
            if (str == "R")
            {
                //q = true;
                //start();
                i = 1;
                timer1.Start();
            }
            else if (str == "G")
            {
                //w = true;
                i = 2;
                timer1.Start();
            }
            else if (str == "B")
            {
                //z = true;
                i = 3;
                timer1.Start();
            }
        }
        //bool q = false;
        //bool w = false;
        //bool z = false;

        double x =  0;

        //public void start()
        //{
        //    if (q == true)
        //    {
        //        while (q == true)
        //        {
        //            btn_DispRed.BackColor = Color.Red;
        //        }
        //        q = false;
        //        btn_DispRed.BackColor = Color.White;
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 1)
            {
                //while (x != 0)
                //{
                //    x += Convert.ToDouble(timer1.Interval);
                //    btn_DispRed.BackColor = Color.Red;
                //}
                //x = 0;
                //btn_DispRed.BackColor = Color.White;
                //if (x == 1000)
                if (x == 1000)
                {
                    x = 0;
                    timer1.Stop();
                }
                else
                {
                    x += Convert.ToDouble(timer1.Interval);
                    if (btn_DispRed.BackColor == Color.White)
                    {
                        btn_DispRed.BackColor = Color.Red;
                    }
                    else
                    {
                        btn_DispRed.BackColor = Color.White;
                    }
                }
            }
            else if (i == 2)
            {
                //if (x == 1000)
                if (x == 1000)
                {
                    x = 0;
                    timer1.Stop();
                }
                else
                {
                    x += Convert.ToDouble(timer1.Interval);
                    if (btn_DispGreen.BackColor == Color.White)
                    {
                        btn_DispGreen.BackColor = Color.Green;
                    }
                    else
                    {
                        btn_DispGreen.BackColor = Color.White;
                    }
                }
            }
            else if (i == 3)
            {
                //if (x == 1000)
                if (x == 1000)
                {
                    x = 0;
                    timer1.Stop();
                }
                else
                {
                    x += Convert.ToDouble(timer1.Interval);
                    if (btn_DispBlue.BackColor == Color.White)
                    {
                        btn_DispBlue.BackColor = Color.Blue;
                    }
                    else
                    {
                        btn_DispBlue.BackColor = Color.White;
                    }
                }
            }
        }
    }
}