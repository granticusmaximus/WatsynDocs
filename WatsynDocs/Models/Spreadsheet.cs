using System;
using System.ComponentModel.DataAnnotations;

namespace WatsynDocs.Models
{
    public class Spreadsheet
    {
        [Key]
        public Guid SpreadsheetID { get; set; }
    }
}
