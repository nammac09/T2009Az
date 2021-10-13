using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBroad.Models
{
    public class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = GetSounds();
            sounds.Clear();
            allSounds.ForEach(a => sounds.Add(a));

        }
        public static void GetAllSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundcategory)
        {
            var allSounds = GetSounds();
            var filterSound = allSounds.Where(p => p.Category == soundcategory).ToList();
            sounds.Clear();
            filterSound.ForEach(a => sounds.Add(a));

        }
        public static void GetAllSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            var allSounds = GetSounds();
            var filterSound = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filterSound.ForEach(a => sounds.Add(a));

        }
        public static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));


            return sounds;
        }
    }
}
