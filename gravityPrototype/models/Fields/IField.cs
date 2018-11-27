﻿using gravityPrototype.models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.Field
{
    interface IField:IEntity
    {
        void clearField();
        void dropCubeByPlayer(uint row, uint column, IPlayer player);
        
    }
}
