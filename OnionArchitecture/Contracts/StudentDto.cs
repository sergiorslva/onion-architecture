﻿using Domain.Enums;

namespace Contracts
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public Boolean Deleted { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public StudentLevelEnum StudentLevelEnum { get; set; }
    }
}
