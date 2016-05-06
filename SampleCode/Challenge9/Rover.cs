namespace Challenge9
{
    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Rover(int x, int y)
        {
            if (Terrain.ValidateCoordinates(x, y))
            {
                X = x;
                Y = y;
            }
            else
            {
                X = Y = 1;
            }
        }

        public bool Move (string direction)
        {
            switch (direction.ToUpper())
            {
                case "L":
                    return ChangeCoordinates(-1, 0);
                case "R":
                    return ChangeCoordinates(1, 0);
                case "U":
                    return ChangeCoordinates(0, -1);
                case "D":
                    return ChangeCoordinates(0, 1);
                default:
                    return false;
            }
        }

        private bool ChangeCoordinates(int xAxisChange, int yAxisChange)
        {
            int newX = X + xAxisChange;
            int newY = Y + yAxisChange;

            if (Terrain.ValidateCoordinates(newX, newY))
            {
                X = newX;
                Y = newY;
                return true;
            }
            return false;
        }
    }
}
