using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 30; // degrees per sec

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate
        bool doRotateCW = Input.GetKey(KeyCode.A);
        bool doRotateCCW = Input.GetKey(KeyCode.D);

        float angle = 0;

        if (doRotateCW)
            angle += +rotationSpeed;

        if (doRotateCCW)
            angle += -rotationSpeed;

        float z = transform.rotation.eulerAngles.z;
        float newZ = z + angle * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, newZ);

        // Position
        bool doMoveUp = Input.GetKey(KeyCode.W);
        bool doMoveDown = Input.GetKey(KeyCode.S);

        Vector3 move = new Vector3();

        if (doMoveUp)
            move += transform.up * speed;

        if (doMoveDown)
            move -= transform.up * speed;

        transform.position += move * Time.deltaTime;

        // Example axis
        float horizontal = Input.GetAxis("Horizontal");
    }
}
