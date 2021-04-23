// GENERATED AUTOMATICALLY FROM 'Assets/Input System/Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""Tower Rotator"",
            ""id"": ""975bac9e-6c01-4f39-b4e8-b4b4f43dbca9"",
            ""actions"": [
                {
                    ""name"": ""RotateTouch"",
                    ""type"": ""Value"",
                    ""id"": ""e02e3b25-3bc9-4fd8-906c-4a805a21fc07"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6fe79b06-6418-46e9-a450-5e5571b313be"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScren"",
                    ""action"": ""RotateTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""TouchScren"",
            ""bindingGroup"": ""TouchScren"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keybord"",
            ""bindingGroup"": ""Keybord"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Tower Rotator
        m_TowerRotator = asset.FindActionMap("Tower Rotator", throwIfNotFound: true);
        m_TowerRotator_RotateTouch = m_TowerRotator.FindAction("RotateTouch", throwIfNotFound: true);
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

    // Tower Rotator
    private readonly InputActionMap m_TowerRotator;
    private ITowerRotatorActions m_TowerRotatorActionsCallbackInterface;
    private readonly InputAction m_TowerRotator_RotateTouch;
    public struct TowerRotatorActions
    {
        private @Controllers m_Wrapper;
        public TowerRotatorActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateTouch => m_Wrapper.m_TowerRotator_RotateTouch;
        public InputActionMap Get() { return m_Wrapper.m_TowerRotator; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TowerRotatorActions set) { return set.Get(); }
        public void SetCallbacks(ITowerRotatorActions instance)
        {
            if (m_Wrapper.m_TowerRotatorActionsCallbackInterface != null)
            {
                @RotateTouch.started -= m_Wrapper.m_TowerRotatorActionsCallbackInterface.OnRotateTouch;
                @RotateTouch.performed -= m_Wrapper.m_TowerRotatorActionsCallbackInterface.OnRotateTouch;
                @RotateTouch.canceled -= m_Wrapper.m_TowerRotatorActionsCallbackInterface.OnRotateTouch;
            }
            m_Wrapper.m_TowerRotatorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateTouch.started += instance.OnRotateTouch;
                @RotateTouch.performed += instance.OnRotateTouch;
                @RotateTouch.canceled += instance.OnRotateTouch;
            }
        }
    }
    public TowerRotatorActions @TowerRotator => new TowerRotatorActions(this);
    private int m_TouchScrenSchemeIndex = -1;
    public InputControlScheme TouchScrenScheme
    {
        get
        {
            if (m_TouchScrenSchemeIndex == -1) m_TouchScrenSchemeIndex = asset.FindControlSchemeIndex("TouchScren");
            return asset.controlSchemes[m_TouchScrenSchemeIndex];
        }
    }
    private int m_KeybordSchemeIndex = -1;
    public InputControlScheme KeybordScheme
    {
        get
        {
            if (m_KeybordSchemeIndex == -1) m_KeybordSchemeIndex = asset.FindControlSchemeIndex("Keybord");
            return asset.controlSchemes[m_KeybordSchemeIndex];
        }
    }
    public interface ITowerRotatorActions
    {
        void OnRotateTouch(InputAction.CallbackContext context);
    }
}
