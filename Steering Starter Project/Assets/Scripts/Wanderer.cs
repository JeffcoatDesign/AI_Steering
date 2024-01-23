using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Wanderer : Kinematic
{
    Wander myMoveType;
    Align myRotateType;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Wander();
        myMoveType.character = this;

        myRotateType = new Face();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
