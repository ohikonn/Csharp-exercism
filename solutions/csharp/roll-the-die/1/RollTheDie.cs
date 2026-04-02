public class Player
{
    public int RollDie()
    {
        Random random = new Random();
        return random.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        Random random2 = new Random();
        return random2.NextDouble()*100;
    }
}
