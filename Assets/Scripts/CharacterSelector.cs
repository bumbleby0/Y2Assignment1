using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string CharacterSelect;

    public void ChangeSCharactere(int characterName)
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


            default:
                // code block
                break;
        }


    }


}
