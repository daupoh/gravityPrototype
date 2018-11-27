using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.CubeModels
{
    interface ICube:IEntity
    {
        ICube getCubeTypeUp();
        ICube getCubeoOUpRight();
        ICube getCubeOnRight();
        ICube getCubeOnDownRight();
        ICube getCubeOnDown();
        ICube getCubeOnDownLeft();
        ICube getCubeOnLeft();
        ICube getCubeOnUpLeft();
    }
}
