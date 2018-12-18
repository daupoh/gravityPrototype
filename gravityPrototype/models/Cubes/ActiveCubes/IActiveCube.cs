using gravityPrototype.models.CubeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravityPrototype.models.Cubes.ActiveCubes
{
    interface IActiveCube
    {
        string OwnerCube { get; } //'game', or PlayersID
        string StateOfVerticalLine { get; } //state 'down','up' or 'both'
        string StateOfHorizontalLine { get; } //state 'left','right' or 'both'
        string StateOfMainDiagonal { get; } //state 'down','up' or 'both'
        string StateOfIncidentalDiagonal { get; } //state 'down','up' or 'both'
        uint HorizontalWeight { get; }
        uint VerticalWeight { get; }
        uint MainDiagonalWeight { get; }
        uint IncidentalDiagonalWeight { get; }

        void horizontalLeftAddWeight(uint addedWeight);
        void horizontalRightAddWeight(uint addedWeight);
        void horizontalBothAddWeight(uint addedWeight);
        void verticalDownAddWeight(uint addedWeight);
        void verticalUpAddWeight(uint addedWeight);
        void verticalBothAddWeight(uint addedWeight);
        void mainDiagonalUpAddWeight(uint addedWeight);
        void mainDiagonalDownAddWeight(uint addedWeight);
        void mainDiagonalBothAddWeight(uint addedWeight);
        void incidentDiagonalUpAddWeight(uint addedWeight);
        void incidentDiagonalDownAddWeight(uint addedWeight);
        void incidentDiagonalBothAddWeight(uint addedWeight);

        ICube getCubeOnUp();
        ICube getCubeOnUpRight();
        ICube getCubeOnRight();
        ICube getCubeOnDownRight();
        ICube getCubeOnDown();
        ICube getCubeOnDownLeft();
        ICube getCubeOnLeft();
        ICube getCubeOnUpLeft();
    }
}
