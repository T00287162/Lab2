using UnityEngine;

public class ApplyExplosionForce : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            ourRigidBody.AddExplosionForce(1000, transform.position - new Vector3(0, -1, -1), 3);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
        collision.transform.position += 10 * Vector3.up;
    }
}
