using System;
using LibNoise;

// used form normal calcolation : http://stackoverflow.com/questions/5281261/generating-a-normal-map-from-a-height-map

public class LibNoiseJob : ThreadedJob
{
	#region Fields
	
	[System.NonSerialized]
    public float[] OutData; // height job data
    public float[] heightData; // height data for generation off normals
    public UnityEngine.Vector3[] OutNormals; // normals job data
	
	private LibNoise.ModuleBase generator;

	private double _displacement = 1.0;
	private double _frequency = 1.0;
	private int _seed = 0;
	private bool _distance = true;

	public int posInArray;
	int x = 0;
    int y = 0;
    float[] s = new float[9];

	int mapY;
	int mapX;
	int xStepSize;
	int yStepSize;
	int startX;
	int startY;
	float perlinScale;
	float mult;

	float z = 0f;


    private bool genNormals = true;
	#endregion

	#region Properties
	public double Displacement
	{
		get { return _displacement; }
		set { _displacement = value; }
	}
	
	/// <summary>
	/// Gets or sets the frequency of the seed points.
	/// </summary>
	public double Frequency
	{
		get { return _frequency; }
		set { _frequency = value; }
	}
	
	/// <summary>
	/// Gets or sets the seed value used by the Voronoi cells.
	/// </summary>
	public int Seed
	{
		get { return _seed; }
		set { _seed = value; }
	}
	
	/// <summary>
	/// Gets or sets a value whether the distance from the nearest seed point is applied to the output value.
	/// </summary>
	public bool UseDistance
	{
		get { return _distance; }
		set { _distance = value; }
	}
	
	public int StartY {
		get {
			return startY;
		}
	}
	
	public int StartX {
		get {
			return startX;
		}
	}

	#endregion

	/// <summary>
	/// Don't touch any data in the job class after initialization until IsDone is true.	/// </summary>
	/// <param name="_startX"> x start position.</param>
	/// <param name="_startY"> y start position.</param>
	/// <param name="_xStepSize"> step width.</param>
	/// <param name="_yStepSize"> step height.</param>
	/// <param name="_mapX"> map width.</param>
	/// <param name="_mapY"> map height.</param>
	/// <param name="_perlinScale">_noise scale.</param>
	/// <param name="_mult">multiplies output height.</param>
	/// <param name="libNoiseModual">lib Noise Modual</param>
    public LibNoiseJob(int _startX, int _startY, int _xStepSize, int _yStepSize, int _mapX, int _mapY, float _perlinScale, float _mult, LibNoise.ModuleBase libNoiseModual) : base()
    {
        OutData = new float[(_mapX * _mapY)];
        heightData = new float[((_mapX+2) * (_mapY+2))];
        OutNormals = new UnityEngine.Vector3[(_mapX * _mapY)];
		this.mapX = _mapX;
		this.mapY = _mapY;
		this.xStepSize = _xStepSize;
		this.yStepSize = _yStepSize;
		this.startX = _startX;
		this.startY = _startY;
		this.perlinScale = _perlinScale;
		this.mult = _mult;
		
		generator = libNoiseModual;
        StartJob();
	}

	// Thread. DON'T use the Unity API here
	protected override void JobFunction ()
	{
        posInArray = 0;
        if (!genNormals)
        {
            for (y = 0; y < mapY; y += 1)
            {
                for (x = 0; x < mapX; x += 1)
                {

                    int xPos = (x * xStepSize) + startX;
                    int yPos = (y * yStepSize) + startY;
                    OutData[posInArray] += (float)GetHeight(xPos, yPos, mapX, mapY);

                    posInArray++;
                }
            }
        }
        else
        {
            // generate height map data
            for (y = -1; y < (mapY+1); y += 1)
            {
                for (x = -1; x < (mapX+1); x += 1)
                {
                    int xPos = (x * xStepSize) + startX;
                    int yPos = (y * yStepSize) + startY;
                    if (x > -1 && y > -1 && x < mapX && y < mapY)
                    {
                        OutData[GeneratorUtil.XYToNum(x,y,mapX)] += (float)GetHeight(xPos, yPos, mapX, mapY);
                        posInArray++;
                    }
                    //UnityEngine.Debug.Log(GeneratorUtil.XYToNum((x + 1), (y + 1), (mapX + 2)));
                    heightData[GeneratorUtil.XYToNum((x+1), (y+1), (mapX+2))] += (float)GetHeight(xPos, yPos, mapX, mapY);
                }
            }
            // generate normal map data
            for (y = 0; y < mapY; y += 1)
            {
                for (x = 0; x < mapX; x += 1)
                {
                    int tx = x;
                    int ty = y;

                    // - bottom 
                    // left
                    tx = x - 1;
                    ty = y - 1;
                    //UnityEngine.Debug.Log("."+GeneratorUtil.XYToNum((x + 1), (y + 1), (mapX + 2)));
                    s[0] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];
                    // center
                    tx = x;
                    s[1] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];
                    // right
                    tx = x + 1;
                    s[2] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];

                    // - center
                    // left
                    tx = x - 1;
                    ty = y;
                    s[3] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];
                    // center
                    tx = x;
                    s[4] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];
                    // right
                    tx = x + 1;
                    s[5] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];

                    // - top
                    // left
                    tx = x - 1;
                    ty = y + 1;
                    s[6] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];
                    // center
                    tx = x;
                    s[7] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];
                    // right
                    tx = x + 1;
                    s[8] = heightData[GeneratorUtil.XYToNum((tx + 1), (ty + 1), (mapX + 2))];


                    UnityEngine.Vector3 normal;
                    normal.x = -(s[2] - s[0] + 2 * (s[5] - s[3]) + s[8] - s[6]);
                    normal.y = -(s[6] - s[0] + 2 * (s[7] - s[1]) + s[8] - s[2]);
                    normal.z = 250.0f;
                    normal.Normalize(); //normalize
                    OutNormals[x + (y * mapX)] = new UnityEngine.Vector3();
                    OutNormals[x + (y * mapX)].x = normal.x;
                    OutNormals[x + (y * mapX)].y = normal.z;
                    OutNormals[x + (y * mapX)].z = normal.y;
                }
            }
            //
        }
		IsDone = true;
	}
	
	protected virtual double GetHeight(float x, float y, int mapX, int mapY){
		x = (float)x/(101f*perlinScale);
		y = (float)y/(101f*perlinScale);
		return generator.GetValue((double)x,(double)y,z)* mult;
	}
}