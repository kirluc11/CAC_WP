using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;

namespace CAC_WP.BL
{
    class PriviousFunction : Function
    {
        private static PriviousFunction instance;

        private PriviousFunction()
        {
        }

        public static PriviousFunction getInstance()
        {
            if (instance == null)
            {
                instance = new PriviousFunction();
            }
            return instance;
        }

        public new void Execute()
        {
            MediaPlayer player = BackgroundMediaPlayer.Current;
        }
    }
}
