namespace Rira_Task.Application.DTOs.Common
{
    public class BaseEntityDto
    {
        public int ID { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}
