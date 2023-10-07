using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : TateChessMonoBehaviour
{
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
