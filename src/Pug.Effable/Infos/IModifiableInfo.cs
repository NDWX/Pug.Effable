using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface ILastModificationInfo<TEntityVersionUser> : IActionContext<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		TEntityVersionUser LastModificationUser
		{
			get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
		}

		[DataMember(IsRequired = true)]
		DateTime LastModificationTimestamp
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
