﻿using Anathema.Patryk.TrainingOne.Chess.Abstract;

namespace Anathema.Patryk.TrainingOne.Chess
{
    public class Bishop : IFigure
    {
        public Bishop()
        {
            Description = "Bishop";
        }

        public bool Move()
        {
            return true;
        }

        public string Color { get; set; }
        public string Description { get; set; }
    }
}