using System;
using UnityEngine;


public class ShapeFactory : MonoBehaviour
{
  [SerializeField] private GameObject cubePrefab;
  [SerializeField] private GameObject cylinderPrefab;
  public void CreateShapeByType(ShapeType shapeType, Vector3 position)
  {
    switch (shapeType)
    {
      case ShapeType.Cube:
        Instantiate(cubePrefab, position, Quaternion.identity);
        break;
      case ShapeType.Cylinder:
        Instantiate(cylinderPrefab, position, Quaternion.identity);
        break;
      case ShapeType.None:
      default:
        throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null);
    }
  }
}