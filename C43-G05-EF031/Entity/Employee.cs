using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EF031.Entity
{
    //Entity
    //poco : plain old clr object 


    // EF CORE SUPPORT 4 WAYS FOR MAPPING CLASS IN DB
    //1:BY CONVERTION ANY CLASS CONVERT TO TABLE

    internal class Employee    //Table (Employee)
    {
        public int Id { get; set; } //PUBLIC numeric proberty named 'ID' or "Employee Id"
        public string Name { get; set; } //reference type (required)

        public int ?Age { get; set; } //nullable value type 

        public string Email { get; set; } //value type : float salary required

        public double ?salary { get; set; } //nvarchar (max)_optional

        public DateTime Dateofcration { get; set; } //DateTime required
    }
}
