using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    private void Awake()
    {
        // Set all Characters to false to prevent errors
        // Find the parent GameObject
        GameObject parent = GameObject.Find("Icons");

        if (parent != null)
        {
            // Loop through each child transform inside the parent
            foreach (Transform child in parent.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.LogError("Could not find the 'icons' GameObject.");
        }
    }
    private void Start()
    {
        //toggle selected characters stats and sprite as active
        string loadedCharacter = PlayerPrefs.GetString("ActiveCharacter","Erishikgal");
        if (loadedCharacter == "Erishikgal")
        {
            GameObject.Find(loadedCharacter).SetActive(true);
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
