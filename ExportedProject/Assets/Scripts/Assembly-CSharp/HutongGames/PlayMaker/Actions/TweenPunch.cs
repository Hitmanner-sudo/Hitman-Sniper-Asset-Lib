using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9C64", Offset = "0x5A9C64")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9C64", Offset = "0x5A9C64")]
	public class TweenPunch : TweenComponentBase<Transform>
	{
		[Token(Token = "0x20011D6")]
		public enum PunchType
		{
			[Token(Token = "0x4005552")]
			Position = 0,
			[Token(Token = "0x4005553")]
			Rotation = 1,
			[Token(Token = "0x4005554")]
			Scale = 2
		}

		[Token(Token = "0x4005548")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF974", Offset = "0x5FF974")]
		public PunchType punchType;

		[Token(Token = "0x4005549")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF9AC", Offset = "0x5FF9AC")]
		public FsmVector3 value;

		[Token(Token = "0x400554A")]
		[FieldOffset(Offset = "0xD8")]
		private Transform transform;

		[Token(Token = "0x400554B")]
		[FieldOffset(Offset = "0xE0")]
		private RectTransform rectTransform;

		[Token(Token = "0x400554C")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 startVector3;

		[Token(Token = "0x400554D")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 endVector3;

		[Token(Token = "0x400554E")]
		[FieldOffset(Offset = "0x100")]
		private Quaternion startRotation;

		[Token(Token = "0x400554F")]
		[FieldOffset(Offset = "0x110")]
		private Quaternion midRotation;

		[Token(Token = "0x4005550")]
		[FieldOffset(Offset = "0x120")]
		private Quaternion endRotation;

		[Token(Token = "0x60068E5")]
		[Address(RVA = "0x1572100", Offset = "0x1572100", VA = "0x1572100", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068E6")]
		[Address(RVA = "0x1572158", Offset = "0x1572158", VA = "0x1572158", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068E7")]
		[Address(RVA = "0x157244C", Offset = "0x157244C", VA = "0x157244C", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068E8")]
		[Address(RVA = "0x1572730", Offset = "0x1572730", VA = "0x1572730")]
		public TweenPunch()
		{
		}
	}
}
