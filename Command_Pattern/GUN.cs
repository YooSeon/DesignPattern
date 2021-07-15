using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUN 
{   
    protected string gunName = default;

    public virtual void Execute(){}
}
public class AK47 : GUN
{
    public AK47(string _name)
    {
        gunName = _name;
    }
    public override void Execute()
    {
        Debug.Log(gunName + " Fire");
    }
}
public class M4 : GUN
{
    public M4(string _name)
    {
        gunName = _name;
    }
    public override void Execute()
    {
        Debug.Log(gunName + " Fire");
    }
}
public class M16 : GUN
{
    public M16(string _name)
    {
        gunName = _name;
    }
    public override void Execute()
    {
        Debug.Log(gunName + " Fire");
    }
}
public class RPG : GUN
{
    public RPG(string _name)
    {
        gunName = _name;
    }
    public override void Execute()
    {
        Debug.Log(gunName + " Fire");
    }
}
