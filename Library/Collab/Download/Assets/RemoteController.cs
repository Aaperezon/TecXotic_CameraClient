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
            ""name"": ""Controller"",
            ""id"": ""bf238e4b-b752-4559-b7df-8c2d2c2434a3"",
            ""actions"": [
                {
                    ""name"": ""PixyLight"",
                    ""type"": ""Button"",
                    ""id"": ""ef3e84ad-696c-4d23-97e4-a0d914f6fe7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""e82b71f9-374c-4fe0-b7d2-507c3678a3e7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""4463c0b6-4141-4f1b-bb93-a87c8fa64daa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""502a4b44-d099-49be-86af-c94d260bd6d7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""f51db970-56ab-4b4b-92f8-f01066a8987f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArmDisarm"",
                    ""type"": ""Button"",
                    ""id"": ""70d2317a-3b66-425e-86a2-a57686f4453d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlightMode"",
                    ""type"": ""Button"",
                    ""id"": ""fa024a47-dab3-4049-971c-e45faa39a23a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Agent3_x"",
                    ""type"": ""Value"",
                    ""id"": ""beed1254-ee8f-4a18-bb97-87f4ae44dc44"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Agent3_y"",
                    ""type"": ""Value"",
                    ""id"": ""fd8a8788-0ad3-46d7-89a1-bd952d9f5e39"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Agent3_resize"",
                    ""type"": ""Button"",
                    ""id"": ""48aecdd1-6ef5-4d74-9373-065da22a3fd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Agent3_shoot"",
                    ""type"": ""Button"",
                    ""id"": ""40321201-4799-41f1-a41f-30a4f8c507c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79fc90ad-46ed-4a61-8915-afbaffda95e9"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PixyLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f85c3239-f8d4-4469-92ed-93e433d3eb84"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf2f145e-4edd-45da-97c6-f99eb72bfb82"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/stick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3456b90-6e34-4a69-8cbc-d52f9ccc3fd1"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f05ee067-c16b-4c1c-9ec4-ab17bcb2357f"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9edc1666-9958-46b8-8bc4-34a0208f0337"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArmDisarm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62955dca-90b0-4c0f-94b1-123dd6f8f327"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlightMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98b70a45-a3ac-4c9f-8ab4-b64cba0d9b7e"",
                    ""path"": ""<DualShockGamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Agent3_x"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f56333d-e51b-4251-a19d-1142c097eb14"",
                    ""path"": ""<DualShockGamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Agent3_y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""597136ab-621f-4a38-98f5-903245306a15"",
                    ""path"": ""<DualShockGamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Agent3_resize"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""223249ef-ca00-4108-a75b-83340b569027"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Agent3_shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controller
        m_Controller = asset.FindActionMap("Controller", throwIfNotFound: true);
        m_Controller_PixyLight = m_Controller.FindAction("PixyLight", throwIfNotFound: true);
        m_Controller_Throttle = m_Controller.FindAction("Throttle", throwIfNotFound: true);
        m_Controller_Pitch = m_Controller.FindAction("Pitch", throwIfNotFound: true);
        m_Controller_Roll = m_Controller.FindAction("Roll", throwIfNotFound: true);
        m_Controller_Yaw = m_Controller.FindAction("Yaw", throwIfNotFound: true);
        m_Controller_ArmDisarm = m_Controller.FindAction("ArmDisarm", throwIfNotFound: true);
        m_Controller_FlightMode = m_Controller.FindAction("FlightMode", throwIfNotFound: true);
        m_Controller_Agent3_x = m_Controller.FindAction("Agent3_x", throwIfNotFound: true);
        m_Controller_Agent3_y = m_Controller.FindAction("Agent3_y", throwIfNotFound: true);
        m_Controller_Agent3_resize = m_Controller.FindAction("Agent3_resize", throwIfNotFound: true);
        m_Controller_Agent3_shoot = m_Controller.FindAction("Agent3_shoot", throwIfNotFound: true);
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

    // Controller
    private readonly InputActionMap m_Controller;
    private IControllerActions m_ControllerActionsCallbackInterface;
    private readonly InputAction m_Controller_PixyLight;
    private readonly InputAction m_Controller_Throttle;
    private readonly InputAction m_Controller_Pitch;
    private readonly InputAction m_Controller_Roll;
    private readonly InputAction m_Controller_Yaw;
    private readonly InputAction m_Controller_ArmDisarm;
    private readonly InputAction m_Controller_FlightMode;
    private readonly InputAction m_Controller_Agent3_x;
    private readonly InputAction m_Controller_Agent3_y;
    private readonly InputAction m_Controller_Agent3_resize;
    private readonly InputAction m_Controller_Agent3_shoot;
    public struct ControllerActions
    {
        private @RemoteController m_Wrapper;
        public ControllerActions(@RemoteController wrapper) { m_Wrapper = wrapper; }
        public InputAction @PixyLight => m_Wrapper.m_Controller_PixyLight;
        public InputAction @Throttle => m_Wrapper.m_Controller_Throttle;
        public InputAction @Pitch => m_Wrapper.m_Controller_Pitch;
        public InputAction @Roll => m_Wrapper.m_Controller_Roll;
        public InputAction @Yaw => m_Wrapper.m_Controller_Yaw;
        public InputAction @ArmDisarm => m_Wrapper.m_Controller_ArmDisarm;
        public InputAction @FlightMode => m_Wrapper.m_Controller_FlightMode;
        public InputAction @Agent3_x => m_Wrapper.m_Controller_Agent3_x;
        public InputAction @Agent3_y => m_Wrapper.m_Controller_Agent3_y;
        public InputAction @Agent3_resize => m_Wrapper.m_Controller_Agent3_resize;
        public InputAction @Agent3_shoot => m_Wrapper.m_Controller_Agent3_shoot;
        public InputActionMap Get() { return m_Wrapper.m_Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllerActions set) { return set.Get(); }
        public void SetCallbacks(IControllerActions instance)
        {
            if (m_Wrapper.m_ControllerActionsCallbackInterface != null)
            {
                @PixyLight.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnPixyLight;
                @PixyLight.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnPixyLight;
                @PixyLight.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnPixyLight;
                @Throttle.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnThrottle;
                @Pitch.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnPitch;
                @Roll.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRoll;
                @Yaw.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnYaw;
                @ArmDisarm.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnArmDisarm;
                @ArmDisarm.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnArmDisarm;
                @ArmDisarm.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnArmDisarm;
                @FlightMode.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnFlightMode;
                @FlightMode.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnFlightMode;
                @FlightMode.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnFlightMode;
                @Agent3_x.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_x;
                @Agent3_x.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_x;
                @Agent3_x.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_x;
                @Agent3_y.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_y;
                @Agent3_y.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_y;
                @Agent3_y.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_y;
                @Agent3_resize.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_resize;
                @Agent3_resize.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_resize;
                @Agent3_resize.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_resize;
                @Agent3_shoot.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_shoot;
                @Agent3_shoot.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_shoot;
                @Agent3_shoot.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnAgent3_shoot;
            }
            m_Wrapper.m_ControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PixyLight.started += instance.OnPixyLight;
                @PixyLight.performed += instance.OnPixyLight;
                @PixyLight.canceled += instance.OnPixyLight;
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @ArmDisarm.started += instance.OnArmDisarm;
                @ArmDisarm.performed += instance.OnArmDisarm;
                @ArmDisarm.canceled += instance.OnArmDisarm;
                @FlightMode.started += instance.OnFlightMode;
                @FlightMode.performed += instance.OnFlightMode;
                @FlightMode.canceled += instance.OnFlightMode;
                @Agent3_x.started += instance.OnAgent3_x;
                @Agent3_x.performed += instance.OnAgent3_x;
                @Agent3_x.canceled += instance.OnAgent3_x;
                @Agent3_y.started += instance.OnAgent3_y;
                @Agent3_y.performed += instance.OnAgent3_y;
                @Agent3_y.canceled += instance.OnAgent3_y;
                @Agent3_resize.started += instance.OnAgent3_resize;
                @Agent3_resize.performed += instance.OnAgent3_resize;
                @Agent3_resize.canceled += instance.OnAgent3_resize;
                @Agent3_shoot.started += instance.OnAgent3_shoot;
                @Agent3_shoot.performed += instance.OnAgent3_shoot;
                @Agent3_shoot.canceled += instance.OnAgent3_shoot;
            }
        }
    }
    public ControllerActions @Controller => new ControllerActions(this);
    public interface IControllerActions
    {
        void OnPixyLight(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnArmDisarm(InputAction.CallbackContext context);
        void OnFlightMode(InputAction.CallbackContext context);
        void OnAgent3_x(InputAction.CallbackContext context);
        void OnAgent3_y(InputAction.CallbackContext context);
        void OnAgent3_resize(InputAction.CallbackContext context);
        void OnAgent3_shoot(InputAction.CallbackContext context);
    }
}
