﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Technology
    {
        public int Id { get; set; } 
        public string Name { get; set; }  
        public int ProgrammingLanguageId { get; set; }  
        public ProgrammingLanguage ProgrammingLanguage { get; set; } 
    }

}
