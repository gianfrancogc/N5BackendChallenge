using System;

namespace N5.Challenge.Application.Dtos
{
    public class GetAllPermissionsViewModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public string PermissionType { get; set; }
    }

    public class GetPermissionViewModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public string PermissionType { get; set; }
        public int PermissionTypeId { get; set; }
        public DateTime PermissionDate { get; set; }
    }
}
