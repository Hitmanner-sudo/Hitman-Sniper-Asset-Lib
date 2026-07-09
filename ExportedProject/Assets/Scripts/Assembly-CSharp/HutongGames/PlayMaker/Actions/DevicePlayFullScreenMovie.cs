using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F78")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D308", Offset = "0x59D308")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D308", Offset = "0x59D308")]
	public class DevicePlayFullScreenMovie : FsmStateAction
	{
		[Token(Token = "0x40048F3")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0E24", Offset = "0x5D0E24")]
		public FsmString moviePath;

		[Token(Token = "0x40048F4")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0E70", Offset = "0x5D0E70")]
		public FsmColor fadeColor;

		[Token(Token = "0x40048F5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0EBC", Offset = "0x5D0EBC")]
		public FullScreenMovieControlMode movieControlMode;

		[Token(Token = "0x40048F6")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0EF4", Offset = "0x5D0EF4")]
		public FullScreenMovieScalingMode movieScalingMode;

		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0xC14210", Offset = "0xC14210", VA = "0xC14210", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0xC14284", Offset = "0xC14284", VA = "0xC14284", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E50")]
		[Address(RVA = "0xC142CC", Offset = "0xC142CC", VA = "0xC142CC")]
		public DevicePlayFullScreenMovie()
		{
		}
	}
}
