public class User{


    public string Name {get; set; }
    public TVLicence TvLic {get; set; }
    public Address Address {get; set; }
    public string Id {get; set; }
    public bool Admin {get; set; }

    public User (string name, TVLicence tvLic, Address address, string id, bool admin)
    {
        this.Name = name; 
        this.TvLic = tvLic; 
        this.Address = address;
        this.Id = id;
        this.Admin = admin;
    }

}