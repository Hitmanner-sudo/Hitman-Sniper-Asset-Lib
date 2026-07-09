using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.Social
{
	[Token(Token = "0x2000AEC")]
	public class InvitedFriendEventHandler : EventArgs
	{
		[Token(Token = "0x40037CD")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC250", Offset = "0x5BC250")]
		private HashSet<FacebookPersonalRecord> _003CInvitedFriends_003Ek__BackingField;

		[Token(Token = "0x17000894")]
		public HashSet<FacebookPersonalRecord> InvitedFriends
		{
			[Token(Token = "0x6004431")]
			[Address(RVA = "0x10BD2B8", Offset = "0x10BD2B8", VA = "0x10BD2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625FF8", Offset = "0x625FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004432")]
			[Address(RVA = "0x10BD2C0", Offset = "0x10BD2C0", VA = "0x10BD2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626008", Offset = "0x626008")]
			internal set
			{
			}
		}

		[Token(Token = "0x6004433")]
		[Address(RVA = "0x10BD2C8", Offset = "0x10BD2C8", VA = "0x10BD2C8")]
		public InvitedFriendEventHandler()
		{
		}
	}
}
