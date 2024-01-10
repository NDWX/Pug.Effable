using System.Runtime.Serialization;

namespace Pug.Effable
{
	public interface INamedEntity<TIdentifier, TName> : IEntityInfo<TIdentifier>, INamed<TName>
	{
		[DataMember(IsRequired = true)]
        new TName Name
		{
			get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
		}
	}

	public interface INamedEntity : INamedEntity<string, string>
	{
	}
}
