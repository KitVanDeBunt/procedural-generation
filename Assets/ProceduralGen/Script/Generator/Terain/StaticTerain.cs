using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Generator;

public class StaticTerain : MonoBehaviour
{

    [SerializeField]
    [HideInInspector]
    private List<TerainGen> terainList = new List<TerainGen>();

    [SerializeField]
    private int terainSizeX = 101;
    [SerializeField]
    private int terainSizeZ = 101;

    [SerializeField]
    private Gradient gizmoColorDistance;

    [SerializeField]
    private TerainGen baseTerain;

    void Start()
    {
        GenParts();
    }
    
    /// <summary>
    /// genatares A gird off terain tiles
    /// </summary>
    void GenParts()
    {
        foreach (TerainGen trainPart in terainList)
        {
            GameObject.Destroy(trainPart.gameObject);
            terainList.Remove(trainPart);
        }

        for (int x = 0; x < terainSizeX; x++)
        {
            for (int z = 0; z < terainSizeZ; z++)
            {
                // generate tile
                GenPart((x * baseTerain.GetxStepSize * (baseTerain.MapX - 1)), (z * baseTerain.GetyStepSize * (baseTerain.MapY - 1)));
            }
        }
    }

    /// <summary>
    /// generates a tain tile
    /// </summary>
    /// <param name="newPartX">X position of new tile</param>
    /// <param name="newPartY">Y position of new tile</param>
    void GenPart(int newPartX, int newPartY)
    {
        TerainGen newTerain = ((GameObject)GameObject.Instantiate(baseTerain.gameObject, Vector3.zero, Quaternion.identity)).GetComponent<TerainGen>();

        newTerain.SetStartX = newPartX;
        newTerain.SetStartY = newPartY;

        newTerain.Generate();
        terainList.Add(newTerain);
        newTerain.transform.parent = transform;
    }
}

























