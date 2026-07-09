using Il2CppDummyDll;
using UnityEngine;

namespace Tapdaq
{
	[Token(Token = "0x2000072")]
	public class TDEventHandler : MonoBehaviour
	{
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x0")]
		private static TDEventHandler reference;

		[Token(Token = "0x1700002D")]
		public static TDEventHandler instance
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x10D3C30", Offset = "0x10D3C30", VA = "0x10D3C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x10F3F24", Offset = "0x10F3F24", VA = "0x10F3F24")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x10D3DC0", Offset = "0x10D3DC0", VA = "0x10D3DC0")]
		public void Init()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x10F3F9C", Offset = "0x10F3F9C", VA = "0x10F3F9C")]
		private void _didLoadConfig(string message)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x10F3FF0", Offset = "0x10F3FF0", VA = "0x10F3FF0")]
		private void _didFailToLoadConfig(string message)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x10F4070", Offset = "0x10F4070", VA = "0x10F4070")]
		private void _didLoad(string jsonMessage)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x10F40FC", Offset = "0x10F40FC", VA = "0x10F40FC")]
		private void _didFailToLoad(string jsonMessage)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x10F4188", Offset = "0x10F4188", VA = "0x10F4188")]
		private void _didClose(string jsonMessage)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x10F4214", Offset = "0x10F4214", VA = "0x10F4214")]
		private void _didClick(string jsonMessage)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x10F42A0", Offset = "0x10F42A0", VA = "0x10F42A0")]
		private void _didDisplay(string jsonMessage)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x10F432C", Offset = "0x10F432C", VA = "0x10F432C")]
		private void _willDisplay(string jsonMessage)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x10F43B8", Offset = "0x10F43B8", VA = "0x10F43B8")]
		private void _didFailToDisplay(string jsonMessage)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x10F4444", Offset = "0x10F4444", VA = "0x10F4444")]
		private void _didComplete(string adType)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x10F4498", Offset = "0x10F4498", VA = "0x10F4498")]
		private void _didEngagement(string adType)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x10F44EC", Offset = "0x10F44EC", VA = "0x10F44EC")]
		private void _didReachLimit(string adType)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x10F45AC", Offset = "0x10F45AC", VA = "0x10F45AC")]
		private void _onRejected(string adType)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x10F466C", Offset = "0x10F466C", VA = "0x10F466C")]
		private void _didFail(string jsonMessage)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x10F46F8", Offset = "0x10F46F8", VA = "0x10F46F8")]
		private void _onUserDeclined(string adType)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x10F47B8", Offset = "0x10F47B8", VA = "0x10F47B8")]
		private void _didVerify(string message)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x10F4844", Offset = "0x10F4844", VA = "0x10F4844")]
		private void _onValidationFailed(string jsonMessage)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x10F48D0", Offset = "0x10F48D0", VA = "0x10F48D0")]
		private void _didRefresh(string jsonMessage)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x10F495C", Offset = "0x10F495C", VA = "0x10F495C")]
		private void _didFailToRefresh(string jsonMessage)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x10F49E8", Offset = "0x10F49E8", VA = "0x10F49E8")]
		public TDEventHandler()
		{
		}
	}
}
