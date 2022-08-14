using System;
using System.Runtime.Serialization;

namespace Pug.Effable
{
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
