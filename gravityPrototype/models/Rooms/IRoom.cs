using gravityPrototype.models.Games;
using gravityPrototype.models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.Rooms
{
    interface IRoom : IEntity
    {
        uint playersMaxNumbers{get;}
        uint playersCurrentNumbers { get; }
        IGame getGameById(string gameID);

        void enterRoom(string playerID);        
        string createNewGame(); //return game id
        void playerLeftRoom(string playerID);
        
    }
}
