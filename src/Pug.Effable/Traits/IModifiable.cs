namespace Pug.Effable
{
	public interface IModifiable<TEntityVersionUser, TModificationInfo> where TModificationInfo : ILastModificationInfo<TEntityVersionUser>
	{
		TModificationInfo LastModificationInfo
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
