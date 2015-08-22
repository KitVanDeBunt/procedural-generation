
public abstract class ThreadedJob
{
    private bool m_IsDone = false;
    private object m_Handle = new object();
    private System.Threading.Thread m_Thread = null;

    public bool IsDone
    {
        get
        {
            bool tmp;
            lock (m_Handle)
            {
                tmp = m_IsDone;
            }
            return tmp;
        }
        protected set
        {
            lock (m_Handle)
            {
                m_IsDone = value;
            }
        }
    }

    protected void StartJob()
    {
        m_Thread = new System.Threading.Thread(JobFunction);
        m_Thread.Start();
        //GetHeights();
    }


    public virtual void Abort()
    {
        m_Thread.Abort();
    }

    protected abstract void JobFunction();
}
