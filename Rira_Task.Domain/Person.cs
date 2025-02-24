using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rira_Task.Domain.Common;


namespace Rira_Task.Domain
{
    public class Person : BaseEntity
    {        
        public string Name { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public string PersianDate { get; set; }

    }
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {    
       
        public void Configure(EntityTypeBuilder<Person> b)
        {

        }
    }

}
