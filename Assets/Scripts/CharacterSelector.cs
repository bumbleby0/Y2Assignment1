using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    string CharacterSelect;

    public void ChangeCharacter(int characterName)
    {
        // Select Character

        switch (characterName)
        {
            case 1:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[1];
                break;
            case 2:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[2];
                break;
            case 3:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[3];
                break;
            case 4:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[4];
                break;

            default:
                // code block
                CharacterSelect = Enum.GetNames(typeof(CharacterList))[2];
                break;
        }


    }

}
