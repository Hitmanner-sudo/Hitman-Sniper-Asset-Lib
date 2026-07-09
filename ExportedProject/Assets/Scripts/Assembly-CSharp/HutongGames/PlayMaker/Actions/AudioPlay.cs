using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F2B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BCF4", Offset = "0x59BCF4")]
	[Attribute(Name = "ActionTarget", RVA = "0x59BCF4", Offset = "0x59BCF4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BCF4", Offset = "0x59BCF4")]
	[Attribute(Name = "ActionTarget", RVA = "0x59BCF4", Offset = "0x59BCF4")]
	public class AudioPlay : ComponentAction<AudioSource>
	{
		[Token(Token = "0x4004799")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBA38", Offset = "0x5CBA38")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CBA38", Offset = "0x5CBA38")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400479A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBACC", Offset = "0x5CBACC")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CBACC", Offset = "0x5CBACC")]
		public FsmFloat volume;

		[Token(Token = "0x400479B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBB20", Offset = "0x5CBB20")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5CBB20", Offset = "0x5CBB20")]
		public FsmObject oneShotClip;

		[Token(Token = "0x400479C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBBA4", Offset = "0x5CBBA4")]
		public FsmBool WaitForEndOfClip;

		[Token(Token = "0x400479D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBBDC", Offset = "0x5CBBDC")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0xC09C38", Offset = "0xC09C38", VA = "0xC09C38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D00")]
		[Address(RVA = "0xC09C7C", Offset = "0xC09C7C", VA = "0xC09C7C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D01")]
		[Address(RVA = "0xC09ED0", Offset = "0xC09ED0", VA = "0xC09ED0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D02")]
		[Address(RVA = "0xC0A054", Offset = "0xC0A054", VA = "0xC0A054")]
		public AudioPlay()
		{
		}
	}
}
