// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d3836515-abf0-4efa-afd4-2bf6f29a6a8f"",
            ""actions"": [
                {
                    ""name"": ""HorizontalAxisCamera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b62b1cf4-f4ed-4f4c-beb6-ca3b77858656"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0da6a5c9-8779-4d2e-a0d7-a63c96b82940"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""97926557-1e6c-45ee-b2ed-358e7193b01b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootLaser"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d9c117fe-5af8-4840-bee9-39dd0acd29bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""0e6b2a6a-5177-444a-a710-f4f6187174db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d0f669fc-5d92-4591-935b-220f5c0415ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ed328607-e8bc-4f13-a582-0a9bde48cdd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleMap"",
                    ""type"": ""Button"",
                    ""id"": ""c32e18e8-7623-4a45-ad02-02e0c2fc2177"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateGun"",
                    ""type"": ""Value"",
                    ""id"": ""11261c18-8e8d-4e0a-aebe-f2e8983a462a"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MeleeAttack"",
                    ""type"": ""PassThrough"",
                    ""id"": ""723b5604-4401-4126-94ed-83a9d9dc4dff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
                },
                {
                    ""name"": ""ActivateButton"",
                    ""type"": ""Button"",
                    ""id"": ""3277eff9-6bb2-46c8-abb8-b5ebce2d5b2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""823b4f41-9275-4280-855f-69c532eca7c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""aad2a7dd-46a1-4c5e-aa05-7c4c6eb0b9e4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""78032a39-e939-4feb-8532-05e95188e868"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6aea89d2-b9ea-43a5-a57e-c921aac999a9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""fb361fc8-1cc5-40ef-ab8c-5d40fa880e20"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""85ea2745-d355-4fcd-a0a6-b621a98b7fd1"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""17b15245-3135-4674-92ec-27da3060c76e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""touchscreen"",
                    ""id"": ""4e825c0a-f2bc-4cda-8c50-3730d799ac4c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""23467d8e-db4f-491b-b262-408e21bc1b69"",
                    ""path"": ""<AndroidJoystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fee76992-dc54-4560-8799-64d0d6bc252f"",
                    ""path"": ""<AndroidJoystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e4eec26d-cb2a-424d-8508-7fd2903f20c9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa4821e2-cb0b-4dae-b658-236ca45c7bbd"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c89a4b9-f133-4332-b0e0-62b5faa19565"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a70b9efc-7711-4afe-9385-4acf5a7c12ba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""accb5994-9016-44b8-9012-ae7c0e981ca8"",
                    ""path"": ""<Touchscreen>/touch1/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24d5bbca-6df5-4fb6-bb3e-7abf2864f3c1"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20e66ae5-db66-4ab5-9ea7-a000e2ae270b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""057efab6-5d95-42a8-a95e-5e1fdedda33c"",
                    ""path"": ""<Touchscreen>/touch2/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76552e73-9705-4da5-9671-8fad0b70e927"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15e6f319-306a-4874-a2cd-4da345cf15f2"",
                    ""path"": ""<Touchscreen>/touch3/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b60190a4-a462-4d44-834f-890905dcac22"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ec46daa-483f-4af0-8fe1-03ec3b0418b0"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61ce3de9-2d42-4a08-a7dd-2e93ee815df8"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9249e257-8df4-41ce-a451-dc2d51a00217"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab747041-34fd-412f-bc7e-639394b0a4d4"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ec2dbcd-3d21-4be1-a443-9546706d6d4b"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MeleeAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""090e7694-41f4-401a-b253-d79671aaf5b0"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MeleeAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
                },
                {
                    ""name"": """",
                    ""id"": ""fac87904-295f-455e-942d-c1598e017e41"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a0e7ce6-b2a7-4176-aa61-746df75cde8d"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
                }
            ]
        },
        {
            ""name"": ""Player_Map"",
            ""id"": ""b2f9f242-1ff9-4c7f-a6be-1be59e20b6ec"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""41f71ac6-184d-4140-83a6-34469f1d6d02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5918bf1d-6ee2-428f-a380-2e2cbaa9d5af"",
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
                    ""id"": ""eb6c8f6d-4625-49ce-ba7f-ff5d24da9a94"",
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
                    ""id"": ""45fa67cf-5f09-4ecb-9bad-bfbddd515c21"",
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
                    ""id"": ""658c8808-bf25-4136-9e2d-0b4e50ef3cba"",
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
                    ""id"": ""9cdb2c6e-a1fd-46de-92b5-84505dcdf9f1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_HorizontalAxisCamera = m_Player.FindAction("HorizontalAxisCamera", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_ShootLaser = m_Player.FindAction("ShootLaser", throwIfNotFound: true);
        m_Player_ChangeWeapon = m_Player.FindAction("ChangeWeapon", throwIfNotFound: true);
        m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
        m_Player_Dash = m_Player.FindAction("Dash", throwIfNotFound: true);
        m_Player_ToggleMap = m_Player.FindAction("ToggleMap", throwIfNotFound: true);
        m_Player_RotateGun = m_Player.FindAction("RotateGun", throwIfNotFound: true);
        m_Player_MeleeAttack = m_Player.FindAction("MeleeAttack", throwIfNotFound: true);
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
        m_Player_ActivateButton = m_Player.FindAction("ActivateButton", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
        // Player_Map
        m_Player_Map = asset.FindActionMap("Player_Map", throwIfNotFound: true);
        m_Player_Map_Movement = m_Player_Map.FindAction("Movement", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_HorizontalAxisCamera;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_ShootLaser;
    private readonly InputAction m_Player_ChangeWeapon;
    private readonly InputAction m_Player_MousePosition;
    private readonly InputAction m_Player_Dash;
    private readonly InputAction m_Player_ToggleMap;
    private readonly InputAction m_Player_RotateGun;
    private readonly InputAction m_Player_MeleeAttack;
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
    private readonly InputAction m_Player_ActivateButton;
    private readonly InputAction m_Player_Inventory;
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalAxisCamera => m_Wrapper.m_Player_HorizontalAxisCamera;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @ShootLaser => m_Wrapper.m_Player_ShootLaser;
        public InputAction @ChangeWeapon => m_Wrapper.m_Player_ChangeWeapon;
        public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
        public InputAction @Dash => m_Wrapper.m_Player_Dash;
        public InputAction @ToggleMap => m_Wrapper.m_Player_ToggleMap;
        public InputAction @RotateGun => m_Wrapper.m_Player_RotateGun;
        public InputAction @MeleeAttack => m_Wrapper.m_Player_MeleeAttack;
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
        public InputAction @ActivateButton => m_Wrapper.m_Player_ActivateButton;
        public InputAction @Inventory => m_Wrapper.m_Player_Inventory;
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @HorizontalAxisCamera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalAxisCamera;
                @HorizontalAxisCamera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalAxisCamera;
                @HorizontalAxisCamera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalAxisCamera;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @ShootLaser.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLaser;
                @ShootLaser.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLaser;
                @ShootLaser.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLaser;
                @ChangeWeapon.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon;
                @MousePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @Dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @ToggleMap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleMap;
                @ToggleMap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleMap;
                @ToggleMap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleMap;
                @RotateGun.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateGun;
                @RotateGun.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateGun;
                @RotateGun.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateGun;
                @MeleeAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMeleeAttack;
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
                @ActivateButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateButton;
                @ActivateButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateButton;
                @ActivateButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateButton;
                @Inventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalAxisCamera.started += instance.OnHorizontalAxisCamera;
                @HorizontalAxisCamera.performed += instance.OnHorizontalAxisCamera;
                @HorizontalAxisCamera.canceled += instance.OnHorizontalAxisCamera;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @ShootLaser.started += instance.OnShootLaser;
                @ShootLaser.performed += instance.OnShootLaser;
                @ShootLaser.canceled += instance.OnShootLaser;
                @ChangeWeapon.started += instance.OnChangeWeapon;
                @ChangeWeapon.performed += instance.OnChangeWeapon;
                @ChangeWeapon.canceled += instance.OnChangeWeapon;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @ToggleMap.started += instance.OnToggleMap;
                @ToggleMap.performed += instance.OnToggleMap;
                @ToggleMap.canceled += instance.OnToggleMap;
                @RotateGun.started += instance.OnRotateGun;
                @RotateGun.performed += instance.OnRotateGun;
                @RotateGun.canceled += instance.OnRotateGun;
                @MeleeAttack.started += instance.OnMeleeAttack;
                @MeleeAttack.performed += instance.OnMeleeAttack;
                @MeleeAttack.canceled += instance.OnMeleeAttack;
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
                @ActivateButton.started += instance.OnActivateButton;
                @ActivateButton.performed += instance.OnActivateButton;
                @ActivateButton.canceled += instance.OnActivateButton;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player_Map
    private readonly InputActionMap m_Player_Map;
    private IPlayer_MapActions m_Player_MapActionsCallbackInterface;
    private readonly InputAction m_Player_Map_Movement;
    public struct Player_MapActions
    {
        private @PlayerControls m_Wrapper;
        public Player_MapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Map_Movement;
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
            }
            m_Wrapper.m_Player_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public Player_MapActions @Player_Map => new Player_MapActions(this);
    public interface IPlayerActions
    {
        void OnHorizontalAxisCamera(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShootLaser(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnToggleMap(InputAction.CallbackContext context);
        void OnRotateGun(InputAction.CallbackContext context);
        void OnMeleeAttack(InputAction.CallbackContext context);
<<<<<<< Updated upstream:Assets/PlayerControls.cs
=======
        void OnActivateButton(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
>>>>>>> Stashed changes:Assets/Scripts/PlayerControls.cs
    }
    public interface IPlayer_MapActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
