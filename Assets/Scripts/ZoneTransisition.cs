using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTransisition : MonoBehaviour
{
    
    public string SceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneToLoad);
            Debug.Log("Loading scene: " + SceneToLoad);
        }
    }

}
