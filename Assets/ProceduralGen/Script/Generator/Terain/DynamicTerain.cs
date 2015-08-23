using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Generator;

public class DynamicTerain : MonoBehaviour
{
    // TODO : new array index is used for each tile spawned. I set the size to a random high number so it doesn't run out fast.
    private TerainGen[] terainList = new TerainGen[1000000];

    [SerializeField]
    private TerainGen baseTerain;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private int terainSize = 101;

    [SerializeField]
    private int drawDist = 3;

    [SerializeField]
    private Gradient gizmoColorDistance;

    [SerializeField]
    private bool draw = false;
    [SerializeField]
    private UnityEngine.UI.Text tileCountText;
    [SerializeField]
    private UnityEngine.UI.Text tileMaxText;
    [SerializeField]
    private UnityEngine.UI.Slider tileMaxSlide;

    private int tileCount = 0;

    public Transform Target
    {
        set
        {
            target = value;
        }
    }

    void OnDrawGizmos()
    {
        if (draw)
        {
            float xPos = target.position.x;
            float zPos = target.position.z;

            int intTerainStartX = Mathf.FloorToInt(xPos / (float)terainSize);
            int intTerainStartZ = Mathf.FloorToInt(zPos / (float)terainSize);

            for (int x = -drawDist; x < (drawDist + 1); x++)
            {
                for (int z = -drawDist; z < (drawDist + 1); z++)
                {
                    float dist = Vector2.Distance(new Vector2((x * terainSize), (z * terainSize)), new Vector2(intTerainStartX, intTerainStartZ));
                    float t = (dist / (float)drawDist) / (float)terainSize;
                    // set color (gradiant distance)
                    Gizmos.color = gizmoColorDistance.Evaluate(t);
                    // draw terain rect
                    DragGizmoRect(new Rect(intTerainStartX + x, intTerainStartZ + z, terainSize, terainSize), 80f - (0.1f * dist));
                }
            }
        }
    }

    void DragGizmoRect(Rect rect, float height)
    {
        Vector3 bottomLeft = new Vector3((rect.x * rect.width), height, (rect.y * rect.height));
        Vector3 bottomRight = new Vector3(((rect.x * rect.width) + rect.width), height, (rect.y * rect.height));
        Vector3 topRight = new Vector3(((rect.x * rect.width) + rect.width), height, ((rect.y * rect.height) + rect.height));
        Vector3 topLeft = new Vector3((rect.x * rect.width), height, ((rect.y * rect.height) + rect.height));

        Gizmos.DrawLine(bottomLeft, bottomRight);
        Gizmos.DrawLine(bottomRight, topRight);
        Gizmos.DrawLine(topRight, topLeft);
        Gizmos.DrawLine(topLeft, bottomLeft);
    }

    void Start()
    {
        Invoke("UpdateTerain", 0.0f);
    }

    void UpdateTerain()
    {

        // update ui
        tileCountText.text = "TILES: " + tileCount + " VERTS: " + (tileCount * 289) + " TRIS: " + (tileCount * 578);
        tileMaxText.text = "MAX TILES: " + tileMaxSlide.value;

        // remove tiles
        if (tileCount > tileMaxSlide.value)
        {
            StartCoroutine(RemoveParts());
        }

        // add tiles
        float xPos = target.position.x;
        float zPos = target.position.z;

        int intTerainStartX = Mathf.FloorToInt(xPos / (float)terainSize);
        int intTerainStartY = Mathf.FloorToInt(zPos / (float)terainSize);

        int terainStartX = intTerainStartX * terainSize;
        int terainStartY = intTerainStartY * terainSize;
        StartCoroutine(UpdateParts(terainStartX, terainStartY));
    }

