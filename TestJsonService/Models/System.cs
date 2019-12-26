using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestJsonService.Models {
    public class System {

        [Key]
        [StringLength(50)]
        public string Key { get; set; }
        [Required]
        [StringLength(50)]
        public string Value { get; set; }

        public System() {}
    }
}
