using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Server
{
    public class ServerSend
    {
        private void SendTCPData(ushort toClient, Packet packet)
        {
            packet.WriteLength();
            ServerBase.Server.Clients[toClient].SendData(packet);
        }

        public static void Welcome(ushort toClient, string message)
        {
            using (Packet packet = new((ushort)ServerToClientId.playerSpawned))
            {
                packet.Write(message);
                packet.Write(toClient);

                SendTCPData(toClient, packet);
            }
        }
    }
}
