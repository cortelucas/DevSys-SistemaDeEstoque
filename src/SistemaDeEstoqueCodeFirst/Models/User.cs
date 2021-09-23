using System;

namespace SistemaDeEstoqueCodeFirst.Models
{
  public class User
  {
        public User() =>
            DateCreated = DateTime.Now;

        public User(int iD, string username, string email, string password, DateTime lastUpdate, string recoveryCode, bool active, int role) : this()
        {
            ID = iD;
            Username = username;
            Email = email;
            Password = password;
            LastUpdate = lastUpdate;
            RecoveryCode = recoveryCode;
            Active = active;
            RoleID = role;

        }
        
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdate { get; set; }
        public string RecoveryCode { get; set; }
        public bool Active { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
  }
}