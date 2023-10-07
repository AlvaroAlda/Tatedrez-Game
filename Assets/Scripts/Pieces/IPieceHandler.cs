using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPieceHandler
{
    public GridCell[,] GetPossibleGrids(GridCell[,] gridCells);
}
