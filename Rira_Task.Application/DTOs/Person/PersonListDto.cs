using Rira_Task.Application.DTOs.Common;
using Rira_Task.Application.DTOs.Person.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rira_Task.Application.DTOs.Person
{
    public class PersonListDto : BaseEntityDto, IPerson
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public string PersianDate { get; set; }

    }
}
