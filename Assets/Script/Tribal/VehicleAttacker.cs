using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleAttacker : MonoBehaviour
{
    public GameObject BigStone;
    public Transform handPos;

    public float throwSpeed;
    public float throwInterval;

    private void Start()
    {
        throwInterval = Random.Range(1.5f, 3f);
        InvokeRepeating("ThrowStones", 0f, throwInterval);
    }

    private void ThrowStones()
    {
        Rigidbody rb = Instantiate(BigStone, handPos.position, Quaternion.identity).GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * throwSpeed, ForceMode.Impulse);
        rb.AddForce(transform.up * throwSpeed / 5, ForceMode.Impulse);
        rb.AddTorque(Vector3.right * 5f);

        Destroy(rb.gameObject, 3f);
    }
}