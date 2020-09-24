/* MainMenu.cs
 *  The initial form of the program that allows the user to play the game, use the level editor, or exit.
 * 
 * Revision History
 *      Tyler Mills, 2019.09.23: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MainMenu : Form
    {
        #region Constructor
        public MainMenu() {
            InitializeComponent();
        } 
        #endregion
        #region Event Methods
        /// <summary>
        /// Brings the user to the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlay_Click(object sender, EventArgs e) {
            new Game().Show();
        }
        /// <summary>
        /// Brings the user to the game's level editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditor_Click(object sender, EventArgs e) {
            new LevelEditor().Show();
        }
        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e) {
            Close();
        } 
        #endregion
    }
}
