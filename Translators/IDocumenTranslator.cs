using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using DGS.Content.Translations;

namespace DGS.Translators 
{
      public enum TranslatioEngine 
      {
        GoogleMl ,
        MicrosoftMl,
        MetaFaceBookMl,
        AWsML 
      }

     
        public interface IDocumentTranslator<T> where T : DocumentContent 
        {
            public DocumentMetaInformation Translate(DocumentContent content );
            public DocumentMetaInformation Translate(DocumentContent documentContent, bool overirde);
            

        }


}