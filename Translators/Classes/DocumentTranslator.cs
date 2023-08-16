        // New .Net Core Implementation of old 2013 DGS
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System;
        using DGS.Translators;
        using DGS.Content.Translations;

public class DocumentTranslator : IDocumentTranslator<DocumentContent>
{
    public DocumentMetaInformation Translate(DocumentContent content)
    {
        /// <summary>
        /// find content translation Rule Vendor Information and perform machine learning Rule here
        /// </summary>
        /// if rule says Google call Google ML Services
        /// <returns></returns>
        throw new NotImplementedException();
    }

    public DocumentMetaInformation Translate(DocumentContent documentContent, bool overirde)
    {
        /// <summary>
        /// overide previous rules if ture 
        /// </summary>
        /// <returns></returns>
                throw new NotImplementedException();

    }
}