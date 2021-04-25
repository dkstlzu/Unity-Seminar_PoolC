using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyClass
{
    public abstract void Function();
}

public class RealClass : MyClass
{
    public override void Function()
    {
        throw new System.NotImplementedException();
    }
}
