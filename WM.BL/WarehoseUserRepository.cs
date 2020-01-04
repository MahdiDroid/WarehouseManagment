using System;
using System.Collections.Generic;
using System.Text;

namespace WM.BL
{
    public class WarehoseUserRepository
    {
        public List<WarehouseUser> RetrieveAll()
        {
            var warehouse= new List<Warehouse>{
                new Warehouse { Id=1,Name= "Laleh"},
                new Warehouse { Id = 2, Name = "Abresan" }
            };
            var users = new List<User>
            {
                new User {Id=99, Name= "Mehdi"},
                new User {Id=88, Name= "Ehsan"},

            };
            var warehouseUsers = new List<WarehouseUser>
            {
                new WarehouseUser{Id=30,UserId=99,WarehouseId=1}
            };
            return warehouseUsers;
        }
    }
}
