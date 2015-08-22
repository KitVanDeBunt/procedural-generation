// NOTE: outdated
/*

using UnityEngine;
/// <summary>
/// Using LibNoise
/// </summary>
namespace GenFunction.Field
{
	public class LibNoiseFunction : BaseGenFunction
	{

		private static LibNoise.ModuleBase generator;
		
		public override bool ThreadedFunction{
			get{ 
				return false;
			}
		}

		public override float GetHeight(float x, float y, int mapX, int mapY){

			if (generator == null) {
				if(true){
					LibNoise.Generator.Voronoi generatorvoroni = new LibNoise.Generator.Voronoi();
					generatorvoroni.UseDistance = true;
					generatorvoroni.Displacement = 0;
					//Debug.Log("D:"+ generatorvoroni.Displacement);
					//Debug.Log("F:"+ generatorvoroni.Frequency);
					//Debug.Log ("UseDistance:"+generatorvoroni.UseDistance);
					generator = generatorvoroni;
				}else if (false){
					LibNoise.Generator.RidgedMultifractal generatorvoroni = new LibNoise.Generator.RidgedMultifractal();
					//generatorvoroni. = true;
					//Debug.Log ("UseDistance:"+generatorvoroni.UseDistance);
					generator = generatorvoroni;

				}else{
					LibNoise.Generator.Billow generatorvoroni = new LibNoise.Generator.Billow();
					//generatorvoroni. = true;
					//Debug.Log ("UseDistance:"+generatorvoroni.UseDistance);
					generator = generatorvoroni;
					
				}

			}

			x = (float)x/(101f*perlinScale);
			y = (float)y/(101f*perlinScale);
			float tempHeight = (float)generator.GetValue((double)x,(double)y,z);
			//tempHeight = tempHeight;
			if(useGen){
				return (tempHeight*mult);
			}else{
				return 0;
			}

		}
		
		public override float GetHeightScale(float x, float y, int mapX, int mapY){
			x = (float)x/((float)mapX*perlinScale);
			y = (float)y/((float)mapY*perlinScale);
			float tempHeight = (float)(generator.GetValue((double)x,(double)y,z));
			if(useGen){
				return (tempHeight);
			}else{
				return 0;
			}
		}
	}
}
*/

