static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double sRate =0;
        if(speed ==0){
            sRate =0;
        }else if(speed>=1&&speed<=4){
            sRate =1;
        }else if(speed>=5&&speed<=8){
            sRate =0.9;
        }else if(speed==9){
            sRate =0.8;
        }else if(speed==10){
            sRate =0.77;
        }
        return sRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double pRate = (double)(speed*SuccessRate(speed)*221);
        return pRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int wPerMin = (int)ProductionRatePerHour(speed)/60;
        return wPerMin;
        
    }
}
