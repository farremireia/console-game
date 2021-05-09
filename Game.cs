using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {

        public new static void UpdatePosition(string key, out int x, out int y)
        {

            x = 0;
            y = 0;

            // SWITCH STATEMENT

            // Detects the key the user has pressed and adjusts the x and y accordingly.
            switch (key)
            {
                case "LeftArrow":
                    x = -1;
                    y = 0;
                    break;
                case "RightArrow":
                    x = 1;
                    y = 0;
                    break;
                case "UpArrow":
                    x = 0;
                    y = -1;
                    break;
                case "DownArrow":
                    x = 0;
                    y = 1;
                    break;
                default:
                    x = 0;
                    y = 0;
                    break;
            }
        }

        //Allows the icon to change with each key pressed depending on direction.
        public new static char UpdateCursor(string key)
        {
            char direction = '0';

            // SWITCH STATEMENT

            // Sets the direction variable to a placeholder variable.
            switch (key)
            {
                case "DownArrow":
                    direction = 'v';
                    break;
                case "UpArrow":
                    direction = '^';
                    break;
                case "LeftArrow":
                    direction = '<';
                    break;
                case "RightArrow":
                    direction = '>';
                    break;
            }

            return direction;
        }

        // Constrains a coordinate between 0 and its maximum value to keep the character from going off-screen.
        public new static int KeepInBounds(int coordinate, int maxValue)
        {

            // IF ELSE STATEMENT

            if (coordinate > maxValue)
            {
                return 0;
                // If the player goes to the left or to the top edge, send them to the opposite side.
            }
            else if (coordinate < 0)
            {
                return maxValue;
                // If the player goes to the right or to the bottom edge, send them to the opposite side.
            }
            else
            {
                return coordinate;
                // If the player is not touching any edges, proceed.
            }
        }

        //Compares coordinates and puts a score.
        public new static bool DidScore(int charX, int charY, int fruitX, int fruitY)
        {

            // IF ELSE STATEMENT

            // Checks if the player and the fruit are on the same coordinate.
            if (charX == fruitX && charY == fruitY)
            {
                return true;
            }
            else
            {
                return false;
                // If the player and the fruit are not on the same coordinate, no score will be added.
            }
        }

    }

}