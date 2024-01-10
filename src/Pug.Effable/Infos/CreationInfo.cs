using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class CreationInfo : CreationInfo<string>
	{
		
	}

	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class CreationInfo<TEntityVersionInfo> : ICreationInfo<TEntityVersionInfo>
	{
		[DataMember(IsRequired = true)]
		public TEntityVersionInfo CreateUser 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
		
		[DataMember(IsRequired = true)]
		public DateTime CreateTimestamp 
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