using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A77")]
	public class GameMonoBehaviour : MonoBehaviour
	{
		[NonSerialized]
		[Token(Token = "0x4003670")]
		[FieldOffset(Offset = "0x18")]
		private Transform _cachedTransform;

		[Token(Token = "0x4003671")]
		[FieldOffset(Offset = "0x20")]
		public readonly LinkedListNode<GameScheduler.GameUpdateDelegate>[] GameSchedulerNode;

		[Token(Token = "0x4003672")]
		[FieldOffset(Offset = "0x28")]
		private GameScheduler.GameUpdateDelegate _fixedGameUpdateDelegate;

		[Token(Token = "0x4003673")]
		[FieldOffset(Offset = "0x30")]
		private GameScheduler.GameUpdateDelegate _gameUpdateDelegate;

		[Token(Token = "0x4003674")]
		[FieldOffset(Offset = "0x38")]
		private GameScheduler.GameUpdateDelegate _lateGameUpdateDelegate;

		[Token(Token = "0x4003675")]
		[FieldOffset(Offset = "0x40")]
		private GameScheduler.ExecutionOrder _executionOrder;

		[Token(Token = "0x4003676")]
		[FieldOffset(Offset = "0x44")]
		private bool _ready;

		[Token(Token = "0x4003677")]
		[FieldOffset(Offset = "0x45")]
		private bool _initialized;

		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x46")]
		private bool _registered;

		[Token(Token = "0x17000878")]
		public Transform baseTransform
		{
			[Token(Token = "0x6004202")]
			[Address(RVA = "0xD98960", Offset = "0xD98960", VA = "0xD98960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000879")]
		public new Transform transform
		{
			[Token(Token = "0x6004203")]
			[Address(RVA = "0xD98968", Offset = "0xD98968", VA = "0xD98968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004204")]
		[Address(RVA = "0xD98970", Offset = "0xD98970", VA = "0xD98970", Slot = "4")]
		protected virtual void FixedGameUpdate()
		{
		}

		[Token(Token = "0x6004205")]
		[Address(RVA = "0xD98974", Offset = "0xD98974", VA = "0xD98974", Slot = "5")]
		protected virtual void GameUpdate()
		{
		}

		[Token(Token = "0x6004206")]
		[Address(RVA = "0xD98978", Offset = "0xD98978", VA = "0xD98978", Slot = "6")]
		protected virtual void LateGameUpdate()
		{
		}

		[Token(Token = "0x6004207")]
		[Address(RVA = "0xD9897C", Offset = "0xD9897C", VA = "0xD9897C", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6004208")]
		[Address(RVA = "0xD989A4", Offset = "0xD989A4", VA = "0xD989A4", Slot = "8")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6004209")]
		[Address(RVA = "0xD968F4", Offset = "0xD968F4", VA = "0xD968F4", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600420A")]
		[Address(RVA = "0xD98B00", Offset = "0xD98B00", VA = "0xD98B00", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600420B")]
		[Address(RVA = "0xD98B8C", Offset = "0xD98B8C", VA = "0xD98B8C", Slot = "11")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600420C")]
		[Address(RVA = "0xD98B9C", Offset = "0xD98B9C", VA = "0xD98B9C", Slot = "12")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600420D")]
		[Address(RVA = "0xD989A8", Offset = "0xD989A8", VA = "0xD989A8")]
		private void RegisterForUpdates()
		{
		}

		[Token(Token = "0x600420E")]
		[Address(RVA = "0xD99204", Offset = "0xD99204", VA = "0xD99204", Slot = "13")]
		protected virtual void UnregisterForUpdates()
		{
		}

		[Token(Token = "0x600420F")]
		[Address(RVA = "0xD98C24", Offset = "0xD98C24", VA = "0xD98C24")]
		private void InitDelegates()
		{
		}

		[Token(Token = "0x6004210")]
		[Address(RVA = "0xD99458", Offset = "0xD99458", VA = "0xD99458")]
		public GameCoroutine StartGameCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6004211")]
		[Address(RVA = "0xD99460", Offset = "0xD99460", VA = "0xD99460")]
		public GameCoroutine StartGameCoroutine(IEnumerator coroutine, bool pausable)
		{
			return null;
		}

		[Token(Token = "0x6004212")]
		[Address(RVA = "0xD994D4", Offset = "0xD994D4", VA = "0xD994D4")]
		public static GameCoroutine StartGameCoroutine(MonoBehaviour behaviour, IEnumerator coroutine, bool pausable)
		{
			return null;
		}

		[Token(Token = "0x6004213")]
		[Address(RVA = "0xD99548", Offset = "0xD99548", VA = "0xD99548")]
		public GameMonoBehaviour()
		{
		}
	}
}
