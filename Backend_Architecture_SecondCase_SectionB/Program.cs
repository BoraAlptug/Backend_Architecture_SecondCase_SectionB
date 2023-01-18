using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cap = "ManageUsers"; //-->Dummy Capability
            var users = new User();     //--> Create instance users object

            useHasCapability(cap, users);
            void useHasCapability(string capability, User user)
            {
                user.role.getCapabilities(capability);
            }
            Console.ReadLine();
        }

    }

}



class User
{
    public Role role { get; set; }
    public User()
    {
        this.role = new Role();       
    }

}
class Role
{

    public void getCapabilities(string capability)
    {
        Console.WriteLine(capability);
    }

}