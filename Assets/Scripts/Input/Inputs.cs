using System;
using UnityEngine;

public class Inputs : MonoBehaviour
{
  private InputActions actions;
  public InputActions Actions => actions ??= new InputActions();
}