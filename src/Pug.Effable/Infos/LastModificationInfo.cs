using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[Obsolete("Use the more generic ActionContext class instead.")]
	[DataContract]
	public class LastModificationInfo : LastModificationInfo<string>
	{
		
	}

	[Obsolete("Use the more generic ActionContext class instead.")]
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