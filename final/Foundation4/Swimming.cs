public class Swimming : Activity
{
    // Constructor(s)
    public Swimming() : base()
    {
        SetActivityType("Swimming");
    }

    // Method(s)
    public override float CalcDistance(float numLaps)
    {
        // Calculate the distance you swam. Swimming occurs in laps, but still is in km
        float distanceSwam = numLaps * 50 / 1000;

        // Retrieve and return the distance run
        return distanceSwam;
    }

    public override float CalcSpeed(float numLaps, float minutes)
    {
        // Calculate the swimming speed, still in kph.

        // Re-find the distance
        float distanceSwam = numLaps * 50 / 1000;


        float swimmingSpeed = (distanceSwam / minutes) * 60;

        // Retrieve and return the cycling speed
        return swimmingSpeed;
    }

    public override float CalcPace(float numLaps, float minutes)
    {
        // Calculate your cycling pace, which is in min per km.

        // Re-find the distance
        float distanceSwam = numLaps * 50 / 1000;

        float swimmingPace = minutes / distanceSwam;

        return swimmingPace;
    }
}