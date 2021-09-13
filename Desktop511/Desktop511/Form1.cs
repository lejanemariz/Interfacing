using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Desktop511
{
    public partial class Form1 : Form
    {
        public int con = 0;
        SerialPort serialPort = new SerialPort();
        //Timer timer1 = new Timer();
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in group12CA.Controls)
            {
                (c as Button).Image = Properties.Resources.offled; 
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GroupIntitialize(false); //groupinitialize
        }
        private void GroupIntitialize(bool checkOn)
        {
           if(checkOn == false)
            {
                foreach(Control c in group12CA.Controls)
                {
                    if(c is Button)
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

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                MessageBox.Show("Connection Successful!");
                con = 1;
            }
            catch
            {
                serialPort.Close();
                MessageBox.Show("Port Unavailable!");
            }
        }

        private void connect()
        {
            //SerialPort serialPort = new SerialPort();
            serialPort.Open();
            //group12CA(true);
        }

        private void LED(string name, bool isOn)
        {
            foreach (Control c in group12CA.Controls)
            {
                if ((c as Button).Name == name)
                {
                    if (isOn)
                    {
                        (c as Button).Image =
                        Properties.Resources.onled; (c as Button).BackColor = Color.FromArgb(51, 153, 253);
                    }
                    else
                    {
                        (c as Button).Image = Properties.Resources.offled;
                        (c as Button).BackColor = Color.FromName("Control");
                    }
                }
            }
        }

        private void Btn_LoadPorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            try
            {
                //serialPort = new SerialPort();
                comboPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                serialPort.BaudRate = (9600);
                serialPort.ReadTimeout = (2000);
                serialPort.WriteTimeout = (2000);
            }

            catch { MessageBox.Show("No Ports :("); }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void comboBox_connection_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = comboPorts.Text;
        }
        private void Btn_counterUp_Click(object sender, EventArgs e)
        {
            serialPort.Write("U");
        }

        private void Btn_counterDown_Click(object sender, EventArgs e)
        {
            serialPort.Write("D");
        }

        private void Btn_buzz_Click(object sender, EventArgs e)
        {
            serialPort.Write("B");
        }
        private void Btn_motorClkwise_Click(object sender, EventArgs e)
        {
            serialPort.Write("R");
        }
        private void Btn_motorCntrClkwise_Click(object sender, EventArgs e)
        {
            serialPort.Write("L");
        }

        private void Read()
        {
            try
            {
                string message = serialPort.ReadLine();
                Console.WriteLine(message);
            }
            catch (TimeoutException) { }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void buttonClick(object sender, EventArgs e)
        {
            foreach (Control c in group12CA.Controls)
            { 
                if(c is Button)
                {
                    if ((sender as Button).Name == "btn1")
                    {
                        if (Btn_Led1.Tag.ToString() == "1")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led1.Tag = 0;
                            serialPort.Write("1");
                            break;
                        }
                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led1.Tag = 1;
                            serialPort.Write("1");
                            break;

                        }
                    }

                    else if ((sender as Button).Name == "btn2")
                    {
                        if (Btn_Led2.Tag.ToString() == "2")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led2.Tag = 0;
                            serialPort.Write("2");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led2.Tag = 1;
                            serialPort.Write("2");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "btn3")
                    {
                        if (Btn_Led3.Tag.ToString() == "3")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led3.Tag = 0;
                            serialPort.Write("3");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led3.Tag = 1;
                            serialPort.Write("3");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "btn4")
                    {
                        if (Btn_Led4.Tag.ToString() == "4")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led4.Tag = 0;
                            serialPort.Write("4");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led4.Tag = 1;
                            serialPort.Write("4");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "btn5")
                    {
                        if (Btn_Led5.Tag.ToString() == "5")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led5.Tag = 0;
                            serialPort.Write("5");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led5.Tag = 1;
                            serialPort.Write("5");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "btn6")
                    {
                        if (Btn_Led6.Tag.ToString() == "6")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led6.Tag = 0;
                            serialPort.Write("6");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led6.Tag = 1;
                            serialPort.Write("6");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "btn7")
                    {
                        if (Btn_Led7.Tag.ToString() == "7")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led7.Tag = 0;
                            serialPort.Write("7");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led7.Tag = 1;
                            serialPort.Write("7");
                            break;
                        }
                    }

                    else if ((sender as Button).Name == "btn8")
                    {
                        if (Btn_Led8.Tag.ToString() == "8")
                        {
                            LED((sender as Button).Name, true);
                            Btn_Led8.Tag = 0;
                            serialPort.Write("8");
                            break;
                        }

                        else
                        {
                            LED((sender as Button).Name, false);
                            Btn_Led8.Tag = 1;
                            serialPort.Write("8");
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = serialPort.ReadExisting();
            bool btn1 = serialPort.ReadExisting().Contains("R");
            bool btn2 = serialPort.ReadExisting().Contains("G");
            bool btn3 = serialPort.ReadExisting().Contains("B");
            if (btn1)
            {
                //timer1.Start();
            }

            else if(btn2)
            {
            
            }

            else if(btn3)
            {

            }

        }

        double x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 5000)
            {
                x = 0;
                //timer1.Stop();
            }
            else
            {
                //x += Convert.ToDouble(timer1.Interval);
                //if (btnRed.BackColor == Color.Red)
                //{
                //    btn_DispRed.BackColor = Color.FromArgb(240, 240, 240);
                //}
                //else
                //{
                //    btn_DispRed.BackColor = Color.Red;
                //}
            }
        }


    }
}
