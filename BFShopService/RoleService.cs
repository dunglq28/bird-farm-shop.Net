using BFShopBussinessObjects.Entities;
using BFShopRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepo;

        public RoleService()
        {
            _roleRepo = new RoleRepository();
        }
        public Role GetByDesc(string desc)
            => _roleRepo.GetByDesc(desc);
    }
}
