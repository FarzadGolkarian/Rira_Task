using Rira_Task.Application.DTOs.Person.Interfaces;

namespace Rira_Task.Application.DTOs.Person
{
    public class UpdatePersonDto : IPerson
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public string PersianDate { get; set; }

    }
}
