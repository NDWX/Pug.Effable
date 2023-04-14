using System;

namespace Pug.Effable
{
	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface IUpdateInfo : ILastUpdateInfo<string>
	{
		
	}

	[Obsolete("Use the more generic IActionContext interface instead.")]
	public interface IUpdateInfo<TEntityVersionUser> : ILastUpdateInfo<TEntityVersionUser>
	{
	}
}