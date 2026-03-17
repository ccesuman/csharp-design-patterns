using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.MediatorPattern
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);

        void AddUser(User user);
    }

    public class ChatRoom : IChatMediator
    {
        private List<User> _users;

        public ChatRoom()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender);
                }
            }
        }

    }

    public class User
    {
        private string _name;
        private IChatMediator _mediator;

        public User(string name, IChatMediator mediator)
        {
            _name = name;
            _mediator = mediator;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_name} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message, User sender)
        {
            Console.WriteLine($"{_name} receives from {sender._name}: {message}");
        }
    }

    public class MediatorPattern
    {
        //public static void Main(string[] args)
        //{
        //    IChatMediator chatMediator = new ChatRoom();
        //    User rahul = new User("Rahul", chatMediator);
        //    User priya = new User("Priya", chatMediator);
        //    User neha = new User("Neha", chatMediator);
        //    User amit = new User("Amit", chatMediator);

        //    chatMediator.AddUser(rahul);
        //    chatMediator.AddUser(priya);
        //    chatMediator.AddUser(neha);
        //    chatMediator.AddUser(amit);

        //    rahul.SendMessage("Hello everyone!");
        //}
    }
}
