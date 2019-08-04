using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Cards/Spell")]
public class spellCard : Card
{
    public int passcode;
    public int tcg, ocg;
    public bool isEquip = false;
    public string secondaryType;
}
