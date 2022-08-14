namespace Pug.Effable
{
	public interface IUpdatable<TEntityVersionUser, TUpdateInfo> where TUpdateInfo : ILastUpdateInfo<TEntityVersionUser>
	{
		TUpdateInfo LastUpdateInfo { get; set; }
	}
}
