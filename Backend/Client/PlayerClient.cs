using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riptide;
using Riptide.Utils;
using Star_Wars_Card_Game.Backend.Server;
using Star_Wars_Card_Game.Backend; 

namespace Star_Wars_Card_Game.Backend.Client
{
    public class PlayerClient
    {
        public static Dictionary<ushort, PlayerClient> Players = [];

        public ushort PlayerID { get; private set; } = 0;

        public string Name { get; private set; } = "None";

        public string Username { get; private set; } = "None";

        public bool IsLocalPlayer { get; private set; } = false; 

        public static void SpawnPlayer(string username, ushort playerID)
        {
            PlayerClient player = new();
            if (playerID == ClientBase.Client.Id)
            {
                // Create a local player
                player = new()
                {
                    IsLocalPlayer = false
                };
            }
            else
            {
                // Create a remote player
                player = new()
                {
                    IsLocalPlayer = false
                };

            }
            player.PlayerID = playerID;
            player.Username = username;
            Players.Add(playerID, player);
        }   


        public void OnDestroy()
        {
            Players.Remove(PlayerID);
        }

        private static ClientBase ClientBase;




        #region Messages

        [MessageHandler((ushort)ServerToClientId.playerSpawned)]
        private static void SpawnPlayer(ushort fromClient, Message message)
        {
            // Use in order that set up in the message
            SpawnPlayer(message.GetString(), message.GetUShort());
        }

        #endregion
    }
}
