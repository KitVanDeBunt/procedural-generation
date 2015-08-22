//------------------------------//
//  Tutorial_8.cs              //
//  Written by Alucard Jay      //
//  2014/6/29                   //
//------------------------------//

//  http://libnoise.sourceforge.net/tutorials/tutorial8.html


using UnityEngine;
using System.Collections;
using System.IO;

using LibNoise;
using LibNoise.Generator;
using LibNoise.Operator;


public class Tutorial_8 : MonoBehaviour 
{
	public int mapSizeX = 512; // for heightmaps, this would be 2^n +1
	public int mapSizeY = 256; // for heightmaps, this would be 2^n +1
	
	public float south = -90.0f;
	public float north = 90.0f;
	
	public float west = -180.0f;
	public float east = 180.0f;
	
	
	public Renderer sphereRenderer; // renderer texture set for testing

	[SerializeField]
	private Texture2D texture; // texture created for testing
	
	
	[SerializeField]
	private string TextureName = "Generated_Sphere_Texture";
	
	//  Persistant Functions
	//    ----------------------------------------------------------------------------
	
	
	void Start() 
	{
		Generate();
	}
	
	
	void Update() 
	{
		if ( Input.GetMouseButtonDown(1) )
			Generate();
	}
	
	
	//  Other Functions
	//    ----------------------------------------------------------------------------
	
	
	void Generate() 
	{
		//Perlin mySphere = new Perlin();
		
		
		// ------------------------------------------------------------------------------------------
		
		// - Compiled Terrain -
		
		ModuleBase myModule;
		
		myModule = Generator.LibnoiseModualGen.GetRTSGenerator(1);
		
		
		// ------------------------------------------------------------------------------------------
		
		// - Generate -
		
		// this part generates the heightmap to a texture, 
		// and sets the renderer material texture of a sphere to the generated texture
		
		
		Noise2D heightMap;
		
		heightMap = new Noise2D( mapSizeX, mapSizeY, myModule );
		
		heightMap.GenerateSpherical( south, north, west, east );
		
		
		texture = heightMap.GetTexture(GradientPresets.Grayscale);

        ///

#if !UNITY_WEBPLAYER
		byte[] bytes = texture.EncodeToPNG();
		File.WriteAllBytes(Application.dataPath + "/Terain/TextureGenOutput/sphere/"+TextureName+".png", bytes);
#endif
        ///
		
		sphereRenderer.material.mainTexture = texture;
	}
}
