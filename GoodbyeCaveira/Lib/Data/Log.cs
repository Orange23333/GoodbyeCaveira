using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeCaveira.Lib.Data
{
	public class Log
	{
		protected DateTime? time;
		protected string? type;

		protected string text;
		public string Text { get { return text; } set { text = value; } }

		public override string ToString()
		{
			if (time == null)
			{
				if (type == null)
				{
					return text;
				}
				return $"[{type}] {text}";
			}
			else
			{
				if (type == null)
				{
					return $"[{time.ToString()}] {text}";
				}
				return $"[{time.ToString()} {type}] {text}";
			}
		}

		public Log(string text) : this(null, null, text) {; }
		public Log(DateTime? time, string? type, string? message)
		{
			this.time = time;
			this.type = type;
			text = message == null ? "" : message;
		}
	}
}
