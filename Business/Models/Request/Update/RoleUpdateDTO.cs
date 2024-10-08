using System;

namespace Business.Models.Request.Update
{
    public class RoleUpdateDTO
    {
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; }
    }
}
