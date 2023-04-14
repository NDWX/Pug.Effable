using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class RegistrationInfo<TEntityVersionUser> : IRegistrationInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		public DateTime RegistrationTimestamp { get; set; }
		
		[DataMember(IsRequired = true)]
		public TEntityVersionUser RegistrationUser { get; set; }
	}

	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class RegistrationInfo : RegistrationInfo<string>
	{
		
	}
}