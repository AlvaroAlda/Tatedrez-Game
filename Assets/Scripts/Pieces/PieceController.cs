using UnityEngine;

public class PieceController : TateChessMonoBehaviour
{
    [SerializeField] private PieceId pieceId;
    private IPieceHandler _pieceHandler;
    
    // Start is called before the first frame update
    void Start()
    {
        _pieceHandler = GetComponent<IPieceHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
