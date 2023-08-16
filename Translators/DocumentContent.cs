using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DGS.Translators;
using Microsoft.Net.Http.Headers;

namespace DGS.Content.Translations 
{
public enum DocumentType
{ 
    FlatFile ,
    WordprocessingDocument,
    WordProcessingSheets,
    ApplePageFormats ,
    XmlFiles ,
    JSONFiles ,
    PDFFiles,
    ImageProcessingOnly 
 
}

public class Document
{
    public string DocumentName {get; set;}
    public string DocumentVersion {get; set;}
    public string filePath {get; set;}
    public DocumentType DocumentType {get; set;}


}
public class DocumentContent
{
    public string Title { get; set;}
    public string ContentDesc { get; set;}

  
     
     public  List<Document> DocumentCollection
     {
        get;
        set;
     }   
     public DateTime DocumentCreatedDate { get; set; }

     public TranslationRules translationRules{ get; set; }
     

    
}
 


}

