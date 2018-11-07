using UnityEngine;
using System.Collections;

public class CameraPositionControl : MonoBehaviour
{

    public GameObject Capsule;  //This is the player object


    private Vector3 offset;         //This is a value of how far away the camera is from the player

    // Use this for initialization
    void Start()
    {
        //This will figure out how much that distance is and store it in the offset value.
        offset = transform.position - Capsule.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        //This will set the camera to be on top of the player but uses the offset value to get to the exact correct position of the player.
        transform.position = Capsule.transform.position + offset;
    }
}