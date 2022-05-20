
    internal static class DateUtil
    {
    public static int YearofBirth(int age)
    {
        return DateTime.Now.Year - age;
    }

    public static int YearofBirth(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
            return 0;
        return dateOfBirth.Year;
    }

    public static int Age(DateTime dateofBirth)
    {
        if (dateofBirth == null)
            return 0;
        return DateTime.Now.Year - dateofBirth.Year;
    }

    }

