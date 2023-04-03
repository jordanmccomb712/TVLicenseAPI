public class ModelTesting{

    static ExpiredUser JohnDoe = new ExpiredUser("John Doe",
                    new TVLicence (new DateTime(2008, 5, 1), STATUS.EXPIRED),
                    new Address (1, "Whoville Lane", "Whoville", "BT1 1JX", "Seuss Land"), 
                    "123456", false, 
                    new Fine (123.50, new DateTime(2021, 5, 1)), 
                    false);
    
    static Account userAcc = new Account(JohnDoe, "JohnBoy", "Password123",
                             new PaymentMethod("John Doe", "1234 5678 9012 3456 ", "111", new DateTime(2024, 5,1)));

    public static void testProperties(){
        Console.WriteLine(JohnDoe.Name);
        Console.WriteLine(JohnDoe.TvLic.ExpiryDate);
        Console.WriteLine(JohnDoe.Address.City);
        Console.WriteLine(JohnDoe.Fine.AmountDue);
        Console.WriteLine(JohnDoe.LetterSent);
        Console.WriteLine(userAcc.Password);
        Console.WriteLine(userAcc.BankCard.CardNumber);
    }
}
