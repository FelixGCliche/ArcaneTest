using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Button = UnityEngine.UI.Button;

public class ShapeButton : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
  [SerializeField] private ShapeType shapeType;

  private TextMeshProUGUI buttonText;
  private Button button;
  private ShapeFactory shapeFactory;

  private void Awake()
  {
    buttonText = GetComponentInChildren<TextMeshProUGUI>();
    shapeFactory = GetComponentInParent<ShapeFactory>();
  }

  private void OnEnable()
  {
    buttonText.SetText("Add " + shapeType);
  }

  public void OnBeginDrag(PointerEventData eventData)
  {
    Debug.Log("Begin drag" + eventData);
  }

  public void OnDrag(PointerEventData eventData)
  {
    Debug.Log("Dragging" + eventData);
  }

  private Vector3 GetWorldPosition(Vector3 pointerPosition)
  {
    var mainCamera = Camera.main;
    pointerPosition.z = 5.0f;
    var worldPoint = mainCamera!.ScreenToWorldPoint(pointerPosition);
    Debug.Log(worldPoint);

    return worldPoint;
  }

  public void OnEndDrag(PointerEventData eventData)
  {
    shapeFactory.CreateShapeByType(
      shapeType,
      GetWorldPosition(eventData.position)
    );
  }
}