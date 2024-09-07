﻿namespace G6.NetITIMVCDay04.Models
{
    public class Department
    {
        /*--------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*--------------------------------------------------------*/
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        /*--------------------------------------------------------*/
    }
}
