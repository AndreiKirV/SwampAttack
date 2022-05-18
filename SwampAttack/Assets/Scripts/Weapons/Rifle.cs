using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    private Vector3 _newShootPoint = new Vector3(1,0,0);
    private int _cartridgeRounds = 5;
    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _cartridgeRounds; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            shootPoint.position += _newShootPoint;
        }

        shootPoint.position -= _newShootPoint * _cartridgeRounds;
    }
}