using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static InputHandler inst;
    [SerializeField] Transform target;
    Stack<Command> cmd_Stack = new Stack<Command>();
    Command cmd;

    void Awake()
    {
        inst = this;    
    }

    void Update()
    {
        cmd = HandlerInput();
        if(cmd != null)
        {
            cmd.Execute(ref target);
            cmd_Stack.Push(cmd);
        }

        if(cmd_Stack.Count != 0)
        {
            if(Input.GetKeyDown(KeyCode.S))
            {
                cmd_Stack.Pop().Undo(ref target);
            }
        }
    }

    public Command HandlerInput()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return new LeftMoveCommand(target,target.position);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            return new RightMoveCommand(target, target.position);
        }
        return null;
    }
}
