using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Generator
{
    [RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
    public class TerainGen : BaseGenarator
    {

        #region Fields

        // start position in noise function
        //[SerializeField]

        // get/set to slow for this fields
        public int startX;
        public int startY;

        // if true transform wil be set to noise start position (startX,0,startY)
        [SerializeField]
        private bool setToStart;

        [SerializeField]
        private bool generateColliders = true;

        // counters
        private int x;
        private int y;
        private int i;
        private int posInArray = 0;

        // mesh size
        [SerializeField]
        private int mapX = 100;
        [SerializeField]
        private int mapY = 100;

        [SerializeField]
        private float mDlo = 12f;

        private float genDataTemp;

        [SerializeField]
        private bool debugPrint = false;

        [SerializeField]
        private int xStepSize = 1;
        [SerializeField]
        private int yStepSize = 1;

        private bool meshGenerate = false;
        private Mesh mesh;

        Vector3[] verts;
        float[] heights;
        Vector3[] generatedNormals;
        Vector2[] uvs;
        int[] tris;

        bool generating = false;

        [SerializeField]
        private bool generateOnStart = false;

        private MeshCollider meshColider;

        #endregion

        #region Properties
        public int MapY
        {
            get
            {
                return mapY;
            }
            set
            {
                mapY = value;
            }
        }

        public int MapX
        {
            get
            {
                return mapX;
            }
            set
            {
                mapX = value;
            }
        }
        /*
        public int StartY
        {
            get
            {
                return startY;
            }
        }

        public int StartX
        {
            get
            {
                return startX;
            }
        }*/

        public int SetStartY
        {
            set
            {
                startY = value;
            }
        }

        public int SetStartX
        {
            set
            {
                startX = value;
            }
        }

        public int GetxStepSize
        {
            get
            {
                return xStepSize;
            }
        }
        public int GetyStepSize
        {
            get
            {
                return yStepSize;
            }
        }

        public bool GenerateColliders
        {
            get
            {
                return generateColliders;
            }
        }

        #endregion

        void Start()
        {
            if (generateOnStart)
            {
                Generate();
            }
        }

        public override void Generate()
        {

            generating = true;
            meshGenerate = false;

            InitData(startX, startY, mapX, mapY, xStepSize, yStepSize);

            mesh = new Mesh();

            // enmpty arrays
            verts = new Vector3[(mapY * mapX)];
            uvs = new Vector2[(mapY * mapX)];
            tris = new int[(mapY * mapX * 6)];

            if (!Application.isPlaying)
            {
                Debug.Log("Start Gen");
                StartCoroutine(LoopInEditor());
            }
        }

        // Update in edit mode needed because using thread
        private IEnumerator LoopInEditor()
        {
            while (generating)
            {
                Debug.Log("Update Gen");
                Update();
                yield return null;
            }
        }

        private void Update()
        {
            if (generating)
            {
                posInArray = y = x = 0;
                if (!meshGenerate)
                {
                    GeneratorDataJob.Tick();
                    bool jobsDone = GeneratorDataJob.JobDone;
                    if (jobsDone)
                    {
                        posInArray = 0;
                        heights = noiseJob.OutData;
                        generatedNormals = noiseJob.OutNormals;

                        GenerateMesh();
                    }
                }
            }
        }

        public void GenerateMesh()
        {
            mesh = GetMesh();

            GetComponent<MeshFilter>().mesh = mesh;

            if (GenerateColliders)
            {
                if (meshColider != null)
                {
                    if (Application.isPlaying)
                    {
                        Destroy(meshColider);
                    }
                    else
                    {
                        DestroyImmediate(meshColider);
                    }
                }
                meshColider = gameObject.AddComponent<MeshCollider>();
            }

            if (setToStart)
            {
                transform.position = new Vector3(startX, 0, startY);
            }
        }

        private Mesh GetMesh()
        {
            generating = false;

            posInArray = 0;

            // generate vertices
            for (y = 0; y < mapY; y += 1)
            {
                for (x = 0; x < mapX; x += 1)
                {
                    int xPos = (x * xStepSize);
                    int yPos = (y * xStepSize);

                    verts[posInArray] = new Vector3(xPos, heights[posInArray], yPos);

                    posInArray++;
                }
            }
            GeneratorDataJob = null;
            meshGenerate = true;

            // generate triangles
            posInArray = y = x = 0;
            for (y = 0; y < (mapY - 1); y += 1)
            {
                for (x = 0; x < (mapX - 1); x += 1)
                {
                    int num = GeneratorUtil.XYToNum(x, y, mapX);

                    tris[posInArray] = (num + mapX);
                    posInArray++;
                    tris[posInArray] = (num + 1);
                    posInArray++;
                    tris[posInArray] = (num);
                    posInArray++;

                    tris[posInArray] = (num + mapX + 1);
                    posInArray++;
                    tris[posInArray] = (num + 1);
                    posInArray++;
                    tris[posInArray] = (num + mapX);
                    posInArray++;
                }
            }

            // generate uvs
            posInArray = y = x = 0;
            for (y = 0; y < mapY; y += 1)
            {
                if (debugPrint) Debug.Log(y + " - " + ((float)y % mDlo));
                for (x = 0; x < mapX; x += 1)
                {
                    uvs[posInArray] = (new Vector2((float)x / (float)mapX, (float)y / (float)mapY));
                    posInArray++;
                }
            }

            // set mesh data
            mesh.vertices = verts;
            mesh.uv = uvs;
            mesh.triangles = tris;
            mesh.normals = generatedNormals;
            mesh.RecalculateBounds();
            mesh.Optimize();

            return mesh;
        }



    }
}
