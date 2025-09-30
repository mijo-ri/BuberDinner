using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Dinner.ValueObjects;

public sealed class Location : ValueObject
{
    public string Name { get; }
    public string Address { get; }
    public decimal Latitude { get; }
    public decimal Longitude { get; }

    private Location(
        string name,
        string address,
        decimal latitude,
        decimal longitude)
    {
        Name = name;
        Address = address;
        Latitude = latitude;
        Longitude = longitude;
    }

    public static Location Create(
        string name,
        string address,
        decimal latitude,
        decimal longitude)
    {
        return new(
            name,
            address,
            latitude,
            longitude);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return Address;
        yield return Latitude;
        yield return Longitude;
    }
}