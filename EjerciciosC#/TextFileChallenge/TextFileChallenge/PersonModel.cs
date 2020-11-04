namespace TextFileChallenge
{
    internal class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string IsAlive { get; set; }
        
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