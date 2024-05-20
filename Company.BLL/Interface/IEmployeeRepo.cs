﻿using Company.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Interface
{
    public interface IEmployeeRepo : IGenericRepo<Employee>
    {
        IEnumerable<Employee> GetAllByName(Expression<Func<Employee,bool>> expression);
    }
}
