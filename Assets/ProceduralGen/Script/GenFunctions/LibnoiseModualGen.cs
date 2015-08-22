using LibNoise.Generator;
using LibNoise.Operator;

namespace Generator
{
	public static class LibnoiseModualGen
	{

		public static LibNoise.ModuleBase GetRTSGenerator (double multiply)
		{
			// part 3
			Perlin perlinGen = new Perlin ();
			perlinGen.OctaveCount = 1;
			perlinGen.Frequency = 0.5f;
			
			/*Const constGen4 = new Const ();
			constGen4.Value = 2f;
			Add perlinMultGenerator = new Add (constGen4,perlinGen);
			*/
			//Multiply perlinMultGenerator2 = new Multiply (constGen3,perlinGen);
			//Clamp perlinMultGenerator2Clamp = new Clamp (-1.0f,1.0f,perlinMultGenerator2);
			
			//Multiply pTest = new Multiply (constGen50,perlinGen);
			
			// part 3 perlin big
			Perlin perlinGen2 = new Perlin ();
			perlinGen2.OctaveCount = 10;
			perlinGen2.Frequency = 0.1f;
			Add perlinGenMult = new Add(new Const(0.5), new Multiply(perlinGen2,new Const(0.5) ));
			//Clamp perlinZeroToOne =  new Clamp(0.0,1.0,perlinGenMult); 
			//part 4 perlin small
			Perlin perlinGen3 = new Perlin ();
			perlinGen3.OctaveCount = 2;
			perlinGen3.Frequency = 0.6f;
			Add perlinSmall =  new Add(new Const(0.5),new Multiply(new Const(0.5),perlinGen3));
			
			
			// part 1 voronoi
			Voronoi voronoiGenerator = new Voronoi (0.3,0.0,0,true);
			Add voronoiZeroToOne =  new Add(new Const(0.5),new Multiply(new Const(0.5),voronoiGenerator));
			
			LibNoise.ModuleBase combinedNoise = new Add(new Multiply(perlinSmall		,new Const(0.15))
			                                            ,new Multiply(voronoiZeroToOne	,new Const(0.85))
			                                            );
			// p4 voroni + p1 perlin small
			
			//LibNoise.ModuleBase noiseFinal = new Multiply(combinedNoise,new Const(1.0));
			//LibNoise.ModuleBase noiseFinal =          new Multiply(combinedNoise,new Power(new Multiply(perlinGenMult,new Const(1.5)),constGen3));
			LibNoise.ModuleBase noiseFinal = new Multiply( combinedNoise , new Power(perlinGenMult,new Const (3)) );
			
			// mult part 1 and part 2
			//Multiply rtsGenerator = new Multiply (perlinGen2,constGen50);
			
			return new Multiply (noiseFinal,new Const (multiply));
			
			//Blend rtsGenerator2 = new Blend (rtsGenerator,rtsGenerator3,perlinMultGenerator2Clamp);
		}

		public static LibNoise.ModuleBase PrettyWorldGenerator ()
		{
			// mult perlin big
			Perlin perlinGenM = new Perlin (0.016,2.0,0.5,3,0,LibNoise.QualityMode.Medium);
			Add perlinGenMult = new Add(new Const(0.5), new Multiply(perlinGenM,new Const(0.5) ));

			// mult voronoi
			Voronoi voronoiGeneratorM = new Voronoi (0.032,0.0,0,true);
			Add voronoiZeroToOneM =  new Add(new Const(0.5),new Multiply(new Const(0.5),voronoiGeneratorM));

			Add mulTotal = new Add (new Multiply(perlinGenMult,new Const(0.5)),
			                        new Multiply(voronoiZeroToOneM,new Const(0.5))
			                        );

			//part 1 perlin
			Perlin perlinGen = new Perlin (0.3,2.0,0.5,2,0,LibNoise.QualityMode.Medium);
			Add perlinZeroToOne =  new Add(new Const(0.5),new Multiply(new Const(0.5),perlinGen));
			//part 2 perlin
			Perlin perlinGen2 = new Perlin (0.08,2.0,0.5,5,0,LibNoise.QualityMode.Medium);
			Add perlinZeroToOne2 =  new Add(new Const(0.5),new Multiply(new Const(0.5),perlinGen2));

			
			
			// part 1 voronoi
			Voronoi voronoiGenerator = new Voronoi (0.06,0.0,0,true);
			Add voronoiZeroToOne =  new Add(new Const(0.5),new Multiply(new Const(0.5),voronoiGenerator));
			
			// part 2 voronoi
			Voronoi voronoiGenerator2 = new Voronoi (0.09,0.0,0,true);
			Add voronoiZeroToOne2 =  new Add(new Const(0.5),new Multiply(new Const(0.5),voronoiGenerator2));
			// part 2 voronoi
			Voronoi voronoiGenerator3 = new Voronoi (0.2,0.0,0,true);
			Add voronoiZeroToOne3 =  new Add(new Const(0.5),new Multiply(new Const(0.5),voronoiGenerator3));
			// part 2 voronoi
			Voronoi voronoiGenerator4 = new Voronoi (0.4,0.0,0,true);
			Add voronoiZeroToOne4 =  new Add(new Const(0.5),new Multiply(new Const(0.5),voronoiGenerator4));
			
			LibNoise.ModuleBase combinedNoise = new Add(new Multiply(perlinZeroToOne		,new Const(0.03))
			                                            ,new Multiply(voronoiZeroToOne	,new Const(0.70))
			                                            );
			combinedNoise = new Add( combinedNoise , new Multiply(voronoiZeroToOne2,new Const(0.06)) );
			combinedNoise = new Add( combinedNoise , new Multiply(voronoiZeroToOne3,new Const(0.04)) );
			combinedNoise = new Add( combinedNoise , new Multiply(voronoiZeroToOne4,new Const(0.02)) );
			combinedNoise = new Add( combinedNoise , new Multiply(perlinZeroToOne2,new Const(0.15)) );


			LibNoise.ModuleBase noiseFinal = new Multiply( combinedNoise , new Power(mulTotal,new Const (2.8)) );
			
			return noiseFinal;
		}
	}
}

