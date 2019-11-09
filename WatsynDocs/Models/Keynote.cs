using System;
using System.ComponentModel.DataAnnotations;

namespace WatsynDocs.Models
{
    public class Keynote
    {
        [Key]
        public Guid KeynoteID { get; set; }
        public string KeynoteTitle { get; set; }
    }
}
