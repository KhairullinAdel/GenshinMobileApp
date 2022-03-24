using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace GenshinMobileApp.DB
{
    public static class Case
    {
        public static string baseUrl { get; private set; } = @"https://api.genshin.dev/";
        public static string baseImgUrl = "https://paimon.moe/images/characters/";
        public static List<Characters> characters { get; set; } = new List<Characters>()
        {
            new Characters("Venti", "Anemo", "Bow", baseImgUrl + "venti.png",baseImgUrl + "full/venti.png"),
            new Characters("Hu Tao", "Pyro", "Spear",baseImgUrl + "hu_tao.png",baseImgUrl + "full/hu_tao.png"),
            new Characters("Ganyu", "Cryo", "Bow",baseImgUrl + "ganyu.png",baseImgUrl + "full/ganyu.png"),
            new Characters("Bennet", "Pyro", "Sword",baseImgUrl + "bennett.png",baseImgUrl + "full/bennett.png"),
            new Characters("Qiqi", "Cryo", "Claymore",baseImgUrl + "qiqi.png",baseImgUrl + "full/qiqi.png"),
            new Characters("Raiden Shogun", "Electro", "Spear",baseImgUrl + "raiden_shogun.png",baseImgUrl + "full/raiden_shogun.png")
        };
    }
}
