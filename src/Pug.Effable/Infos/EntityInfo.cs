using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public abstract class EntityInfo<TIdentifier/*, TEntityVersionUser*/> : IEntityInfo<TIdentifier/*, TEntityVersionUser*/>
	{
		protected EntityInfo() { }
		
		protected EntityInfo(TIdentifier identifier)
		{
			this.Identifier = identifier;
		}

		[DataMember(IsRequired = true)]
		public TIdentifier Identifier 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
	}
}
