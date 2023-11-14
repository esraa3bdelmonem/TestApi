using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Domin
{
    public class Country
    {
   
        
        public int Id { get; set; }
        public string Name{ get; set; }= string.Empty;
        [Index(IsUnique = true)]
        public int Code { get; set; }
    }
}
