using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterType", menuName = "SO/Character Type")]
public class CharacterTypeSO : ScriptableObject
{
    public string characterType;
    public int health;
    public int attack;
    public int defense;
}
