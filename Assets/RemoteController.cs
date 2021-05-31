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
                },
                {
                    ""name"": ""ConnectPixhawk"",
                    ""type"": ""Button"",
                    ""id"": ""664db57f-3c8e-498d-8753-ed4a33e627ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraPitchUp"",
                    ""type"": ""Button"",
                    ""id"": ""d25c8ea6-5b44-49d9-847a-cf0192e5ccf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraPitchDown"",
                    ""type"": ""Button"",
                    ""id"": ""e6495793-039a-4f02-a970-253a3b396e31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiniROV_forward"",
                    ""type"": ""Button"",
                    ""id"": ""beca4e1b-73a4-4615-9a8f-afde48079641"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiniROV_backward"",
                    ""type"": ""Button"",
                    ""id"": ""cd3a8275-6a50-4e85-b3ba-0a2c37af54b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiniROV_left"",
                    ""type"": ""Button"",
                    ""id"": ""2f520b11-e4a3-4932-9b25-956f8d79eba1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiniROV_right"",
                    ""type"": ""Button"",
                    ""id"": ""b6f0fdb7-6021-4000-8123-5d1fea5fa693"",
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
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button7"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""cba2342d-6815-4f34-9fa5-9bb0a66245f2"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ConnectPixhawk"",
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
                    ""id"": ""b2df42cd-dee8-44c7-8e21-744e3f9265d0"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraPitchUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6b06242-4e61-480c-b6a6-9077bbd72029"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraPitchDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f858072-1852-44b1-bf15-e14b0c283b05"",
                    ""path"": ""<HID::BDA NSW wired controller>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiniROV_forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e97dbf2b-04b8-4333-98a0-da00f9da19b2"",
                    ""path"": ""<HID::BDA NSW wired controller>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiniROV_backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af8a9393-47a0-42ab-9d1b-8241e6b464f6"",
                    ""path"": ""<HID::BDA NSW wired controller>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiniROV_left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f9e4042-0f44-4582-abed-dbf062e72a52"",
                    ""path"": ""<HID::BDA NSW wired controller>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiniROV_right"",
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
        m_Controller_ConnectPixhawk = m_Controller.FindAction("ConnectPixhawk", throwIfNotFound: true);
        m_Controller_CameraPitchUp = m_Controller.FindAction("CameraPitchUp", throwIfNotFound: true);
        m_Controller_CameraPitchDown = m_Controller.FindAction("CameraPitchDown", throwIfNotFound: true);
        m_Controller_MiniROV_forward = m_Controller.FindAction("MiniROV_forward", throwIfNotFound: true);
        m_Controller_MiniROV_backward = m_Controller.FindAction("MiniROV_backward", throwIfNotFound: true);
        m_Controller_MiniROV_left = m_Controller.FindAction("MiniROV_left", throwIfNotFound: true);
        m_Controller_MiniROV_right = m_Controller.FindAction("MiniROV_right", throwIfNotFound: true);
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
    private readonly InputAction m_Controller_ConnectPixhawk;
    private readonly InputAction m_Controller_CameraPitchUp;
    private readonly InputAction m_Controller_CameraPitchDown;
    private readonly InputAction m_Controller_MiniROV_forward;
    private readonly InputAction m_Controller_MiniROV_backward;
    private readonly InputAction m_Controller_MiniROV_left;
    private readonly InputAction m_Controller_MiniROV_right;
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
        public InputAction @ConnectPixhawk => m_Wrapper.m_Controller_ConnectPixhawk;
        public InputAction @CameraPitchUp => m_Wrapper.m_Controller_CameraPitchUp;
        public InputAction @CameraPitchDown => m_Wrapper.m_Controller_CameraPitchDown;
        public InputAction @MiniROV_forward => m_Wrapper.m_Controller_MiniROV_forward;
        public InputAction @MiniROV_backward => m_Wrapper.m_Controller_MiniROV_backward;
        public InputAction @MiniROV_left => m_Wrapper.m_Controller_MiniROV_left;
        public InputAction @MiniROV_right => m_Wrapper.m_Controller_MiniROV_right;
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
                @ConnectPixhawk.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnConnectPixhawk;
                @ConnectPixhawk.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnConnectPixhawk;
                @ConnectPixhawk.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnConnectPixhawk;
                @CameraPitchUp.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnCameraPitchUp;
                @CameraPitchUp.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnCameraPitchUp;
                @CameraPitchUp.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnCameraPitchUp;
                @CameraPitchDown.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnCameraPitchDown;
                @CameraPitchDown.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnCameraPitchDown;
                @CameraPitchDown.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnCameraPitchDown;
                @MiniROV_forward.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_forward;
                @MiniROV_forward.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_forward;
                @MiniROV_forward.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_forward;
                @MiniROV_backward.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_backward;
                @MiniROV_backward.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_backward;
                @MiniROV_backward.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_backward;
                @MiniROV_left.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_left;
                @MiniROV_left.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_left;
                @MiniROV_left.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_left;
                @MiniROV_right.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_right;
                @MiniROV_right.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_right;
                @MiniROV_right.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnMiniROV_right;
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
                @ConnectPixhawk.started += instance.OnConnectPixhawk;
                @ConnectPixhawk.performed += instance.OnConnectPixhawk;
                @ConnectPixhawk.canceled += instance.OnConnectPixhawk;
                @CameraPitchUp.started += instance.OnCameraPitchUp;
                @CameraPitchUp.performed += instance.OnCameraPitchUp;
                @CameraPitchUp.canceled += instance.OnCameraPitchUp;
                @CameraPitchDown.started += instance.OnCameraPitchDown;
                @CameraPitchDown.performed += instance.OnCameraPitchDown;
                @CameraPitchDown.canceled += instance.OnCameraPitchDown;
                @MiniROV_forward.started += instance.OnMiniROV_forward;
                @MiniROV_forward.performed += instance.OnMiniROV_forward;
                @MiniROV_forward.canceled += instance.OnMiniROV_forward;
                @MiniROV_backward.started += instance.OnMiniROV_backward;
                @MiniROV_backward.performed += instance.OnMiniROV_backward;
                @MiniROV_backward.canceled += instance.OnMiniROV_backward;
                @MiniROV_left.started += instance.OnMiniROV_left;
                @MiniROV_left.performed += instance.OnMiniROV_left;
                @MiniROV_left.canceled += instance.OnMiniROV_left;
                @MiniROV_right.started += instance.OnMiniROV_right;
                @MiniROV_right.performed += instance.OnMiniROV_right;
                @MiniROV_right.canceled += instance.OnMiniROV_right;
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
        void OnConnectPixhawk(InputAction.CallbackContext context);
        void OnCameraPitchUp(InputAction.CallbackContext context);
        void OnCameraPitchDown(InputAction.CallbackContext context);
        void OnMiniROV_forward(InputAction.CallbackContext context);
        void OnMiniROV_backward(InputAction.CallbackContext context);
        void OnMiniROV_left(InputAction.CallbackContext context);
        void OnMiniROV_right(InputAction.CallbackContext context);
    }
}
