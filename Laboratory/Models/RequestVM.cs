namespace Laboratory.Models
{
    public class RequestVM
    {
        public Request Request { get; set; }

        public List<DateTime> AvilableDates { get; internal set; }

    }
}
