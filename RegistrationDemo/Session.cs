namespace RegistrationDemo
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; } = string.Empty;

        public static void Clear()
        {
            UserId = 0;
            FullName = string.Empty;
        }
    }
}