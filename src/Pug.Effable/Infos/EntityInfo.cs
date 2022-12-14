using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public abstract class EntityInfo<TIdentifier/*, TEntityVersionUser*/> : IEntityInfo<TIdentifier/*, TEntityVersionUser*/>
	{
		protected EntityInfo(TIdentifier identifier)
		{
			this.Identifier = identifier;
		}

		[DataMember(IsRequired = true)]
		public TIdentifier Identifier { get; set; }
	}
}
