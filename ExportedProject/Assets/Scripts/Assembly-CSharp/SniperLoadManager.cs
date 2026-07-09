using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000293")]
[AutoInstantiate]
[Scope]
public class SniperLoadManager : GameSingleton<SniperLoadManager>
{
	[Token(Token = "0x2000294")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592FD8", Offset = "0x592FD8")]
	private sealed class _003CLoadSceneSequence_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x20")]
		public SniperLoadManager _003C_003E4__this;

		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x28")]
		public string scene;

		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0x30")]
		private SaveGameManager _003Csgm_003E5__2;

		[Token(Token = "0x17000269")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0xA4AACC", Offset = "0xA4AACC", VA = "0xA4AACC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FA1")]
			[Address(RVA = "0xA4AB14", Offset = "0xA4AB14", VA = "0xA4AB14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0xA4A180", Offset = "0xA4A180", VA = "0xA4A180")]
		[DebuggerHidden]
		public _003CLoadSceneSequence_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0xA4A1AC", Offset = "0xA4A1AC", VA = "0xA4A1AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0xA4A1B0", Offset = "0xA4A1B0", VA = "0xA4A1B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0xA4AAD4", Offset = "0xA4AAD4", VA = "0xA4AAD4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000E7B")]
	public const string EMPTY_SCENE = "EmptyScene";

	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x48")]
	public ModelContainer Models;

	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x50")]
	private bool _isLoading;

	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x58")]
	private AsyncOperation _loadingOperation;

	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x60")]
	private int _scenesToLoad;

	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x64")]
	private int _scenesLoaded;

	[Token(Token = "0x17000268")]
	public float LoadProgress
	{
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0xA64724", Offset = "0xA64724", VA = "0xA64724")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000F97")]
	[Address(RVA = "0xA64760", Offset = "0xA64760", VA = "0xA64760")]
	public void LoadScene(string scene)
	{
	}

	[Token(Token = "0x6000F98")]
	[Address(RVA = "0xA64798", Offset = "0xA64798", VA = "0xA64798")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6155A4", Offset = "0x6155A4")]
	private IEnumerator LoadSceneSequence(string scene)
	{
		return null;
	}

	[Token(Token = "0x6000F99")]
	[Address(RVA = "0xA64810", Offset = "0xA64810", VA = "0xA64810")]
	public void LoadGamePlayLevel(ModelContainer modelContainer, bool showLoadingScreen = true)
	{
	}

	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0xA64AE8", Offset = "0xA64AE8", VA = "0xA64AE8")]
	private void OnLevelLoadedIntoScene()
	{
	}

	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0xA64C40", Offset = "0xA64C40", VA = "0xA64C40")]
	public SniperLoadManager()
	{
	}
}
