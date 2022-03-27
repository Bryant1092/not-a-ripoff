using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profession: MonoBehaviour
{



    public Classes theClass;

    [SerializeField]
    private ArchStats archstat = new ArchStats();
    void Start()
    {
        //this.GameObject.sprite
    }

    void Update()
    {

    }

}

public enum Classes {
    Archer,
    Goblin,
    Orc,
    Troll,
    Giant,
    Wizard,
    Catapult
}