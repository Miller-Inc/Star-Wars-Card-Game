using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Riptide;
using Riptide.Utils;

namespace Star_Wars_Card_Game.Backend.Server
{

    public enum ServerToClientId : ushort
    {
        playerSpawned = 1,
        playerDespawned = 2,

    }

    public enum ClientToServerId : ushort
    {
        name = 1, 

    }

    public class ServerBase
    {
        public static Riptide.Server Server { get; private set; }

        public static ushort Port { get; private set; }

        public static ushort MaxClients { get; private set; }

        public static void FixedUpdate()
        {
            Server.Update();
        }

        public static void StopServer()
        {
            Running = false;
            Server.Stop();
        }

        public static void StartServer(ushort port, ushort maxClients)
        {
            Port = port;
            MaxClients = maxClients;

            if (Server != null || Server.IsRunning)
                return;

            Server = new Riptide.Server();
            Server.Start(port, maxClients);
            Server.ClientDisconnected += PlayerDisconnect;
            Server.ClientConnected += PlayerConnect;
        }

        public static volatile bool Running = true;

        public static void PlayerConnect(object sender, ServerConnectedEventArgs e)
        {
            // When a player connects, add them to the list of players
            Player.AddPlayer("Guest", e.Client.Id);
        }

        private static void PlayerDisconnect(object sender, ServerDisconnectedEventArgs e)
        {
            // When a player disconnects, remove them from the list of players
            Player.Players.Remove(e.Client.Id);
            // Do anything else needed to remove the player
            Message message = Message.Create(MessageSendMode.Reliable, (ushort)ServerToClientId.playerDespawned);
            message.AddUShort(e.Client.Id);
            Server.SendToAll(message, e.Client.Id);
        }
    }
}
