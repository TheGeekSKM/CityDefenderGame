using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GameObject bulletObject;
    [SerializeField] Transform bulletStartPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletObject, bulletStartPoint.position, Quaternion.identity);
        }
    }
}
