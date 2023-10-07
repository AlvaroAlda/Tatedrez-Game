using UnityEngine;

public static class CameraExtension
{
    public static float GetDistanceFromFrustumWidth(this Camera camera, float frustumWidth)
    {
        return frustumWidth / camera.aspect * 0.5f / Mathf.Tan(camera.fieldOfView * 0.5f * Mathf.Deg2Rad);
    }
}
