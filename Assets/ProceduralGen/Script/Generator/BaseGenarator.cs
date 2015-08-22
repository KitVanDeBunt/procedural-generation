using UnityEngine;
using System.Collections.Generic;

namespace Generator {
	public abstract class BaseGenarator : MonoBehaviour {
		
		public abstract void Generate ();
		protected LibNoiseJob noiseJob;
        protected ThreadedJobHandeler GeneratorDataJob;

        [SerializeField]
        private float multyplyNoiseScale = 1f;
        [SerializeField]
        private float multyplyNoiseHeight = 1700f;
	
		protected void InitData (int startX,int startY,int mapX,int mapY,int xStepSize,int yStepSize)
		{
            LibNoise.ModuleBase noiseModual = Generator.LibnoiseModualGen.PrettyWorldGenerator();
			// Generator.LibnoiseModualGen.GetRTSGenerator(500)

            // start threaded job
            noiseJob = new LibNoiseJob(startX, startY, xStepSize, yStepSize, mapX, mapY, multyplyNoiseScale, multyplyNoiseHeight, noiseModual);
            GeneratorDataJob = new ThreadedJobHandeler();
            GeneratorDataJob.Init(noiseJob);
		}
	}
}
