using Google.Apis.Calendar.v3.Data;

namespace Sample.GoogleCalendarApi.Common.Model;

public class EventModel
{
    public string Summary { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public DateTime EndDateTime { get; set; }
    public DateTime StartDateTime { get; set; }
    public string TimeZone { get; } = "Asia/Tehran";
    public List<Attendee> Attendees { get; set; }
}

public class Attendee
{
    public string AttendeesEmail { get; set; }
    public string AttendeesName { get; set; }
}

