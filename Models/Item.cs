using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key] //ASP.NET에서는 ID를 자동적으로 프라이머리 키로 설정하므로 실제로는 작성하지 않아도 된다.
        public int Id { get; set; }

        public string Borrower { get; set; }


    }
}
