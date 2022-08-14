namespace Pug.Effable
{
	public interface IUpdateInfo : ILastUpdateInfo<string>
	{
		
	}

	public interface IUpdateInfo<TEntityVersionUser> : ILastUpdateInfo<TEntityVersionUser>
	{
	}
}