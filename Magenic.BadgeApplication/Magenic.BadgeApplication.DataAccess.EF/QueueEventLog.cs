//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magenic.BadgeApplication.DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class QueueEventLog
    {
        public int QueueEventLogId { get; set; }
        public int QueueEventId { get; set; }
        public int BadgeAwardId { get; set; }
        public System.DateTime QueueEventCreated { get; set; }
        public string Message { get; set; }
    
        public virtual BadgeAward BadgeAward { get; set; }
        public virtual QueueEvent QueueEvent { get; set; }
    }
}