    IEnumerator RemoveParts()
    {
        int remove = 20;
        // fill distance arrays
        int[] indexFarest = new int[remove];
        float[] faretsDist = new float[remove];
        for (int r = 0; r < remove; r++)
        {
            indexFarest[r] = 0;
            faretsDist[r] = 0f;
        }

        // find array indexes to remove
        for (int i = 0; i < tileCount; i++)
        {
            float dist = Vector2.Distance(TileWorldPos(terainList[i])
                                            , new Vector2(target.position.x, target.position.z));
            for (int j = 0; j < remove; j++)
            {
                if (dist > faretsDist[j])
                {
                    //Debug.Log("j:"+j);
                    for (int k = 5; k > (0 + j); k--)
                    {
                        //Debug.Log("k:" + k);
                        indexFarest[k] = indexFarest[k - 1];
                        faretsDist[k] = faretsDist[k - 1];
                    }
                    indexFarest[j] = i;
                    faretsDist[j] = dist;
                    break;
                }
            }
        }

        //sort array indexes
        System.Array.Sort(indexFarest);

        // remove tiles from array
        for (int j = remove - 1; j > -1; j--)
        {
            // remove
            if (terainList[indexFarest[j]] != null)
            {
                GameObject.Destroy(terainList[indexFarest[j]].gameObject);
                terainList[indexFarest[j]] = null;
                // move rest parts down 
                for (int i = indexFarest[j]; i < tileCount; i++)
                {
                    terainList[i] = terainList[i + 1];
                }
                tileCount--;
            }
        }
        yield return null;
    }


    IEnumerator UpdateParts(int terainStartX, int terainStartY)
    {

        //List<NewPart> newParts = new List<NewPart>();
        NewPart[] newPartsAr = new NewPart[((drawDist + drawDist + 1) * (drawDist + drawDist + 1))];
        int num = 0;
        // colect posible new tile positions
        Vector3 targetPos = target.position;
        for (int x = -drawDist; x < (drawDist + 1); x++)
        {
            for (int z = -drawDist; z < (drawDist + 1); z++)
            {
                float dist = Vector2.Distance(new Vector2(terainStartX + ((x * terainSize) - (terainSize * 0.5f)), terainStartY + ((z * terainSize) - (terainSize * 0.5f))), new Vector2(targetPos.x, targetPos.z));
                newPartsAr[num] = new NewPart(terainStartX + (x * (terainSize)), terainStartY + (z * (terainSize)), dist);
                num++;
            }
        }

        // start threaded sort job to sort possible new tiles by distance
        SortTerainGenByDistJob sortJob = new SortTerainGenByDistJob(newPartsAr);
        ThreadedJobHandeler sortJobHandler = new ThreadedJobHandeler();
        sortJobHandler.Init(sortJob);
        while (!sortJobHandler.JobDone)
        {
            sortJobHandler.Tick();
            yield return null;
        }

        int currentPartsGenerated = 0;

        // generate max 2 new parts
        for (int i = 0; i < newPartsAr.Length; i++)
        {
            // generate parts
            if (GenPart(newPartsAr[i].xPart, newPartsAr[i].yPart))
            {
                currentPartsGenerated++;
            };

            if (currentPartsGenerated > 2)
            {
                break;
            }
        }
        yield return null;
        UpdateTerain();
    }


    bool GenPart(int newPartX, int newPartY)
    {
        bool alreadyExists = false;
        for (int i = 0; i < tileCount; i++)
        {
            if (terainList[i].startX == newPartX && terainList[i].startY == newPartY)
            {
                alreadyExists = true;
                return false;
            }
        }
        if (!alreadyExists)
        {
            TerainGen newTerain = ((GameObject)GameObject.Instantiate(baseTerain.gameObject, Vector3.zero, Quaternion.identity)).GetComponent<TerainGen>();

            newTerain.SetStartX = newPartX;
            newTerain.SetStartY = newPartY;
            newTerain.Generate();
            terainList[tileCount] = newTerain;
            newTerain.transform.parent = transform;

            tileCount++;

            return true;
        }
        return false;
    }

    Vector2 TileWorldPos(TerainGen tile)
    {
        return new Vector2(tile.startX, tile.startY);
    }
}