public class Account{
    public User AccountUser {get;}
    public string UserName {get; set; }
    public string Password {get; set;}
    public PaymentMethod BankCard {get; set;}

    public Account(User accountUser, string userName, string password, PaymentMethod bankCard)
    {
        this.AccountUser = accountUser;
        this.UserName = userName;
        this.Password = password;
        this.BankCard = bankCard;
    }
}