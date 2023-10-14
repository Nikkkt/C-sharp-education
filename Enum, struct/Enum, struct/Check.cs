using System.Text;

namespace Enum__struct
{
    public struct Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemCount { get; set; }

        public Item(string itemName, double itemPrice, int itemCount)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            ItemCount = itemCount;
        }
    }
    public struct Check
    {
        public string Country { get; set; }
        public string ShopName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public List<Item> PurchasedItems { get; set; }
        public string CheckNumber { get; private set; }
        public int Cashier { get; set; }
        public string PayerName { get; set; }
        public string BankName { get; set; }
        public double Amount { get; private set; }
        public DateTime IssueDate { get; set; }
        public List<string> Predictions = new List<string>() { "Все буде добре", "Ви найкращий", "Треба трохи відпочити", "Подзвонить мамі", "Скоро у вас все буде добре", "Перемога буде!" };


        public Check(string country, string shopName, string city, string street, List<Item> purchasedItems, int cashier, string payerName, string bankName)
        {
            Country = country;
            ShopName = shopName;
            City = city;
            Street = street;
            PurchasedItems = purchasedItems;
            Cashier = cashier;
            PayerName = payerName;
            BankName = bankName;
            IssueDate = DateTime.Now;
            CheckNumber = GenerateCheckNumber();
        }

        private string GenerateCheckNumber()
        {
            // Implement a real algorithm to generate a check number
            // Placeholder: Generating a random number
            Random rand = new Random();
            int checkNumber = rand.Next(100000000, 999999999);
            return checkNumber.ToString();
        }

        public void PrintCheck()
        {
            StringBuilder checkText = new StringBuilder();
            int width = 40;
            foreach (var item in PurchasedItems) Amount += item.ItemPrice * item.ItemCount;

            checkText.AppendLine("┌────────────────────────────────────────┐");
            checkText.AppendLine($"│{Country.PadLeft((width + Country.Length) / 2).PadRight(width)}│");
            checkText.AppendLine("├────────────────────────────────────────┤");
            checkText.AppendLine($"│{ShopName.PadLeft((width + ShopName.Length) / 2).PadRight(width)}│");
            checkText.AppendLine($"│{City.PadLeft((width + City.Length) / 2).PadRight(width)}│");
            checkText.AppendLine($"│{Street.PadLeft((width + Street.Length) / 2).PadRight(width)}│");
            checkText.AppendLine("├────────────────────────────────────────┤");
            foreach (var item in PurchasedItems)
            {
                checkText.AppendLine($"│ {(item.ItemCount.ToString() + " X").PadRight(width - 6)} {item.ItemPrice.ToString("0.0")}".PadRight(width) + "│");
                checkText.AppendLine($"│ {item.ItemName.PadRight(width - 6)} {Math.Round((item.ItemPrice * item.ItemCount), 1).ToString("0.0")}".PadRight(width) + "│");
                checkText.AppendLine("│".PadRight(width + 1) + "│");
            }
            checkText.AppendLine("├────────────────────────────────────────┤");
            checkText.AppendLine($"│ Чек #{CheckNumber}".PadRight(width + 1) + "│");
            checkText.AppendLine($"│ Каса #{Cashier}".PadRight(width + 1) + "│");
            checkText.AppendLine("├────────────────────────────────────────┤");
            checkText.AppendLine($"│ Передбачення:".PadRight(width + 1) + "│");
            checkText.AppendLine($"│ {Predictions[new Random().Next(Predictions.Count)]}".PadRight(width + 1) + "│");
            checkText.AppendLine("├────────────────────────────────────────┤");
            checkText.AppendLine($"│ Платник {PayerName}".PadRight(width + 1) + "│");
            checkText.AppendLine($"│ Банк {BankName}".PadRight(width + 1) + "│");
            checkText.AppendLine("├────────────────────────────────────────┤");
            checkText.AppendLine($"│ Усього {Math.Round(Amount, 1)}".PadRight(width + 1) + "│");
            checkText.AppendLine("├────────────────────────────────────────┤");
            checkText.AppendLine($"│ Дата {IssueDate:dd.MM.yyyy}".PadRight(width + 1) + "│");
            checkText.AppendLine("└────────────────────────────────────────┘");

            Console.WriteLine(checkText.ToString());
        }
    }
}
