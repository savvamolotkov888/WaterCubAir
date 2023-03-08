using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDirection : MonoBehaviour
{
    [SerializeField] private Transform ice;

    // Update is called once per frame
    void Update()
    {
        transform.position = ice.transform.position;
        transform.rotation =
            Quaternion.Euler(0, ice.transform.rotation.eulerAngles.y, 0);
    }
}