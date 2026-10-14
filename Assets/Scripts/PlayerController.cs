using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string ActiveCharacterKey = "ActiveCharacter";
    private const string DefaultCharacter = nameof(CharacterList.Erishikgal);

    public float MoveSpeed = 5f;
    public Rigidbody2D rb;

    private GameObject iconsParent;
    private Vector2 movement;

    private void Awake()
    {
        iconsParent = GameObject.Find("Icons");

        if (iconsParent == null)
        {
            Debug.LogError("Could not find the 'Icons' GameObject.");
            return;
        }

        foreach (Transform child in iconsParent.transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        if (iconsParent == null)
        {
            return;
        }

        string activeCharacter = PlayerPrefs.GetString(
            ActiveCharacterKey,
            DefaultCharacter);

        activeCharacter = activeCharacter.Trim();

        Transform characterTransform =
            iconsParent.transform.Find(activeCharacter);

        if (characterTransform == null)
        {
            Debug.LogError(
                $"Could not find a child named '{activeCharacter}' inside Icons.");
            return;
        }

        characterTransform.gameObject.SetActive(true);
        Debug.Log($"Successfully activated: {characterTransform.name}");
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (rb == null)
        {
            return;
        }

        rb.MovePosition(
            rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
