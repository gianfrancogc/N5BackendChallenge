using System;

namespace N5.Challenge.Domain.Entities
{
    public class Permission : BaseEntity
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public int PermissionTypeId { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public DateTime PermissionDate { get; set; }
    }
}
