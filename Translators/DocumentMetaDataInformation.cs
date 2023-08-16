   using System.Collections.Generic;
   using System.Linq;
   using System;

  namespace DGS.Translators 
  {
     public class DocumentMetaInformation 
      {

        public string HeaderName { get; set;}
        public string Title { get; set;}
        public DateTime TimeStamp { get; set;}
        public List<string> DocumentContentTranslationInformation {get; set;}

        public string OriginalCulture {get;set;}

        public List<string> DestinationCultures {get;set;}




      }


  }
    