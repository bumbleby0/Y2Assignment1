using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    private void Start()
    {
        string chosen = PlayerPrefs.GetString("ChosenCharater", "Erishikgal");

    }
    void Update()
    {
        // Movement Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        // SelectedCharacter Stat

    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);

    }
}
