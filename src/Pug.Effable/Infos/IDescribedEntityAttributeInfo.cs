namespace Pug.Effable
{
	public interface IDescribedEntityAttributeInfo< TKey, TValue, TDescription /*, out TEntityVersionUser*/> : IEntityAttributeInfo<TKey, TValue/*, TEntityVersionUser*/>, IDescribed<TDescription>
	{
	}
}