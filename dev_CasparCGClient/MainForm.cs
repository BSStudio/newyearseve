using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svt.Caspar;
using Svt.Caspar.Controls;
using Svt.Network;

namespace dev_CasparCGClient
{
    

    public partial class MainForm : Form
    {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        CasparDevice casparDevice = new CasparDevice();
        CasparCGDataCollection casparData = new CasparCGDataCollection();
        bool clockIsOn = false;

        bool speechIsLocked = false;

        public MainForm()
        {
            InitializeComponent();


            lb_status.Text = "Disconnected";
            statusStrip1.BackColor = System.Drawing.Color.Red;

            setupTimer();

            // Subscribe to Caspar events
            casparDevice.ConnectionStatusChanged += casparDevice_ConnectionStatusChanged;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                ClearChannel((int)tb_channel.Value - 1);
            }
        }

        /*
         * Needed to change the button text from another thread
         * */
        private delegate void ChangeConnectButtonDelegate(string text);
        private void ChangeConnectButton(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new ChangeConnectButtonDelegate(ChangeConnectButton), new object[] { text });
                btn_connect.Enabled = true;
                tb_ServerAddress.Enabled = !casparDevice.IsConnected;
            }
            else
            {
                btn_connect.Text = text;
                btn_connect.Enabled = true;
                tb_ServerAddress.Enabled = !casparDevice.IsConnected;
            }
        }

        /*
         * If the caspar device changes its connection status, this function is triggered.
         * Just changes the connect button and the status bar.
         * */
        void casparDevice_ConnectionStatusChanged(object sender, ConnectionEventArgs e)
        {
            if (casparDevice.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now + ": Caspar connected");
                statusStrip1.BackColor = System.Drawing.Color.Green;
                lb_status.Text = "Connected";
                ChangeConnectButton("Disconnect");

                casparDevice.RefreshMediafiles();
                casparDevice.RefreshDatalist();
                casparDevice.RefreshTemplates();
                casparDevice.DataRetrieved += casparDevice_DataRetrieved;
                System.Diagnostics.Debug.WriteLine(DateTime.Now + " Channels: " + casparDevice.Channels.Count);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now + ": Caspar disconnected");
                statusStrip1.BackColor = System.Drawing.Color.Red;
                lb_status.Text = "Disconnected";
                ChangeConnectButton("Connect");
            }
        }

        #region Button Actions
        /*
         * On connect the host and port is set and connection tries.
         * */
        private void btn_connect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;

            if (!casparDevice.IsConnected)
            {
                casparDevice.Settings.Hostname = this.tb_ServerAddress.Text;
                casparDevice.Settings.Port = 5250;
                casparDevice.Connect();

                lbl_help.Text = "Válaszd ki és lockold a kijátszócsatornát!";
            }
            else
            {
                casparDevice.Disconnect();
                lbl_help.Text = "Csatlakozz a szerverhez!";
            }
        }

        private void btn_lockChannel_Click(object sender, EventArgs e)
        {
            casparDevice_DataRetrieved(null, null); //ez rakja ki a media fajlneveket a listboxba 
            if (tb_channel.Enabled)
            {
                this.tb_channel.Enabled = false;
                this.btn_lockChannel.BackgroundImage = global::dev_CasparCGClient.Properties.Resources.lock1;

                lbl_help.Text = "Add meg a beszéd kezdetének idejét és válaszd ki a beszéd videófájlját, majd lockold!";
            }
            else
            {
                this.tb_channel.Enabled = true;
                this.btn_lockChannel.BackgroundImage = global::dev_CasparCGClient.Properties.Resources.lock_unlock;
            }
        }

        private void btn_clearChannel_Click(object sender, EventArgs e)
        {

            ClearChannel((int)tb_channel.Value);
        }

        #endregion

        #region ToolStripMenuItems
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Functions
        private void ClearChannel(int channel)
        {
            // Use caspar if only the channel is locked!
            if (!tb_channel.Enabled)
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now + ": Cleared channel " + tb_channel.Value);
                try
                {
                    if (casparDevice.IsConnected)
                    {
                        this.casparDevice.Channels[channel - 1].CG.Clear();
                        this.casparDevice.Channels[channel - 1].Clear();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                    throw;

                }
            }
            else
            {
                clockIsOn = false;
                MessageBox.Show("Lock the channel first!");
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (casparDevice.IsConnected)
            {
                if (cb_ClockOnClears.Checked)
                {
                    ClearChannel((int)tb_channel.Value);
                }
                
                CasparCGDataCollection CGdata = new CasparCGDataCollection();
                string time = DateTime.Now.ToString("HH:mm:ss");
                CGdata.SetData("f0", time);
                casparDevice.Channels[(int)tb_channel.Value - 1].CG.Add(0, 0, "ORASZILVESZTER", true, CGdata);

                clockIsOn = true;

                lbl_help.Text = "Kész is vagy!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (casparDevice.IsConnected)
            {
                casparDevice.Channels[(int)tb_channel.Value - 1].CG.Remove(0, 0);
                clockIsOn = false;
            }
        }

        private void setupTimer()
        {
            /* Adds the event and the event handler for the method that will 
          process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            myTimer.Interval = 50;
            myTimer.Enabled = true;
            myTimer.Start();
        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");

            lbl_Clock.Text = time;
            
            //23:58-kor kirakja az orat magatol, ha meg nincs fenn
            /*if (time == "23:58:00" && !clockIsOn)
            {
                //ClearChannel(1);
                clockIsOn = true;
                //casparDevice.Channels[(int)tb_channel.Value - 1].LoadBG(9, "ADAS_PLAYOUT/01_DISZLET", false, TransitionType.MIX, 5);
                casparDevice.Channels[(int)tb_channel.Value - 1].CG.Add(10, 0, "SZILVESZTER/ORASZILVESZTER", true);
                
            }*/
            if (casparDevice.IsConnected && (clockIsOn))
            {
                CasparCGDataCollection CGdata = new CasparCGDataCollection();
                CGdata.SetData("f0", time);
                casparDevice.Channels[(int)tb_channel.Value - 1].CG.Update(10, 0, CGdata);

                if (time == /*"00:00:05"*/dtp_SpeechStartTime.Value.ToString("HH:mm:ss") && speechIsLocked) //ha elerkezik az ido, ami meg van adva, akkor elinditja az Elnoki beszedet
                {
                    dtp_SpeechStartTime.Enabled = false;
                    lb_MediaFiles.Enabled = false;

                    casparDevice.Channels[(int)tb_channel.Value - 1].CG.Remove(10, 0);
                    clockIsOn = false;
                    System.Diagnostics.Debug.WriteLine((string)lb_MediaFiles.SelectedItem);
                    casparDevice.Channels[(int)tb_channel.Value - 1].LoadBG(10, /*"ADAS_PLAYOUT/HIMNUSZ_BESZED"*/ (string) lb_MediaFiles.SelectedItem, false, TransitionType.MIX,5);
                    casparDevice.Channels[(int)tb_channel.Value - 1].Play(10);
                }

            }

            l_ClockOn.Visible = clockIsOn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (casparDevice.IsConnected)
            {
                casparDevice.SendString("INFO");
                string text = "";
                casparDevice.RetrieveData(text);
                System.Diagnostics.Debug.WriteLine(DateTime.Now + ": " + text);
                casparDevice.RetrieveData("MY_DATA");
            }
        }

        void casparDevice_DataRetrieved(object sender, DataEventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine(DateTime.Now + ": " + e.Data.ToString());
            System.Diagnostics.Debug.WriteLine(casparDevice.Mediafiles.Count);
            List<string> fileNames = new List<string>();
            foreach (MediaInfo mi in casparDevice.Mediafiles)
            {
                //System.Diagnostics.Debug.WriteLine(mi.FullName);
                fileNames.Add(mi.FullName);
            }
            lb_MediaFiles.DataSource = fileNames;
        }

        private void btn_lockSpeech_Click(object sender, EventArgs e)
        {
            if (!speechIsLocked) 
            {
                speechIsLocked = true;
                
                lb_MediaFiles.Enabled = false;
                dtp_SpeechStartTime.Enabled = false;

                btn_lockSpeech.BackgroundImage = global::dev_CasparCGClient.Properties.Resources.lock1;

                if (!clockIsOn)
                {
                    lbl_help.Text = "Rakd fel az órát!";
                }
                else
                {
                    lbl_help.Text = "Kész is vagy, mehetsz inni! :D";
                }
            }
            else
            {
                speechIsLocked = false;

                lb_MediaFiles.Enabled = true;
                dtp_SpeechStartTime.Enabled = true;

                btn_lockSpeech.BackgroundImage = global::dev_CasparCGClient.Properties.Resources.lock_unlock;

                if (clockIsOn)
                {
                    lbl_help.Text = "Ne felejtsd el lockolni a videót!";
                }
            }
        }
    }
}
