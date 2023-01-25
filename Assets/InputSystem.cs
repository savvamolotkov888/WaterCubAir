//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputSystem.inputactions
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

public partial class @InputSystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Control"",
            ""id"": ""f13aaf27-d6b9-419c-860a-08e7b7659bb0"",
            ""actions"": [
                {
                    ""name"": ""MoveVertical"",
                    ""type"": ""Value"",
                    ""id"": ""924b925d-8623-474e-a230-fd5d35b83461"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveGorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""2046dcfc-6478-4124-8e5d-6a685475ccec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""2c12c2f3-53bc-4955-b28c-3a5245238f5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shift"",
                    ""type"": ""Button"",
                    ""id"": ""acb6862c-e9f9-49e6-b282-504ed817b0ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WS"",
                    ""id"": ""b1b56364-871c-48bb-a77e-658a57a0d6cb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e14824ec-43a7-4d35-a82c-a95b15144a2e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f1ff90e6-5de9-40ba-b1b1-b929cc55cdaf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0d24e146-71eb-4312-99a5-f21379ef0992"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bbc705b-76bf-4b1d-8ecb-8f5c2c9e69e3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""0f8998ea-3f8c-49b3-b03f-e0160ee8322b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveGorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""af0ed425-b914-44da-9ad3-6ba384b9a3ef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveGorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b3cee074-07f0-4c57-b4d1-02ef9aa915a8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveGorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Transformation"",
            ""id"": ""c5d85277-26ef-4788-8b90-eaaf7881ade8"",
            ""actions"": [
                {
                    ""name"": ""ToWater"",
                    ""type"": ""Button"",
                    ""id"": ""29b16359-1447-40e2-b3ed-8255d286bf9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToIce"",
                    ""type"": ""Button"",
                    ""id"": ""ba0742f5-c491-4ef4-bb4a-f8593f254112"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToAir"",
                    ""type"": ""Button"",
                    ""id"": ""f8732685-2293-4f3d-8f63-d32a37638e96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a5327e36-74a7-4297-8965-7d273f084d76"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ToWater"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66768e3f-0e7a-4a63-83d3-268ef4e531dd"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToIce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60d9e1f6-4034-43e1-97d5-ed7834d676bc"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToAir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Control
        m_Control = asset.FindActionMap("Control", throwIfNotFound: true);
        m_Control_MoveVertical = m_Control.FindAction("MoveVertical", throwIfNotFound: true);
        m_Control_MoveGorizontal = m_Control.FindAction("MoveGorizontal", throwIfNotFound: true);
        m_Control_Jump = m_Control.FindAction("Jump", throwIfNotFound: true);
        m_Control_Shift = m_Control.FindAction("Shift", throwIfNotFound: true);
        // Transformation
        m_Transformation = asset.FindActionMap("Transformation", throwIfNotFound: true);
        m_Transformation_ToWater = m_Transformation.FindAction("ToWater", throwIfNotFound: true);
        m_Transformation_ToIce = m_Transformation.FindAction("ToIce", throwIfNotFound: true);
        m_Transformation_ToAir = m_Transformation.FindAction("ToAir", throwIfNotFound: true);
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

    // Control
    private readonly InputActionMap m_Control;
    private IControlActions m_ControlActionsCallbackInterface;
    private readonly InputAction m_Control_MoveVertical;
    private readonly InputAction m_Control_MoveGorizontal;
    private readonly InputAction m_Control_Jump;
    private readonly InputAction m_Control_Shift;
    public struct ControlActions
    {
        private @InputSystem m_Wrapper;
        public ControlActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveVertical => m_Wrapper.m_Control_MoveVertical;
        public InputAction @MoveGorizontal => m_Wrapper.m_Control_MoveGorizontal;
        public InputAction @Jump => m_Wrapper.m_Control_Jump;
        public InputAction @Shift => m_Wrapper.m_Control_Shift;
        public InputActionMap Get() { return m_Wrapper.m_Control; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlActions set) { return set.Get(); }
        public void SetCallbacks(IControlActions instance)
        {
            if (m_Wrapper.m_ControlActionsCallbackInterface != null)
            {
                @MoveVertical.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnMoveVertical;
                @MoveVertical.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnMoveVertical;
                @MoveVertical.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnMoveVertical;
                @MoveGorizontal.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnMoveGorizontal;
                @MoveGorizontal.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnMoveGorizontal;
                @MoveGorizontal.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnMoveGorizontal;
                @Jump.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnJump;
                @Shift.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnShift;
                @Shift.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnShift;
                @Shift.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnShift;
            }
            m_Wrapper.m_ControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveVertical.started += instance.OnMoveVertical;
                @MoveVertical.performed += instance.OnMoveVertical;
                @MoveVertical.canceled += instance.OnMoveVertical;
                @MoveGorizontal.started += instance.OnMoveGorizontal;
                @MoveGorizontal.performed += instance.OnMoveGorizontal;
                @MoveGorizontal.canceled += instance.OnMoveGorizontal;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shift.started += instance.OnShift;
                @Shift.performed += instance.OnShift;
                @Shift.canceled += instance.OnShift;
            }
        }
    }
    public ControlActions @Control => new ControlActions(this);

    // Transformation
    private readonly InputActionMap m_Transformation;
    private ITransformationActions m_TransformationActionsCallbackInterface;
    private readonly InputAction m_Transformation_ToWater;
    private readonly InputAction m_Transformation_ToIce;
    private readonly InputAction m_Transformation_ToAir;
    public struct TransformationActions
    {
        private @InputSystem m_Wrapper;
        public TransformationActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToWater => m_Wrapper.m_Transformation_ToWater;
        public InputAction @ToIce => m_Wrapper.m_Transformation_ToIce;
        public InputAction @ToAir => m_Wrapper.m_Transformation_ToAir;
        public InputActionMap Get() { return m_Wrapper.m_Transformation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TransformationActions set) { return set.Get(); }
        public void SetCallbacks(ITransformationActions instance)
        {
            if (m_Wrapper.m_TransformationActionsCallbackInterface != null)
            {
                @ToWater.started -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToWater;
                @ToWater.performed -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToWater;
                @ToWater.canceled -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToWater;
                @ToIce.started -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToIce;
                @ToIce.performed -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToIce;
                @ToIce.canceled -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToIce;
                @ToAir.started -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToAir;
                @ToAir.performed -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToAir;
                @ToAir.canceled -= m_Wrapper.m_TransformationActionsCallbackInterface.OnToAir;
            }
            m_Wrapper.m_TransformationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToWater.started += instance.OnToWater;
                @ToWater.performed += instance.OnToWater;
                @ToWater.canceled += instance.OnToWater;
                @ToIce.started += instance.OnToIce;
                @ToIce.performed += instance.OnToIce;
                @ToIce.canceled += instance.OnToIce;
                @ToAir.started += instance.OnToAir;
                @ToAir.performed += instance.OnToAir;
                @ToAir.canceled += instance.OnToAir;
            }
        }
    }
    public TransformationActions @Transformation => new TransformationActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IControlActions
    {
        void OnMoveVertical(InputAction.CallbackContext context);
        void OnMoveGorizontal(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShift(InputAction.CallbackContext context);
    }
    public interface ITransformationActions
    {
        void OnToWater(InputAction.CallbackContext context);
        void OnToIce(InputAction.CallbackContext context);
        void OnToAir(InputAction.CallbackContext context);
    }
}
