using System;

namespace FooCore
{
    public class TreeKeyExistsException : Exception
	{
		public TreeKeyExistsException (object key) : base ("Duplicate key: " + key.ToString())
		{
			
		}
	}

}

