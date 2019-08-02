using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Cards/Trap")]
public class trapCard : ScriptableObject
{
    public int passcode;
    public int tcg, ocg;
    public string cardName;
    public string secondaryType;
    public Sprite cardImage;
    public string description;
}
