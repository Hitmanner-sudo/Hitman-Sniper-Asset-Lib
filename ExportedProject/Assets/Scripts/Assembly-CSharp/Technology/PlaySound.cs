using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A4B")]
	public class PlaySound : GameMonoBehaviour
	{
		[Token(Token = "0x40035AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BBD6C", Offset = "0x5BBD6C")]
		private SoundContainer _sound;

		[Token(Token = "0x40035B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _playOnEnable;

		[Token(Token = "0x40035B1")]
		[FieldOffset(Offset = "0x58")]
		private PlayingSoundContainer _playingSound;

		[Token(Token = "0x6004137")]
		[Address(RVA = "0xB813AC", Offset = "0xB813AC", VA = "0xB813AC", Slot = "11")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6004138")]
		[Address(RVA = "0xB81484", Offset = "0xB81484", VA = "0xB81484", Slot = "12")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6004139")]
		[Address(RVA = "0xB81490", Offset = "0xB81490", VA = "0xB81490")]
		protected void PlaySoundContainer(AnimationEvent ev)
		{
		}

		[Token(Token = "0x600413A")]
		[Address(RVA = "0xB813C0", Offset = "0xB813C0", VA = "0xB813C0")]
		private void Play(SoundContainer sound)
		{
		}

		[Token(Token = "0x600413B")]
		[Address(RVA = "0xB8157C", Offset = "0xB8157C", VA = "0xB8157C")]
		protected void StopSoundContainer(AnimationEvent ev)
		{
		}

		[Token(Token = "0x600413C")]
		[Address(RVA = "0xB81594", Offset = "0xB81594", VA = "0xB81594")]
		public PlaySound()
		{
		}
	}
}
