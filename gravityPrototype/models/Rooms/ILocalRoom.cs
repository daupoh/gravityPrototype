﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.Rooms
{
    interface ILocalRoom:IRoom
    {
        IList<string> createLocalIDs(uint nPlayers);

    }
}
