using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class LastUpdateInfo : LastUpdateInfo<string>
	{
	}

	[DataContract]
	public class LastUpdateInfo<TEntityVersionUser> : ILastUpdateInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		public DateTime LastUpdateTimestamp { get; set; }

		[DataMember(IsRequired = true)]
		public TEntityVersionUser LastUpdateUser { get; set; }
	}
}