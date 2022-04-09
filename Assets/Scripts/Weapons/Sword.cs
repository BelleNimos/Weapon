using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        Instantiate(Arrow, shootPoint.position, Quaternion.identity);
    }
}