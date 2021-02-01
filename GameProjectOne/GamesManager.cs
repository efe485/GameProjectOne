using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    class GamesManager : IGamesService
    {
        public void GameAdd(Games game)
        {
            Console.WriteLine(game.GameName + " isimli oyun sisteme eklendi");
        }

        public void GameDelete(Games game)
        {
            Console.WriteLine(game.GameName + " isimli oyun sistemden silindi");
        }
    }
}
