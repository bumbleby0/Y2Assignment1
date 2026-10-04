using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterMAnager : MonoBehaviour
{
    public static PlayerCharacterMAnager Instance;

    public CharacterList SelectedCharater;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
