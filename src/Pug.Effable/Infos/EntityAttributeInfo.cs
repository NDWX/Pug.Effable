using System.Runtime.Serialization;

namespace Pug.Effable
{
	[DataContract]
	public class EntityAttributeInfo<TKey, TValue> : IEntityAttributeInfo<TKey, TValue>
	{
		public EntityAttributeInfo()
		{
			
		}

		public EntityAttributeInfo(TKey name, TValue value)
		{
			this.Name = name;
			this.Value = value;
		}

		[DataMember(IsRequired = true)]
		public TKey Name 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}

		[DataMember(IsRequired = true)]
		public TValue Value 
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
