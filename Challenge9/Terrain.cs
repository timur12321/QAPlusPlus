using System;

namespace Challenge9
{
    public static class Terrain
    {
        public static int Height { get; } = 10;
        public static int Width { get; } = 30;

        public static bool ValidateCoordinates(int x, int y)
        {
            if (x < 1 || x > Width || y < 1 || y > Height)
                return false;

            return true;
        }

        public static void Draw(Rover rover)
        {
            DrawPaddedRow(Terrain.Width, "-", 1, "-");

            for (int y = 1; y <= Terrain.Height; y++)
            {
                if (rover.Y == y)
                {
                    DrawRow(1, "|");
                    for (int x = 1; x <= Terrain.Width; x++)
                    {
                        if (rover.X == x)
                        {
                            DrawRow(1, "X");
                        }
                        else
                        {
                            DrawRow(1, " ");
                        }
                    }
                    DrawRow(1, "|", true);
                }
                else
                {
                    DrawPaddedRow(Terrain.Width, " ", 1, "|");
                }
            }
            DrawPaddedRow(Terrain.Width, "-", 1, "-");
        }

        private static void DrawPaddedRow(int width, string unit, int padding, string paddingUnit)
        {
            DrawRow(padding, paddingUnit);
            DrawRow(width, unit);
            DrawRow(padding, paddingUnit, true);
        }
        private static void DrawRow(int width, string unit, bool endOfLine = false)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write(unit);
            }

            if (endOfLine)
            {
                Console.WriteLine();
            }
        }
    }
}