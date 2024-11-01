abstract class Activity
{
    // Protected properties to allow access in derived classes
    protected DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({minutes} min) - Distance: {GetDistance():F1} {GetDistanceUnit()}, Speed: {GetSpeed():F1} {GetSpeedUnit()}, Pace: {GetPace():F1} min per {GetDistanceUnit()}";
    }

    protected virtual string GetDistanceUnit()
    {
        return "mile";
    }

    protected virtual string GetSpeedUnit()
    {
        return "mph";
    }
}