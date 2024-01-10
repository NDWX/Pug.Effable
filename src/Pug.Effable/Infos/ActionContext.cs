using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class ActionContext<TActor> : IActionContext<TActor>
	{
		[DataMember(IsRequired = true)]
		public TActor Actor 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
		
		[DataMember(IsRequired = true)]
		public DateTime Timestamp 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
	}

	public class ActionContext : ActionContext<IReference>, IActionContext
	{
		
	}
}