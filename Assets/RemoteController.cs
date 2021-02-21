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
                    ""id"": ""103e1b5d-79c7-4642-85fc-79384eaffbc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateClamp"",
                    ""type"": ""Button"",
                    ""id"": ""1146c9aa-199a-404c-9a6d-dd169fefdee2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeSub"",
                    ""type"": ""Button"",
                    ""id"": ""7749372a-3bf1-4a27-bdc9-51f994ea9482"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""cba9ec56-2867-4a0e-b45a-9e38698f345c"",
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
                    ""id"": ""90c0ca69-32ba-48c5-af6a-e0c7335cb67e"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlightMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb682498-65d6-4aa1-b6d2-3fbf85115180"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateClamp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cecb9f0b-3643-4e17-a56b-c0bdc2c6d0eb"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeSub"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab0060bb-182b-478d-8c82-4d8dcb33d182"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeSub"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""022da403-e877-48d1-b1e7-3c5c47c078a9"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
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
        m_Controller_ActivateClamp = m_Controller.FindAction("ActivateClamp", throwIfNotFound: true);
        m_Controller_ChangeSub = m_Controller.FindAction("ChangeSub", throwIfNotFound: true);
        m_Controller_Rotate = m_Controller.FindAction("Rotate", throwIfNotFound: true);
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
    private readonly InputAction m_Controller_ActivateClamp;
    private readonly InputAction m_Controller_ChangeSub;
    private readonly InputAction m_Controller_Rotate;
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
        public InputAction @ActivateClamp => m_Wrapper.m_Controller_ActivateClamp;
        public InputAction @ChangeSub => m_Wrapper.m_Controller_ChangeSub;
        public InputAction @Rotate => m_Wrapper.m_Controller_Rotate;
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
                @ActivateClamp.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnActivateClamp;
                @ActivateClamp.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnActivateClamp;
                @ActivateClamp.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnActivateClamp;
                @ChangeSub.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnChangeSub;
                @ChangeSub.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnChangeSub;
                @ChangeSub.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnChangeSub;
                @Rotate.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRotate;
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
                @ActivateClamp.started += instance.OnActivateClamp;
                @ActivateClamp.performed += instance.OnActivateClamp;
                @ActivateClamp.canceled += instance.OnActivateClamp;
                @ChangeSub.started += instance.OnChangeSub;
                @ChangeSub.performed += instance.OnChangeSub;
                @ChangeSub.canceled += instance.OnChangeSub;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
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
        void OnActivateClamp(InputAction.CallbackContext context);
        void OnChangeSub(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
