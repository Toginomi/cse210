class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * minutes) / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;

}