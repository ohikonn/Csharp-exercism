class RemoteControlCar
{
    public int Times = 0;
    public int Meter=0;
    public int Battary = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {Meter} meters";
    }

    public string BatteryDisplay()
    {
        if(Battary<=0){
            return "Battery empty";
        }
        return $"Battery at {Battary}%";
    }

    public void Drive()
    {
        if(Battary>0){
            Meter +=20;
            Battary -=1; 
        }  
    }
}
