using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform objectToFollow;

    [SerializeField]
    float cameraSpeed = 0.5f;

    [SerializeField]
    float yOffset;

    [SerializeField]
    float xOffset;

    float zOffset;
	// Use this for initialization
	void Start ()
    {
        zOffset = transform.position.z;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 newPosition = 
            new Vector3(objectToFollow.position.x + xOffset, 
            objectToFollow.position.y + yOffset, zOffset);

        Vector3 adjustedPosition = Vector3.Lerp(transform.position, newPosition, 
            cameraSpeed * Time.deltaTime);

        transform.position = adjustedPosition;	
	}
}
