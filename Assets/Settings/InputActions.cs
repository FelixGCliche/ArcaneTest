//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Settings/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Shape"",
            ""id"": ""24583255-df13-489a-b312-fce6f0edae39"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""56abaf36-32f5-4de0-9f6b-d6c318f9398b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""02269d7c-de21-4fa1-a65f-ca100d574493"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Shape
        m_Shape = asset.FindActionMap("Shape", throwIfNotFound: true);
        m_Shape_Select = m_Shape.FindAction("Select", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Shape
    private readonly InputActionMap m_Shape;
    private IShapeActions m_ShapeActionsCallbackInterface;
    private readonly InputAction m_Shape_Select;
    public struct ShapeActions
    {
        private @InputActions m_Wrapper;
        public ShapeActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Shape_Select;
        public InputActionMap Get() { return m_Wrapper.m_Shape; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShapeActions set) { return set.Get(); }
        public void SetCallbacks(IShapeActions instance)
        {
            if (m_Wrapper.m_ShapeActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_ShapeActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_ShapeActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_ShapeActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_ShapeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public ShapeActions @Shape => new ShapeActions(this);
    public interface IShapeActions
    {
        void OnSelect(InputAction.CallbackContext context);
    }
}
