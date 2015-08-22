
// outdated

/*
using UnityEngine;
using System.Collections.Generic;
using System.IO;

using GenFunction.Field;

namespace Generator {
	public class TextureGen : BaseGenarator {
		
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

		[SerializeField]
		private Gradient heightGradiant;

		public override void Generate () {

			float color;
			tempTexture = new Texture2D(texWidth, texHeight, TextureFormat.RGBA32, false);
			for (x = 0; x < texWidth; x++) {
				for (y = 0; y < texWidth; y++) {
					color = GeneratorDataJob.GetHeight(x,y,mapX,mapY);
					tempTexture.SetPixel(x,y,heightGradiant.Evaluate(color));
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