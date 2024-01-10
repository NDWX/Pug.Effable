namespace Pug.Effable
{
    public interface IReferencing
    {
        string Reference 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
    }
}
