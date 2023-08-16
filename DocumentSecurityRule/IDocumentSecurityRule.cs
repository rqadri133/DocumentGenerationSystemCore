using System;
using System.Collections.Generic;
using System.Linq;

using DGS.Content.Translations;

namespace DGS.DocumentSecurityService
{
    public enum SecurityType 
    {
        HahedBases64 ,
        RSAEncryption ,
        CustomPhrasesModelFakeBinariesSerialized ,
        BlowFish,
        TowFish,
        AES
    }
    public interface IDocumentSecurity
    {
        public DocumentContent SecureDocument(DocumentContent content);
        

    }

}