using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    private float _timer = 0;
    private float _delay = 1f;
    private float _numberOfShots = 5;
    private bool _isShooting = false;

    private void Update() 
    {
        if (_isShooting == true)
        {
            Debug.Log("отсчитываю");
        }
    }

    public override void Shoot(Transform shootPoint)
    {
        _isShooting = !_isShooting;
        Debug.Log("Переключил исшутинг" + _isShooting);
    }

    private void StartTimer()
    {
        Debug.Log("отсчитываю");
        _timer -= Time.deltaTime;
    }
}