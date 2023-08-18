    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.Metadata;
    using System.Text;
    using DGS.Content.Translations;
    using DGS.Translators;

    namespace DGS.StorageContainers
    {


    public interface IStorageContainerHolder<T> where T :  ConnectorInfo
    {
        public string Url { get; set; }
        public string ContaninerName { get; set; }

        public ConnectorStorgeType ContaninerType { get;  set;}   
        public string ContaninerTypeDescription { get; set; }

        public bool ConnectToContainer(string endpoint , T model);

        public string UploadToContainer (string endpoint , T filePath) ;
    
        public DocumentContent LoadDocument(T connector);




    }

    }