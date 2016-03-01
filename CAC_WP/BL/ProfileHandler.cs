using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAC_WP.BL
{
    class ProfileHandler
    {
        // File

        private static ProfileHandler instance;

        private LinkedList<Profile> profiles = new LinkedList<Profile>();

        private ProfileHandler()
        {

        }

        public static ProfileHandler getInstance()
        {
            if(instance == null)
            {
                instance = new ProfileHandler();
            }
            return instance;
        }

        public void AddProfile(Profile profile)
        {
            if(!profiles.Contains(profile))
            {
                profiles.AddLast(profile);
            }
        }

        public void SaveProfiles()
        {
            //todo Save all profiles in one binary file
        }

        public void LoadProfiles()
        {
            this.profiles.Clear();

            //todo Load all profiles from one binary file
        }
    }
}
