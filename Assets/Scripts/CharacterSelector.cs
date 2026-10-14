using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    private const string ActiveCharacterKey = "ActiveCharacter";

    public string ActiveCharacter { get; private set; }

    public void ChangeCharacter(int characterValue)
    {
        if (!System.Enum.IsDefined(typeof(CharacterList), characterValue))
        {
            Debug.LogWarning($"Invalid character value: {characterValue}. Using Erishikgal.");
            characterValue = (int)CharacterList.Erishikgal;
        }

        CharacterList selectedCharacter = (CharacterList)characterValue;
        ActiveCharacter = selectedCharacter.ToString();

        PlayerPrefs.SetString(ActiveCharacterKey, ActiveCharacter);
        PlayerPrefs.Save();

        Debug.Log($"Selected character: {ActiveCharacter}");
    }
}
