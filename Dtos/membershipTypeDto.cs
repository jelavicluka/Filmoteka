using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Filmoteka.Dtos
{
    public class membershipTypeDto
    {
        public byte Id { get; set; }
       
        public string Name { get; set; }

    }
}