using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHolder : MonoBehaviour
{
    GUN gun = default;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))    
        {
            gun = new AK47("AK47");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun = new M4("M4");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            gun = new M16("M16");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            gun = new RPG("RPG");
        }

        if(Input.GetMouseButton(0))
        {
            Attack(gun);
        }
    }

    void Attack(GUN _gun)
    {
        if(_gun != null)
            _gun.Execute();
    }
}
