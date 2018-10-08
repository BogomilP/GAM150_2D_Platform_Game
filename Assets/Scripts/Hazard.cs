using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Hazard : MonoBehaviour
{
    public GameObject Capsule;
    void OnTriggerEnter(Collider Capsule)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // The scene manager loads the same level after the player hits a hazerdous object and the level restarts. Im sure there are better and easier ways to do this but at my current level this seems logical.
    }

}