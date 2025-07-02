using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Passenger
{

        [Key]
    public int IDPassenger { get; set; }

    public int IDLoyaltyPackage { get; set; }

    [Required]
    [MaxLength(255)]
    public string PassengerFullName { get; set; }

    [Required]
    [MaxLength(255)]
    public string PassengerPhone { get; set; }

    [Required]
    [MaxLength(255)]
    public string PassengerEmail { get; set; }

    [MaxLength(255)]
    public string? PassengerPicture { get; set; }

    [Required]
    public string PassengerGender { get; set; } // consider using enum in C#

    public DateTime? PassengerBirthDate { get; set; }

    [Required]
    [MaxLength(255)]
    public string PassengerPassword { get; set; }

    [Required]
    public string LoginBy { get; set; } // consider using enum

    [MaxLength(255)]
    public string? SocialUniqueID { get; set; }

    public bool? Verified { get; set; }

    [MaxLength(255)]
    public string? VerificationCode { get; set; }

    public int? TripsCount { get; set; }

    public bool? PassengerBlocked { get; set; }

    public bool? PassengerTotalyBlocked { get; set; }

    public int? PassengerTotalyBlockedCounter { get; set; }

    public int? PassengerBlockedCounter { get; set; }

    public int? ActualLoyaltyPointsBalance { get; set; }

    public int? TotalLoyaltyPointsOverall { get; set; }

    public int? TotalSpentLoyaltyPoints { get; set; }

    public double? Balance { get; set; }

    [Required]
    [MaxLength(255)]
    public string PassengerReferalCode { get; set; }

    public bool? TestAccount { get; set; }

    [Required]
    public string DefaultPayment { get; set; } // consider enum

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    [Required]
    public bool PassengerDeleted { get; set; }

    [Required]
    public string DeviceType { get; set; }

    [Required]
    public string PassengerMobileService { get; set; }

    [Required]
    public string AppLanguage { get; set; }

    [Required]
    [MaxLength(255)]
    public string DeviceOSVersion { get; set; }

    [Required]
    [MaxLength(255)]
    public string AppVersion { get; set; }

    [Required]
    [MaxLength(255)]
    public string DeviceToken { get; set; }

    [Required]
    [MaxLength(255)]
    public string DeviceSerial { get; set; }

    [Required]
    [MaxLength(14)]
    public string MembershipCard { get; set; }

    public int UseWallet { get; set; }

    [Required]
    public bool HasRating { get; set; }

    public DateTime created_at { get; set; }

    public DateTime updated_at { get; set; }
}
