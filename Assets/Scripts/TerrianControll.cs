using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrianControll : MonoBehaviour
{
    public static TerrianControll instance;

    public Terrain[,] dataCurrentMap;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) { instance = new TerrianControll(); }

    }

    // read data

    Terrain getDataByIndex(int col, int row)
    {
        Terrain rs = dataCurrentMap[col, row];
        return rs;
    }

    void setValueByIndex(int col, int row, Terrain data)
    {
        dataCurrentMap[col, row] = data;
    }

    void Update()
    {

    }
}
