using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DGS.Content.Translations;
using DGS.Translators;


namespace DGS.StorageContainers
{

   public enum ConnectorStorgeType 
   {
      GoogleFirebaseStorage ,
      AzureFirebaseStorage,
      FTPFileStorage,
      AWSBuckets 
   }


   public class ConnectorInfo 
   {
      private readonly string _url = String.Empty ;  
      public ConnectorInfo(string Url)
      {
         _url = Url;
      
      }
   
      public ConnectorStorgeType ConnectorStorgeType 
      {
         get;
         set;

      }

      

      public List<DocumentContent> DocumentContents 
      {
         get;
         set;
      }

   }



}
