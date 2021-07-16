using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int playerX;
    [SerializeField] int playerZ;
    void Update()
    {
        MoveToPlayer();
    }
    void MoveToPlayer()
    {
        playerX = Mathf.Clamp(Mathf.RoundToInt(this.transform.position.x),0,2); 
        playerZ = Mathf.Clamp(Mathf.RoundToInt(this.transform.position.z), 0, 2);

        float _terrain = World.inst.GetTile(playerX, playerZ).GetMoveSpeed() * Time.deltaTime;
        Debug.Log("NowSpeed :" + World.inst.GetTile(playerX, playerZ).GetMoveSpeed());
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3( -_terrain,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(_terrain, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0, 0, _terrain);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += new Vector3(0, 0, -_terrain);
        }
        this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -0.5f , 2.5f),0,Mathf.Clamp(this.transform.position.z, -0.5f, 2.5f));
    }
}
