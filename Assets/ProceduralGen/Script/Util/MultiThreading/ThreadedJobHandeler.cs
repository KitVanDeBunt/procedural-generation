using UnityEngine;
using System.Collections.Generic;

public class ThreadedJobHandeler
{
	private ThreadedJob thisJob;
	private bool done = false;

    public bool JobDone     { get { return done;        }}

    public void Init(ThreadedJob job)
    {
        // Don't touch any data in the job class after initialization until IsDone is true.
        thisJob = job;
    }

    public void Tick()
    {
        if (thisJob != null)
        {
            if (thisJob.IsDone)
            {
                thisJob = null;
                done = true;
            }
        }
    }

}


