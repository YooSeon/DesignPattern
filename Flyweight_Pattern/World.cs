using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain
{
    public Terrain(float _moveSpeed , bool _isWater)
    {
        moveSpeed = _moveSpeed;
        isWater = _isWater;
    }
    public float GetMoveSpeed() => moveSpeed;
    public bool IsWater() => isWater;

    private float moveSpeed;
    private bool isWater;
}

public class World : MonoBehaviour
{
    public static World inst;
    [SerializeField] Material[] mat;
    Terrain[,] tiles = new Terrain[3,3];
    Terrain grassTerrain = new Terrain(3,false);
    Terrain hillTerrain = new Terrain(1,false);
    Terrain riverTerrain = new Terrain(0.5f,true);
    public Terrain GetTile(int x, int y) => tiles[x,y];

    void Awake()
    {
        inst = this;
        CreateTile();
    }

    void CreateTile()
    {
        for(int x = 0 ; x < 3; x++)
        {
            for(int z = 0 ; z < 3; z++)
            {
                GameObject _ob = GameObject.CreatePrimitive(PrimitiveType.Cube);
                _ob.transform.position = new Vector3(x,-1,z);
                if(z == 0) tiles[x,z] = grassTerrain;
                else if(z == 1) tiles[x,z] = riverTerrain;
                else if(z == 2) tiles[x,z] = hillTerrain;

                _ob.GetComponent<MeshRenderer>().material = mat[z];
                _ob.transform.SetParent(this.transform);
            }
        }
    }



}
