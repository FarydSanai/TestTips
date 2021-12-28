// GENERATED AUTOMATICALLY FROM 'Assets/TouchControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControls"",
    ""maps"": [
        {
            ""name"": ""TouchMap"",
            ""id"": ""55f588ad-7cda-4085-baae-82cf8c01ec89"",
            ""actions"": [
                {
                    ""name"": ""PrimaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""ff0b8a0d-60ef-40ff-b989-5c4dfffc1625"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryFingerDelta"",
                    ""type"": ""Value"",
                    ""id"": ""9d93aac0-0bf3-4bc6-922e-4326bd7a296c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryFingerTouch"",
                    ""type"": ""Button"",
                    ""id"": ""0a3bdb32-a628-40cd-b01f-eeeb504ecc00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2de65361-4e5a-4f2a-8f03-deed8ea1636e"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73989162-5d5c-4156-8c24-2aa2d691fa08"",
                    ""path"": ""<Touchscreen>/touch0/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afc7c931-198f-46f2-9698-b187504240e1"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TouchMap
        m_TouchMap = asset.FindActionMap("TouchMap", throwIfNotFound: true);
        m_TouchMap_PrimaryFingerPosition = m_TouchMap.FindAction("PrimaryFingerPosition", throwIfNotFound: true);
        m_TouchMap_PrimaryFingerDelta = m_TouchMap.FindAction("PrimaryFingerDelta", throwIfNotFound: true);
        m_TouchMap_PrimaryFingerTouch = m_TouchMap.FindAction("PrimaryFingerTouch", throwIfNotFound: true);
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

    // TouchMap
    private readonly InputActionMap m_TouchMap;
    private ITouchMapActions m_TouchMapActionsCallbackInterface;
    private readonly InputAction m_TouchMap_PrimaryFingerPosition;
    private readonly InputAction m_TouchMap_PrimaryFingerDelta;
    private readonly InputAction m_TouchMap_PrimaryFingerTouch;
    public struct TouchMapActions
    {
        private @TouchControls m_Wrapper;
        public TouchMapActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_TouchMap_PrimaryFingerPosition;
        public InputAction @PrimaryFingerDelta => m_Wrapper.m_TouchMap_PrimaryFingerDelta;
        public InputAction @PrimaryFingerTouch => m_Wrapper.m_TouchMap_PrimaryFingerTouch;
        public InputActionMap Get() { return m_Wrapper.m_TouchMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchMapActions set) { return set.Get(); }
        public void SetCallbacks(ITouchMapActions instance)
        {
            if (m_Wrapper.m_TouchMapActionsCallbackInterface != null)
            {
                @PrimaryFingerPosition.started -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerDelta.started -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerDelta;
                @PrimaryFingerDelta.performed -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerDelta;
                @PrimaryFingerDelta.canceled -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerDelta;
                @PrimaryFingerTouch.started -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerTouch;
                @PrimaryFingerTouch.performed -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerTouch;
                @PrimaryFingerTouch.canceled -= m_Wrapper.m_TouchMapActionsCallbackInterface.OnPrimaryFingerTouch;
            }
            m_Wrapper.m_TouchMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @PrimaryFingerDelta.started += instance.OnPrimaryFingerDelta;
                @PrimaryFingerDelta.performed += instance.OnPrimaryFingerDelta;
                @PrimaryFingerDelta.canceled += instance.OnPrimaryFingerDelta;
                @PrimaryFingerTouch.started += instance.OnPrimaryFingerTouch;
                @PrimaryFingerTouch.performed += instance.OnPrimaryFingerTouch;
                @PrimaryFingerTouch.canceled += instance.OnPrimaryFingerTouch;
            }
        }
    }
    public TouchMapActions @TouchMap => new TouchMapActions(this);
    public interface ITouchMapActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnPrimaryFingerDelta(InputAction.CallbackContext context);
        void OnPrimaryFingerTouch(InputAction.CallbackContext context);
    }
}
