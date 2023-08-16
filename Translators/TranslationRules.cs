using System.Collections.Generic;

using System.Linq;
using System.Text;


namespace DGS.Translators
{
    public class TranslationRules 
    {
        public string SourceCulture { get; set; }
        public string Language { get; set; }
        public List<string> DestinationCulture {get;set;}

        public List<string> FindSpecificRegularExpressionsMatch {get;set;}    

        public bool ConvertImagesToBinaries {get;set;} 

        public bool SaveSnapShots {get;set;}

        public TranslatioEngine TranslatioEngineVendor { get; set; }

        


        


    }
}


