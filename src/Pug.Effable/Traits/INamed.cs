namespace Pug.Effable
{
	public interface INamed<N>
	{
		N Name
		{
			get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
		}
	}

	public interface INamed : INamed<string>
	{
	}
}
