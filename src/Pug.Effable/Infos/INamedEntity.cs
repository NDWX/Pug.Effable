using System.Runtime.Serialization;

namespace Pug.Effable
{
	public interface INamedEntity<TIdentifier, TName> : IEntityInfo<TIdentifier>, INamed<TName>
	{
		[DataMember(IsRequired = true)]
        new TName Name
        {
            get;
            set;
        }
	}

	public interface INamedEntity : INamedEntity<string, string>
	{
	}
}
