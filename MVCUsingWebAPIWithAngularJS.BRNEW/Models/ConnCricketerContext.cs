using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCUsingWebAPIWithAngularJS.BR.Models
{
    public class ConnCricketerContext : DbContext
    {
        public ConnCricketerContext() : base("name=CricketerDBEntities"){  }
        public virtual DbSet<Cricketer_Details> Cricketer_Details { get; set; }
        public virtual DbSet<Cricketer_ODI_Statistics> Cricketer_ODI_Statistics { get; set; }
        public virtual DbSet<Cricketer_Test_Statistics> Cricketer_Test_Statistics { get; set; }
        public virtual DbSet<Cricketer> Cricketers { get; set; }
    }
    public partial class Cricketer
    {       
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ODI { get; set; }
        public Nullable<int> Test { get; set; }
    }
    public partial class Cricketer_Details
    {
        [Key]
        public int Details_ID { get; set; }
        public Nullable<int> Cricketer_ID { get; set; }
        public string Team { get; set; }
        public Nullable<int> ODI_Runs { get; set; }
        public Nullable<int> Test_Runs { get; set; }
        public Nullable<int> Wickets { get; set; }
        public virtual Cricketer Cricketer { get; set; }
    }
    public partial class Cricketer_ODI_Statistics
    {
        [Key]
        public int ODI_ID { get; set; }
        public Nullable<int> Cricketer_ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Half_Century { get; set; }
        public Nullable<int> Century { get; set; }
        public virtual Cricketer Cricketer { get; set; }
    }
    public partial class Cricketer_Test_Statistics
    {
        [Key]
        public int Test_ID { get; set; }
        public Nullable<int> Cricketer_ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Half_Century { get; set; }
        public Nullable<int> Century { get; set; }
        public virtual Cricketer Cricketer { get; set; }
    }
}
