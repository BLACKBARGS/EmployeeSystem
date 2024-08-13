namespace BaseLibrary.Entities
{
    public class Branch : BaseEntity 
    {
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }
        public List<Employee>? Employees { get; set; }
     }
}
