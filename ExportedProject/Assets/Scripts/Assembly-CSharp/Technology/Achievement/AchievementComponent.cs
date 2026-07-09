using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.Achievement;

namespace Technology.Achievement
{
	[Token(Token = "0x2000E75")]
	internal sealed class AchievementComponent
	{
		[Token(Token = "0x4004406")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAchievementComponent _component;

		[Token(Token = "0x17000BF9")]
		public Dictionary<string, IArmoryAchievementDescription> Descriptions
		{
			[Token(Token = "0x6005935")]
			[Address(RVA = "0xAA6980", Offset = "0xAA6980", VA = "0xAA6980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005936")]
		[Address(RVA = "0xAA6A2C", Offset = "0xAA6A2C", VA = "0xAA6A2C")]
		internal AchievementComponent(IAchievementComponent controller)
		{
		}

		[Token(Token = "0x6005937")]
		[Address(RVA = "0xAA6A58", Offset = "0xAA6A58", VA = "0xAA6A58")]
		public void Unlock(string id)
		{
		}

		[Token(Token = "0x6005938")]
		[Address(RVA = "0xAA6B18", Offset = "0xAA6B18", VA = "0xAA6B18")]
		public void Reveal(string id)
		{
		}

		[Token(Token = "0x6005939")]
		[Address(RVA = "0xAA6BD8", Offset = "0xAA6BD8", VA = "0xAA6BD8")]
		public void Increment(string id, int steps)
		{
		}

		[Token(Token = "0x600593A")]
		[Address(RVA = "0xAA6CA0", Offset = "0xAA6CA0", VA = "0xAA6CA0")]
		public void ShowUI()
		{
		}

		[Token(Token = "0x600593B")]
		[Address(RVA = "0xAA6D50", Offset = "0xAA6D50", VA = "0xAA6D50")]
		public void ResetPlayerProgression()
		{
		}

		[Token(Token = "0x600593C")]
		[Address(RVA = "0xAA6E00", Offset = "0xAA6E00", VA = "0xAA6E00")]
		public void GetRecord(string id)
		{
		}

		[Token(Token = "0x600593D")]
		[Address(RVA = "0xAA6EC0", Offset = "0xAA6EC0", VA = "0xAA6EC0")]
		public void GetRecords()
		{
		}

		[Token(Token = "0x600593E")]
		[Address(RVA = "0xAA6F70", Offset = "0xAA6F70", VA = "0xAA6F70")]
		public void RefreshDescriptions()
		{
		}

		[Token(Token = "0x600593F")]
		[Address(RVA = "0xAA7020", Offset = "0xAA7020", VA = "0xAA7020")]
		public void Reinitialize()
		{
		}

		[Token(Token = "0x6005940")]
		[Address(RVA = "0xAA70D0", Offset = "0xAA70D0", VA = "0xAA70D0")]
		public Type GetComponentType()
		{
			return null;
		}
	}
}
