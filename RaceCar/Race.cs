namespace CarRacing
{
    public class Race
    {
        private readonly PlayerCar playerCar;
        private readonly List<AICar> aiCars;

        public Race()
        {
            playerCar = new PlayerCar();
            aiCars = new List<AICar>();
        }

        public void StartRace()
        {

        }

    }
}