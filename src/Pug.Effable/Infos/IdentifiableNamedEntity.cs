using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class IdentifiableNamedEntity<T> : IdentifiableNamedEntity<T, T>
	{
		
	}

	[DataContract]
	public class IdentifiableNamedEntity<TIdentifier, TName> : IIdentifiableNamedEntity<TIdentifier, TName>
	{
		[DataMember(IsRequired = true)]
		public TIdentifier Identifier { get; set; }
		
		[DataMember(IsRequired = true)]
		public TName Name { get; set; }
	}
}