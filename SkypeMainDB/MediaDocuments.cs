//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkypeMainDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class MediaDocuments
    {
        public long id { get; set; }
        public Nullable<long> is_permanent { get; set; }
        public Nullable<long> storage_document_id { get; set; }
        public Nullable<long> status { get; set; }
        public Nullable<long> doc_type { get; set; }
        public string uri { get; set; }
        public string original_name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string thumbnail_url { get; set; }
        public string web_url { get; set; }
        public string mime_type { get; set; }
        public string type { get; set; }
        public string service { get; set; }
        public Nullable<long> consumption_status { get; set; }
        public Nullable<long> convo_id { get; set; }
        public Nullable<long> message_id { get; set; }
    }
}