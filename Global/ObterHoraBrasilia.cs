namespace SenacQuizApp.Global
{
    public static class ObterHora
    {
        public static DateTime ObterHoraBrasilia()
        {
            var fusoBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, fusoBrasilia);
        }
    }
}
