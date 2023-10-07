using UnityEngine;

public class GridCell: MonoBehaviour
{
    public GameObject PossiblePositionHelper;
    public GameObject LastPositionHelper;
    public GameObject HoverHelper;
    
    public PieceController GuestPiece;
    public Color GridColor;

    private void Start()
    {
        GetComponent<SpriteRenderer>().color = GridColor;
    }

    private void OnMouseEnter()
    {
        HoverHelper.SetActive(true);
    }


    private void OnMouseExit()
    {
        HoverHelper.SetActive(false);
    }

}
