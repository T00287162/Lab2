using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody ourRigidBody;

    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddForce(3 * Vector3.up);
        }

    }
}
