﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyKing : CoouseyFigure
    {
        public CoouseyKing(CoouseyCoordinates coordinates, FigureKind figureKind) : base(coordinates, figureKind)
        {
        }

        public new bool Move(ICoordinates newCoordinates)
        {
            return true;
        }
    }
}
