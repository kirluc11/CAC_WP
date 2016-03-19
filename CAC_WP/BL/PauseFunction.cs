using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;

namespace CAC_WP.BL
{
    class PauseFunction : Function
    {
        private static PauseFunction instance;

        private PauseFunction()
        {
        }

        public static PauseFunction getInstance()
        {
            if (instance == null)
            {
                instance = new PauseFunction();
            }
            return instance;
        }

        public new void Execute()
        {
            MediaPlayer player = BackgroundMediaPlayer.Current;
            if(player.CanPause)
            {
                player.Pause();
            }
        }
    }
}
