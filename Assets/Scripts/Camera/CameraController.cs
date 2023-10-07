using UnityEngine;

public class CameraController : TateChessMonoBehaviour
{
    private void Start()
    {
        var mainCamera = Camera.main;
        
        var size = GameConfig.Size;
        var distanceOffset = mainCamera.GetDistanceFromFrustumWidth(size);

        if (mainCamera != null) 
            mainCamera.transform.position = new Vector3(size * 0.5f, size * 0.5f, -distanceOffset);
    }
}
