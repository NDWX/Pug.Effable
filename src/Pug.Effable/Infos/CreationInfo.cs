using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class CreationInfo : CreationInfo<string>
	{
		
	}

	[DataContract]
	public class CreationInfo<TEntityVersionInfo> : ICreationInfo<TEntityVersionInfo>
	{
		[DataMember(IsRequired = true)]
		public TEntityVersionInfo CreateUser { get; set; }
		
		[DataMember(IsRequired = true)]
		public DateTime CreateTimestamp { get; set; }
	}
}