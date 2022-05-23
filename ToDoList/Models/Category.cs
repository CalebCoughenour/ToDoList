using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class Category
  {
    public Category()
    {
      this.JoinEntities = new HashSet<CategoryItem>();
    }

    public string Name { get; set; }
    public int CategoryId { get; set; }
    public virtual ICollection<CategoryItem> JoinEntities { get; set; }    
  }
}