using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class ActionContext<TUser> : IActionContext<TUser>
	{
		[DataMember(IsRequired = true)]
		public TUser User { get; set; }
		
		[DataMember(IsRequired = true)]
		public DateTime Timestamp { get; set; }
	}
}