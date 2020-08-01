using PizzaShop.Aplication.Interfaces;
using PizzaShop.Aplication.Models;
using PizzaShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Aplication.Services
{
    public class ToppingService : IToppingService
    {
        public IToppingRepository _toppingRepository;
        public ToppingService(IToppingRepository toppingRepository)
        {
            _toppingRepository = toppingRepository;
        }

        /// <summary>
        /// Method to get paginated toppings.
        /// </summary>
        /// <param name="pageIndex">Current page.</param>
        /// <param name="pageSize">Listing size.</param>
        /// <returns>Ranking toppings listing by page.</returns>
        public PaginationDTO GetToppings(int pageIndex, int pageSize)
        {
            try
            {
                if (pageIndex == 0)
                    throw new Exception("Page index can not be 0.");

                if (pageSize == 0)
                    throw new Exception("Page size can not be 0.");



                var response = _toppingRepository.GetToppings();

                List<string> sortedList = new List<string>();
                List<RankingDTO> rankingList = new List<RankingDTO>();
                PaginationDTO pagination = new PaginationDTO();

                SortList(response, ref sortedList);
                GroupList(sortedList, ref rankingList);

                var list = rankingList.OrderByDescending(o => o.Repeats).ThenBy(x => x.Topping).ToList();
                pagination.Count = list.Count;
                pagination.Items = list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

                return pagination;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void GroupList(List<string> sortedList, ref List<RankingDTO> rankingList)
        {
            foreach (var line in sortedList.GroupBy(info => info)
             .Select(group => new RankingDTO
             {
                 Topping = group.Key,
                 Repeats = group.Count()
             }))
            {
                rankingList.Add(line);
            }
        }

        private void SortList(List<Dictionary<string, List<string>>> response, ref List<string> sortedList)
        {
            foreach (var item in response)
            {
                var sortedItems = item["toppings"].OrderBy(p => p).ToList();
                string sortedString = string.Empty;

                for (int i = 0; i < sortedItems.Count; i++)
                {
                    if (string.IsNullOrEmpty(sortedString))
                    { sortedString = sortedItems[i]; }
                    else
                    { sortedString = sortedString + ", " + sortedItems[i]; }
                }

                sortedList.Add(sortedString);
            }
        }

    }
}
