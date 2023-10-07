using UnityEngine;

public class CheckBoardController : TateChessMonoBehaviour
{
    private int _size;
    public GridCell[,] GridCells;

    // Start is called before the first frame update
    void Start()
    {
        UpdateSizeAndPosition();
    }
    
    void UpdateSizeAndPosition()
    {
        _size = GameConfig.Size;
        
        var checkBoardTransform = transform;
        checkBoardTransform.localScale = Vector3.one * _size;
        checkBoardTransform.localPosition = new Vector3(_size * 0.5f, _size * 0.5f, 1);
        
        GridCells = new GridCell[_size,_size];

        for (var i = 0; i < _size; i++)
        {
            for (var j = 0; j < _size; j++)
            {
                //Adding the half unit for the center of the piece
                GridCells[i, j] = new GridCell(new Vector2(i + 0.5f, j + 0.5f));
            }
        }

        //Publishing gridCells to the shared game config
        GameConfig.GridCells = GridCells;
    }
}
