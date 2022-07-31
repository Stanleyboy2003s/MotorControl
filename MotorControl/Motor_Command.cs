using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MotorControl
{
    public class Motor_Command
    {
        private MainControlPanel _maincontrolpanel;
       
        public Motor_Command(MainControlPanel panel)
        {
            this._maincontrolpanel = panel;
        }
        public void _WorkProcess()
        {
            while (_maincontrolpanel.b_isStop == false)
            {
                if (_maincontrolpanel.serialPort.IsOpen == true)
                {
                    switch (_maincontrolpanel._command)
                    {
                        case (int)Cmd.LoadMode:
                            ushort[] _Mode = _maincontrolpanel.master.ReadHoldingRegisters(1, 0x0501, 1);
                            _maincontrolpanel.ShowParameter(_Mode[0], _maincontrolpanel._command);
                            _maincontrolpanel._command = (int)Cmd.LoadStep;
                            break;
                        case (int)Cmd.LoadStep:
                            ushort[] _Step = _maincontrolpanel.master.ReadHoldingRegisters(1, 0x0401, 1);
                            _maincontrolpanel.ShowParameter(_Step[0], _maincontrolpanel._command);
                            _maincontrolpanel._command = (int)Cmd.LoadVelocity;
                            break;
                        case (int)Cmd.LoadVelocity:
                            ushort[] _Velocity = _maincontrolpanel.master.ReadHoldingRegisters(1, 0x0481, 1);
                            _maincontrolpanel.ShowParameter(_Velocity[0], _maincontrolpanel._command);
                            _maincontrolpanel._command = (int)Cmd.LoadAcceleration;
                            break;
                        case (int)Cmd.LoadAcceleration:
                            ushort[] _Acc = _maincontrolpanel.master.ReadHoldingRegisters(1, 0x0601, 1);
                            _maincontrolpanel.ShowParameter(_Acc[0], _maincontrolpanel._command);
                            _maincontrolpanel._command = (int)Cmd.LoadDeceleration;
                            break;
                        case (int)Cmd.LoadDeceleration:
                            ushort[] _Dec = _maincontrolpanel.master.ReadHoldingRegisters(1, 0x0681, 1);
                            _maincontrolpanel.ShowParameter(_Dec[0], _maincontrolpanel._command);
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            break;
                        case (int)Cmd.ReadNowPosition:
                            ushort[] _NowPosition = _maincontrolpanel.master.ReadHoldingRegisters(1, 0x00C7, 1);
                            _maincontrolpanel.ShowParameter(_NowPosition[0], _maincontrolpanel._command);
                            Console.WriteLine(_NowPosition[0]);
                            if (!_maincontrolpanel._isCommand)
                                _maincontrolpanel._command = (int)Cmd.ReadStatus;
                            break;
                        case (int)Cmd.ReadStatus:
                            ushort[] _Status = _maincontrolpanel.master.ReadHoldingRegisters(1, 0x007F, 1);
                            _maincontrolpanel.ShowParameter(_Status[0], _maincontrolpanel._command);
                            if (!_maincontrolpanel._isCommand)
                                _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            break;
                        case (int)Cmd.Home:
                            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0010);
                            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0000);
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            _maincontrolpanel._isCommand = false;
                            break;
                        case (int)Cmd.ResetAlarm:
                            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0180);
                            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0000);
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            _maincontrolpanel._isCommand = false;
                            break;
                        case (int)Cmd.RVS:
                            _RVS();
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            _maincontrolpanel._isCommand = false;
                            break;
                        case (int)Cmd.Stop:
                            //設定START OFF(0000h)
                            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0000);
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            _maincontrolpanel._isCommand = false;
                            break;
                        case (int)Cmd.FWD:
                            _FWD();
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            _maincontrolpanel._isCommand = false;
                            break;
                        case (int)Cmd.Move:
                            _Move();
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            _maincontrolpanel._isCommand = false;
                            break;
                        case (int)Cmd.Emergency:
                            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0020);
                            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0000);
                            _maincontrolpanel._command = (int)Cmd.ReadNowPosition;
                            _maincontrolpanel._isCommand = false;
                            break;
                    }
                }
                Thread.Sleep(1);
            }
        }
        private void _Move()
        {
            //設定運轉方式(0501h)為增量式(0000h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x0501, (ushort)_maincontrolpanel.mod);
            //設定位置(0401h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x0401, (ushort)_maincontrolpanel.step);
            //設定速度(0481h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x0481, (ushort)_maincontrolpanel.vel);
            //設定加速(0601h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x0601, (ushort)(_maincontrolpanel.acc * 1000));
            //設定減速(0681h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x0681, (ushort)(_maincontrolpanel.dec * 1000));
            //設定START ON(0008h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0008);
            //設定START OFF(0000h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x0000);
        }
        private void _FWD()
        {
            //設定速度(0481h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x0481, (ushort)_maincontrolpanel.continueVel);
            //設定FWD ON(4000h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x4000);
        }
        private void _RVS()
        {
            //設定速度(0481h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x0481, (ushort)_maincontrolpanel.continueVel);
            //設定RVS ON(8000h)
            _maincontrolpanel.master.WriteSingleRegister(1, 0x007D, 0x8000);
        }
    }
}
