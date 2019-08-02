using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Cards/Spell")]
public class spellCard : ScriptableObject
{
    public int passcode;
    public int tcg, ocg;
    public string cardName;
    public bool isEquip = false;
    public struct equiptedTo { int passdcode; string name; };
    public string secondaryType;
    public Sprite cardImage;
    public string description;
}
