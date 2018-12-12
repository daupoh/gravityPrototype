using gravityPrototype.models.CubeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.Actions
{
    interface IAction:IEntity
    {
        uint FieldsRowIndex { get; }
        uint FieldsColumnIndex { get; }
        string PlayersID { get; }
        ICube Cube { get; }
    }
}
