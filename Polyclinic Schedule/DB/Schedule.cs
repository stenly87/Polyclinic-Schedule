using System;
using System.Collections.Generic;

namespace Polyclinic_Schedule.DB;

public partial class Schedule
{
    public int Id { get; set; }

    public DateTime StartTime { get; set; }

    public int? IdUser { get; set; }

    public int IdDoctor { get; set; }

    public virtual Doctor IdDoctorNavigation { get; set; } = null!;

    public virtual User? IdUserNavigation { get; set; }
}
