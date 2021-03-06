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
    
    public partial class Conversations
    {
        public long id { get; set; }
        public Nullable<long> is_permanent { get; set; }
        public string identity { get; set; }
        public Nullable<long> type { get; set; }
        public string live_host { get; set; }
        public Nullable<long> live_start_timestamp { get; set; }
        public Nullable<long> live_is_muted { get; set; }
        public string alert_string { get; set; }
        public Nullable<long> is_bookmarked { get; set; }
        public string given_displayname { get; set; }
        public string displayname { get; set; }
        public Nullable<long> local_livestatus { get; set; }
        public Nullable<long> inbox_timestamp { get; set; }
        public Nullable<long> inbox_message_id { get; set; }
        public Nullable<long> unconsumed_suppressed_messages { get; set; }
        public Nullable<long> unconsumed_normal_messages { get; set; }
        public Nullable<long> unconsumed_elevated_messages { get; set; }
        public Nullable<long> unconsumed_messages_voice { get; set; }
        public Nullable<long> active_vm_id { get; set; }
        public Nullable<long> context_horizon { get; set; }
        public Nullable<long> consumption_horizon { get; set; }
        public Nullable<long> last_activity_timestamp { get; set; }
        public Nullable<long> active_invoice_message { get; set; }
        public Nullable<long> spawned_from_convo_id { get; set; }
        public Nullable<long> pinned_order { get; set; }
        public string creator { get; set; }
        public Nullable<long> creation_timestamp { get; set; }
        public Nullable<long> my_status { get; set; }
        public Nullable<long> opt_joining_enabled { get; set; }
        public string opt_access_token { get; set; }
        public Nullable<long> opt_entry_level_rank { get; set; }
        public Nullable<long> opt_disclose_history { get; set; }
        public Nullable<long> opt_history_limit_in_days { get; set; }
        public Nullable<long> opt_admin_only_activities { get; set; }
        public string passwordhint { get; set; }
        public string meta_name { get; set; }
        public string meta_topic { get; set; }
        public string meta_guidelines { get; set; }
        public byte[] meta_picture { get; set; }
        public Nullable<long> premium_video_status { get; set; }
        public Nullable<long> premium_video_is_grace_period { get; set; }
        public string guid { get; set; }
        public string dialog_partner { get; set; }
        public string meta_description { get; set; }
        public string premium_video_sponsor_list { get; set; }
        public Nullable<long> chat_dbid { get; set; }
        public Nullable<long> history_horizon { get; set; }
        public Nullable<long> extprop_profile_height { get; set; }
        public Nullable<long> extprop_chat_width { get; set; }
        public Nullable<long> extprop_chat_left_margin { get; set; }
        public Nullable<long> extprop_chat_right_margin { get; set; }
        public Nullable<long> extprop_entry_height { get; set; }
        public Nullable<long> extprop_windowpos_x { get; set; }
        public Nullable<long> extprop_windowpos_y { get; set; }
        public Nullable<long> extprop_windowpos_w { get; set; }
        public Nullable<long> extprop_windowpos_h { get; set; }
        public Nullable<long> extprop_window_maximized { get; set; }
        public Nullable<long> extprop_window_detached { get; set; }
        public Nullable<long> extprop_pinned_order { get; set; }
        public Nullable<long> extprop_new_in_inbox { get; set; }
        public Nullable<long> extprop_tab_order { get; set; }
        public Nullable<long> extprop_video_layout { get; set; }
        public Nullable<long> extprop_video_chat_height { get; set; }
        public Nullable<long> extprop_chat_avatar { get; set; }
        public Nullable<long> extprop_consumption_timestamp { get; set; }
        public Nullable<long> extprop_form_visible { get; set; }
        public Nullable<long> extprop_recovery_mode { get; set; }
        public string mcr_caller { get; set; }
        public string history_sync_state { get; set; }
    }
}
