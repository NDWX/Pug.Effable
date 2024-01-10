using System;

namespace Pug.Effable
{
	public interface IActionContext<TUser>
	{
		TUser User { get; set; }
		
		DateTime Timestamp { get; set; }
	}

	public interface IActionContext : IActionContext<string>
	{
	}
}