using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cratw : Fighter
{
    protected override void Death()
    {
        Destroy(gameObject);
    }
}
