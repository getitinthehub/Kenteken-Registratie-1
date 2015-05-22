using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratieLibrary
{
    internal class KentekenGenerator
    {
        public string LaatsteKenteken { get; private set; }
        private string kentekenFormat = "00-AA-00";

        private string sequenceOneFormat = "00";
        private string sequenceTwoFormat = "AA";
        private string sequenceThreeFormat = "00";

        internal KentekenGenerator()
        {
            // Laatste kenteken ophalen
            LaatsteKenteken = FileControl.GetLaatsteKenteken();

        }

        internal string GenereerNieuwKenteken()
        {
            string returnData = string.Empty;
            bool deel1LimitReached = false;
            bool deel2LimitReached = false;
            bool deel3LimitReached = false;

            if(LaatsteKenteken == "" || LaatsteKenteken == string.Empty || LaatsteKenteken == null)
            {
                return null;
            }

            string[] kentekenDelen = LaatsteKenteken.Split('-');

            if(kentekenDelen.Count() != 3)
            {
                return null;
            }

            if(int.Parse(kentekenDelen[0]) == 99)
            {
                deel1LimitReached = true;
            }

            if(kentekenDelen[1] == "ZZZ")
            {
                deel2LimitReached = true;
            }

            if(int.Parse(kentekenDelen[2]) == 99)
            {
                deel3LimitReached = true;
            }





            return returnData;
        }



    }

    internal static class FileControl
    {
        internal static string GetLaatsteKenteken()
        {
            return File.ReadAllText(Path.Combine(Environment.CurrentDirectory,"data","cache.txt"));
        }
        internal static bool SaveLaatsteKenteken(string kenteken)
        {
            bool flag = false;

            // Delete the old file
            File.Delete(Path.Combine(Environment.CurrentDirectory, "data", "cache.txt"));

            // Create the new file
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory,"data","cache.txt"), kenteken);

            // Check the saved value
            string savedValue = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "data", "cache.txt"));

            if(savedValue == kenteken)
            {
                flag = true;
            }

            return flag;
        }
    }
}
