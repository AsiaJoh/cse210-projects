public class Cycling : Activity
{
    // Constructor(s)
    public Cycling() : base()
    {
        SetActivityType("Cycling");
    }

    // Method(s)
    public override float CalcDistance(float distanceCycled)
    {
        // Calculate the distance cycled. Cycling is still linear, and thus will be calculated accordingly

        // Retrieve and return the distance run
        return distanceCycled;
    }

    public override float CalcSpeed(float distanceCycled, float minutes)
    {
        // Calculate the cycling speed, which is much greater than running speed, and thus is in kph.

        float cyclingSpeed = (distanceCycled / minutes) * 60;

        // Retrieve and return the cycling speed
        return cyclingSpeed;
    }

    public override float CalcPace(float distanceCycled, float minutes)
    {
        // Calculate your cycling pace, which is in min per km.
        float cyclingDistance = minutes / distanceCycled;

        return cyclingDistance;
    }
    
}