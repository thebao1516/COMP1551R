using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;


namespace Main_Project
{
    public enum Role
    {
        Teacher,
        Student,
        Admin
    }

    public class Person
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        public Person(string name, string telephone, string email, Role role)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
            Role = role;
        }
    }
}
    


   


