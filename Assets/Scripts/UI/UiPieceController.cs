using UnityEngine;
using UnityEngine.UI;

public class UiPieceController : TateChessMonoBehaviour
{
    [SerializeField] private Image pieceImage;
    private PieceData _pieceData;

    void UpdateUiPiece(PieceData pieceData)
    {
        pieceImage.sprite = pieceData.PieceSprite;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
