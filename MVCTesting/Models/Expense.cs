using System.ComponentModel.DataAnnotations;

namespace MVCTesting.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public string Description { get; set; }

    }
}
