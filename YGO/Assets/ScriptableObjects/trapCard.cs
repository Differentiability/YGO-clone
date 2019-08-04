using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Cards/Trap")]
public class trapCard : Card
{
    public int passcode;
    public int tcg, ocg;
    public string secondaryType;
}
