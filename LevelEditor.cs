/* LevelEditor.cs
 *  A level editor that displays and interacts with the map object's data
 *  
 *  It also contains the Tile class which inherits from PictureBox
 *  and gives x, y, and value properties to use
 * 
 * Revision History
 *      Tyler Mills, 2019.09.23: Created
 *      Tyler Mills, 2019.09.25: Replaced (int)selectedIndex with (Image)selectedImage
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class LevelEditor : Form
    {
        #region Globals
        const int BOX_WIDTH = 40;
        const int BOX_MARGIN = 1;
        const int BOX_STARTING_X = 94;
        const int BOX_STARTING_Y = 151;
        enum Image
        {
            None,
            Hero,
            Wall,
            Box,
            Destination
        }
        #endregion
        #region Properties
        Map map;
        Tile[,] tiles;
        Image selectedImage;
        #endregion
        #region Constructor
        public LevelEditor() {
            InitializeComponent();
        }
        #endregion
        #region Event Methods
        /// <summary>
        /// Generates a new Map instance and reloads the grid with the input provided
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerate_Click(object sender, EventArgs e) {
            try {
                int rows = Convert.ToInt32(txtRows.Text);
                int columns = Convert.ToInt32(txtColumns.Text);

                if (map != null && tiles != null) ClearGrid();

                map = new Map(rows, columns);
                tiles = new Tile[rows, columns];

                for (int x = 0; x < rows; x++) {
                    for (int y = 0; y < columns; y++) {
                        map.map[x, y] = 0;
                        // PictureBoxes name and location
                        tiles[x, y] = new Tile(x, y, map.map[x,y]);
                        tiles[x, y].Name = $"Tile{x.ToString()}{y.ToString()}";
                        tiles[x, y].Size = new Size(BOX_WIDTH, BOX_WIDTH);
                        tiles[x, y].Margin = new Padding(BOX_MARGIN);
                        // Location is listed correctly on the form by rows and columns in the grid
                        tiles[x, y].Location = new Point(
                            BOX_STARTING_Y + BOX_WIDTH * y,
                            BOX_STARTING_X + BOX_WIDTH * x
                        );
                        // Appearance
                        tiles[x, y].BorderStyle = BorderStyle.FixedSingle;
                        tiles[x, y].BackgroundImage = imageList1.Images[0];
                        tiles[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                        // Events and finalization
                        tiles[x, y].MouseDown += new MouseEventHandler(PictureBox_MouseDown);
                        tiles[x, y].MouseMove += new MouseEventHandler(PictureBox_MouseMove);
                        Controls.Add(tiles[x, y]);
                    }
                }

            }
            catch (FormatException) {
                MessageBox.Show("Row and/or column is invalid. Only integer values over 0 are accepted.");
            }
            catch {
                throw;
            }
        }
        /// <summary>
        /// When the mouse moves over any pictureboxes within the tile array, while a mouse button is clicked down, the
        /// picturebox will change into the currently selected image
        /// 
        /// Credit: https://stackoverflow.com/a/4827546
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right) {
                Control control = (Control)sender;
                if (control.Capture)
                    control.Capture = false;
                
                if (control.ClientRectangle.Contains(e.Location))
                    PictureBox_MouseDown(control, e);
            }
        }
        /// <summary>
        /// When the mouse clicks down over any pictureboxes within the tile array, the
        /// picturebox will change into the currently selected image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e) {
            Tile tile = (Tile)sender;

            tile.Value = (int)selectedImage;
            if (e.Button == MouseButtons.Right)
                tile.Value = 0;

            map.map[tile.X, tile.Y] = tile.Value;
            tile.BackgroundImage = imageList1.Images[tile.Value];
        }
        private void LevelEditor_Load(object sender, EventArgs e) {
            btnRadio0.Checked = true;
        }
        /// <summary>
        /// Sets the selectedImage to the clicked toolbox image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRadio_Click(object sender, EventArgs e) {
            RadioButton radioButton = (RadioButton)sender;
            selectedImage = (Image)radioButton.ImageIndex;
        }
        /// <summary>
        /// Triggers the saveDialog and uses the filePath to save the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e) {
            if (map == null) {
                MessageBox.Show("Map cannot be saved because it contains no data.");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                map.SaveFile(saveFileDialog1.FileName);
        }
        /// <summary>
        /// Closes the level editor window and returns to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e) {
            Close();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Clears the map grid by removing all picture boxes listed in the tile array within the class
        /// </summary>
        private void ClearGrid() {
            map = null;
            foreach (PictureBox item in tiles) {
                Controls.Remove(item);
            }
            tiles = null;
        } 
        #endregion
    }
}
