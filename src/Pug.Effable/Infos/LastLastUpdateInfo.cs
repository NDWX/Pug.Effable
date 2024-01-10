using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class LastUpdateInfo : LastUpdateInfo<string>
	{
	}
	
	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class LastUpdateInfo<TEntityVersionUser> : ILastUpdateInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		public DateTime LastUpdateTimestamp 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}

		[DataMember(IsRequired = true)]
		public TEntityVersionUser LastUpdateUser 
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