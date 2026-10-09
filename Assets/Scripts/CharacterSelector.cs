using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public string ActiveCharacter;

    string CharacterSelect;


    public void ChangeCharacter(int characterName)
    {
        // Select Character

        switch (characterName)
        {
            case 1:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[0];
                ActiveCharacter = "Erishikgal";
                PlayerPrefs.SetString("Active Character",ActiveCharacter);
                PlayerPrefs.Save();
                break;
            case 2:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[1];
                ActiveCharacter = "Frederick";
                PlayerPrefs.SetString("Active Character", ActiveCharacter);
                PlayerPrefs.Save();
                break;
            case 3:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[2];
                ActiveCharacter = "Ezikiel";
                PlayerPrefs.SetString("Active Character", ActiveCharacter);
                PlayerPrefs.Save();
                break;
            case 4:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[3];
                ActiveCharacter = "Miranda";
                PlayerPrefs.SetString("Active Character", ActiveCharacter);
                PlayerPrefs.Save();
                break;

            default:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[2];
                ActiveCharacter = "Frederick";
                PlayerPrefs.SetString("Active Character", ActiveCharacter);
                PlayerPrefs.Save();
                break;
        }


    }

}
