using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    protected string cardName;
    protected Sprite cardImage;
    protected string description;
    protected struct equiptedToMonster // cant be protected? look into C# specs
    { 
        int passcode;
        string name;
        public equiptedToMonster(int cPasscode, string cName)
        {
            passcode = cPasscode;
            name = cName;
        }
    }
    protected void activateCard()
    {
        Debug.Log("Card activated");
    }
    protected void summonCard()
    {
        Debug.Log("Card summoned");
    }
    protected void placeFaceDown()
    {
        Debug.Log("Card placed face-down");
    }

    protected void equipCard(int passcode, string name)
    {
        equiptedToMonster equiped = new equiptedToMonster(passcode, name);
    }

}
