using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionLevelChange : MonoBehaviour {
 
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // The scene manager loads the next level of the game when the Capsule touches the green circle.
    }
    
}
