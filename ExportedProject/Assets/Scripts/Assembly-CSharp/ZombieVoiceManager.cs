using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000BC")]
[Scope]
public class ZombieVoiceManager : GameSingleton<ZombieVoiceManager>
{
	[Token(Token = "0x20000BD")]
	private enum State
	{
		[Token(Token = "0x400047C")]
		ChooseVO = 0,
		[Token(Token = "0x400047D")]
		WaitVOFinished = 1,
		[Token(Token = "0x400047E")]
		WaitTimeBetweenVO = 2
	}

	[Serializable]
	[Token(Token = "0x20000BE")]
	public class ZombieVO
	{
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x10")]
		public SoundContainer SoundContainer;

		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x18")]
		public float PlayableDelay;

		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x1C")]
		public int Priority;

		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public float QueuedTime;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xA43F48", Offset = "0xA43F48", VA = "0xA43F48")]
		public ZombieVO()
		{
		}
	}

	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592340", Offset = "0x592340")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x10")]
		public float timeEpsilon;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xA43E58", Offset = "0xA43E58", VA = "0xA43E58")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xA43E60", Offset = "0xA43E60", VA = "0xA43E60")]
		internal bool _003CClearExhaustedVOs_003Eb__0(ZombieVO r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _minDelayBetweenVO;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ZombieVO _survivorGettingAttacked;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ZombieVO _survivorGettingShot;

	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ZombieVO _survivorDied;

	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ZombieVO[] _VOEvent;

	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private NPCFilter _survivorNPCFilter;

	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<ZombieVO> _queuedVOs;

	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x80")]
	private PlayingSoundContainer _playingContainer;

	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x88")]
	private ZombieVO _playingZombieVO;

	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x90")]
	private float _endVOTime;

	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x94")]
	private int _lastVOPriority;

	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x98")]
	private State _state;

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x887EC4", Offset = "0x887EC4", VA = "0x887EC4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x887F9C", Offset = "0x887F9C", VA = "0x887F9C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x8880BC", Offset = "0x8880BC", VA = "0x8880BC")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x8883F0", Offset = "0x8883F0", VA = "0x8883F0")]
	public void PlayVOEvent(SoundContainer soundContainer)
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x8884D8", Offset = "0x8884D8", VA = "0x8884D8")]
	private ZombieVO FindVOEvent(SoundContainer soundContainer)
	{
		return null;
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x8882F4", Offset = "0x8882F4", VA = "0x8882F4")]
	private void QueueVO(ZombieVO zombieVO)
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x8885B0", Offset = "0x8885B0", VA = "0x8885B0")]
	private static int SortByPriority(ZombieVO a, ZombieVO b)
	{
		return default(int);
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x8885D8", Offset = "0x8885D8", VA = "0x8885D8")]
	private void SortVOs()
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x88868C", Offset = "0x88868C", VA = "0x88868C")]
	protected void Update()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x8886B4", Offset = "0x8886B4", VA = "0x8886B4")]
	private void ChooseVO()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x8889E8", Offset = "0x8889E8", VA = "0x8889E8")]
	private void ClearExhaustedVOs()
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x888838", Offset = "0x888838", VA = "0x888838")]
	private void WaitVOFinished()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x88891C", Offset = "0x88891C", VA = "0x88891C")]
	private void WaitTimeBetweenVO()
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x888B50", Offset = "0x888B50", VA = "0x888B50")]
	public ZombieVoiceManager()
	{
	}
}
