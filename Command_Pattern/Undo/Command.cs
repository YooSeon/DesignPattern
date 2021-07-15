using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command
{
    protected Transform target;
    protected Vector3 beforPos;
    public virtual void Execute( ref Transform _target ){}
    public void Undo(ref Transform _traget)
    {
        _traget.position = beforPos;
    }
}

public class LeftMoveCommand : Command
{
    public LeftMoveCommand(Transform _target , Vector3 _beforPos)
    {
        target = _target;
        beforPos = _beforPos;
    }
    public override void Execute(ref Transform _target)
    {
        _target.position += new Vector3(-1,0,0);
    }
}
public class RightMoveCommand : Command
{
    public RightMoveCommand(Transform _target, Vector3 _beforPos)
    {
        target = _target;
        beforPos = _beforPos;
    }
    public override void Execute(ref Transform _target)
    {
        _target.position += new Vector3(1, 0, 0);
    }
}
