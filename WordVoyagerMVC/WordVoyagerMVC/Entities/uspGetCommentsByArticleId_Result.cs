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
    
    public partial class uspGetCommentsByArticleId_Result
    {
        public int CommentId { get; set; }
        public Nullable<int> ArticleId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
    }
}
