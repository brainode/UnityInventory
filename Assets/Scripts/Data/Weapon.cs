using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Weapon : Item
{
    //[Header("Weapon Attack Type")]
    [Header("Weapon Parameters")]
    public Weapons.eWeaponAttackType eAttackType;
    //[Header("Weapon Attack Power")]
    public float fAttackPower;
    //[Header("Weapon Attack Range")]
    public float fAttackRange;


}
