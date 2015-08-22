
// outdated

/*
using UnityEngine;
using System.Collections.Generic;
using System.IO;

using GenFunction.Field;

namespace Generator
{
    public class TextureGen2 : BaseGenarator
    {

        [SerializeField]
        private int startX;
        [SerializeField]
        private int startY;

        //counters
        private int x;
        private int y;
        private int i;

        [SerializeField]
        private int mapX = 100;
        [SerializeField]
        private int mapY = 100;

        private float genDataTemp;

        private Texture2D tempTexture;

        [SerializeField]
        private string TextureName = "Generated_Texture";

        private int texWidth = 1024;
        private int texHeight = 1024;


        private int mapWidth = 512;
        private int mapHeight = 512;

        private int mapCount = 4;

        [SerializeField]
        private Gradient[] heightGradiant;

        public override void Generate()
        {

            InitData(0, 0, mapX, mapY, texWidth, texHeight);

            float color;
            tempTexture = new Texture2D(texWidth, texHeight, TextureFormat.RGBA32, false);
            for (int j = 0; j < mapCount; j++)
            {
                int startX = (((j) % 2) * 512);
                int startY = ((j / 2) * 512);

                Debug.Log("startX: " + startX + " startY: " + startY);

                for (x = 0; x < mapWidth; x++)
                {
                    for (y = 0; y < mapHeight; y++)
                    {
                        color = GeneratorDataJob.GetHeight(x, y, mapX, mapY);
                        tempTexture.SetPixel((startX + x), (startY + y), heightGradiant[j].Evaluate(color));
                    }
                }
            }

            tempTexture.Apply();

            

#if !UNITY_WEBPLAYER
            byte[] bytes = tempTexture.EncodeToPNG();
            File.WriteAllBytes(Application.dataPath + "/ProceduralGen/TextureGenOutput/" + TextureName + ".png", bytes);
#endif
            if (Application.isPlaying)
            {
                Destroy(tempTexture);
            }
            else
            {
                DestroyImmediate(tempTexture);
            }
        }

    }
}
*/