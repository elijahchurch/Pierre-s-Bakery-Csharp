namespace Items.Models
{
    public class Bread
    {
        static public int BreadCost { get;} = 5;
        static public int TotalBreadCost {get; set;}
        static public int AmountOfLoaves {get; set;}

        static public void CalculateBreadOrder(int userAmount)
        {
            AmountOfLoaves = userAmount;
            for (int i = 0; i <= userAmount; i++)
            {
                if(i%3 != 0)
                {
                    TotalBreadCost += BreadCost;
                }
            }
        }

    }
}