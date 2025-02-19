using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EF031.Entity
{
    //Entity
    //poco : plain old clr object 


    // EF CORE SUPPORT 4 WAYS FOR MAPPING CLASS IN DB
    //1:BY CONVERTION ANY CLASS CONVERT TO TABLE

    //internal class Employee    //Table (Employee)
    //{
    //    public int Id { get; set; } //PUBLIC numeric proberty named 'ID' or "Employee Id"
    //    public string Name { get; set; } //reference type (required)

    //    public int ?Age { get; set; } //nullable value type 

    //    public string Email { get; set; } //value type : float salary required

    //    public double ?salary { get; set; } //nvarchar (max)_optional

    //    public DateTime Dateofcration { get; set; } //DateTime required
    //}

    //BY DATA ANNOTATION : set of attribute used for data validation
    internal class Employee    
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } 

        [Required]
        [Column("EmpName",TypeName ="varchar")]
        [MaxLength(50)]
        [StringLength(50 , MinimumLength =10)]
        public string ?Name { get; set; }

        [Range(0,50)]
        public int? Age { get; set; }
        [EmailAddress]
        public string Email { get; set; } //value type : float salary required
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Column(TypeName ="money")]
        [DataType(DataType.Currency)]
        public double? salary { get; set; }

        [NotMapped]
        public double? totalsalary { get; set; }
       
    }


}
