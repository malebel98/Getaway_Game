using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 10;
    public float rotationSpeed = 60;

	// Update is called once per frame
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0, 0, vertical) * Time.deltaTime * movementSpeed;
        transform.Translate(movement);

        Vector3 rotation = new Vector3(0, horizontal, 0) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }
}
