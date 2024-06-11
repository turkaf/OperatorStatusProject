namespace OperatorStatusProject.App.Entity
{
    public class ShiftData
    {
        public int ShiftId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }

    }
}
