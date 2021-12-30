using System;
using System.ComponentModel.DataAnnotations;
namespace D_Ui.Models.Data
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
