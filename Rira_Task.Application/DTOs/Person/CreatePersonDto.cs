using Rira_Task.Application.DTOs.Common;
using Rira_Task.Application.DTOs.Person.Interfaces;

namespace Rira_Task.Application.DTOs.Person
{
    public class CreatePersonDto : BaseEntityDto, IPerson
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public string PersianDate { get; set; }

    }
}
