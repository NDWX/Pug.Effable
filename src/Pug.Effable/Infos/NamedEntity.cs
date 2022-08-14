using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class NamedEntity<TName> : INamed<TName>
	{
		[DataMember(IsRequired = true)]
		public TName Name { get; set; }
	}
	
	[DataContract]
	public class NamedEntity : NamedEntity<string>
	{
	}

	[DataContract]
	public class IdentifiableNamedEntity : IdentifiableNamedEntity<string>
	{
		
	}
}