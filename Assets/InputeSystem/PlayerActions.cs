//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputeSystem/PlayerActions.inputactions
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

public partial class @PlayerActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Player_Map"",
            ""id"": ""6672d2a2-e79b-4933-8b2e-aec7551a3b82"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""53382cd3-a711-44ba-96c1-dbab4c424352"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""51bfe970-3dfa-433a-8257-edffa6ef6533"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Item1"",
                    ""type"": ""Button"",
                    ""id"": ""34d0bb6d-55d6-48f7-b81b-abc80438ecab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Item2"",
                    ""type"": ""Button"",
                    ""id"": ""67a9b772-9af0-43a7-8a0b-09fa251df3a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cd3a6153-a7b6-416e-9ddd-a8721bb01ea3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""68ad96af-52f8-4159-9959-0a00efcf4e75"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7f1bf001-7ded-476e-8baf-1a54913488b8"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d5afb2c2-84a9-4c71-a219-7ca9653e6c9e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1a2e242e-5382-4dda-b06b-f9ba01ea6843"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""783ad1f9-e19f-40bd-a09d-e42970428410"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ade4dca0-fba3-439f-81de-03bb0332a4a5"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""114e5b3d-3c9f-4cb3-a196-6312795b7590"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player_Map_Kb"",
            ""id"": ""a88d4f66-2e66-4b2d-af87-afe62bb95c5f"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""beadaf40-e8a9-41a1-a1f9-3b369b308a3e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""ef252cfd-6d32-4c09-aea4-54d1ea5dd096"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Item1"",
                    ""type"": ""Button"",
                    ""id"": ""21b8df44-da0c-4197-b02f-486e8b9aec4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Item2"",
                    ""type"": ""Button"",
                    ""id"": ""f7969cf6-ae1f-4302-bf89-fe804a41b43d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""29c0bb30-bd4c-4af5-9836-b2e139b644be"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9663de89-a95a-420f-afa2-7aa940d405c3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""98697d30-a5da-4e2e-b168-38b32b4a8400"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""32e18cfa-cc30-4107-93ad-b8ed52626e0e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8fd31a02-0bcd-4611-ae98-9e3d7891be9a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""59a61b85-bfec-4807-8404-dea30aed8b88"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd1e5081-0991-4514-8e7a-ce3aa7f51398"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb7ad3d1-48dc-44ce-b78f-f214248c9f5a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player_Map_Kb1"",
            ""id"": ""dee8062c-70dd-45d9-9a54-9fdc9d5ff92a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d3d26387-5992-4e7b-b9c1-de26d09b6c0b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""9542dfd2-8e1e-4413-a5ea-e622dfa7d165"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Item1"",
                    ""type"": ""Button"",
                    ""id"": ""6f22a435-f597-4de6-b81b-dca47154b721"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Item2"",
                    ""type"": ""Button"",
                    ""id"": ""1e119cf9-53b5-4093-b92a-7344999234f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""854dd9a3-cc3e-44e4-8092-e8a189004ba7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""18b3f523-332e-41b5-9aa6-f1bb499d266b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""846cb5d4-a050-4309-b81c-ae213c45b246"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0f30079f-03fe-45f5-a6ba-bf000e12266e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""48da01b8-ce94-4182-9b9b-e943f2b700fb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6c18f381-1c40-46ca-afa4-35c72dcc6f13"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f61dd337-f6ad-4758-960f-a130ca298421"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""034880f8-df1a-48e3-a25e-a5b8ad9f084e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player_Map
        m_Player_Map = asset.FindActionMap("Player_Map", throwIfNotFound: true);
        m_Player_Map_Movement = m_Player_Map.FindAction("Movement", throwIfNotFound: true);
        m_Player_Map_Shoot = m_Player_Map.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Map_Item1 = m_Player_Map.FindAction("Item1", throwIfNotFound: true);
        m_Player_Map_Item2 = m_Player_Map.FindAction("Item2", throwIfNotFound: true);
        // Player_Map_Kb
        m_Player_Map_Kb = asset.FindActionMap("Player_Map_Kb", throwIfNotFound: true);
        m_Player_Map_Kb_Movement = m_Player_Map_Kb.FindAction("Movement", throwIfNotFound: true);
        m_Player_Map_Kb_Shoot = m_Player_Map_Kb.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Map_Kb_Item1 = m_Player_Map_Kb.FindAction("Item1", throwIfNotFound: true);
        m_Player_Map_Kb_Item2 = m_Player_Map_Kb.FindAction("Item2", throwIfNotFound: true);
        // Player_Map_Kb1
        m_Player_Map_Kb1 = asset.FindActionMap("Player_Map_Kb1", throwIfNotFound: true);
        m_Player_Map_Kb1_Movement = m_Player_Map_Kb1.FindAction("Movement", throwIfNotFound: true);
        m_Player_Map_Kb1_Shoot = m_Player_Map_Kb1.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Map_Kb1_Item1 = m_Player_Map_Kb1.FindAction("Item1", throwIfNotFound: true);
        m_Player_Map_Kb1_Item2 = m_Player_Map_Kb1.FindAction("Item2", throwIfNotFound: true);
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

    // Player_Map
    private readonly InputActionMap m_Player_Map;
    private IPlayer_MapActions m_Player_MapActionsCallbackInterface;
    private readonly InputAction m_Player_Map_Movement;
    private readonly InputAction m_Player_Map_Shoot;
    private readonly InputAction m_Player_Map_Item1;
    private readonly InputAction m_Player_Map_Item2;
    public struct Player_MapActions
    {
        private @PlayerActions m_Wrapper;
        public Player_MapActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Map_Movement;
        public InputAction @Shoot => m_Wrapper.m_Player_Map_Shoot;
        public InputAction @Item1 => m_Wrapper.m_Player_Map_Item1;
        public InputAction @Item2 => m_Wrapper.m_Player_Map_Item2;
        public InputActionMap Get() { return m_Wrapper.m_Player_Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_MapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_MapActions instance)
        {
            if (m_Wrapper.m_Player_MapActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnShoot;
                @Item1.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnItem1;
                @Item1.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnItem1;
                @Item1.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnItem1;
                @Item2.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnItem2;
                @Item2.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnItem2;
                @Item2.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnItem2;
            }
            m_Wrapper.m_Player_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Item1.started += instance.OnItem1;
                @Item1.performed += instance.OnItem1;
                @Item1.canceled += instance.OnItem1;
                @Item2.started += instance.OnItem2;
                @Item2.performed += instance.OnItem2;
                @Item2.canceled += instance.OnItem2;
            }
        }
    }
    public Player_MapActions @Player_Map => new Player_MapActions(this);

    // Player_Map_Kb
    private readonly InputActionMap m_Player_Map_Kb;
    private IPlayer_Map_KbActions m_Player_Map_KbActionsCallbackInterface;
    private readonly InputAction m_Player_Map_Kb_Movement;
    private readonly InputAction m_Player_Map_Kb_Shoot;
    private readonly InputAction m_Player_Map_Kb_Item1;
    private readonly InputAction m_Player_Map_Kb_Item2;
    public struct Player_Map_KbActions
    {
        private @PlayerActions m_Wrapper;
        public Player_Map_KbActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Map_Kb_Movement;
        public InputAction @Shoot => m_Wrapper.m_Player_Map_Kb_Shoot;
        public InputAction @Item1 => m_Wrapper.m_Player_Map_Kb_Item1;
        public InputAction @Item2 => m_Wrapper.m_Player_Map_Kb_Item2;
        public InputActionMap Get() { return m_Wrapper.m_Player_Map_Kb; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_Map_KbActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_Map_KbActions instance)
        {
            if (m_Wrapper.m_Player_Map_KbActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnShoot;
                @Item1.started -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnItem1;
                @Item1.performed -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnItem1;
                @Item1.canceled -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnItem1;
                @Item2.started -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnItem2;
                @Item2.performed -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnItem2;
                @Item2.canceled -= m_Wrapper.m_Player_Map_KbActionsCallbackInterface.OnItem2;
            }
            m_Wrapper.m_Player_Map_KbActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Item1.started += instance.OnItem1;
                @Item1.performed += instance.OnItem1;
                @Item1.canceled += instance.OnItem1;
                @Item2.started += instance.OnItem2;
                @Item2.performed += instance.OnItem2;
                @Item2.canceled += instance.OnItem2;
            }
        }
    }
    public Player_Map_KbActions @Player_Map_Kb => new Player_Map_KbActions(this);

    // Player_Map_Kb1
    private readonly InputActionMap m_Player_Map_Kb1;
    private IPlayer_Map_Kb1Actions m_Player_Map_Kb1ActionsCallbackInterface;
    private readonly InputAction m_Player_Map_Kb1_Movement;
    private readonly InputAction m_Player_Map_Kb1_Shoot;
    private readonly InputAction m_Player_Map_Kb1_Item1;
    private readonly InputAction m_Player_Map_Kb1_Item2;
    public struct Player_Map_Kb1Actions
    {
        private @PlayerActions m_Wrapper;
        public Player_Map_Kb1Actions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Map_Kb1_Movement;
        public InputAction @Shoot => m_Wrapper.m_Player_Map_Kb1_Shoot;
        public InputAction @Item1 => m_Wrapper.m_Player_Map_Kb1_Item1;
        public InputAction @Item2 => m_Wrapper.m_Player_Map_Kb1_Item2;
        public InputActionMap Get() { return m_Wrapper.m_Player_Map_Kb1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_Map_Kb1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_Map_Kb1Actions instance)
        {
            if (m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnShoot;
                @Item1.started -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnItem1;
                @Item1.performed -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnItem1;
                @Item1.canceled -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnItem1;
                @Item2.started -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnItem2;
                @Item2.performed -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnItem2;
                @Item2.canceled -= m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface.OnItem2;
            }
            m_Wrapper.m_Player_Map_Kb1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Item1.started += instance.OnItem1;
                @Item1.performed += instance.OnItem1;
                @Item1.canceled += instance.OnItem1;
                @Item2.started += instance.OnItem2;
                @Item2.performed += instance.OnItem2;
                @Item2.canceled += instance.OnItem2;
            }
        }
    }
    public Player_Map_Kb1Actions @Player_Map_Kb1 => new Player_Map_Kb1Actions(this);
    public interface IPlayer_MapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnItem1(InputAction.CallbackContext context);
        void OnItem2(InputAction.CallbackContext context);
    }
    public interface IPlayer_Map_KbActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnItem1(InputAction.CallbackContext context);
        void OnItem2(InputAction.CallbackContext context);
    }
    public interface IPlayer_Map_Kb1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnItem1(InputAction.CallbackContext context);
        void OnItem2(InputAction.CallbackContext context);
    }
}
