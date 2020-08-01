using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Aplication.Models
{
    public class PaginationDTO
    {
        public int Count { get; set; }
        public List<RankingDTO> Items { get; set; }
    }
}
