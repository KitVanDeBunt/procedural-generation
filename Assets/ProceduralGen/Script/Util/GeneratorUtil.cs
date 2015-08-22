
static public class GeneratorUtil
{
    static public int XYToNum(int x, int y, int width)
    {
        return (x + y * width);
    }

    static public float XYToNum(float xn, float yn, int width)
    {
        return (xn + (yn * (float)width));
    }
}