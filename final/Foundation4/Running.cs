public class Running : Activity
{
    // Constructor(s)
    public Running() : base()
    {
        SetActivityType("Running");
    }

    // Method(s)
    public override float CalcDistance(float distanceRan)
    {
        // Calculate the distance run. Running happens along a path in a linear fashion, so just... return distance run.
        // Units are km

        // Correct and return the distance run
        SetDistance(distanceRan);

        return distanceRan;
    }

    public override float CalcSpeed(float distanceRan, float minutes)
    {
        // Calculate the speed at which you ran. Speed is distance / time.
        // Units are km

        float runningSpeed = (distanceRan / minutes) * 60;

        // Retrieve and return the running speed
        return runningSpeed;
    }

    public override float CalcPace(float distanceRan, float minutes)
    {
        // Calculate your running pace. Pace is time / distance
        // Units are min per km
        float runningPace = minutes / distanceRan;

        return runningPace;
    }
}