using CoreRCON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinecraftAutomationForWPF
{
    public class Move
    {
        public string LogMessage = ""; //ログメッセージ

        Environment Env = new Environment(); //プレイヤ環境データのインスタンス化

        public async void ButtonBitMove(short button) //プレイヤの移動
        {
            string TPCommand = "";

            switch (button)
            {
                case 0: //東
                    TPCommand = $"/tp {Env.PlayerName} ~+1 ~ ~";
                    break;

                case 1: //西
                    TPCommand = $"/tp {Env.PlayerName} ~-1 ~ ~";
                    break;

                case 2: //南
                    TPCommand = $"/tp {Env.PlayerName} ~ ~ ~-1";
                    break;

                case 3: //北
                    TPCommand = $"/tp {Env.PlayerName} ~ ~ ~+1";
                    break;

            }
            LogMessage = await Env.Connection.SendCommandAsync(TPCommand);
        }

        public async void Position() //プレイヤの現在位置を取得
        {
            string TPCommand = $"/tp {Env.PlayerName} ~ ~ ~";
            LogMessage = await Env.Connection.SendCommandAsync(TPCommand);
        }

    }
}
