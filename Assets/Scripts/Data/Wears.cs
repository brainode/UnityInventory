using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wears", menuName = "Items/WearsList")]
public class Wears : Items
{
    [SerializeField]
    private List<Wear> listWears;

    public Wear this[int i]
    {
        get { return listWears[i]; }
    }
}
