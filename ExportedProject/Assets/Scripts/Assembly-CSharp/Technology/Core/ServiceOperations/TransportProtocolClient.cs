using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CFE")]
	public class TransportProtocolClient
	{
		[Token(Token = "0x2000CFF")]
		public enum Verb
		{
			[Token(Token = "0x4003E54")]
			POST = 0,
			[Token(Token = "0x4003E55")]
			GET = 1
		}

		[Token(Token = "0x4003E4C")]
		[FieldOffset(Offset = "0x10")]
		private readonly IRequestContext _requestContext;

		[Token(Token = "0x4003E4D")]
		[FieldOffset(Offset = "0x18")]
		private readonly IResponseContext _responseContext;

		[Token(Token = "0x4003E4E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object _locker;

		[Token(Token = "0x4003E4F")]
		[FieldOffset(Offset = "0x8")]
		private static sbyte _runningRequests;

		[Token(Token = "0x4003E50")]
		private const sbyte MAX_SIMULATANEOUS_REQUESTS = 10;

		[Token(Token = "0x4003E51")]
		[FieldOffset(Offset = "0x10")]
		private static string[] _analyticsRefusedHeaders;

		[Token(Token = "0x4003E52")]
		[FieldOffset(Offset = "0x18")]
		private static bool _isAnalytic;

		[Token(Token = "0x6005030")]
		[Address(RVA = "0xC988BC", Offset = "0xC988BC", VA = "0xC988BC")]
		private TransportProtocolClient()
		{
		}

		[Token(Token = "0x6005031")]
		[Address(RVA = "0xC988C4", Offset = "0xC988C4", VA = "0xC988C4")]
		public TransportProtocolClient(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6005032")]
		[Address(RVA = "0xC98B18", Offset = "0xC98B18", VA = "0xC98B18")]
		public void Post(bool verbose = true)
		{
		}

		[Token(Token = "0x6005033")]
		[Address(RVA = "0xC9AE34", Offset = "0xC9AE34", VA = "0xC9AE34")]
		public void Get(bool verbose = true)
		{
		}

		[Token(Token = "0x6005034")]
		[Address(RVA = "0xC9A380", Offset = "0xC9A380", VA = "0xC9A380")]
		private static void AddHeaders(IExtendedOnlineClient client, KeyValuePair<string, string>[] headers)
		{
		}

		[Token(Token = "0x6005035")]
		[Address(RVA = "0xC9A560", Offset = "0xC9A560", VA = "0xC9A560")]
		private void HandleResponse(IExtendedOnlineClient client, string response, Exception error, bool cancelled)
		{
		}

		[Token(Token = "0x6005036")]
		[Address(RVA = "0xC99998", Offset = "0xC99998", VA = "0xC99998")]
		private void HandleException(Exception ex)
		{
		}

		[Token(Token = "0x6005037")]
		[Address(RVA = "0xC9B870", Offset = "0xC9B870", VA = "0xC9B870")]
		private void LogResult()
		{
		}

		[Token(Token = "0x6005038")]
		[Address(RVA = "0xC9B874", Offset = "0xC9B874", VA = "0xC9B874")]
		private void ClientOnDownloadAsyncComplete(object sender, DownloadStringCompletedEventArgs eventsArgs)
		{
		}

		[Token(Token = "0x6005039")]
		[Address(RVA = "0xC9BA40", Offset = "0xC9BA40", VA = "0xC9BA40")]
		private void ClientOnUploadAsyncComplete(object sender, UploadStringCompletedEventArgs eventsArgs)
		{
		}

		[Token(Token = "0x600503A")]
		[Address(RVA = "0xC997B8", Offset = "0xC997B8", VA = "0xC997B8")]
		private bool IsMaxRequestLimitHit()
		{
			return default(bool);
		}

		[Token(Token = "0x600503B")]
		[Address(RVA = "0xC99868", Offset = "0xC99868", VA = "0xC99868")]
		private static void IncrementRunningRequests(bool verbose = true)
		{
		}

		[Token(Token = "0x600503C")]
		[Address(RVA = "0xC9A228", Offset = "0xC9A228", VA = "0xC9A228")]
		private static void DecrementRunningRequests(bool verbose = true)
		{
		}
	}
}
