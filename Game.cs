/* Game.cs
 *  Form that enables user interaction with the map object 
 *  and allows the user to load and play levels
 * 
 * Revision History
 *      Tyler Mills, 2019.11.02: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Game : Form
    {
        #region Globals
        const int BOX_WIDTH = 40;
        const int BOX_MARGIN = 0;
        const int BOX_STARTING_X = 0;
        const int BOX_STARTING_Y = 0;
        enum Image
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
        Map map;
        Tile[,] tiles;
        bool isFinished;
        #endregion
        #region Constructors
        public Game()
        {
            InitializeComponent();
        }
        #endregion
        #region Event Methods
        /// <summary>
        /// Sets up the Game form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_Load(object sender, EventArgs e)
        {
            // Brings the user to the levels directory when using the loadFileDialog/openFileDialog
            loadFileDialog.InitialDirectory = Path.GetFullPath(Directory.GetParent(Application.StartupPath).Parent.FullName + @"\levels");
        }
        /// <summary>
        /// Prompts the open file dialog and uses the resulting filepath to generate a new map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                Generate(loadFileDialog.FileName);
                isFinished = false;
                txtMoves.Text = 0.ToString();
                txtPushes.Text = 0.ToString();
                lblScore.Text = $"{map.filledStorage}/{map.totalStorage}";
            }
        }
        /// <summary>
        /// Handler function for controls. Interacts with the tiles and map and returns based on the maps logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardInput(object sender, KeyEventArgs e)
        {
            if (map == null || tiles == null || isFinished) return;
            
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
            {
                map.MovePlayer(e.KeyCode, ref tiles);
                txtMoves.Text = map.numOfMoves.ToString();
                txtPushes.Text = map.numOfPushes.ToString();
                lblScore.Text = $"{map.filledStorage}/{map.totalStorage}";
                DrawBoard();
                if (map.GameFinished() && !isFinished)
                {
                    MessageBox.Show($"You win!\nMoves: {txtMoves.Text}\nPushes: {txtPushes.Text}","Congratulations!");
                    ClearGrid();
                    isFinished = true;
                }
            }
        }

        private void GamepadInput(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(Button)) return;
            Button button = (Button)sender;
            Keys keyPressed;

            if (button.Name.Contains("Left"))
            {
                keyPressed = Keys.A;
            }
            else if (button.Name.Contains("Up"))
            {
                keyPressed = Keys.W;
            }
            else if (button.Name.Contains("Right"))
            {
                keyPressed = Keys.D;
            }
            else if (button.Name.Contains("Down"))
            {
                keyPressed = Keys.S;
            }
            else return;

            KeyboardInput(sender, new KeyEventArgs(keyPressed));
        }
        #endregion
        #region Methods
        /// <summary>
        /// Generates a new Map instance and reloads the grid with the input provided
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate(string fileData)
        {
            try
            {
                if (map != null && tiles != null) ClearGrid();

                map = Map.LoadFile(fileData);
                if (map == null) return;
                tiles = new Tile[map.map.GetLength(0), map.map.GetLength(1)];

                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    for (int y = 0; y < tiles.GetLength(1); y++)
                    {
                        // PictureBoxes name and location
                        tiles[x, y] = new Tile(x, y, map.map[x, y]);
                        tiles[x, y].Name = $"Tile{x},{y}";
                        tiles[x, y].Size = new Size(BOX_WIDTH, BOX_WIDTH);
                        tiles[x, y].Margin = new Padding(BOX_MARGIN);
                        // Location is listed correctly on the form by rows and columns in the grid
                        tiles[x, y].Location = new Point(
                            BOX_STARTING_Y + BOX_WIDTH * y,
                            BOX_STARTING_X + BOX_WIDTH * x
                        );
                        // Appearance
                        tiles[x, y].BorderStyle = BorderStyle.FixedSingle;
                        tiles[x, y].BackgroundImage = imageList.Images[map.map[x,y]];
                        tiles[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                        // Finalization
                        pnlGame.Controls.Add(tiles[x, y]);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Row and/or column is invalid. Only integer values over 0 are accepted.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error! Something went wrong!\n{ex.Message}");
            }
        }
        private void DrawBoard()
        {
            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    tiles[x, y].BackgroundImage = imageList.Images[tiles[x, y].Value];
                    tiles[x, y].Refresh();
                }
            }
        }
        /// <summary>
        /// Clears the map grid by removing all picture boxes listed in the tile array within the class
        /// </summary>
        private void ClearGrid()
        {
            map = null;
            foreach (PictureBox item in tiles)
            {
                pnlGame.Controls.Remove(item);
            }
            tiles = null;
        }
        #endregion
    }
}
