using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface IRegistrationInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		DateTime RegistrationTimestamp
		{
			get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
		}

		[DataMember(IsRequired = true)]
		TEntityVersionUser RegistrationUser
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
