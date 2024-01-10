using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface ILastUpdateInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		DateTime LastUpdateTimestamp 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}

		[DataMember(IsRequired = true)]
		TEntityVersionUser LastUpdateUser 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
	}
	
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface ILastUpdateInfo : ILastUpdateInfo<string>
	{
	
	}
}
