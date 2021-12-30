namespace D_Ui.Models.Data.Entity
{
    public class EventApplication:BaseEntity
    {
        public int EventId { get; set; }
        public string UserId { get; set; }
        public virtual Event Event{ get; set; }
    }
}
