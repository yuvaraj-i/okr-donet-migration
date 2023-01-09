using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
