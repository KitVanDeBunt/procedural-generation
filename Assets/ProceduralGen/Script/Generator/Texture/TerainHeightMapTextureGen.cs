
// used code from : http://libnoise.sourceforge.net/tutorials/tutorial8.html

// can generate height or normalmap for a terain

//#define TEST_TEXTURE

using UnityEngine;
using System.Collections;
using System.IO;

using LibNoise;
using LibNoise.Generator;
using LibNoise.Operator;

namespace Generator {
	public class TerainHeightMapTextureGen : BaseGenarator
    {

#if TEST_TEXTURE
		[SerializeField]
		private Texture2D textureGenerated; // texture created for testing
#endif
        
        public int textureSizeX = 512; // for heightmaps, this would be 2^n +1
		public int textureSizeY = 512; // for heightmaps, this would be 2^n +1

		public float StepsX = 40f;
		public float StepsY = 40f;

		private float StepPower = 1.25f;
		private float StepSizeX = 0;
		private float StepSizeY = 0;

		
		[SerializeField]
		private Gradient gradiant;
		
		[SerializeField]
		private string TextureName = "Generated_Sphere_Texture";

		public float BG = 1f;
		public float SM = 0f;

		public bool generateNormalMap = false;
		
		public override void Generate() 
		{
			// ------------------------------------------------------------------------------------------
			StepSizeX = textureSizeX * StepPower;
			StepSizeY = textureSizeY * StepPower;

			float stepSizeXScaleX = (StepSizeX*(float)StepsX)/textureSizeX;
			float stepSizeXScaleY = (StepSizeY*(float)StepsY)/textureSizeY;

			// - Compiled Terrain -
			
			ModuleBase myModule = Generator.LibnoiseModualGen.GetRTSGenerator(1);
			
			///////////////
			Texture2D newTexture = new Texture2D(textureSizeX, textureSizeY);
			Color[] pixels = new Color[textureSizeX * textureSizeY];

			int bigger = 0;
			int smallar = 0;
			for (int x = 0; x < textureSizeX; x++)
			{
				for (int y = 0; y < textureSizeY; y++)
				{
					//float sample = (float)myModule.GetValue(((float)x/terainStepsX),((float)y/terainStepsY),0);
					//pixels[x + y * mapSizeX] = gradiant.Evaluate(sample);

					if(!generateNormalMap){ // height map
						float sample = (float)myModule.GetValue(( ((float)x/textureSizeX)*stepSizeXScaleX),( ((float)y/textureSizeY)*stepSizeXScaleY) ,0); //////StepSizeX
						if(sample > BG){
							bigger++;
						}else if(sample < SM){
							smallar++;
						}
						pixels[x + (y * textureSizeX)] = gradiant.Evaluate(sample);
					}else{// normalmap
						float[] s = new float[9];

						int tx = x;
						int ty = y;

						// - bottom 
						// left
						tx = x - 1;
						ty = y - 1;
						s[0] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0);
						// center
						tx = x;
						s[1] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0); 
						// right
						tx = x + 1;
						s[2] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0); 

						// - center
						// left
						tx = x - 1;
						ty = y;
						s[3] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0);
						// center
						tx = x;
						s[4] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0); 
						// right
						tx = x + 1;
						s[5] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0); 

						// - top
						// left
						tx = x - 1;
						ty = y + 1;
						s[6] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0);
						// center
						tx = x;
						s[7] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0); 
						// right
						tx = x + 1;
						s[8] = (float)myModule.GetValue(( ((float)tx/textureSizeX)*stepSizeXScaleX),( ((float)ty/textureSizeY)*stepSizeXScaleY) ,0); 


						Vector3 normal;
						normal.x = -(s[2]-s[0]+2*(s[5]-s[3])+s[8]-s[6]);
						normal.y = -(s[6]-s[0]+2*(s[7]-s[1])+s[8]-s[2]);
						normal.z = 1.0f;
						// TODO: normalize?
						pixels[x + (y * textureSizeX)].r = normal.x+0.5f;
						pixels[x + (y * textureSizeX)].g = normal.y+0.5f;
						pixels[x + (y * textureSizeX)].b = normal.z+0.5f;
					}
				}
			}


			Debug.Log ("bigger:"+bigger+" smaller:"+smallar);
			newTexture.SetPixels(pixels);
			newTexture.wrapMode = TextureWrapMode.Clamp;
			newTexture.Apply();
			///////////
			
			//Noise2D heightMap = new Noise2D( mapSizeX, mapSizeY, myModule );
			//heightMap.GeneratePlanar (0, mapSizeX, 0, mapSizeY, false);
			//texture = heightMap.GetTexture(gradiant);
#if TEST_TEXTURE
			textureGenerated = newTexture;
#endif		
            ///

#if !UNITY_WEBPLAYER
			byte[] bytes = newTexture.EncodeToPNG();

			if(!generateNormalMap){
                File.WriteAllBytes(Application.dataPath + "/ProceduralGen/TextureGenOutput/terain/" + TextureName + ".png", bytes);
			}else{
                File.WriteAllBytes(Application.dataPath + "/ProceduralGen/TextureGenOutput/terain/" + TextureName + "_normalmap" + ".png", bytes);
			}
#endif
            ///
			
			//sphereRenderer.material.mainTexture = texture;
		}
	}
}
