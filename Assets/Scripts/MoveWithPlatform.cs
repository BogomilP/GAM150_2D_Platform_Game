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
}

    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = null;
    }
}