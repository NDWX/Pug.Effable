using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class ActionContext<TActor> : IActionContext<TActor>
	{
		[DataMember(IsRequired = true)]
		public TActor Actor { get; set; }
		
		[DataMember(IsRequired = true)]
		public DateTime Timestamp { get; set; }
	}

	[DataContract]
	public class ActionContext : ActionContext<string>, IActionContext
	{
		
	}
}