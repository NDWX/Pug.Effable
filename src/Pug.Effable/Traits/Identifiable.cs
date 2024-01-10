namespace Pug.Effable
{
	public interface Identifiable<I>
	{
		I Identifier
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
