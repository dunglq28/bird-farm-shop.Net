using BFShopBussinessObjects.Entities;
using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class RoleRepository : IRoleRepository
    {
        
        public Role GetByDesc(string desc)
            => RoleDAO.Instance.GetByDesc(desc);
    }
}
