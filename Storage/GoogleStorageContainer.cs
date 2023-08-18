        using DGS.StorageContainers;
        using System ;
        using System.Collections.Generic;
        using System.Linq;
        using System.Runtime.CompilerServices;
        using DGS.Translators;
        using DGS.Content.Translations;

        namespace DGS.StorageContainers
        {
        public class GoogleContianerManager : IStorageContainerHolder<ConnectorInfo>
        {  
            public string Url { get; set; }
            public string ContaninerName { get; set; }

           
            public string ContaninerTypeDescription { get; set; }
        ConnectorStorgeType IStorageContainerHolder<ConnectorInfo>.ContaninerType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool ConnectToContainer(string endpoint , ConnectorInfo model)
            {
              /// <summary>
              /// 
              /// </summary>
              /// <param name="endpoint"></param>
              /// <param name="filePath"></param>
              /// <returns></returns>
              return true;
              
            }

            public string UploadToContainer (string endpoint , ConnectionInfo filePath) 
            { 
              throw new NotImplementedException();

            }     
        
            public DocumentContent LoadDocument(ConnectorInfo connector) 
            {
                throw new NotImplementedException();


            }

              
                public string UploadToContainer(string endpoint, ConnectorInfo filePath)
                {
                    throw new NotImplementedException();
                }
            }

        }
