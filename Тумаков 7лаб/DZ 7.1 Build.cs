namespace Тумаков_7лаб
{
    class Building
    {
        private static int lastBuildingNumber = 0;
        private int NumberOfBuilding;
        private int height;
        private int floors;
        private int apartments;
        private int entrances;

        public Building(int height, int floors, int apartments, int entrances)
        {
            NumberOfBuilding = GenerateNumberOfBuilding();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        private static int GenerateNumberOfBuilding()
        {
            lastBuildingNumber++;
            return lastBuildingNumber;
        }

        public int BuildingNumber()
        {
            return NumberOfBuilding;
        }

        public int Height()
        {
            return height;
        }

        public int Floors()
        {
            return floors;
        }

        public int Apartments()
        {
            return apartments;
        }

        public int Entrances()
        {
            return entrances;
        }

        public double CalculateFloorHeight()
        {
            return (double)height / floors;
        }

        public double CalculateApartmentsEntrance()
        {
            return (double)apartments / entrances;
        }

        public double CalculateApartmentsFloor()
        {
            return (double)apartments / floors;
        }
    }
}
