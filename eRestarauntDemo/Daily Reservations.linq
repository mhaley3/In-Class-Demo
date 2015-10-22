<Query Kind="Expression">
  <Connection>
    <ID>274bc064-2990-4ae8-ad61-f3c55a4658f2</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from eachRow in Reservations
where eachRow.ReservationStatus == 'B' //Use "B" in VisualStudio
// TBA - && eachRow has the correct EventCode
orderby eachRow.ReservationDate
//select eachRow
group eachRow by new {eachRow.ReservationDate.Month, eachRow.ReservationDate.Day}
into dailyReservation
select new // dailyReservation
{
	Month = dailyReservation.Key.Month,
	Day = dailyReservation.Key.Day,
	Reservations = from booking in dailyReservation
				   select new // Booking() //Create a Booking DTO class
				   {
				   	Name = booking.CustomerName,
					Time = booking.ReservationDate.TimeOfDay,
					NumberInParty = booking.NumberInParty,
					Phone = booking.ContactPhone,
					Event = booking.SpecialEvents.Description
				   }
	
}