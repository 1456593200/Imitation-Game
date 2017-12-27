using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.Entities;

namespace v1.Domain.IRepository
{
    public interface IManagerRepository
    {
        IEnumerable<Manager> Managers { get; }
    }
}
