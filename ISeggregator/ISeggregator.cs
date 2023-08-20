using System.Collections.Generic;
using System.Linq;
using DGS.Content.Translations;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


namespace DGS.Seggregators 
{
    // This code is a clean code version of my 2013 DGS 
     public interface ISegregator<T> where T : MainDocumentPart
     {

           T   FindDocumentPart(MainDocumentPart part);
           List<MainDocumentPart> LoadAllDocumentPart(DocumentContent documentContent);
           List<MainDocumentPart> SplitMerge(DocumentContent documentContent);
            


     }  


}