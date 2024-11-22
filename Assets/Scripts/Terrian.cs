using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrian : MonoBehaviour
{
    public float height = 0f;
    public float width = 0f;
    //[Header("Mesh Asset")]
    //public Mesh mesh;
    public TerianScope ts;
    public bool hasEvent;
    public bool hasEffect;



    void Start()
    {

    }


    void Update()
    {

    }
}

public enum TerianScope
{
    RoadMap,
    Dungeon,
    Battle
}
