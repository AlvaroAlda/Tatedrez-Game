using UnityEngine;

public class CheckBoardController : TateChessMonoBehaviour
{
    private int _size;
    GridCell[,] GridCells;
    public GridCell GridCellPrefab;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCheckBoard();
    }
    
    void UpdateCheckBoard()
    {
        _size = GameConfig.Size;
        
        var checkBoardTransform = transform;
        checkBoardTransform.localPosition = new Vector3(_size * 0.5f, _size * 0.5f, 1);
        
        GridCells = new GridCell[_size,_size];

        for (var i = 0; i < _size; i++)
        {
            for (var j = 0; j < _size; j++)
            {
                //Adding the half unit for the center of the piece
                var gridCell = GridCells[i, j] = Instantiate(GridCellPrefab, transform);
                gridCell.transform.localPosition = new Vector2(i + 0.5f - _size * 0.5f, j + 0.5f - _size * 0.5f);

                var gridColor = (i + j) % 2 == 0 ? GameConfig.ColorEven : GameConfig.ColorOdd;
                gridCell.GridColor = gridColor;
            }
        }

        //Publishing gridCells to the shared game config
        GameConfig.GridCells = GridCells;
    }
}
