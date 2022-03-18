using UnityEngine;

public static class PointerUtils
{
  public static Vector3 GetWorldPosition(Vector3 pointerPosition)
  {
    var mainCamera = Camera.main;
    pointerPosition.z = 5.0f;
    return mainCamera!.ScreenToWorldPoint(pointerPosition);
  }

  public static Ray GetRayFromPointer(Vector3 pointerPosition)
  {
    var mainCamera = Camera.main;
    pointerPosition.z = mainCamera.depth;
    
    return mainCamera!.ScreenPointToRay(pointerPosition);
  }
}