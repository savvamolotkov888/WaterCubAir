using System;
using Obi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private PlayerDirection Direction;
    [SerializeField] private PlayerSensor playerSensor;
    public float smoothFacor;
    
    [SerializeField] private Transform targetA;
    public Transform targetB;

    public ObiSolver WaterSolwer;


    public ObiActor waterActor;


    private GameObject Water;
    private GameObject Ice;
    private GameObject Air;
    
    private GameObject currentGameobjectState;

    private float moveAcceleration;
    private float RotationAcceleration;
    private float jumpBoost;

    private InputSystem inputSystem;
    private PlayerState currentState;

    

    public Water water;
    public Ice ice;
    public Air air;


    private Vector3 LookAtpoz;
    void Jump(IJump jump) => jump.Jump(currentGameobjectState);

    void Move(IMove movable) =>
        movable.Move(Direction, currentGameobjectState,
            playerSensor.rorator);

    private void Awake()
    {
        Direction = new PlayerDirection();
        //Cursor.lockState = CursorLockMode.Locked;
        // Water = water.gameObject;

        Ice = ice.gameObject;
        Air = air.gameObject;

        currentGameobjectState = Ice;
        currentState = PlayerState.Ice;

        inputSystem = new InputSystem();


        inputSystem.Transformation.ToIce.performed += context => TransformaitionToIce();
        inputSystem.Transformation.ToAir.performed += context => TransformaitionToAir();
    }

    private void Update()
    {
        Direction.Forward = inputSystem.Control.MoveVertical.ReadValue<float>();
        Direction.Lateral = inputSystem.Control.MoveGorizontal.ReadValue<float>();
        Direction.Up = inputSystem.Control.Jump.ReadValue<float>();

        if (inputSystem.Transformation.ToWater.ReadValue<float>() > 0)
            TransformaitionToWater();
        if (inputSystem.Transformation.ToIce.ReadValue<float>() > 0)
            TransformaitionToIce();
        if (inputSystem.Transformation.ToAir.ReadValue<float>() > 0)
            TransformaitionToAir();
        LookAtpoz = Vector3.Lerp(targetB.position,
            new Vector3(targetA.position.x, ice.transform.position.y, targetA.position.z), smoothFacor);
        targetB.position = LookAtpoz;
        UpdatePosition();
    }

    private void FixedUpdate()
    {    
        
        Move();
        Jump();
    }

    private void LateUpdate()
    {
   
    }

    void Move()
    {
        switch (currentState)
        {
            case PlayerState.Water:
                Move(water);
                break;
            case PlayerState.Ice:
                if (playerSensor.OnTheFloar)
                {
                    Move(ice);
                }

                break;
            case PlayerState.Air:
                air.transform.LookAt(targetB);
                Move(air);
                break;
        }
    }

    void Jump()
    {
        switch (currentState)
        {
            case PlayerState.Water:
                if (playerSensor.OnTheFloar && Direction.Up > 0)
                Jump(water);
                break;
            case PlayerState.Ice:
                if (playerSensor.OnTheFloar && Direction.Up > 0)
                    Jump(ice);
                break;

            case PlayerState.Air:
                Jump(air);
                break;
        }
    }

    void UpdatePosition()
    {
        switch (currentState)
        {
            case PlayerState.Water:
                transform.position = water.transform.position;
                break;
            case PlayerState.Ice:
                transform.position = ice.transform.position;

                break;
            case PlayerState.Air:
                transform.position = air.transform.position;

                break;
        }
    }

    void TransformaitionToWater()
    {
        Debug.Log("TransformaitionToWater");
        Ice.SetActive(false);
        Air.SetActive(false);
        
        currentState = PlayerState.Water;
        currentGameobjectState = waterActor.gameObject;
        WaterSolwer.gameObject.SetActive(true);
        waterActor.Teleport(transform.position, transform.rotation);
        gameObject.transform.position = water.transform.position;
    }

    void TransformaitionToIce()
    {
        
        Debug.Log("TransformaitionToIce");
        WaterSolwer.gameObject.SetActive(false);
        air.gameObject.SetActive(false);
        
        currentState = PlayerState.Ice;
        ice.transform.position = transform.position;
        ice.gameObject.SetActive(true);
        currentState = PlayerState.Ice;
    }

    void TransformaitionToAir()
    {
        Debug.Log("TransformaitionToAire");
        WaterSolwer.gameObject.SetActive(false);
        Ice.gameObject.SetActive(false);
        
        currentState = PlayerState.Air;
        air.transform.position = transform.position;
        air.gameObject.SetActive(true);
        currentGameobjectState = Air;
    }


    private void OnEnable()
    {
        inputSystem.Enable();
    }

    private void OnDisable()
    {
        inputSystem.Disable();
    }
}

public enum PlayerState
{
    Water,
    Ice,
    Air
}