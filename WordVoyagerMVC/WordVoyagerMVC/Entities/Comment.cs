//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordVoyagerMVC.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentId { get; set; }
        public Nullable<int> ArticleId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual User User { get; set; }
    }
}