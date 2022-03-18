using UnityEngine;
using UnityEngine.InputSystem;


public class ShapeSelector : MonoBehaviour
{
  [SerializeField] private Color highlightColor;

  private InputActions.ShapeActions shapeActions;
  private GameObject selectedShape;
  private Color baseColor;

  public GameObject SelectedShape => selectedShape;

  private void Awake()
  {
    shapeActions = GetComponent<Inputs>().Actions.Shape;
  }

  private void Start()
  {
    shapeActions.Enable();
  }

  private void OnEnable()
  {
    shapeActions.Select.performed += OnSelect;
  }

  private void OnDestroy()
  {
    shapeActions.Select.performed -= OnSelect;
  }

  private void HighlightSelectedShape()
  {
    if (selectedShape != null)
    {
      var renderer = selectedShape.GetComponentInChildren<Renderer>();
      baseColor = renderer.material.color;
      renderer.material.color = highlightColor;
    }
  }

  private void OnUnselect()
  {
    if (selectedShape != null)
    {
      var renderer = selectedShape.GetComponentInChildren<Renderer>();
      renderer.material.color = baseColor;
    }
  }

  private void OnSelect(InputAction.CallbackContext context)
  {
    OnUnselect();
    
    var pointerPosition = Pointer.current.position.ReadValue();
    var ray = PointerUtils.GetRayFromPointer(pointerPosition);
    
    selectedShape = Physics.Raycast(ray, out var hit, 100) ? hit.transform.gameObject : null;
    
    HighlightSelectedShape();
  }
}