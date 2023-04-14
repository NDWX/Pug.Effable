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
			set;
		}

		[DataMember(IsRequired = true)]
		DateTime CreateTimestamp
		{
			get;
			set;
		}
	}
}
