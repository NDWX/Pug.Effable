using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface ILastUpdateInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		DateTime LastUpdateTimestamp { get; set; }

		[DataMember(IsRequired = true)]
		TEntityVersionUser LastUpdateUser { get; set; }
	}
	
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface ILastUpdateInfo : ILastUpdateInfo<string>
	{
	
	}
}
