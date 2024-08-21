﻿using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.IO;
using System.Linq;
=======
using System.IO;
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
<<<<<<< HEAD
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameCaro
{
    public class SocketManager
=======
using System.Threading;

namespace Game_Caro
{
    class SocketManager
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
    {
        #region Client
        Socket client;
        public bool ConnectServer()
        {
<<<<<<< HEAD
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
=======
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(iep);
                return true;
<<<<<<< HEAD
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region server

        Socket server;
        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(iep);
            server.Listen(10);

            Thread acceptClient = new Thread(() =>
            {
                client = server.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
=======
            }                
            catch
            {
                return false;
            } 
        }
        #endregion

        #region Server
        Socket server;
        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(iep);
            server.Listen(10); // Đợi kết nối client trong 10s nếu ko có thì bỏ

            Thread AcceptClient = new Thread(() => { try { client = server.Accept(); } catch { } });
            AcceptClient.IsBackground = true; // Để khi chương trình tắt ngang thì Thread cũng tự tắt
            AcceptClient.Start();
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
<<<<<<< HEAD
        public int PORT = 9999;
        public const int BUFFER = 1024;
        public bool isServer = true;

        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);

            return SendData(client, sendData);
=======
        public int Port = 9999;
        public bool IsServer = true;
        public const int BUFFER = 1024;

        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1;
        }

        private bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1;
        }

        public bool Send(object data)
        {
            byte[] sendedData = SerializeData(data);
            return SendData(client, sendedData);
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
        }

        public object Receive()
        {
<<<<<<< HEAD
            byte[] receiveData = new byte[BUFFER];
            bool isOk = ReceiveData(client, receiveData);

            return DeserializeData(receiveData);
        }

        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }


        private bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }
=======
            byte[] receivedData = new byte[BUFFER]; // 1 lần nhận tin là cỡ bao nhiêu
            bool IsOk = ReceiveData(client, receivedData);
            return DeserializeData(receivedData);
        }

>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
        /// <summary>
        /// Nén đối tượng thành mảng byte[]
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        /// <summary>
        /// Giải nén mảng byte[] thành đối tượng object
        /// </summary>
        /// <param name="theByteArray"></param>
        /// <returns></returns>
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        /// <summary>
        /// Lấy ra IP V4 của card mạng đang dùng
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
<<<<<<< HEAD
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

=======

            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            output = ip.Address.ToString();
            return output;
        }

        public void CloseConnect()
        {
            try
            {
                server.Close();
                client.Close();
            } catch { }
            
        }
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
        #endregion
    }
}
