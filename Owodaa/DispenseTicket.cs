using System;

namespace Owodaa
{
    class DispenseTicket
    {
        public string TicketType { get; set; }
        public int DailyAmount { get; set; } = 0;
        public int MonthlyAmount { get; set; } = 0;
        public long DailyTicket { get; set; }
        public long MonthlyTicket { get; set; }

        public long TotalAmount { get; set; }
        public int IDD { get; set; } = 0;
        public int IMD { get; set; } = 0;


        public void DoAgain()
        {
            while(true)
            {
                TakePayment();
            }
        }
        public void TakePayment()
        {
            Console.WriteLine("Enter  \n \"1\" for daily ticket \n \"2\" for monthly ticket \n \"3\" for Summary");
            Console.WriteLine("Daily tickets cost #300 per day and monthly tickets costs #150 per day (#4500)");
            TicketType = Console.ReadLine();

            if (TicketType == "1")
            {
                DailyAmount += 150;
                Random random = new Random();
                DailyTicket = random.Next(10000000);
                Console.WriteLine($"Your ticket number: {DailyTicket}");
                IDD++;
                Console.WriteLine($"Your ticket ID: D{IDD}");
                Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy H:mm"));
            }
            else if (TicketType == "2")
            {
                MonthlyAmount += 4500;
                Random random = new Random();
                MonthlyTicket = random.Next(1000000000);
                Console.WriteLine($"Your ticket number: {MonthlyTicket}");
                IMD++;
                Console.WriteLine($"Your ticket ID: M{IMD}");
                Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy H:mm tt"));
            } 
            else if (TicketType == "3")
            {
                PrintSummary();
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }

        public string SumAmount()
        {
            TotalAmount = DailyAmount + MonthlyAmount;
            return $"Total amount: #{TotalAmount} \n You are to remit #{0.65 * TotalAmount}";
        }

        public void PrintSummary() 
        {
            Console.WriteLine(SumAmount());
            Console.WriteLine("Press any key to go back");
            Console.ReadKey();
            DoAgain();
        }
    }
}
