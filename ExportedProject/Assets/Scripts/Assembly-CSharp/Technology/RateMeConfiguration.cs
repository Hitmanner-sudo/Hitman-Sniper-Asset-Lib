using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AB8")]
	public class RateMeConfiguration : ScriptableObject
	{
		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _googleAppID;

		[Token(Token = "0x40036FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _appleAppID;

		[Token(Token = "0x40036FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _editorAppID;

		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0x30")]
		public int AppearOnMissionCompletedCount;

		[Token(Token = "0x4003701")]
		[FieldOffset(Offset = "0x34")]
		public int RemindOnMissionCompletedCount;

		[Token(Token = "0x17000888")]
		public string AppID
		{
			[Token(Token = "0x600430B")]
			[Address(RVA = "0xB3F894", Offset = "0xB3F894", VA = "0xB3F894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600430C")]
		[Address(RVA = "0xB3F89C", Offset = "0xB3F89C", VA = "0xB3F89C")]
		public RateMeConfiguration()
		{
		}
	}
}
