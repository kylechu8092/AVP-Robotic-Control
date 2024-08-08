using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RoboticControl
{
    public class BrookRobot : IRobot
    {
        Socket _sender;
        public BrookRobot() 
        {
            //establishConnection();
        }
        public void establishConnection()
        {
            try
            {
                _sender = new connectSocket().getSocket();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void sendCommand(string command)
        {
            try
            {
                int retries = 3;
                while (retries > 0)
                {
                    byte[] send = Encoding.UTF8.GetBytes(command);
                    _sender.Send(send);
                    byte[] response = new byte[1024];
                    _sender.Receive(response);
                    string answer = Encoding.UTF8.GetString(response);
                    if (answer.Equals("_RDY"))
                    {
                        break;
                    }
                    retries--;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void communicate()
        {
            try
            {
                sendCommand(RobotCommands.contact);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void up()
        {
            try
            {
                sendCommand(RobotCommands.moveUp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void down()
        {
            try
            {
                sendCommand(RobotCommands.moveDown);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void home()
        {
            try
            {
                sendCommand(RobotCommands.home);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void retract()
        {
            try
            {
                sendCommand(RobotCommands.retract);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void extend()
        {
            try
            {
                sendCommand(RobotCommands.extend);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void moveTo(int station)
        {
            try
            {
                sendCommand(RobotCommands.moveTo + station.ToString() + "\r\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
