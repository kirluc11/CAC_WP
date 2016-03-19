using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CAC_WP.BL
{
    
    class ProfileHandler 
    {
        private string filePath = "profiles.txt";

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

        public async Task SaveProfiles()
        {
            //var serializer = new DataCotractSerializer(typeof(LinkedList<Profile>));
        }

        public void LoadProfiles()
        {
            this.profiles.Clear();

            //todo Load all profiles from one binary file
        }
    }
}
