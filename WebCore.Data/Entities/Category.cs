using System;
using System.Collections.Generic;
using System.Text;
using WebCore.Data.Enums;

namespace WebCore.Data.Entities
{
   public class Category
    {
       public int Id { get; set; }
       public string name { get; set; }
       public  string SortOrder { get; set; }
       public  bool IsShowOnHome { get; set; }
       public  int? ParentID { get; set; }
       public  Status Status { get; set; }

    }
}
