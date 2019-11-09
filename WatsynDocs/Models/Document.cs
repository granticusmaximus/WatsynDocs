using System;
using System.ComponentModel.DataAnnotations;

namespace WatsynDocs.Models
{
    public class Document
    {
        [Key]
        public Guid DocumentID { get; set; }
        public string DocumentTitle { get; set; }
    }
}
