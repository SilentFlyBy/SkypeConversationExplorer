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
    
    public partial class Alerts
    {
        public long id { get; set; }
        public Nullable<long> is_permanent { get; set; }
        public Nullable<long> timestamp { get; set; }
        public string partner_name { get; set; }
        public Nullable<long> is_unseen { get; set; }
        public Nullable<long> partner_id { get; set; }
        public string partner_event { get; set; }
        public string partner_history { get; set; }
        public string partner_header { get; set; }
        public string partner_logo { get; set; }
        public Nullable<long> meta_expiry { get; set; }
        public string message_header_caption { get; set; }
        public string message_header_title { get; set; }
        public string message_header_subject { get; set; }
        public string message_header_cancel { get; set; }
        public string message_header_later { get; set; }
        public string message_content { get; set; }
        public string message_footer { get; set; }
        public string message_button_caption { get; set; }
        public string message_button_uri { get; set; }
        public Nullable<long> message_type { get; set; }
        public Nullable<long> window_size { get; set; }
        public byte[] chatmsg_guid { get; set; }
        public Nullable<long> notification_id { get; set; }
        public Nullable<long> event_flags { get; set; }
        public Nullable<long> extprop_hide_from_history { get; set; }
    }
}
