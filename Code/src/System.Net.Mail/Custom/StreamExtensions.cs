using System.IO;

namespace System
{
	//See: https://github.com/ServiceStack/ServiceStack/blob/master/src/ServiceStack.Client/AsyncUtils.cs
	public static class StreamExtensions
	{
		public static IAsyncResult BeginWrite(this Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}
		public static void EndWrite(this Stream stream, IAsyncResult result)
		{
			throw new NotImplementedException();
		}
		public static IAsyncResult BeginRead(this Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}
		public static int EndRead(this Stream stream, IAsyncResult result)
		{
			throw new NotImplementedException();
		}
		public static void Close(this Stream stream)
		{
			stream.Dispose();
		}
	}
}