using System;

namespace Pug.Effable
{
	public interface IActionContext<TActor>
	{
		TActor Actor 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
		
		DateTime Timestamp 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
	}

	public interface IActionContext : IActionContext<IReference>
	{
	}

	public interface IUserActionContext : IActionContext<string>
	{
	}
}