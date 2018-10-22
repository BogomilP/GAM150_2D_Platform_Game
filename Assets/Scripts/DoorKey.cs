using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorKey : MonoBehaviour
{
    public GameObject Door;
    public GameObject Capsule;
    void OnTriggerEnter(Collider Capsule)
    {
        Destroy(Door.gameObject);
        Destroy(gameObject);
    }

}