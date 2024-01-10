namespace Pug.Effable
{
    public interface IDescribed<T>
    {
        T Description 
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
