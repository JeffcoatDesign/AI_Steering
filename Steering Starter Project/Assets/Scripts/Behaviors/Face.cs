﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align
{
    // TODO: override Align's getTargetAngle to face the target instead of matching it's orientation
    public override float getTargetAngle()
    {
        Vector3 direction = character.transform.position - target.transform.forward;
        float targetAngle = Mathf.Atan2(-direction.x, direction.z) * Mathf.Rad2Deg;

        return targetAngle;
    }
}
