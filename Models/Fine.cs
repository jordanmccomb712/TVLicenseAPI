public class Fine{
    public double AmountDue {get; set;} //in GBP
    public DateTime DateIssued {get; set;}

    public Fine (double amountDue, DateTime dateIssued){
        this.AmountDue = amountDue;
        this.DateIssued = dateIssued;
    }
}