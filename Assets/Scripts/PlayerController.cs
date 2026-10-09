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
        // 1. Get the character name from PlayerPrefs
        string loadedCharacter = PlayerPrefs.GetString("ActiveCharacter", "Erishikgal");

        if (!string.IsNullOrEmpty(loadedCharacter))
        {
            // 2. Clean the string to prevent hidden space bugs
            loadedCharacter = loadedCharacter.Trim();

            if (iconsParent != null)
            {
                // 3. Search for the character dynamically using the variable name
                Transform characterTransform = iconsParent.transform.Find(loadedCharacter);

                // 4. Fallback: If it fails, check if the object has a trailing space in the Hierarchy
                if (characterTransform == null)
                {
                    characterTransform = iconsParent.transform.Find(loadedCharacter + " ");
                }

                // 5. Activate the character if found
                if (characterTransform != null)
                {
                    characterTransform.gameObject.SetActive(true);
                    Debug.Log("Successfully activated: " + characterTransform.name);
                }
                else
                {
                    Debug.LogError($"Could not find a child named '{loadedCharacter}' or '{loadedCharacter} ' inside Icons.");
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
