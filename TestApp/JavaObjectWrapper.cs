using System;
namespace TestApp
{
public class JavaObjectWrapper<T> : Java.Lang.Object
	{
		public JavaObjectWrapper(T data)
		{
			Obj = data;
		}
		public T Obj { get; set; }
	}
}

