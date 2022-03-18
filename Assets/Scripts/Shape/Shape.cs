using UnityEngine;
using UnityEngine.UIElements;

public struct Shape
{
  private ShapeType shapeType;
  private Vector3 position;

  public ShapeType ShapeType => shapeType;
  public Vector3 Position => position;

  public Shape(ShapeType shapeType, Vector3 position)
  {
    this.shapeType = shapeType;
    this.position = position;
  }
}