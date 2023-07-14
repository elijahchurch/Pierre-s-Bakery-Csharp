namespace Items.Models
{
    public class Bread
    {
        static public int BreadCost { get;} = 5;
        static public int TotalBreadOrder {get; set;}
        static public int AmountofLoaves {get; set;}

        static public void CalculateBreadOrder(int userAmount)
        {
            AmountofLoaves += userAmount;
        }

    }
}