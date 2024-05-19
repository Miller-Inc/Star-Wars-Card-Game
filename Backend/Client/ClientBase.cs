using Riptide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Client
{

    public class ClientBase
    {
        public Riptide.Client Client { get; private set; }

        public void ConnectToServer(string ip, ushort port)
        {
            Client = new Riptide.Client();
            Client.Connect(ip, port);
            Client.Connected += Client_Connected; 
            Client.Disconnected += Client_Disconnected;
            Client.ClientDisconnected += PlayerDisconnect;

        }

        private void Client_Disconnected(object sender, EventArgs e)
        {
            // Called when the client disconnects from the server

        }

        private void Client_Connected(object sender, EventArgs e)
        {
            ConnectedToServer();
        }

        public void FixedUpdate()
        {
            Client.Update();
        }

        private void ConnectedToServer()
        {
            // Called when the client connects to the server
        }

        public void DisconnectFromServer()
        {
            Client.Disconnect();
        }

        private void PlayerDisconnect(object sender, ClientDisconnectedEventArgs e)
        {
            // When a player disconnects, remove them from the list of players
            // Remove player

        }

        public string IP { get; set; } = "127.0.0.1";

        public ushort Port { get; set; } = 4296;


        public void Connect(string ip, ushort port)
        {
            this.IP = ip;
            this.Port = port;
            Client = new Riptide.Client();
            Client.Connect($"{ip}:{port}");
        }

    }
}
