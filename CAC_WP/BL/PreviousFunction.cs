using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;

namespace CAC_WP.BL
{
    class PreviousFunction : Function
    {
        private static PreviousFunction instance;

        private PreviousFunction()
        {
        }

        public static PreviousFunction getInstance()
        {
            if (instance == null)
            {
                instance = new PreviousFunction();
            }
            return instance;
        }

        public new void Execute()
        {
            MediaPlayer player = BackgroundMediaPlayer.Current;
        }
    }
}
