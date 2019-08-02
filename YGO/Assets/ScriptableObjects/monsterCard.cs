using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Monster")]
public class monsterCard : ScriptableObject
{
    public int passcode;
    public int tcg, ocg;
    public string cardName;
    public bool isFusion = false;
    public bool isRitual = false;
    public int attack;
    public int defense;
    public string attribute;
    public string secondaryType;
    public int cardLevel;
    public Sprite cardImage;
    public string description;
}
