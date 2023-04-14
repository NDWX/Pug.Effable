using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface ILastModificationInfo<TEntityVersionUser> : ILastUpdateInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		TEntityVersionUser LastModificationUser
		{
			get;
			set;
		}

		[DataMember(IsRequired = true)]
		DateTime LastModificationTimestamp
		{
			get;
			set;
		}
	}
}
