class Lasagna
{
    public int ExpectedMinutesInOven() => 40;


    public int RemainingMinutesInOven(int actualMinutesInOven)
        => ExpectedMinutesInOven() - actualMinutesInOven;


    public int PreparationTimeInMinutes(int layercount)=>
        layercount * 2 ;


    public int ElapsedTimeInMinutes(int layercount, int actualMinutesInOven)=>
        PreparationTimeInMinutes(layercount) + actualMinutesInOven ;
        
}
