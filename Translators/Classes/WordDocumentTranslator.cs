using System.Collections.Generic;
using System;
using DGS.Content.Translations;
using DGS.StorageContainers;

namespace DocumentGenerationSystemCore.Page.Translator 
{
    public class WordDocumentTranslator<T> : IPageTranslators<DocumentContent> where T : DocumentContent
    {
        private readonly IStorageContainerHolder<ConnectorInfo> storageContainerHolderRef ; 
        
        public WordDocumentTranslator (IStorageContainerHolder<ConnectorInfo> storageContainerHolder)
        {
            storageContainerHolderRef = storageContainerHolder;
        }

       

        public DocumentContent TranslateDocument(DocumentContent content, ConnectorInfo connectionInfo)
        {
            switch(connectionInfo.ConnectorStorgeType)
            {
               case ConnectorStorgeType.GoogleFirebaseStorage :
                break;


            }
            /// <summary>
            /// impelmentation Required New Seggrated Architecture in Progress 
            /// </summary>
            /// <returns></returns>
            return new DocumentContent();
          
        }
    }



}