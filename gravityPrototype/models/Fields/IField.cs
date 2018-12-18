using gravityPrototype.models.Actions;
using gravityPrototype.models.CubeModels;
using gravityPrototype.models.Players;
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
        void interactWithAction(IAction action);
        ICube getCubeByIndexes(uint rowIndex, uint columnIndex);
        
        
    }
}
