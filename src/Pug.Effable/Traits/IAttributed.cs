using System.Collections.Generic;

namespace Pug.Effable
{
	public interface IAttributed<K, TAttributeInfo, V/*, TEntityVersionUser*/> where TAttributeInfo : IEntityAttributeInfo<K, V/*, TEntityVersionUser*/>
	{
		V this[K key]
		{
			get; 
		}

		IDictionary<K, TAttributeInfo> Attributes
		{
			get;
			set;
		}
	}
}
