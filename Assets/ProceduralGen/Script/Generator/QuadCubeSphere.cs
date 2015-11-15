using UnityEngine;
using System.Collections.Generic;

namespace Generator
{
    public class QuadCubeSphere : BaseGenarator
    {

        override public void Generate()
        {
            Create(gameObject, 1, 20f);
        }

        public void Create(GameObject meshGameObejct, int recursionLevel, float radius)
        {
            Mesh mesh = new Mesh();
            MeshFilter meshFilter = meshGameObejct.GetComponent<MeshFilter>();
            if (meshFilter == null)
            {
                meshGameObejct.AddComponent<MeshFilter>().mesh = mesh;
            }
            else
            {
                meshFilter.mesh = mesh;
            }
            mesh.Clear();

            List<Vector3> vertList = new List<Vector3>();
            Dictionary<long, int> middlePointIndexCache = new Dictionary<long, int>();

            // create 8 vertices of a cube
            // top
            vertList.Add(new Vector3(-1f, -1f, -1f) * radius);
            vertList.Add(new Vector3( 1f, -1f, -1f) * radius);
            vertList.Add(new Vector3( 1f, -1f,  1f) * radius);
            vertList.Add(new Vector3(-1f, -1f,  1f) * radius);

            //bottom
            vertList.Add(new Vector3(-1f, 1f, -1f) * radius);
            vertList.Add(new Vector3( 1f, 1f, -1f) * radius);
            vertList.Add(new Vector3( 1f, 1f,  1f) * radius);
            vertList.Add(new Vector3(-1f, 1f,  1f) * radius);


            // 7 - 6
            // |   |
            // 4 - 5

            // 3 - 2
            // |   |
            // 0 - 1


            // create 12 triangles of the cubesphere
            List<TriangleIndices> faces = new List<TriangleIndices>();

            // 5 faces around point 0

            //bottom
            faces.Add(new TriangleIndices(0, 1, 2));
            faces.Add(new TriangleIndices(0, 2, 3));

            //top
            faces.Add(new TriangleIndices(7, 6, 5));
            faces.Add(new TriangleIndices(7, 5, 4));

            //front
            faces.Add(new TriangleIndices(4, 5, 1));
            faces.Add(new TriangleIndices(4, 1, 0));

            //back
            faces.Add(new TriangleIndices(3, 7, 2));
            faces.Add(new TriangleIndices(2, 7, 6));



            // refine triangles
            for (int i = 0; i < recursionLevel; i++)
            {

            }

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
        }
    }
}
