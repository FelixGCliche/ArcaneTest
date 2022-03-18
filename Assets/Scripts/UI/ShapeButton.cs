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
  }

  public void OnDrag(PointerEventData eventData)
  {
  }

  public void OnEndDrag(PointerEventData eventData)
  {
    shapeFactory.CreateShapeByType(
      shapeType,
      PointerUtils.GetWorldPosition(eventData.position)
    );
  }
}