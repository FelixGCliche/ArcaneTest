using UnityEngine;
using UnityEngine.InputSystem;

public class EntityController : MonoBehaviour
{
  private InputActions modelActions;
  [SerializeField]private GameObject prefab;

  private void Awake()
  {
    modelActions = FindObjectOfType<Inputs>().Actions;
    Debug.Log("Awake");
    modelActions.Model.Create.performed += OnCreate;
  }

  private void Start()
  {
    modelActions.Enable();
  }

  private void OnCreate(InputAction.CallbackContext context)
  {
    Debug.Log("Context: " + context);
    Instantiate(prefab, Vector3.one, Quaternion.identity);
  }
}