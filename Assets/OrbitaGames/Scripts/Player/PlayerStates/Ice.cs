using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;


public class Ice : Player, IMove, IJump, IShift, IDoubleShift
{
    [SerializeField] private float MoveAcceleration;

    [SerializeField] private float RotationAcceleration;

    // [SerializeField] private float JumpAcceleration;
    [SerializeField] private float ShiftAcceleration;
    [SerializeField] private float ShiftImpulseAcceleration;
    [SerializeField] private PlayerController playerController;

    private float shiftAcceleration = 1f;
    private HUD_Service _HUDService;

    [Inject]
    private void Construct(HUD_Service _HUD_Service)
    {
        _HUDService = _HUD_Service;
    }

    public override float CurrentHealthHP
    {
        get => currentHealthHP;
        protected set
        {
            if (value < 0)
            {
                currentHealthHP = _HUDService.IceHealthHP = 0;
                Died();
            }
            else if (value > MaxHealthHP)
            {
                currentHealthHP = _HUDService.IceHealthHP = MaxHealthHP;
                Debug.LogError("Ice FULL HEALTH");
            }
            else
                currentHealthHP = _HUDService.IceHealthHP = value;
        }
    }

    private bool additingBoostHP = true;

    public override float CurrentBoostHP
    {
        get => currentBoostHP;
        protected set
        {
            if (value < 0)
            {
                currentBoostHP = _HUDService.IceBoostHP = 0;
                Died();
            }
            else if (value > MaxHealthHP)
            {
                currentBoostHP = _HUDService.IceBoostHP = MaxHealthHP;
                Debug.LogError("Ice FULL Boost");
            }
            else if (value < MaxHealthHP && additingBoostHP)
            {
                BoostRegeneration();
            }
            else
            {
                currentBoostHP = _HUDService.IceBoostHP = value;
            }
        }
    }


    private Rigidbody iceRigidbody;
    [SerializeField] private float DoubleShiftPower;
    [SerializeField] private float ShiftPower;
    [SerializeField] private float boostSpeed;
    private CompositeDisposable compositeDisposable = new();
    [SerializeField] private float JumpAcceleration;
    [SerializeField] private Transform referenceFrame;

    private void Awake()
    {
        iceRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        
    }

    public void Move(PlayerDirection direction, Player ice,
        RotateDirection rotationDirection)
    {
        if (direction.Forward == 0 && direction.Lateral == 0)
            return;

        if (rotationDirection != RotateDirection.DontRotate)
        {
            iceRigidbody.AddTorque(0, RotationAcceleration * (float)rotationDirection * shiftAcceleration, 0);
            return;
        }

        //  Debug.LogError(rotationDirection);

        if (rotationDirection == RotateDirection.DontRotate)
        {
            var forceDirection = Vector3.zero;

            if (direction.Forward != 0)
            {
                forceDirection += referenceFrame.forward * MoveAcceleration;
                forceDirection.y = transform.position.y;

                iceRigidbody.AddForce(new Vector3(forceDirection.normalized.x, forceDirection.normalized.y,
                                          forceDirection.normalized.z)
                                      * MoveAcceleration * direction.Forward * direction.AirControll,
                    ForceMode.Force);
            }

            if (direction.Lateral != 0)
            {
                forceDirection += referenceFrame.right * MoveAcceleration;
                forceDirection.y = transform.position.y;
                iceRigidbody.AddForce(
                    forceDirection.normalized * MoveAcceleration * direction.Lateral * direction.AirControll,
                    ForceMode.Force);
            }
            // Debug.DrawRay(transform.position, forceDirection * 2, Color.black);
        }
    }

    public void Jump(PlayerDirection direction, Player ice)
    {
        Debug.Log("IceJump");
        iceRigidbody.AddForce(0, JumpAcceleration, 0, ForceMode.Impulse);
    }

    public void Shift(PlayerDirection direction, Player ice, float IceAcelerationTime)
    {
        if ((direction.Forward == 1 || direction.Lateral == 0) && direction.Shift > 0 && CurrentBoostHP > 0)
        {
            shiftAcceleration = ShiftAcceleration;

            CurrentBoostHP -= ShiftPower;
            //   Debug.LogError(CurrentBoostHP);
        }

        else if (direction.Shift <= 0)
            shiftAcceleration = 1;
    }

    public void DoubleShift(PlayerDirection direction, Player ice, float IceAcelerationTime)
    {
        if (direction.Forward != 0 && direction.Lateral == 0)
        {
            iceRigidbody.AddRelativeForce(0, 0,
                direction.Forward * ShiftImpulseAcceleration, ForceMode.Impulse);

            CurrentBoostHP -= DoubleShiftPower;
        }
    }

    public void TakeHealth(float iceHealthValue)
    {
        Debug.LogError("Ice TakeHealth");
    }

    private void OnCollisionStay(Collision player)
    {
        //TODO НУЖЕН ФИКС
        iceRigidbody.WakeUp();

        if (player.gameObject.TryGetComponent(out DamagePlatfom enemy))
        {
            LosingHealthHP(enemy.iceDamage);
        }

        else if (player.gameObject.TryGetComponent(out HealthPlatform healthPlatform))
        {
            TakeHealth(healthPlatform.waterHealth);
            AddingHealthHP(healthPlatform.iceHealth);
        }
    }

    protected override void LosingHealthHP(float iceDamageValue)
    {
        if (canChangeHealthHP)
        {
            if (canChangeHealthHP)
            {
                CurrentHealthHP -= iceDamageValue;
                Debug.LogError("Ice TakeDamage" + iceDamageValue);
                FixedChangeHealthHP();
            }
        }
    }

    protected override void AddingHealthHP(float addedHealth)
    {
        if (canChangeHealthHP)
        {
            CurrentHealthHP += addedHealth;
            Debug.LogError("Water TakeHealth" + addedHealth);
            FixedChangeHealthHP();
        }
    }


    protected override void Died()
    {
        Debug.LogError("IceDied");
    }

    protected override void BoostRegeneration()
    {
        Observable.EveryUpdate().Subscribe(_ =>
        {
            additingBoostHP = false;

            if (CurrentBoostHP < MaxBoostHP && playerController.Direction.Shift == 0)
            {
                CurrentBoostHP += boostSpeed;
                if (CurrentBoostHP >= MaxBoostHP)
                {
                    additingBoostHP = true;
                    compositeDisposable.Clear();
                }
            }
        }).AddTo(compositeDisposable);
    }
}