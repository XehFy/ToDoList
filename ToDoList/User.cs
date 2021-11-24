using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ToDoList
{
    [Table("Users")]
    public class User
    { 
        [Key]
        public int user_id { get; set; }

        private string login, password, name;
        public string Login
        {
            get { return login; }
            set { this.login = value; }
        }
        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public User() { } // Конструктор по умолчанию
        public User( string login, string password, string name)
        {
            this.login = login;
            this.password = password;
            this.name = name;
        }
    }
}
