using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    [SerializeField]
    private Rigidbody RigidBody;
    private Vector3 position;

    void Start()
    {
        position = transform.position;
        RigidBody.AddForce(new Vector3(0.0f, 0.0f, 50.0f), ForceMode.Force);
    }

    public void AddImpulse()
    {
        RigidBody.AddForce(new Vector3(0.0f, 0.0f, 50.0f), ForceMode.Force);
    }
    public void ResetStats()
    {
        transform.position = position;
        transform.rotation = Quaternion.identity;
    }
}
