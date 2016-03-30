using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;

//using Microsoft.Phone.BackgroundAudio;

namespace CAC_WP.BL
{
    class NextFunction : Function
    {
        private static NextFunction instance;

        private NextFunction()
        {
        }

        public static NextFunction getInstance()
        {
            if(instance == null)
            {
                instance = new NextFunction();
            }
            return instance;
        }

        public new void Execute()
        {
            MediaPlayer player = BackgroundMediaPlayer.Current;
            
        }
    }
}
