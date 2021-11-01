using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.models
{
    class sound
    {
        public string Name { get; set; }
        public string Nameimg { get; set; }
        public string Source { get; set; }
        public string audioFile { get; set; }
        public string imgFile { get; set; }
        public sound(string name, string source, string nameimg)
        {
            Nameimg = nameimg;
            Name = name;
            Source = source;
            audioFile = string.Format("/Assets/sound/{0}", source);
            imgFile = string.Format("/Assets/img/{0}", nameimg);
        }
    }
}
