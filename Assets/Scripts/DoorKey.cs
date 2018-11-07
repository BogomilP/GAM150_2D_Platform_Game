using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorKey : MonoBehaviour
{
    public GameObject Door;
    //This allows us to set a GameObjects in Unity. In this case the door blocking the goal.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Destroy (Door.gameObject);
            Destroy(gameObject);
        //This will destroy the key it is attached to and the door.
    }

}