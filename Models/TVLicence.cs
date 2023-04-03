public class TVLicence{
    public DateTime ExpiryDate {get; set;}
    public STATUS LicenseStatus {get; set;}

    public TVLicence(DateTime expiryDate, STATUS licenseStatus)
    {
        this.ExpiryDate = expiryDate;
        this.LicenseStatus = licenseStatus;
    }
}



public enum STATUS{
    ACTIVE, EXPIRED
}