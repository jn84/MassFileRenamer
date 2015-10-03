using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MassFileRenamer_Jenny
{
	class DirectoryLoadException : Exception
	{
		public override string Message { get; }

		public DirectoryLoadException(string message) : base(message)
		{
			
		}
	}
}
