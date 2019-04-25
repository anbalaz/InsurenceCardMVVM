﻿using System;

namespace Support.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonIdNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime ValidFrom { get; set; }
    }
}
