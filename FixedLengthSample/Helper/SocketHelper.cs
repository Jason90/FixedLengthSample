using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Jason.Util.Helper;

namespace FixedLengthSample
{
    public class SocketHelper
    {
        Socket _socket = null;

        private static SocketHelper _instance;
        public static SocketHelper CreateInstance()
        {
            if (_instance == null)
                _instance = new SocketHelper();

            return _instance;
        }

        private SocketHelper()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        ~SocketHelper()
        {
            if (_socket != null)
                _socket.Close();
        }

        public void Connect(string ip, int port)
        {
            if (!_socket.Connected)
            {
                _socket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
            }
        }

        public void Disconnect()
        {
            if (_socket.Connected)
            {
                _socket.Close();
            }
        }

        public void Send(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            _socket.Send(buffer);
        }
        public string Receive()
        {
            StringBuilder sb = new StringBuilder();
            byte[] buffer = new byte[1024];
            while (_socket.Available > 0)
            {
                _socket.Receive(buffer, buffer.Length, SocketFlags.None);
                sb.Append(Encoding.UTF8.GetString(buffer));
            }

            return sb.ToString();
        }

        public string Query(string message)
        {
            Send(message);

            Thread.Sleep(100);

            return PollingReceive();
        }

        public string PollingReceive()
        {
            StringBuilder sb = new StringBuilder();
            string response = string.Empty;

            if (BaseHelper.PollingCheck(delegate()
            {
                if (_socket.Available > 0)
                {
                    response = Receive();
                    return true;
                }
                return false;

            }, TimeSpan.FromMilliseconds(200), 10))//TimeSpan.FromMilliseconds(ConfigHelper.RetryInterval), ConfigHelper.RetryTimes))
            {
                return sb.ToString();
            }
            else
            {
                throw new Exception(string.Format("Connection failed after retry {0} times.", 10));//ConfigHelper.RetryTimes
            }
        }

        //public static string SendMessage(string ip, int port, string message)
        //{
        //    //Log.Write("Write message to {0}:{1} {2}...");
        //    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    socket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
        //    //Log.Write("Client is online...");

        //    //Send MSG
        //    byte[] buffer = Encoding.UTF8.GetBytes(message);
        //    socket.Send(buffer);

        //    //Receive MSG
        //    StringBuilder sb = new StringBuilder();
        //    buffer = new byte[1024];

        //    //toto: pollingcheck
        //    bool isReceived = false;
        //    do
        //    {
        //        while (socket.Available > 0)
        //        {
        //            socket.Receive(buffer, buffer.Length, SocketFlags.None);
        //            sb.Append(Encoding.UTF8.GetString(buffer));
        //            isReceived = true;
        //        }
        //        socket.Close();

        //        Thread.Sleep(100);
        //    } while (!isReceived);

        //    return sb.ToString();
        //    //Log.Write("Receive:{0}", sb.ToString());

        //}

        public static string SendMessage(string ip, int port, string message, Encoding encoding)
        {
            //Log.Write("Write message to {0}:{1} {2}...");
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
            //Log.Write("Client is online...");

            //Send MSG
            byte[] buffer = encoding.GetBytes(message);
            socket.Send(buffer);

            Thread.Sleep(100);
            //Receive MSG
            StringBuilder sb = new StringBuilder();
            buffer = new byte[4096];

            ////toto: pollingcheck
            //bool isReceived = false;
            //do
            //{

            while (socket.Available > 0)
            {
                socket.Receive(buffer, buffer.Length, SocketFlags.None);
                sb.Append(encoding.GetString(buffer));
                //isReceived = true;
            }
            socket.Close();

            //    Thread.Sleep(100);
            //} while (!isReceived);

            return sb.ToString();
            //Log.Write("Receive:{0}", sb.ToString());

        }




    }
}
