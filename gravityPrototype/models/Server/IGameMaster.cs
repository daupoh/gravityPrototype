using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.Server
{
    interface IGameMaster:IEntity
    {
        string enter();//return global player ID
        string createLocalRoom(uint nPlayers); //create local room for nPlayers numbers and return Room ID
        string enterRoom(string playerID, string roomID); //enter player with global PlayerID into room with RoomID and return GameID
        IList<string> startGame(string playerID, string gameID, string roomID); //player with global PlayerID
                                                                                //start game with GameID in room with RoomID and return 
                                                                                //list of local PlayerID's
        void makeAction(string playerID, string roomID); //make action by playerID in roomID game
        string gameOver(string playerID, string gameID, string roomID); //game with GameID in room with RoomID over and return new game GameID
        void leaveRoom(string playerID, string roomID); //leave room with RoomID
    }
}
