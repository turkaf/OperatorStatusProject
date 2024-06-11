using OperatorStatusProject.App.Entity;

namespace OperatorStatusProject.App.Models
{
    public class DataViewModel
    {
        public List<ShiftData> shiftData = new List<ShiftData>
        {
            new ShiftData { ShiftId = 1, StartTime = new DateTime(2020, 5, 23, 7, 30, 0), EndTime = new DateTime(2020, 5, 23, 8, 30, 0), Status = "URETIM" },
            new ShiftData { ShiftId = 2, StartTime = new DateTime(2020, 5, 23, 8, 30, 0), EndTime = new DateTime(2020, 5, 23, 12, 0, 0), Status = "URETIM" },
            new ShiftData { ShiftId = 3, StartTime = new DateTime(2020, 5, 23, 12, 0, 0), EndTime = new DateTime(2020, 5, 23, 13, 0, 0), Status = "URETIM" },
            new ShiftData { ShiftId = 4, StartTime = new DateTime(2020, 5, 23, 13, 0, 0), EndTime = new DateTime(2020, 5, 23, 13, 45, 0), Status = "DURUŞ", Reason = "ARIZA" },
            new ShiftData { ShiftId = 5, StartTime = new DateTime(2020, 5, 23, 13, 45, 0), EndTime = new DateTime(2020, 5, 23, 17, 30, 0), Status = "URETIM" }
        };

        public List<StandartStances> stances = new List<StandartStances>
        {
            new StandartStances{StartTime = new TimeSpan(10, 0, 0), EndTime=new TimeSpan(10, 15, 0), Reason = "Çay Molası"},
            new StandartStances{StartTime = new TimeSpan(12, 0, 0), EndTime=new TimeSpan(12, 30, 0), Reason = "Yemek Molası"},
            new StandartStances{StartTime = new TimeSpan(15, 0, 0), EndTime=new TimeSpan(15, 15, 0), Reason = "Çay Molası"}
        };

    }
}
