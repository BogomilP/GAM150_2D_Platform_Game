using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour {
    [SerializeField]
    Text CollectibleText;
    [SerializeField]
    Text GotEverything;

    public GameObject KeyDoor;
    int CollectedObjects;
    int TotalObjects;
    

    // Use this for initialization
    private void Start() {
        
        CollectibleText.enabled = false;
        GotEverything.enabled = false;
        TotalObjects = GameObject.FindGameObjectsWithTag("Collectible").Length;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectible")
        {
            CollectedObjects += 1;
            if (CollectedObjects <= TotalObjects)
            {
                CollectibleText.text = CollectedObjects.ToString() + " collected out of " + TotalObjects;
                StopAllCoroutines();
                StartCoroutine(showText());


            }

            if (CollectedObjects == TotalObjects)
            {
                GotEverything.text = "You can now find the key...";
                StopAllCoroutines();
                StartCoroutine(showText());
                Destroy(KeyDoor.gameObject);

            }
        }
    }
    IEnumerator showText()
    {
        CollectibleText.enabled = true;
        yield return new WaitForSeconds(2);
        CollectibleText.enabled = false;
        yield return new WaitForSeconds(2);
        GotEverything.enabled = true;
        yield return new WaitForSeconds(2);
        GotEverything.enabled = false;
    }
}
