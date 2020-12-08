// GENERATED AUTOMATICALLY FROM 'Assets/RemoteController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @RemoteController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @RemoteController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RemoteController"",
    ""maps"": [
        {
            ""name"": ""CameraVideo"",
            ""id"": ""bf238e4b-b752-4559-b7df-8c2d2c2434a3"",
            ""actions"": [
                {
                    ""name"": ""PixyLight"",
                    ""type"": ""Button"",
                    ""id"": ""ef3e84ad-696c-4d23-97e4-a0d914f6fe7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79fc90ad-46ed-4a61-8915-afbaffda95e9"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PixyLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraVideo
        m_CameraVideo = asset.FindActionMap("CameraVideo", throwIfNotFound: true);
        m_CameraVideo_PixyLight = m_CameraVideo.FindAction("PixyLight", throwIfNotFound: true);
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

    // CameraVideo
    private readonly InputActionMap m_CameraVideo;
    private ICameraVideoActions m_CameraVideoActionsCallbackInterface;
    private readonly InputAction m_CameraVideo_PixyLight;
    public struct CameraVideoActions
    {
        private @RemoteController m_Wrapper;
        public CameraVideoActions(@RemoteController wrapper) { m_Wrapper = wrapper; }
        public InputAction @PixyLight => m_Wrapper.m_CameraVideo_PixyLight;
        public InputActionMap Get() { return m_Wrapper.m_CameraVideo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraVideoActions set) { return set.Get(); }
        public void SetCallbacks(ICameraVideoActions instance)
        {
            if (m_Wrapper.m_CameraVideoActionsCallbackInterface != null)
            {
                @PixyLight.started -= m_Wrapper.m_CameraVideoActionsCallbackInterface.OnPixyLight;
                @PixyLight.performed -= m_Wrapper.m_CameraVideoActionsCallbackInterface.OnPixyLight;
                @PixyLight.canceled -= m_Wrapper.m_CameraVideoActionsCallbackInterface.OnPixyLight;
            }
            m_Wrapper.m_CameraVideoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PixyLight.started += instance.OnPixyLight;
                @PixyLight.performed += instance.OnPixyLight;
                @PixyLight.canceled += instance.OnPixyLight;
            }
        }
    }
    public CameraVideoActions @CameraVideo => new CameraVideoActions(this);
    public interface ICameraVideoActions
    {
        void OnPixyLight(InputAction.CallbackContext context);
    }
}
