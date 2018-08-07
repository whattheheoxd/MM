using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project_V1.Music
{   ///Add new songs in this class
    public class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allsounds = GetSounds();
            sounds.Clear();
            allsounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory sc)
        {
            var allsounds = GetSounds();
            var filteredSounds = allsounds.Where(p => p.Category == sc).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        //Add songs to the list to the list
        private static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();

            //Usage: Sound("Song Name", "Song Name", Category)
            sounds.Add(new Sound("Wake Me up", "Wake Me up", SoundCategory.Avicii));
            sounds.Add(new Sound("Addicted to You", "Addicted to You", SoundCategory.Avicii));
            sounds.Add(new Sound("Hey Brother", "Hey Brother", SoundCategory.Avicii));

            sounds.Add(new Sound("Guts Over Fear", "Guts Over Fear", SoundCategory.Others));
            sounds.Add(new Sound("Me Myself and I", "Me Myself and I", SoundCategory.Others));
            sounds.Add(new Sound("Mentalism", "Mentalism", SoundCategory.Others));
            sounds.Add(new Sound("Middle", "Middle", SoundCategory.Others));
            sounds.Add(new Sound("You Know You Like it", "You Know You Like it", SoundCategory.Others));

            return sounds;
        }
        public static void GetSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            var allsounds = GetSounds();
            var filteredSounds = allsounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
    }
}