using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapons", menuName = "Items/WeaponsList")]
public class Weapons : Items
{

    [SerializeField]
    private List<Weapon> listWeapon;

    public enum eWeaponAttackType
    {
        Melee = 0,
        Range = 1
    }

    public Weapon this[int i]
    {
        get { return listWeapon[i]; }
    }
}
