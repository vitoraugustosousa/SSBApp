using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SSBApp.Models
{
    
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }
    public class User : BaseModel
    {
        public User()
        {
        }

        [Required]
        public string Name { get; private set; }

        [Required]
        public string Password { get; private set; }

        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }

    public class Manager : User
    {
    }

    public class Pawn : User
    {
    }

    public class Event : BaseModel
    {
        public Event()
        {
        }

        [Required]
        public string Name { get; private set; }

        [Required]
        public DateTime Date { get; private set; }

        public int NumStaff { get; set; }

        public Event(string name, DateTime date, int numStaff)
        {
            this.Name = name;
            this.Date = date;
            this.NumStaff = numStaff;
        }
    }

    public class Shift : BaseModel
    {
        public Shift()
        {
        }

        [Required]
        public string eventName { get;  private set; }

        [Required]
        public List<Pawn> Pawns { get; private set; } = new List<Pawn>();
    }
}
