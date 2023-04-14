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
			set;
		}

		[DataMember(IsRequired = true)]
		TEntityVersionUser RegistrationUser
		{
			get;
			set;
		}
	}
}
