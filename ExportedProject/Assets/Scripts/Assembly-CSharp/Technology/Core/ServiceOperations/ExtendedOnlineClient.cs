using System;
using System.Net;
using System.Text;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CE9")]
	public class ExtendedOnlineClient : IExtendedOnlineClient, IDisposable
	{
		[Token(Token = "0x4003E01")]
		[FieldOffset(Offset = "0x10")]
		private IExtendedOnlineClient _client;

		[Token(Token = "0x17000A8E")]
		public Encoding Encoding
		{
			[Token(Token = "0x6004FCE")]
			[Address(RVA = "0x94B338", Offset = "0x94B338", VA = "0x94B338", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FCF")]
			[Address(RVA = "0x94B3E4", Offset = "0x94B3E4", VA = "0x94B3E4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x14000144")]
		public event DownloadStringCompleteEventHandler DownloadStringCompleted
		{
			[Token(Token = "0x6004FD4")]
			[Address(RVA = "0x94B7BC", Offset = "0x94B7BC", VA = "0x94B7BC", Slot = "12")]
			add
			{
			}
			[Token(Token = "0x6004FD5")]
			[Address(RVA = "0x94B87C", Offset = "0x94B87C", VA = "0x94B87C", Slot = "13")]
			remove
			{
			}
		}

		[Token(Token = "0x14000145")]
		public event DownloadDataCompleteEventHandler DownloadDataCompleted
		{
			[Token(Token = "0x6004FD7")]
			[Address(RVA = "0x94B9FC", Offset = "0x94B9FC", VA = "0x94B9FC", Slot = "15")]
			add
			{
			}
			[Token(Token = "0x6004FD8")]
			[Address(RVA = "0x94BABC", Offset = "0x94BABC", VA = "0x94BABC", Slot = "16")]
			remove
			{
			}
		}

		[Token(Token = "0x14000146")]
		public event UploadStringCompleteEventHandler UploadStringCompleted
		{
			[Token(Token = "0x6004FDA")]
			[Address(RVA = "0x94BC54", Offset = "0x94BC54", VA = "0x94BC54", Slot = "18")]
			add
			{
			}
			[Token(Token = "0x6004FDB")]
			[Address(RVA = "0x94BD14", Offset = "0x94BD14", VA = "0x94BD14", Slot = "19")]
			remove
			{
			}
		}

		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x94AECC", Offset = "0x94AECC", VA = "0x94AECC")]
		public ExtendedOnlineClient()
		{
		}

		[Token(Token = "0x6004FCC")]
		[Address(RVA = "0x94B1C0", Offset = "0x94B1C0", VA = "0x94B1C0", Slot = "7")]
		public void AddHeader(string key, string value)
		{
		}

		[Token(Token = "0x6004FCD")]
		[Address(RVA = "0x94B288", Offset = "0x94B288", VA = "0x94B288", Slot = "6")]
		public WebHeaderCollection GetHeaders()
		{
			return null;
		}

		[Token(Token = "0x6004FD0")]
		[Address(RVA = "0x94B4A4", Offset = "0x94B4A4", VA = "0x94B4A4", Slot = "8")]
		public string UploadString(Uri uri, string type, string postData)
		{
			return null;
		}

		[Token(Token = "0x6004FD1")]
		[Address(RVA = "0x94B57C", Offset = "0x94B57C", VA = "0x94B57C", Slot = "9")]
		public string DownloadString(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6004FD2")]
		[Address(RVA = "0x94B63C", Offset = "0x94B63C", VA = "0x94B63C", Slot = "10")]
		public byte[] DownloadData(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6004FD3")]
		[Address(RVA = "0x94B6FC", Offset = "0x94B6FC", VA = "0x94B6FC", Slot = "11")]
		public void DownloadStringAsync(Uri uri)
		{
		}

		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0x94B93C", Offset = "0x94B93C", VA = "0x94B93C", Slot = "14")]
		public void DownloadDataAsync(Uri uri)
		{
		}

		[Token(Token = "0x6004FD9")]
		[Address(RVA = "0x94BB7C", Offset = "0x94BB7C", VA = "0x94BB7C", Slot = "17")]
		public void UploadStringAsync(Uri uri, string type, string postData)
		{
		}

		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x94BDD4", Offset = "0x94BDD4", VA = "0x94BDD4", Slot = "20")]
		public void CancelAsync()
		{
		}

		[Token(Token = "0x6004FDD")]
		[Address(RVA = "0x94BE84", Offset = "0x94BE84", VA = "0x94BE84", Slot = "21")]
		public void Dispose()
		{
		}
	}
}
