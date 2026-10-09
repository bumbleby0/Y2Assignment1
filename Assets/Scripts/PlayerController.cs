using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D rb;

    private GameObject iconsParent;

    Vector2 movement;

    private void Awake()
    {
        // Find the parent GameObject
        iconsParent = GameObject.Find("Icons");

        if (iconsParent != null)
        {
            // Loop through each child transform inside the parent and disable them
            foreach (Transform child in iconsParent.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.LogError("Could not find the 'Icons' GameObject.");
        }
    }
    private void Start()
    {
        // Get the chosen character name (defaults to "Erishikgal" if empty)
        string loadedCharacter = PlayerPrefs.GetString("ActiveCharacter", "Erishikgal");

        if (!string.IsNullOrEmpty(loadedCharacter))
        {
            loadedCharacter = loadedCharacter.Trim(); // Removes potential whitespace bugs

            if (loadedCharacter == "Erishikgal" && iconsParent != null)
            {
                // transform.Find looks through INACTIVE children. 
                Transform characterTransform = iconsParent.transform.Find("Erishikgal");

                if (characterTransform != null)
                {
                    characterTransform.gameObject.SetActive(true);
                    Debug.Log("Successfully activated: " + characterTransform.name);
                }
                else
                {
                    Debug.LogError("Could not find child named 'Erishikgal ' inside Icons.");
                }
            }
            if (loadedCharacter == "Frederick" && iconsParent != null)
            {
                // transform.Find looks through INACTIVE children. 
                Transform characterTransform = iconsParent.transform.Find("Frederick");

                if (characterTransform != null)
                {
                    characterTransform.gameObject.SetActive(true);
                    Debug.Log("Successfully activated: " + characterTransform.name);
                }
                else
                {
                    Debug.LogError("Could not find child named 'Frederick ' inside Icons.");
                }
            }
        }
        else
        {
            Debug.Log("No Prefs");
        }
    }
    void Update()
    {
        // Movement Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);

    }
}
