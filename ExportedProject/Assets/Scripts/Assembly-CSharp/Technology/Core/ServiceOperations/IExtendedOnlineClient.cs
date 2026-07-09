using System;
using System.Net;
using System.Text;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF1")]
	internal interface IExtendedOnlineClient : IDisposable
	{
		[Token(Token = "0x17000A90")]
		Encoding Encoding
		{
			[Token(Token = "0x6005008")]
			get;
			[Token(Token = "0x6005009")]
			set;
		}

		[Token(Token = "0x1400014A")]
		event DownloadStringCompleteEventHandler DownloadStringCompleted;

		[Token(Token = "0x1400014B")]
		event DownloadDataCompleteEventHandler DownloadDataCompleted;

		[Token(Token = "0x1400014C")]
		event UploadStringCompleteEventHandler UploadStringCompleted;

		[Token(Token = "0x600500A")]
		WebHeaderCollection GetHeaders();

		[Token(Token = "0x600500B")]
		void AddHeader(string key, string value);

		[Token(Token = "0x600500C")]
		string UploadString(Uri uri, string type, string postData);

		[Token(Token = "0x600500D")]
		string DownloadString(Uri uri);

		[Token(Token = "0x600500E")]
		byte[] DownloadData(Uri uri);

		[Token(Token = "0x600500F")]
		void DownloadStringAsync(Uri uri);

		[Token(Token = "0x6005012")]
		void DownloadDataAsync(Uri uri);

		[Token(Token = "0x6005015")]
		void UploadStringAsync(Uri uri, string type, string postData);

		[Token(Token = "0x6005018")]
		void CancelAsync();
	}
}
