using System.Collections.Generic;

namespace SistemaDeEstoqueCodeFirst.Models
{
  public class Role
  {
    public Role(int iD, string name)
    {
      ID = iD;
      Name = name;

    }
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<User> Users { get; set; }

  }
}