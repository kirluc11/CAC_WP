using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;

namespace CAC_WP.BL
{
    class PlayFunction : Function
    {
        private static PlayFunction instance;

        private PlayFunction()
        {
        }

        public static PlayFunction getInstance()
        {
            if (instance == null)
            {
                instance = new PlayFunction();
            }
            return instance;
        }

        public new void Execute()
        {
            MediaPlayer player = BackgroundMediaPlayer.Current;
            if (player.CanPause)
            {
                player.Play();
            }
        }
    }
}
