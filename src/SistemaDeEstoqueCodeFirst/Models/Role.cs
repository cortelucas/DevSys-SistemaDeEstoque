using System.Collections.Generic;

namespace SistemaDeEstoqueCodeFirst.Models
{
  public class Role
  {
    public Role(int iD, string nome)
    {
      ID = iD;
      Nome = nome;

    }
    public int ID { get; set; }
    public string Nome { get; set; }
    public ICollection<User> Users { get; set; }

  }
}