/* Map.cs
 *  Handles, saves and (eventually) loads data for the map object
 * 
 * Revision History
 *      Tyler Mills, 2019.09.23: Created
 *      Tyler Mills, 2019.11.02: Updated for Assignment 2
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    class Map
    {
        #region Globals
        enum TileType
        {
            None,
            Hero,
            Wall,
            Box,
            Destination,
            BoxOnDestination
        }
        #endregion
        #region Properties
        public int[,] map { get; set; }
        public int numOfPushes { get; private set; }
        public int numOfMoves { get; private set; }
        public int filledStorage { get; private set; }
        public int totalStorage { get; private set; }
        private static FileStream _file;
        #endregion
        #region Constructor
        public Map(int rows, int cols)
        {
            try
            {
                map = new int[rows, cols];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! Something went wrong!\n{ex.Message}");
            }

            numOfMoves = 0;
            numOfPushes = 0;
            filledStorage = 0;
            totalStorage = 0;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Saves file to the specified filePath & Name
        /// </summary>
        /// <param name="filePath">file's path and name</param>
        public void SaveFile(string filePath)
        {
            try
            {
                _file = new FileStream(filePath, FileMode.OpenOrCreate);

                using (var sw = new StreamWriter(_file))
                {
                    string saveStuff = ToString();
                    if (!string.IsNullOrWhiteSpace(saveStuff))
                        sw.Write(ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! Something went wrong!\n{ex.Message}");
            }
            finally
            {
                if (_file != null)
                {
                    _file.Close();
                }
            }
        }

        public static Map LoadFile(string filePath)
        {
            Map newMap;

            try
            {
                _file = new FileStream(filePath, FileMode.Open);
                string fileData = "";

                using (StreamReader reader = new StreamReader(_file))
                {
                    fileData = reader.ReadToEnd();
                }
                newMap = FromString(fileData);

                foreach (var item in newMap.map)
                {
                    if (item == (int)TileType.Destination)
                    {
                        newMap.totalStorage += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! Something went wrong!\n{ex.Message}");
                newMap = null;
            }
            finally
            {
                if (_file != null)
                {
                    _file.Close();
                }
            }

            return newMap;
        }
        /// <summary>
        /// Calculates whether the player can move and then acts upon the information as required
        /// Remember: 37 left, 38 up, 39 right, 40 down
        /// </summary>
        /// <param name="keyCode"></param>
        public void MovePlayer(Keys wasdKey, ref Tile[,] gameBoard)
        {
            if (wasdKey != Keys.W && wasdKey != Keys.A && wasdKey != Keys.S && wasdKey != Keys.D)
            {
                return;
            }

            Tile player = new Tile(0,0,1);
            foreach (var item in gameBoard)
            {
                if (item.Value == 1)
                {
                    player.X = item.X;
                    player.Y = item.Y;
                    break;
                }
            }

            Tile checkingTile = new Tile(0,0,0);
            switch (wasdKey)
            {
                case Keys.A:
                    checkingTile.Y -= 1;
                    break;
                case Keys.D:
                    checkingTile.Y += 1;
                    break;
                case Keys.W:
                    checkingTile.X -= 1;
                    break;
                case Keys.S:
                    checkingTile.X += 1;
                    break;
            }

            // If next tile doesnt exist or is a wall, no moves can be made, so exit the function
            if ((player.X + checkingTile.X) < 0 || (player.Y + checkingTile.Y) < 0 ||
                (player.X + checkingTile.X) * (player.Y + checkingTile.Y) > gameBoard.Length || 
                gameBoard[player.X + checkingTile.X, player.Y + checkingTile.Y].Value == (int)TileType.Wall)
            {
                return;
            }
            // if next tile is a box?
            else if (gameBoard[player.X + checkingTile.X, player.Y + checkingTile.Y].Value == (int)TileType.Box ||
                     gameBoard[player.X + checkingTile.X, player.Y + checkingTile.Y].Value == (int)TileType.BoxOnDestination)
            {
                // if tile behind box is not a wall or a box, or out of bounds
                if (gameBoard[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2].Value != (int)TileType.Wall && 
                    gameBoard[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2].Value != (int)TileType.Box &&
                    gameBoard[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2].Value != (int)TileType.BoxOnDestination ||
                    (player.X + checkingTile.X * 2) < 0 || (player.Y + checkingTile.Y * 2) < 0 ||
                    (player.X + checkingTile.X * 2) * (player.Y + checkingTile.Y * 2) > gameBoard.Length)
                {
                    gameBoard[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2].Value = (int)TileType.Box;
                    gameBoard[player.X + checkingTile.X, player.Y + checkingTile.Y].Value = (int)TileType.Hero;
                    gameBoard[player.X, player.Y].Value = (int)TileType.None;

                    numOfMoves++;
                    numOfPushes++;

                    // If the box is or isnt moved onto a destination tile
                    if (map[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2] == (int)TileType.Destination)
                    {
                        gameBoard[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2].Value = (int)TileType.BoxOnDestination;
                        filledStorage += 1;
                    }
                    else if (map[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2] == (int)TileType.None &&
                             map[player.X + checkingTile.X, player.Y + checkingTile.Y] == (int)TileType.Destination)
                    {
                        gameBoard[player.X + checkingTile.X * 2, player.Y + checkingTile.Y * 2].Value = (int)TileType.Box;
                        filledStorage -= 1;
                    }
                }
            }
            else
            {
                gameBoard[player.X + checkingTile.X, player.Y + checkingTile.Y].Value = (int)TileType.Hero;
                gameBoard[player.X, player.Y].Value = (int)TileType.None;
                numOfMoves++;
            }

            if (map[player.X, player.Y] == (int)TileType.Destination)
            {
                gameBoard[player.X, player.Y].Value = (int)TileType.Destination;
            }
        }
        /// <summary>
        /// Checks if a game has all storage tiles filled
        /// </summary>
        /// <returns></returns>
        public bool GameFinished()
        {
            bool result = false;

            if (filledStorage != 0)
            {
                if (filledStorage / totalStorage >= 1)
                {
                    result = true;
                }
            }

            return result;
        }
        #endregion
        #region Generic Methods
        /// <summary>
        /// Returns a string starting with the column and row lengths of the map
        /// and outputs the data in an incremental loop in this format: {x, y, value}
        /// </summary>
        /// <returns>"rows, columns, f(x,y) = {x, y, value}[x*y]", each number separated by a new line</returns>
        public override string ToString()
        {
            string result = "";
            int rows = map.GetLength(0);
            int columns = map.GetLength(1);

            result += rows + "\n";
            result += columns + "\n";
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    result += x + "\n";
                    result += y + "\n";
                    result += map[x,y] + "\n";
                }
            }

            return result;
        }
        /// <summary>
        /// Converts loaded fileData into a new map object
        /// </summary>
        /// <param name="fileData"></param>
        /// <returns>a map object</returns>
        public static Map FromString(string fileData)
        {
            string[] splitData = fileData.Split('\n');
            Map newMap = new Map(Convert.ToInt32(splitData[0]), Convert.ToInt32(splitData[1]));
            int i = 2;
            for (int x = 0; x < newMap.map.GetLength(0); x++)
            {
                for (int y = 0; y < newMap.map.GetLength(1); y++)
                {
                    newMap.map[Convert.ToInt32(splitData[i]), Convert.ToInt32(splitData[i+1])] = Convert.ToInt32(splitData[i+2]);
                    i += 3;
                }
            }

            return newMap;
        }
        #endregion
    }

    public class Tile : PictureBox
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Value { get; set; }
        #endregion
        #region Constructor
        public Tile(int _x, int _y, int _value)
        {
            X = _x;
            Y = _y;
            Value = _value;
        }
        #endregion
    }
}
