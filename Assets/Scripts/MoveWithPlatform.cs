using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithPlatform : MonoBehaviour {

    Transform OriginalValue;
    private GameObject Player;
    private void OnTriggerStay(Collider other)
    {
        Player = GameObject.Find("Capsule");
        OriginalValue = Player.transform;
    Player.transform.parent = gameObject.transform;
        //This maked the player a child of the moving platform. When it triggers the collision with it it becomes a child.
}

    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = null;
        //When it exits the platform or the collider no longer touches it, its no longer a child of the parent platform.
    }
}