using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class LastModificationInfo : LastModificationInfo<string>
	{
		
	}

	[DataContract]
	public class LastModificationInfo<TEntityVersionUser> : ILastModificationInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		public DateTime LastUpdateTimestamp { get; set; }
		
		[DataMember(IsRequired = true)]
		public TEntityVersionUser LastUpdateUser { get; set; }
		
		[DataMember(IsRequired = true)]
		public TEntityVersionUser LastModificationUser { get; set; }
		
		[DataMember(IsRequired = true)]
		public DateTime LastModificationTimestamp { get; set; }
	}
}