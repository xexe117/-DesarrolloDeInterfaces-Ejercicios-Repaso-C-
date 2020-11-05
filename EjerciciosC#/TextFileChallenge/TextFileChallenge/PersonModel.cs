namespace TextFileChallenge
{
    internal class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }

        public string DisplayText
        {
            get
            {
                string estadoLive = "is dead";

                if (IsAlive == true)
                {
                    estadoLive = "is alive";
                }
                return $"{ FirstName } { LastName } is { Age } and { estadoLive }";
            }
        }
    }
}