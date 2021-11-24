using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //Подключаем для работы с БД

namespace ToDoList
{
    class AppContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppContext() : base("DefaultConnection") {
            //Database.SetInitializer<AppContext>(null);
        }
    }
}
