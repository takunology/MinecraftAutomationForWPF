using CoreRCON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// プレイヤーの環境データ
/// サーバアドレス、パス、プレイヤー名など
/// </summary>

namespace MinecraftAutomationForWPF
{
    public class Environment
    {
        public string PlayerName = "Prau_Splacraft";
        private static IPAddress ServerAddrss = IPAddress.Parse("127.0.0.1");
        private static string ServerPass = "minecraft";
        private static ushort Port = 25575;
        public RCON Connection = new RCON(ServerAddrss, Port, ServerPass);
    }
}
