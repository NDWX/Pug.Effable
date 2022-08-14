using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class RegistrationInfo<TEntityVersionUser> : IRegistrationInfo<TEntityVersionUser>
	{
		[DataMember(IsRequired = true)]
		public DateTime RegistrationTimestamp { get; set; }
		
		[DataMember(IsRequired = true)]
		public TEntityVersionUser RegistrationUser { get; set; }
	}

	[DataContract]
	public class RegistrationInfo : RegistrationInfo<string>
	{
		
	}
}