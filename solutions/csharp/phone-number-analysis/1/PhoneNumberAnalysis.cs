public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        
            bool IsNewYork = phoneNumber.Split("-")[0] == "212"? true:false;
            bool IsFake = phoneNumber.Split("-")[1] == "555"?true:false;
            string LocalNumber = phoneNumber.Split("-")[2];
        return (IsNewYork,IsFake,LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if(phoneNumberInfo.IsFake){
            return true;
        }
        return false;
    }
}
