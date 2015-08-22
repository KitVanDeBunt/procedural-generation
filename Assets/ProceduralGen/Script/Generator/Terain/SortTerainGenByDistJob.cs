using System;
using System.Collections.Generic;

public struct NewPart
{
    public int xPart;
    public int yPart;
    public float dist;

    public NewPart(int xPart, int yPart, float dist)
    {
        this.xPart = xPart;
        this.yPart = yPart;
        this.dist = dist;
    }
}

public class SortDist : IComparer<NewPart>
{
    int IComparer<NewPart>.Compare(NewPart a, NewPart b)
    {
        if (a.dist > b.dist)
            return 1;
        if (a.dist < b.dist)
            return -1;
        else
            return 0;
    }
}

public class SortTerainGenByDistJob :ThreadedJob
{
    private NewPart[] arrayToSort;

    public SortTerainGenByDistJob(NewPart[] arrayToSort)
    {
        this.arrayToSort = arrayToSort;
        StartJob();
    }

    protected override void JobFunction()
    {
        System.Array.Sort(arrayToSort, new SortDist());
        IsDone = true;
    }
}
