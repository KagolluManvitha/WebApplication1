using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graphql_project.Model
{
    public class Cake
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string? description{ get; set; }
        public int? price { get; set; }

    }
}
