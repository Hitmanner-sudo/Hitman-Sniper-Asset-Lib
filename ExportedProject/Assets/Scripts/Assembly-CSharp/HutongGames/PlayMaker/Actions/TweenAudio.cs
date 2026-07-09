using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9964", Offset = "0x5A9964")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A9964", Offset = "0x5A9964")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9964", Offset = "0x5A9964")]
	public class TweenAudio : TweenComponentBase<AudioSource>
	{
		[Token(Token = "0x20011CA")]
		public enum AudioProperty
		{
			[Token(Token = "0x40054F6")]
			Volume = 0,
			[Token(Token = "0x40054F7")]
			Pitch = 1
		}

		[Token(Token = "0x40054EF")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF3D4", Offset = "0x5FF3D4")]
		public AudioProperty property;

		[Token(Token = "0x40054F0")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF40C", Offset = "0x5FF40C")]
		public TweenDirection tweenDirection;

		[Token(Token = "0x40054F1")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF444", Offset = "0x5FF444")]
		public FsmFloat value;

		[Token(Token = "0x40054F2")]
		[FieldOffset(Offset = "0xD8")]
		private AudioSource audio;

		[Token(Token = "0x40054F3")]
		[FieldOffset(Offset = "0xE0")]
		private float fromFloat;

		[Token(Token = "0x40054F4")]
		[FieldOffset(Offset = "0xE4")]
		private float toFloat;

		[Token(Token = "0x60068B5")]
		[Address(RVA = "0xCABEAC", Offset = "0xCABEAC", VA = "0xCABEAC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068B6")]
		[Address(RVA = "0xCABF00", Offset = "0xCABF00", VA = "0xCABF00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068B7")]
		[Address(RVA = "0xCAC040", Offset = "0xCAC040", VA = "0xCAC040", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068B8")]
		[Address(RVA = "0xCAC108", Offset = "0xCAC108", VA = "0xCAC108")]
		public TweenAudio()
		{
		}
	}
}
