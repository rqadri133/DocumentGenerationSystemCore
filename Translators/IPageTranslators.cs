using System;
using System.Collections.Generic;
using System.Linq;
using DGS.Content.Translations;
using DGS.StorageContainers;

namespace DocumentGenerationSystemCore.Page.Translator 
{
          public interface IPageTranslators<T> where T : DocumentContent 
            {

             T TranslateDocument(T content, ConnectorInfo connectionInfo);



      } 




}