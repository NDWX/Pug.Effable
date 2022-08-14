using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	public interface ILastUpdateInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		DateTime LastUpdateTimestamp { get; set; }

		[DataMember(IsRequired = true)]
		TEntityVersionUser LastUpdateUser { get; set; }
	}
	
	public interface ILastUpdateInfo : ILastUpdateInfo<string>
	{
	
	}
}
