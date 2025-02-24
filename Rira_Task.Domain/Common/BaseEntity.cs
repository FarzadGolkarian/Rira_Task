namespace Rira_Task.Domain.Common
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public bool? IsActive { get; set; } = true;
        public DateTime LastModifiedDate { get; set; } =DateTime.Now;
        public DateTime DateCreated { get; set; } = DateTime.Now;


    }
}
