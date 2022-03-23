using System;
using System.Collections.Generic;
using System.Text;

namespace GenshinMobileApp.DB
{
    public class Characters
    {
        public string name { get; set; }
        public string vision { get; set; }
        public string weapon { get; set; }
        public string image { get; set; }
        public string fullImage { get; set; }

        public Characters(string name, string vision, string weapon, string image, string fullImage)
        {
            this.name = name;
            this.vision = vision;
            this.weapon = weapon;
            this.image = image;
            this.fullImage = fullImage;
        }
        public Characters(string name, string vision, string weapon)
        {
            this.name = name;
            this.vision = vision;
            this.weapon = weapon;
            this.image = image;
            this.fullImage = fullImage;
        }
    }
}
