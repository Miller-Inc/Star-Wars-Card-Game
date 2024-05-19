using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riptide;
using Riptide.Utils;
using Star_Wars_Card_Game.Backend; 

namespace Star_Wars_Card_Game.Backend.Server
{
    public class Player
    {
        public static Dictionary<ushort, Player> Players = new Dictionary<ushort, Player>();

        public ushort PlayerID { get; private set; }

        public string Name { get; private set; }

        public string Username { get; private set; }

        public static void AddPlayer(string username, ushort playerID)
        {
            foreach (Player otherPlayer in Players.Values)
            {
               otherPlayer.SendSpawned(playerID);
            }

            username = $"Player {playerID} ({(string.IsNullOrEmpty(username) ? "Guest" : username)})";
            username = $"{(string.IsNullOrEmpty(username) ? "Guest" : username)}";
            Player player = new()
            {
                Name = $"Player {playerID} ({username})",
                PlayerID = playerID,
                Username = username
            };

            
            player.SendSpawned();
            Players.Add(playerID, player);
        }

        public void OnDestroy()
        {
            Players.Remove(PlayerID);
        }

        private static ServerBase ServerBase; 

        [MessageHandler((ushort)ClientToServerId.name)]
        private static void Create(ushort fromClient, Message message)
        {
            AddPlayer(message.GetString(), fromClient);
        }

        #region Messages
        private void SendSpawned()
        {
            Message message = Message.Create(MessageSendMode.Reliable, (ushort)ServerToClientId.playerSpawned);
            message.AddUShort(PlayerID);
            message.AddString(Name);
            ServerBase.Server.SendToAll(message);
        }
        // fix this 16:48
        private void SendSpawned(ushort playerId)
        {
            Message message = Message.Create(MessageSendMode.Reliable, (ushort)ServerToClientId.playerSpawned);
            message.AddUShort(PlayerID);
            message.AddString(Name);
            ServerBase.Server.Send(message, playerId);
        }

        #endregion
    }
}
