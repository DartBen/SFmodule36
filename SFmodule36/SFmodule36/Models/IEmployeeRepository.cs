using System;
using System.Collections.Generic;

namespace SFmodule36.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(Guid id);

        void Add(Employee employee);

        void Delete(Guid id);
    }
}
