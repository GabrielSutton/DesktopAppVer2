using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERIAL_RX_TX;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace DesktopAppVer2
{
    public partial class MainWindow : Form
    {
        //Form Variables
        private SerialComPort serialPort;
        private Timer receivedDataTimer;
        private Timer replayLogTimer;
        private StringCollection receivedData = new StringCollection(); //MutexVariable!
        private bool dataReady = false; //Flag!
        private bool dataReading = false; //Mutex for received data!
        private StreamReader file;

        //FORM CONSTRUCTOR
        public MainWindow()
        {
            InitializeComponent();
            file = null;
            //he
            serialPort = new SerialComPort();
            serialPort.RegisterReceiveCallback(ReceiveDataHandler);
            receivedDataTimer = new Timer();
            receivedDataTimer.Interval = 25;   // 25 ms
            receivedDataTimer.Tick += new EventHandler(ReceivedDataTimerTick);
            receivedDataTimer.Start();
            replayLogTimer = new Timer();
            replayLogTimer.Interval = 1000;   // 1000 ms
            replayLogTimer.Tick += new EventHandler(ReplayLogTimerTick);
            replayLogTimer.Start();
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = "TERMINAL - Serial Data Terminal v" + version;
            lblVers.Text += "0.5";
        }

        private void ReceiveDataHandler(string data)
        {
            if (dataReading)
            {
                Debug.Print("Received data was thrown away because line buffer not emptied");
            }
            else
            {
                receivedData.Add(data);
                dataReady = true;
            }
        }

        //dataready should always be checked before modifying the variable
        private void ReceivedDataTimerTick(object sender, EventArgs e)
        {
            if (dataReady)
            {
                dataReading = true;
                for (int iter = 0; iter < receivedData.Count; iter++)
                {
                    
                    UpdateDataWindow(receivedData[iter]);
                }
                receivedData = new StringCollection();
                dataReading = false;
                dataReady = false;
            }
        }

        private void ReplayLogTimerTick(object sender, EventArgs e)
        {
            if (file != null)
            {
                try
                {
                    string message = file.ReadLine();
                    if (!file.EndOfStream)
                    {
                        serialPort.SendLine(message + "\r\n");
                    }
                    else
                    {
                        file.BaseStream.Seek(0, 0);  // start over reading the file
                    }
                }
                catch (Exception error)
                {
                    Debug.Print(error.Message);
                }
            }
        }

        // I did not use a .net queue here because it is CPU expensive and I don't really need it
        // If the program checks the line buffer every 25 ms, it will handle roughly up to 40 lines per second without a line buffer over-write
        private void UpdateDataWindow(string message)
        {
            tbDataWindow.Text += message;
            tbDataWindow.SelectionStart = tbDataWindow.TextLength;
            tbDataWindow.ScrollToCaret();
        }

        private void BAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                  "Written by Dale Gambill (same as 'Software Guy For You' on Youtube)\r\n\r\n" +
                  "TERMINAL demonstrates event-handling of serial COM port data as follows:\r\n\r\n" +
                  "1 - getting messages from a COM port via a callback function\r\n" +
                  "2 - sending messages from a file to the COM port, one at a time\r\n" +
                  "3 - sending log file messages and receiving messages at the same time\r\n\r\n" +
                  "Source code at: Github URL: https://github.com/dalegambill/CsharpTerminal\r\n",
                  "About"
              );
        }

        private void bOpenComPort_Click(object sender, EventArgs e)
        {
            // Handles the Open/Close button, which toggles its label, depending on previous state.
            string status;
            if (bOpenComPort.Text == "Open COM Port")
            {
                status = serialPort.Open(tbComPort.Text, tbBaudRate.Text, "8", "None", "One");
                if (status.Contains("Opened"))
                {
                    bOpenComPort.Text = "Close COM Port";
                }
            }
            else
            {
                status = serialPort.Close();
                bOpenComPort.Text = "Open COM Port";
            }
            UpdateDataWindow(status);
        }

        private void bClearRxData_Click(object sender, EventArgs e)
        {
            tbDataWindow.Clear();
        }

        private void bSendMessage_Click(object sender, EventArgs e)
        {
            fctSendMessage(tbMessageToSend.Text);
        }

        private bool fctSendMessage(string message)
        {
            if (serialPort.IsOpen())
            {
                message += "\r\n";
                serialPort.SendLine(message);
                UpdateDataWindow(message);
                return true;
            }
            else
            {
                UpdateDataWindow("Open COM port first\r\n");
                return false;
            }
            
        }
        private void bTutorials_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCouhHzMMU9c-Qh-TkZl5GDg");
        }

        //private void bReplayLog_Click(object sender, EventArgs e)
        //{
        //    if (!serialPort.IsOpen())
        //    {
        //        UpdateDataWindow("Open COM port first\r\n");
        //        return;
        //    }
        //    if (bReplayLog.Text == "Replay Log")
        //    {
        //        OpenFileDialog openFileDialog = new OpenFileDialog();
        //        DialogResult result = openFileDialog.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            file = new System.IO.StreamReader(openFileDialog.FileName);
        //            bReplayLog.Text = "Stop Replay Log";
        //            UpdateDataWindow("Replaying to COM port: " + openFileDialog.FileName + "\r\n");
        //        }
        //    }
        //    else
        //    {
        //        if (file != null)
        //        {
        //            file.Close();
        //            file = null;
        //            bReplayLog.Text = "Replay Log";
        //        }
        //    }
        //}
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            fctSendMessage("MOTOR SET" + lblSPEED.Text + " " + tbSpeed.Text);
        }

    }
}
