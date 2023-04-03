public class PaymentMethod{


    public string FullName {get; set; }
    public string CardNumber {get; set; }
    public string Cvc {get; set; }
    public DateTime ExpiryDate {get; set; }

    public PaymentMethod(string fullName, string cardNumber, string cvc, DateTime expiryDate)
    {
        this.FullName = fullName;
        this.CardNumber = cardNumber;
        this.Cvc = cvc;
        this.ExpiryDate = expiryDate;
    }
}