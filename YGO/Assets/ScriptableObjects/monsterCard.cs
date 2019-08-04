using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Monster")]
public class monsterCard : Card
{
    public int passcode;
    public int tcg, ocg;
    public bool isFusion = false;
    public bool isRitual = false;
    public string attack;
    public string defense;
    public string attribute;
    public string secondaryType;
    public int cardLevel;
}
