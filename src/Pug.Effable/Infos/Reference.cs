namespace Pug.Effable;

public class Reference : IReference
{
	public string Type 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
		
	public string Identifier
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
}