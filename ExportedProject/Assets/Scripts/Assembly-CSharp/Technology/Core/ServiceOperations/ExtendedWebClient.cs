using System;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CEA")]
	public class ExtendedWebClient : WebClient, IExtendedOnlineClient, IDisposable
	{
		[Token(Token = "0x4003E02")]
		[FieldOffset(Offset = "0x0")]
		public static readonly object SyncLock;

		[Token(Token = "0x4003E03")]
		[FieldOffset(Offset = "0x158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE1F4", Offset = "0x5BE1F4")]
		private int _003CTimeout_003Ek__BackingField;

		[Token(Token = "0x4003E04")]
		[FieldOffset(Offset = "0x160")]
		private WebRequest _request;

		[Token(Token = "0x17000A8F")]
		public int Timeout
		{
			[Token(Token = "0x6004FDE")]
			[Address(RVA = "0x94BF30", Offset = "0x94BF30", VA = "0x94BF30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629360", Offset = "0x629360")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004FDF")]
			[Address(RVA = "0x94BF38", Offset = "0x94BF38", VA = "0x94BF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629370", Offset = "0x629370")]
			set
			{
			}
		}

		[Token(Token = "0x14000147")]
		public new event DownloadStringCompleteEventHandler DownloadStringCompleted
		{
			[Token(Token = "0x6004FE6")]
			[Address(RVA = "0x94C22C", Offset = "0x94C22C", VA = "0x94C22C", Slot = "32")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629380", Offset = "0x629380")]
			add
			{
			}
			[Token(Token = "0x6004FE7")]
			[Address(RVA = "0x94C2D0", Offset = "0x94C2D0", VA = "0x94C2D0", Slot = "33")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629390", Offset = "0x629390")]
			remove
			{
			}
		}

		[Token(Token = "0x14000148")]
		public new event DownloadDataCompleteEventHandler DownloadDataCompleted
		{
			[Token(Token = "0x6004FE8")]
			[Address(RVA = "0x94C374", Offset = "0x94C374", VA = "0x94C374", Slot = "35")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6293A0", Offset = "0x6293A0")]
			add
			{
			}
			[Token(Token = "0x6004FE9")]
			[Address(RVA = "0x94C418", Offset = "0x94C418", VA = "0x94C418", Slot = "36")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6293B0", Offset = "0x6293B0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000149")]
		public new event UploadStringCompleteEventHandler UploadStringCompleted
		{
			[Token(Token = "0x6004FEA")]
			[Address(RVA = "0x94C4BC", Offset = "0x94C4BC", VA = "0x94C4BC", Slot = "38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6293C0", Offset = "0x6293C0")]
			add
			{
			}
			[Token(Token = "0x6004FEB")]
			[Address(RVA = "0x94C560", Offset = "0x94C560", VA = "0x94C560", Slot = "39")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6293D0", Offset = "0x6293D0")]
			remove
			{
			}
		}

		[Token(Token = "0x6004FE0")]
		[Address(RVA = "0x94AF30", Offset = "0x94AF30", VA = "0x94AF30")]
		public ExtendedWebClient()
		{
		}

		[Token(Token = "0x6004FE1")]
		[Address(RVA = "0x94BF40", Offset = "0x94BF40", VA = "0x94BF40")]
		private void DownloadStringHandler(object sender, System.Net.DownloadStringCompletedEventArgs results)
		{
		}

		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x94C020", Offset = "0x94C020", VA = "0x94C020")]
		private void DownloadDataHandler(object sender, System.Net.DownloadDataCompletedEventArgs results)
		{
		}

		[Token(Token = "0x6004FE3")]
		[Address(RVA = "0x94C100", Offset = "0x94C100", VA = "0x94C100")]
		private void UploadStringHandler(object sender, System.Net.UploadStringCompletedEventArgs results)
		{
		}

		[Token(Token = "0x6004FE4")]
		[Address(RVA = "0x94C1E0", Offset = "0x94C1E0", VA = "0x94C1E0", Slot = "27")]
		public void AddHeader(string key, string value)
		{
		}

		[Token(Token = "0x6004FE5")]
		[Address(RVA = "0x94C224", Offset = "0x94C224", VA = "0x94C224", Slot = "26")]
		public WebHeaderCollection GetHeaders()
		{
			return null;
		}

		[Token(Token = "0x6004FEC")]
		[Address(RVA = "0x94C604", Offset = "0x94C604", VA = "0x94C604", Slot = "10")]
		protected override WebRequest GetWebRequest(Uri address)
		{
			return null;
		}

		[Token(Token = "0x6004FED")]
		[Address(RVA = "0x94C6F8", Offset = "0x94C6F8", VA = "0x94C6F8")]
		public HttpWebResponse Response()
		{
			return null;
		}

		[Token(Token = "0x6004FEE")]
		[Address(RVA = "0x94C78C", Offset = "0x94C78C", VA = "0x94C78C")]
		public static bool CheckValidationResult(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors errors)
		{
			return default(bool);
		}

		[SpecialName]
		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x94C808", Offset = "0x94C808", VA = "0x94C808", Slot = "24")]
		private Encoding Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002Eget_Encoding()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6004FF1")]
		[Address(RVA = "0x94C810", Offset = "0x94C810", VA = "0x94C810", Slot = "25")]
		private void Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002Eset_Encoding(Encoding value)
		{
		}

		[Token(Token = "0x6004FF2")]
		[Address(RVA = "0x94C818", Offset = "0x94C818", VA = "0x94C818", Slot = "28")]
		private string Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002EUploadString(Uri uri, string type, string postData)
		{
			return null;
		}

		[Token(Token = "0x6004FF3")]
		[Address(RVA = "0x94C820", Offset = "0x94C820", VA = "0x94C820", Slot = "29")]
		private string Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002EDownloadString(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6004FF4")]
		[Address(RVA = "0x94C828", Offset = "0x94C828", VA = "0x94C828", Slot = "30")]
		private byte[] Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002EDownloadData(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6004FF5")]
		[Address(RVA = "0x94C830", Offset = "0x94C830", VA = "0x94C830", Slot = "31")]
		private void Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002EDownloadStringAsync(Uri uri)
		{
		}

		[Token(Token = "0x6004FF6")]
		[Address(RVA = "0x94C838", Offset = "0x94C838", VA = "0x94C838", Slot = "34")]
		private void Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002EDownloadDataAsync(Uri uri)
		{
		}

		[Token(Token = "0x6004FF7")]
		[Address(RVA = "0x94C840", Offset = "0x94C840", VA = "0x94C840", Slot = "37")]
		private void Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002EUploadStringAsync(Uri uri, string type, string postData)
		{
		}

		[Token(Token = "0x6004FF8")]
		[Address(RVA = "0x94C848", Offset = "0x94C848", VA = "0x94C848", Slot = "40")]
		private void Technology_002ECore_002EServiceOperations_002EIExtendedOnlineClient_002ECancelAsync()
		{
		}
	}
}
