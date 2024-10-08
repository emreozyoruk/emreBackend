using System;

namespace Business.Models.Request.Create
{
    public class RoleCreateDTO
    {
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; }
    }
}
