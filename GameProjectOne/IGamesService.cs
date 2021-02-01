using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    interface IGamesService
    {
        void GameAdd(Games game);
        void GameDelete(Games game);
    }
}
