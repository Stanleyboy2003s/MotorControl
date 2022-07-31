using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO.Ports;
using Modbus.Device;
using System.Threading;

namespace MotorControl
{
    public partial class MainControlPanel : Form
    {
        public SerialPort serialPort;
        public ModbusSerialMaster master;
        Motor_Command class_cmd;
        Thread _upDate;
        public volatile bool b_isStop = false;
        public volatile bool _isCommand = false;
        public volatile int _command = -1;
        public int mod = 0, step = 0, vel = 0, acc = 0, dec = 0, continueVel = 0;

        public MainControlPanel()
        {
            InitializeComponent();
            class_cmd = new Motor_Command(this);
            btn_connect.Enabled = true;
            dudMod.SelectedIndex = 0;
            btn_connect.Enabled = false;
            gbxContinue.Enabled = false;
            gbxPoint.Enabled = false;
            gbxStatus.Enabled = false;
            gbxMotorFunction.Enabled = false;
            serialPort = new SerialPort();
            GetConnectCOM();

            //
            _upDate = new Thread(class_cmd._WorkProcess);
            _upDate.Start();
           
        }



        public void Dev_Update_Off()
        {
            return;
        }

        private void GetConnectCOM()
        {
            cbxCOM.Items.Clear();
            String[] COMPorts = SerialPort.GetPortNames();
            if (COMPorts.Length != 0)
            {
                foreach (string port in COMPorts) { cbxCOM.Items.Add(port); }
                cbxCOM.SelectedIndex = 0;
                btn_connect.Enabled = true;
            }
        }

        public delegate void _showParameter(ushort value, int status);
        public void ShowParameter(ushort value, int status)
        {
            if (this.InvokeRequired)
            {
                _showParameter func = new _showParameter(ShowParameter);
                Invoke(func, value, status);
            }
            else
            {
                switch (status)
                {
                    case (int)Cmd.LoadMode:
                        dudMod.SelectedIndex = value;
                        break;
                    case (int)Cmd.LoadStep:
                        nudStep.Value = (int)value;
                        break;
                    case (int)Cmd.LoadVelocity:
                        nudHz.Value = (int)value;
                        nudContinueHz.Value = (int)value;
                        break;
                    case (int)Cmd.LoadAcceleration:
                        nudAcc.Value = (int)value / 1000;
                        break;
                    case (int)Cmd.LoadDeceleration:
                        nudDec.Value = (int)value / 1000;
                        break;
                    case (int)Cmd.ReadNowPosition:
                        if (value > 40000)
                            tbx_nowPosition.Text = Convert.ToInt32(Convert.ToString(value, 16).PadLeft(8, 'F'), 16).ToString();
                        else
                            tbx_nowPosition.Text = ((int)value).ToString();
                        break;
                    case (int)Cmd.ReadStatus:
                        string b = (Convert.ToString(value, 2)).PadLeft(16, '0');
                        pbxMove.BackColor = b[2] == '0' ? Color.White : Color.Green;
                        pbxReady.BackColor = b[10] == '0' ? Color.White : Color.Green;
                        pbxAlarm.BackColor = b[8] == '0' ? Color.White : Color.Green;
                        pbxWarning.BackColor = b[9] == '0' ? Color.White : Color.Green;
                        pbxHomep.BackColor = b[11] == '0' ? Color.White : Color.Green;
                        if (b[11] == '1')
                            gbxContinue.Enabled = gbxPoint.Enabled = true;
                        break;
                }
            }
        }

        #region Event

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            b_isStop = true;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = cbxCOM.SelectedItem.ToString();
                    serialPort.BaudRate = 115200;
                    serialPort.Parity = Parity.Even;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.ReceivedBytesThreshold = 1;
                    serialPort.Open();
                    master = ModbusSerialMaster.CreateRtu(serialPort);
                    master.Transport.ReadTimeout = 300;
                    if (serialPort.IsOpen)
                    {
                        btn_connect.Text = "中斷";
                        gbxMotorFunction.Enabled = true;
                        gbxStatus.Enabled = true;
                        _command = (int)Cmd.LoadMode;
                    }
                }
                else
                {
                    serialPort.Close();
                    btn_connect.Text = "連接";
                    gbxContinue.Enabled = false;
                    gbxPoint.Enabled = false;
                    gbxStatus.Enabled = false;
                    gbxMotorFunction.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("拒絕存取通訊埠");
            }

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //Dpend on Controller.tag by our definition
            //tag:0(btn_Home), tag:1(btn_rstAlarm), tag: 2(btn_Emergency)
            int tag = Convert.ToInt32(((Button)sender).Tag);

            _isCommand = true;
            switch (tag)
            {
                case 0:
                    _command = (int)Cmd.Home;
                    break;
                case 1:
                    _command = (int)Cmd.ResetAlarm;
                    break;
                case 2:
                    _command = (int)Cmd.Emergency;
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetConnectCOM();
        }

        private void btn_RVS_Click(object sender, EventArgs e)
        {
            int tag = Convert.ToInt32(((Button)sender).Tag);
            continueVel = (int)nudContinueHz.Value;

            _isCommand = true;
            switch (tag)
            {
                case 0:
                    _command = (int)Cmd.RVS;
                    break;
                case 1:
                    _command = (int)Cmd.Stop;
                    break;
                case 2:
                    _command = (int)Cmd.FWD;
                    break;
            }

        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            mod = dudMod.SelectedIndex;
            step = (int)nudStep.Value;
            vel = (int)nudHz.Value;
            acc = (int)nudAcc.Value;
            dec = (int)nudDec.Value;
            _isCommand = true;
            _command = (int)Cmd.Move;
        }



        #endregion

    }
}
