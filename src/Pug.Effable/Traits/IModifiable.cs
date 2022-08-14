namespace Pug.Effable
{
	public interface IModifiable<TEntityVersionUser, TModificationInfo> where TModificationInfo : ILastModificationInfo<TEntityVersionUser>
	{
		TModificationInfo LastModificationInfo { get; set;  }
	}
}
