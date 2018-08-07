using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project_V1.Music
{
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string SoundName { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, string soundName, SoundCategory category)
        {
            SoundName = soundName;
            Name = name;
            Category = category;
            SoundName = soundName;
            AudioFile = String.Format("/Assets/Audio/{0}/{1}.mp3", category, name);
            ImageFile = String.Format("/Assets/Images/{0}/{1}.jpg", category, name);
        }

    }

    public enum SoundCategory
    {
        Avicii,
        Others
    }

}
