using System;

namespace Business.Models.Request.Create
{
    public class EmployeeCreateDTO
    {
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public int DepartmentId { get; set; }
    }
}
