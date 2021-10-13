using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBroad.Models
{
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AutoFile { get; set; }
        public string ImgFile { get; set; }
        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AutoFile = string.Format("/Assets/Audio/{0}/{1}.wav", category, name);
            ImgFile = string.Format("/Assets/Images/{0}/{1}.png", category, name);
        }
       
    }
    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
}
