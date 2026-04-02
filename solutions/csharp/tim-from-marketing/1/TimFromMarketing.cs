static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string? departmentUpper = department?.ToUpper();
        if(id==null && department ==null)
            return $"{name} - OWNER";
        else if(department == null){
            return $"[{id}] - {name} - OWNER";
        }else if(id==null){
            return $"{name} - {departmentUpper}";
        }
        return $"[{id}] - {name} - {departmentUpper}";
        
    }
}
