using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManagerApp.Data
{
    public class HistoryData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        /// <summary>
        /// 1: Income; 2: Expense
        /// </summary>
        public int OperationType { get; set; }
        public string Explanation { get; set; }
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 1:Monthly, 2: Weekly , 3: Daily
        /// </summary>
        public int Occurance { get; set; }
    }
}
