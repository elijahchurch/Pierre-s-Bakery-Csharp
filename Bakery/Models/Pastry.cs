namespace Items.Models
{
    public class Pastry
    {
        static public int PastryCost {get;} = 2;
        static public int TotalPastryCost {get; set;}
        static public int AmountOfPastries {get; set;}
    
        static public void CalculatePastryOrder(int userAmount)
        {
            AmountOfPastries = userAmount;
            for (int i = 1; i <= userAmount; i++)
            {
                if(i%4 != 0)
                {
                    TotalPastryCost += PastryCost;
                }
            }
        }
    }

}