using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if NET6_0_OR_GREATER
	#nullable disable
#endif

namespace GoodbyeCaveira.Lib.Data
{
	public class Log
	{
		protected Nullable<DateTime> time;
		public Nullable<DateTime> Time { get { return time; } set { time = value; } }
		protected string type;
		public string Type { get { return type; } set { type = value; } }

		protected string text;
		public string Text {
			get { return text; }
			set
			{
				text = value == null ? "" : value;
			}
		}

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
		public Log(Nullable<DateTime> time, string type, string message)
		{
			this.time = time;
			this.type = type;
			text = message == null ? "" : message;
		}
	}
}
