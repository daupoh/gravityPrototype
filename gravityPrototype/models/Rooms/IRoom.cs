using gravityPrototype.models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.Rooms
{
    interface IRoom:IEntity
    {
        void enterRoom(string playerID);
        string createNewGame(); //return game id
        void makeAction(string playerID);
    }
}
