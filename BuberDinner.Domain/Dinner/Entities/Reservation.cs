using BuberDinner.Domain.Bill.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.Enums;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Host.ValueObjects;

namespace BuberDinner.Domain.Dinner.Entities;

public sealed class Reservation : Entity<ReservationId>
{
    public int GuestCount { get; }
    public ReservationStatus ReservationStatus { get; }
    public GuestId GuestId { get; }
    public BillId BillId { get; }
    public DateTime? ArrivateDateTime { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Reservation(
        ReservationId id,
        int guestCount,
        ReservationStatus reservationStatus,
        GuestId guestId,
        BillId billId,
        DateTime? arriveDateTime,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(id)
    {
        GuestCount = guestCount;
        ReservationStatus = reservationStatus;
        GuestId = guestId;
        BillId = billId;
        ArrivateDateTime = arriveDateTime;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Reservation Create(
        int guestCount,
        ReservationStatus reservationStatus,
        GuestId guestId,
        BillId billId,
        DateTime? arriveDateTime)
    {
        return new Reservation(
            ReservationId.CreateUnique(),
            guestCount,
            reservationStatus,
            guestId,
            billId,
            arriveDateTime,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}