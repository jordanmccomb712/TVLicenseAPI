public class ExpiredUser : User {

    public Fine Fine{get; set;}
    public bool LetterSent {get; set;}
    public ExpiredUser (string name, TVLicence tvLic, Address address, string id, bool admin, Fine fine, bool letterSent ) 
        : base(name, tvLic, address, id, admin)
    {
        this.Fine = fine;
        this.LetterSent = letterSent;
    }
}