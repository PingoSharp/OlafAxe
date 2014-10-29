using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;


namespace OlafAxe
{
    class Program
    {
        private static GameObject _axeObj;

        static void Main(string[] args)
        {
            Drawing.OnDraw += Drawing_OnDraw;
            GameObject.OnCreate += GameObject_OnCreate;
            GameObject.OnDelete += GameObject_OnDelete;
        }

        private static void GameObject_OnCreate(GameObject obj, EventArgs args)
        {
            if (obj.Name.Equals("olaf_axe_totem_team_id_green.troy"))
                _axeObj = obj;
        }

        private static void GameObject_OnDelete(GameObject obj, EventArgs args)
        {
            if (obj.Name.Equals("olaf_axe_totem_team_id_green.troy"))
                _axeObj = null;
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            if (_axeObj != null)
            {
                var screenCoord = Drawing.WorldToScreen(_axeObj.Position);
                Drawing.DrawText(screenCoord.X, screenCoord.Y, Color.BlueViolet, "AXEEE");
            }
        }
    }
}
