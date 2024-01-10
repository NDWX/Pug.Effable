using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface ICreationInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		TEntityVersionUser CreateUser
		{
			get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
		}

		[DataMember(IsRequired = true)]
		DateTime CreateTimestamp
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
