using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class DescribedEntityAttributeInfo<TKey, TValue, TDescription /*, TEntityVersionUser*/> : EntityAttributeInfo<TKey, TValue /*, TEntityVersionUser*/>, IDescribedEntityAttributeInfo<TKey, TValue, TDescription /*, TEntityVersionUser*/>
	{
		public DescribedEntityAttributeInfo()
		{
			
		}
		
		public DescribedEntityAttributeInfo(TKey name, TValue value, TDescription description)
			: base(name, value)
		{
			Description = description;
		}

		[DataMember(IsRequired = true)]
		public TDescription Description 
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
