﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightBullet : Bullet
{


    public override void Shoot()
    {
        transform.position += direction * speed;
    }
}
