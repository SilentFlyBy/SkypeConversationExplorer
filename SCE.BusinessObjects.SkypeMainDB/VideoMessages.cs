//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCE.BusinessObjects.SkypeMainDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class VideoMessages
    {
        public long id { get; set; }
        public Nullable<long> is_permanent { get; set; }
        public byte[] qik_id { get; set; }
        public string attached_msg_ids { get; set; }
        public string sharing_id { get; set; }
        public Nullable<long> status { get; set; }
        public Nullable<long> vod_status { get; set; }
        public string vod_path { get; set; }
        public string local_path { get; set; }
        public string public_link { get; set; }
        public Nullable<long> progress { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public Nullable<long> creation_timestamp { get; set; }
    }
}
