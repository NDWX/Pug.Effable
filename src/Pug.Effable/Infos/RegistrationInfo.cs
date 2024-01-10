using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class RegistrationInfo<TEntityVersionUser> : IRegistrationInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		public DateTime RegistrationTimestamp 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
		
		[DataMember(IsRequired = true)]
		public TEntityVersionUser RegistrationUser 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
	}

	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class RegistrationInfo : RegistrationInfo<string>
	{
		
	}
}