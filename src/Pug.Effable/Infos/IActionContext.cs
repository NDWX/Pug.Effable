using System;

namespace Pug.Effable
{
	public interface IActionContext<TUser>
	{
		TUser Actor { get; set; }
		
		DateTime Timestamp { get; set; }
	}

	public interface IActionContext : IActionContext<string>
	{
	}
}