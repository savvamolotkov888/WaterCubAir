using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : Player, IMove, IJump, IStateToWater, IStateToIce
{
    [SerializeField] private float MoveAcceleration;
    [SerializeField] private float FlyAcceleration;
    [SerializeField] private float FlyAccelerationWhenMoove;
    [Range(0, 1)] public float airControl = 0.3f;
    private Rigidbody airRigidbody;

    public void Move(PlayerDirection direction, Player air, RotateDirection rotationDirection)
    {
        if (!airRigidbody)
            airRigidbody = air.GetComponent<Rigidbody>();

        airRigidbody.AddRelativeForce(direction.Lateral * MoveAcceleration, 0, direction.Forward * MoveAcceleration);


        airRigidbody.AddRelativeForce(direction.Lateral * MoveAcceleration, 0, direction.Forward * MoveAcceleration);
    }

    public void Jump(PlayerDirection direction, Player air)
    {
        Debug.Log("AirJump");
        if (!airRigidbody)
            airRigidbody = air.GetComponent<Rigidbody>();

        if (direction.Forward != 1 && direction.Forward != -1 && direction.Lateral != 1 && direction.Lateral != -1)
            airRigidbody.AddForce(0, FlyAcceleration, 0, ForceMode.Force);

        else
            airRigidbody.AddForce(0, FlyAccelerationWhenMoove, 0, ForceMode.Force);
    }

    public void Stet()
    {
        Debug.Log("AirJump");
    }

    public void StateToIce()
    {
    }

    public void StateToWater()
    {
    }
}