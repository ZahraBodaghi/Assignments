using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace GameCell 
{
    class GameCell: UserControl
    {
        public int GameCellRow { get; set; }
        public int GameCellCol { get; set; }
        public GameCellStates GameCellStates { get; set; }
    }
}
