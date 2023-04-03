public class Address{
    public int HouseNumber {get; set; }
    public string StreetName {get; set; }
    public string AppartmentNum {get; set; }
    public string City {get; set; }
    public string PostCode {get; set; }
    public string Country {get; set; }

    public Address(int houseNumber, string streetName, string city, string postCode, string country, string appartmentNum = "")
    {
        this.HouseNumber = houseNumber;
        this.StreetName = streetName;
        this.AppartmentNum = appartmentNum;
        this.City = city;
        this.PostCode = postCode;
        this.Country = country;
    }
}