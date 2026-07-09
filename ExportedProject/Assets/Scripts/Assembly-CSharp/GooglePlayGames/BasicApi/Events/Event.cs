using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	[Token(Token = "0x2000A10")]
	internal class Event : IEvent
	{
		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4003513")]
		[FieldOffset(Offset = "0x18")]
		private string mName;

		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0x20")]
		private string mDescription;

		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0x28")]
		private string mImageUrl;

		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0x30")]
		private ulong mCurrentCount;

		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0x38")]
		private EventVisibility mVisibility;

		[Token(Token = "0x17000803")]
		public string Id
		{
			[Token(Token = "0x6003FAA")]
			[Address(RVA = "0xE16A14", Offset = "0xE16A14", VA = "0xE16A14", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000804")]
		public string Name
		{
			[Token(Token = "0x6003FAB")]
			[Address(RVA = "0xE16A1C", Offset = "0xE16A1C", VA = "0xE16A1C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000805")]
		public string Description
		{
			[Token(Token = "0x6003FAC")]
			[Address(RVA = "0xE16A24", Offset = "0xE16A24", VA = "0xE16A24", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000806")]
		public string ImageUrl
		{
			[Token(Token = "0x6003FAD")]
			[Address(RVA = "0xE16A2C", Offset = "0xE16A2C", VA = "0xE16A2C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000807")]
		public ulong CurrentCount
		{
			[Token(Token = "0x6003FAE")]
			[Address(RVA = "0xE16A34", Offset = "0xE16A34", VA = "0xE16A34", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000808")]
		public EventVisibility Visibility
		{
			[Token(Token = "0x6003FAF")]
			[Address(RVA = "0xE16A3C", Offset = "0xE16A3C", VA = "0xE16A3C", Slot = "9")]
			get
			{
				return default(EventVisibility);
			}
		}

		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0xE169B0", Offset = "0xE169B0", VA = "0xE169B0")]
		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility)
		{
		}
	}
}
