class RemoteControlCar
{
    private int speed = 5;
    private int batteryDrain = 2;
    private int distance = 0;
    private int battery =100;

    public RemoteControlCar(int speed,int batteryDrain){
            this.speed = speed;
            this.batteryDrain = batteryDrain;
        }

    public bool BatteryDrained()
    {
        if(battery<batteryDrain){
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if(battery>=batteryDrain){
            distance +=speed;
            battery -= batteryDrain;
        }
        
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    
    private int distance = 800; 
    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained()){
            car.Drive();
        }
       return car.DistanceDriven() >= distance;
        
    }
}
