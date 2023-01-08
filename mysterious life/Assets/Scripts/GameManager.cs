using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{    
    string[] texty = {"The spikes will kill you instantly, and that's not good. Watch out for them.", "I would recommend taking checkpoints they look like a flag and will make it easier for you to get through the game.", "this game is a normal jumping so don't look for science in it and relax...", "this game was made in the Czech Republic." +
            ""};
    public Text textovepole;
    void Start()
    {
        textovepole.text = texty[Random.Range(0,texty.Length)];
    }

   
}
