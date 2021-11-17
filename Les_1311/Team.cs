namespace Les_1311
{
    class Team
    {
        public string Country;

        public Team(string country)
        {
            Country = country;
        }

        public void ToPlay(IGame game)
        {
            game.Play(Country);
        }
    }
}
