using UnityEngine;
using System.Collections.Generic;

namespace Generator
{
    public class SphereQuad : BaseGenarator
    {
        private Material material;
        
        [Range(-90,90)]
        private int xDirection, yDirection, zDirection;
        
        [SerializeField]
        protected int sublevels = 1;

        protected Rect quadSpace = new Rect(new Vector2(-1, -1), new Vector2(2, 2));

        protected float radius = 100f;

        [HideInInspector]
        [SerializeField]
        private GameObject[] subQuads;
        
        public int level = 0;

        public float dot;

        private Transform target;

        void OnDrawGizmos()
        {
            /*if (sublevels == 0)
            {
                dot = -1f*Vector3.Dot((QuadCenter() - target.position).normalized,(QuadCenter() - transform.position).normalized);

                Gizmos.color = Color.Lerp(Color.cyan,Color.red,((dot+1f)/2f));
                Gizmos.DrawSphere(QuadCenter(), 1.5f + dot);
            }*/
            //Debug.Log(dir);
        }

        private Vector3 Ang()
        {
            return new Vector3(
            xDirection ,
            yDirection ,
            zDirection);
        }

        protected virtual Vector3 Dir()
        {
            return new Vector3(
            Mathf.Sin(xDirection * Mathf.Deg2Rad),
            Mathf.Sin(yDirection * Mathf.Deg2Rad),
            Mathf.Sin(zDirection * Mathf.Deg2Rad)).normalized;
        }

        private Vector3 QuadCenter()
        {
            return ((Dir() + (Quaternion.FromToRotation(Vector3.up, Dir()) * new Vector3(quadSpace.center.x, 0f, quadSpace.center.y))).normalized * radius) + transform.position;
        }

        override public void Generate()
        {
            Create(sublevels, radius);
        }

        public void SubQuadInit(int xDirection, int yDirection, int zDirection, int sublevels, int level, Rect quadSpace, Material material, Transform target)
        {
            this.xDirection = xDirection;
            this.yDirection = yDirection;
            this.zDirection = zDirection;
            this.sublevels = sublevels - 1;
            this.quadSpace = quadSpace;
            this.level = level + 1;
            this.material = material;
            this.target = target;

            Create(this.sublevels, radius);
        }

        public void Create(int sublevels, float radius)
        {
            if (sublevels > 0)
            {
                CreateSubmesh();
            }
            else
            {
                CreateMesh(gameObject, radius);
            }
        }

        private void CreateSubmesh()
        {
            if(subQuads == null || subQuads.Length == 0)
            {
                
            }
            else
            {
                for (int i = 0; i < subQuads.Length; i++)
                {
                    DestroyImmediate(subQuads[i]);
                    // update quads
                }
            }

            // create sub quads
            subQuads = new GameObject[4];
            for (int i = 0; i < subQuads.Length; i++)
            {
                subQuads[i] = new GameObject("sub quad");
                subQuads[i].transform.parent = transform;
                subQuads[i].transform.position = transform.position;
            }
            AddSphereQuadToGameObjects(subQuads);
        }

        protected virtual void AddSphereQuadToGameObjects(GameObject[] subQuads)
        {
            float sublevelDevider = (quadSpace.size.x / 2f);

            SphereQuad newQuad = subQuads[0].AddComponent<SphereQuad>();
            newQuad.SubQuadInit(xDirection, yDirection, zDirection, sublevels, level, new Rect(quadSpace.position, (quadSpace.size / 2)), material,target);

            newQuad = subQuads[1].AddComponent<SphereQuad>();
            Rect newQuadRect = new Rect(quadSpace.position, (quadSpace.size / 2));
            newQuadRect.x += sublevelDevider;
            newQuad.SubQuadInit(xDirection, yDirection, zDirection, sublevels, level, newQuadRect, material, target);

            newQuad = subQuads[2].AddComponent<SphereQuad>();
            newQuadRect.x -= sublevelDevider;
            newQuadRect.y += sublevelDevider;
            newQuad.SubQuadInit(xDirection, yDirection, zDirection, sublevels, level, newQuadRect, material, target);

            newQuad = subQuads[3].AddComponent<SphereQuad>();
            newQuadRect.x += sublevelDevider;
            newQuad.SubQuadInit(xDirection, yDirection, zDirection, sublevels, level, newQuadRect, material, target);
        }

        private void CreateMesh(GameObject meshGameObejct, float radius)
        {
            Mesh mesh = new Mesh();
            MeshFilter meshFilter = meshGameObejct.GetComponent<MeshFilter>();
            if (meshFilter == null)
            {
                meshGameObejct.AddComponent<MeshFilter>().mesh = mesh;
                meshGameObejct.AddComponent<MeshRenderer>().sharedMaterial = material;
            }
            else
            {
                meshFilter.mesh = mesh;
            }
            mesh.Clear();

            List<Vector3> vertList = new List<Vector3>();
            Dictionary<long, int> middlePointIndexCache = new Dictionary<long, int>();

            // create 8 vertices Quad
            // top

            Vector3 pDisplaysment = new Vector3(quadSpace.position.x, 0f, quadSpace.position.y);
            Vector3 p1 = Dir() + (Quaternion.FromToRotation(Vector3.up, Dir()) * pDisplaysment);

            pDisplaysment = new Vector3(quadSpace.position.x, 0f, quadSpace.position.y+ quadSpace.size.y);
            Vector3 p2 = Dir() + (Quaternion.FromToRotation(Vector3.up, Dir()) * pDisplaysment);

            pDisplaysment = new Vector3(quadSpace.position.x + quadSpace.size.x, 0f, quadSpace.position.y + quadSpace.size.y);
            Vector3 p3 = Dir() + (Quaternion.FromToRotation(Vector3.up, Dir()) * pDisplaysment);

            pDisplaysment = new Vector3(quadSpace.position.x + quadSpace.size.x, 0f, quadSpace.position.y);
            Vector3 p4 = Dir() + (Quaternion.FromToRotation(Vector3.up, Dir()) * pDisplaysment);
            
            vertList.Add(p1);
            vertList.Add(p2);
            vertList.Add(p3);
            vertList.Add(p4);

            for (int i = 0; i < vertList.Count; i++)
            {
                vertList[i] = vertList[i].normalized * radius;
            }
            
            // 7 - 6
            // |   |
            // 4 - 5

            // 3 - 2
            // |   |
            // 0 - 1
            
            // create 12 triangles of the cubesphere
            List<TriangleIndices> faces = new List<TriangleIndices>();


            faces.Add(new TriangleIndices(0, 1, 2));
            faces.Add(new TriangleIndices(0, 2, 3));

            mesh.vertices = vertList.ToArray();

            List<int> triList = new List<int>();
            for (int i = 0; i < faces.Count; i++)
            {
                triList.Add(faces[i].v1);
                triList.Add(faces[i].v2);
                triList.Add(faces[i].v3);
            }
            mesh.triangles = triList.ToArray();
            mesh.uv = new Vector2[mesh.vertices.Length];

            //Vector3[] normales = new Vector3[vertList.Count];
            //for (int i = 0; i < normales.Length; i++)
            //    normales[i] = vertList[i].normalized;


            //mesh.normals = normales;

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.Optimize();

            meshGameObejct.AddComponent<MeshCollider>();
        }

    }
}
