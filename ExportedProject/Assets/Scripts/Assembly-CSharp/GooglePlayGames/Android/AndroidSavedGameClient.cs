using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x20009B1")]
	internal class AndroidSavedGameClient : ISavedGameClient
	{
		[Token(Token = "0x20009B2")]
		private class AndroidConflictResolver : IConflictResolver
		{
			[Token(Token = "0x40033BE")]
			[FieldOffset(Offset = "0x10")]
			private readonly AndroidJavaObject mSnapshotsClient;

			[Token(Token = "0x40033BF")]
			[FieldOffset(Offset = "0x18")]
			private readonly AndroidJavaObject mConflict;

			[Token(Token = "0x40033C0")]
			[FieldOffset(Offset = "0x20")]
			private readonly AndroidSnapshotMetadata mOriginal;

			[Token(Token = "0x40033C1")]
			[FieldOffset(Offset = "0x28")]
			private readonly AndroidSnapshotMetadata mUnmerged;

			[Token(Token = "0x40033C2")]
			[FieldOffset(Offset = "0x30")]
			private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;

			[Token(Token = "0x40033C3")]
			[FieldOffset(Offset = "0x38")]
			private readonly Action mRetryFileOpen;

			[Token(Token = "0x40033C4")]
			[FieldOffset(Offset = "0x40")]
			private readonly AndroidSavedGameClient mAndroidSavedGameClient;

			[Token(Token = "0x6003DC7")]
			[Address(RVA = "0x91E364", Offset = "0x91E364", VA = "0x91E364")]
			internal AndroidConflictResolver(AndroidSavedGameClient androidSavedGameClient, AndroidJavaObject snapshotClient, AndroidJavaObject conflict, AndroidSnapshotMetadata original, AndroidSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen)
			{
			}

			[Token(Token = "0x6003DC8")]
			[Address(RVA = "0x91E950", Offset = "0x91E950", VA = "0x91E950", Slot = "5")]
			public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
			{
			}

			[Token(Token = "0x6003DC9")]
			[Address(RVA = "0x91F338", Offset = "0x91F338", VA = "0x91F338", Slot = "4")]
			public void ChooseMetadata(ISavedGameMetadata chosenMetadata)
			{
			}

			[Token(Token = "0x6003DCA")]
			[Address(RVA = "0x91F7D4", Offset = "0x91F7D4", VA = "0x91F7D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624DB8", Offset = "0x624DB8")]
			private void _003CResolveConflict_003Eb__8_0(AndroidJavaObject dataOrConflict)
			{
			}

			[Token(Token = "0x6003DCB")]
			[Address(RVA = "0x91F7F0", Offset = "0x91F7F0", VA = "0x91F7F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624DC8", Offset = "0x624DC8")]
			private void _003CResolveConflict_003Eb__8_1(AndroidJavaObject exception)
			{
			}

			[Token(Token = "0x6003DCC")]
			[Address(RVA = "0x91F9C0", Offset = "0x91F9C0", VA = "0x91F9C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624DD8", Offset = "0x624DD8")]
			private void _003CChooseMetadata_003Eb__9_0(AndroidJavaObject dataOrConflict)
			{
			}

			[Token(Token = "0x6003DCD")]
			[Address(RVA = "0x91F9DC", Offset = "0x91F9DC", VA = "0x91F9DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624DE8", Offset = "0x624DE8")]
			private void _003CChooseMetadata_003Eb__9_1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59758C", Offset = "0x59758C")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40033C5")]
			[FieldOffset(Offset = "0x10")]
			public ConflictResolutionStrategy resolutionStrategy;

			[Token(Token = "0x40033C6")]
			[FieldOffset(Offset = "0x18")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			[Token(Token = "0x6003DCE")]
			[Address(RVA = "0x91D774", Offset = "0x91D774", VA = "0x91D774")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6003DCF")]
			[Address(RVA = "0x91D77C", Offset = "0x91D77C", VA = "0x91D77C")]
			internal void _003COpenWithAutomaticConflictResolution_003Eb__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}
		}

		[Token(Token = "0x20009B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59759C", Offset = "0x59759C")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x40033C7")]
			[FieldOffset(Offset = "0x10")]
			public AndroidSavedGameClient _003C_003E4__this;

			[Token(Token = "0x40033C8")]
			[FieldOffset(Offset = "0x18")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			[Token(Token = "0x40033C9")]
			[FieldOffset(Offset = "0x20")]
			public string filename;

			[Token(Token = "0x40033CA")]
			[FieldOffset(Offset = "0x28")]
			public DataSource source;

			[Token(Token = "0x40033CB")]
			[FieldOffset(Offset = "0x2C")]
			public ConflictResolutionStrategy resolutionStrategy;

			[Token(Token = "0x40033CC")]
			[FieldOffset(Offset = "0x30")]
			public bool prefetchDataOnConflict;

			[Token(Token = "0x40033CD")]
			[FieldOffset(Offset = "0x38")]
			public ConflictCallback conflictCallback;

			[Token(Token = "0x40033CE")]
			[FieldOffset(Offset = "0x40")]
			public Action _003C_003E9__2;

			[Token(Token = "0x6003DD0")]
			[Address(RVA = "0x91DB60", Offset = "0x91DB60", VA = "0x91DB60")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6003DD1")]
			[Address(RVA = "0x91DB68", Offset = "0x91DB68", VA = "0x91DB68")]
			internal void _003CInternalOpen_003Eb__0(AndroidJavaObject dataOrConflict)
			{
			}

			[Token(Token = "0x6003DD2")]
			[Address(RVA = "0x91E490", Offset = "0x91E490", VA = "0x91E490")]
			internal void _003CInternalOpen_003Eb__2()
			{
			}

			[Token(Token = "0x6003DD3")]
			[Address(RVA = "0x91E4C0", Offset = "0x91E4C0", VA = "0x91E4C0")]
			internal void _003CInternalOpen_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5975AC", Offset = "0x5975AC")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40033CF")]
			[FieldOffset(Offset = "0x10")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> callback;

			[Token(Token = "0x40033D0")]
			[FieldOffset(Offset = "0x18")]
			public AndroidSavedGameClient _003C_003E4__this;

			[Token(Token = "0x6003DD4")]
			[Address(RVA = "0x91E690", Offset = "0x91E690", VA = "0x91E690")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6003DD5")]
			[Address(RVA = "0x91E698", Offset = "0x91E698", VA = "0x91E698")]
			internal void _003CCommitUpdate_003Eb__0(AndroidJavaObject snapshotMetadata)
			{
			}

			[Token(Token = "0x6003DD6")]
			[Address(RVA = "0x91E780", Offset = "0x91E780", VA = "0x91E780")]
			internal void _003CCommitUpdate_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5975BC", Offset = "0x5975BC")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40033D1")]
			[FieldOffset(Offset = "0x10")]
			public Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback;

			[Token(Token = "0x40033D2")]
			[FieldOffset(Offset = "0x18")]
			public AndroidSavedGameClient _003C_003E4__this;

			[Token(Token = "0x6003DD7")]
			[Address(RVA = "0x91CAC4", Offset = "0x91CAC4", VA = "0x91CAC4")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6003DD8")]
			[Address(RVA = "0x91CACC", Offset = "0x91CACC", VA = "0x91CACC")]
			internal void _003CFetchAllSavedGames_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003DD9")]
			[Address(RVA = "0x91D238", Offset = "0x91D238", VA = "0x91D238")]
			internal void _003CFetchAllSavedGames_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5975CC", Offset = "0x5975CC")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x40033D3")]
			[FieldOffset(Offset = "0x10")]
			public AndroidSavedGameClient _003C_003E4__this;

			[Token(Token = "0x40033D4")]
			[FieldOffset(Offset = "0x18")]
			public Action<AndroidJavaObject> callback;

			[Token(Token = "0x6003DDA")]
			[Address(RVA = "0x91D44C", Offset = "0x91D44C", VA = "0x91D44C")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6003DDB")]
			[Address(RVA = "0x91D454", Offset = "0x91D454", VA = "0x91D454")]
			internal void _003CAddOnFailureListenerWithSignOut_003Eb__0(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x20009B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5975DC", Offset = "0x5975DC")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x40033D5")]
			[FieldOffset(Offset = "0x10")]
			public ConflictCallback conflictCallback;

			[Token(Token = "0x6003DDC")]
			[Address(RVA = "0x91D5D0", Offset = "0x91D5D0", VA = "0x91D5D0")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6003DDD")]
			[Address(RVA = "0x91D5D8", Offset = "0x91D5D8", VA = "0x91D5D8")]
			internal void _003CToOnGameThread_003Eb__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}
		}

		[Token(Token = "0x20009B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5975EC", Offset = "0x5975EC")]
		private sealed class _003C_003Ec__DisplayClass13_1
		{
			[Token(Token = "0x40033D6")]
			[FieldOffset(Offset = "0x10")]
			public IConflictResolver resolver;

			[Token(Token = "0x40033D7")]
			[FieldOffset(Offset = "0x18")]
			public ISavedGameMetadata original;

			[Token(Token = "0x40033D8")]
			[FieldOffset(Offset = "0x20")]
			public byte[] originalData;

			[Token(Token = "0x40033D9")]
			[FieldOffset(Offset = "0x28")]
			public ISavedGameMetadata unmerged;

			[Token(Token = "0x40033DA")]
			[FieldOffset(Offset = "0x30")]
			public byte[] unmergedData;

			[Token(Token = "0x40033DB")]
			[FieldOffset(Offset = "0x38")]
			public _003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003DDE")]
			[Address(RVA = "0x91D734", Offset = "0x91D734", VA = "0x91D734")]
			public _003C_003Ec__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6003DDF")]
			[Address(RVA = "0x91D73C", Offset = "0x91D73C", VA = "0x91D73C")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20009BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5975FC", Offset = "0x5975FC")]
		private sealed class _003C_003Ec__DisplayClass17_0<T1, T2>
		{
			[Token(Token = "0x40033DC")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> toConvert;

			[Token(Token = "0x6003DE0")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6003DE1")]
			internal void _003CToOnGameThread_003Eb__0(T1 val1, T2 val2)
			{
			}
		}

		[Token(Token = "0x20009BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59760C", Offset = "0x59760C")]
		private sealed class _003C_003Ec__DisplayClass17_1<T1, T2>
		{
			[Token(Token = "0x40033DD")]
			[FieldOffset(Offset = "0x0")]
			public T1 val1;

			[Token(Token = "0x40033DE")]
			[FieldOffset(Offset = "0x0")]
			public T2 val2;

			[Token(Token = "0x40033DF")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass17_0<T1, T2> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003DE2")]
			public _003C_003Ec__DisplayClass17_1()
			{
			}

			[Token(Token = "0x6003DE3")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex ValidFilenameRegex;

		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mSnapshotsClient;

		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0x18")]
		private AndroidClient mAndroidClient;

		[Token(Token = "0x6003DB8")]
		[Address(RVA = "0xD6A784", Offset = "0xD6A784", VA = "0xD6A784")]
		public AndroidSavedGameClient(AndroidClient androidClient, AndroidJavaObject account)
		{
		}

		[Token(Token = "0x6003DB9")]
		[Address(RVA = "0xD74F94", Offset = "0xD74F94", VA = "0xD74F94", Slot = "4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0xD756E4", Offset = "0xD756E4", VA = "0xD756E4", Slot = "5")]
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0xD7531C", Offset = "0xD7531C", VA = "0xD7531C")]
		private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0xD759A4", Offset = "0xD759A4", VA = "0xD759A4", Slot = "6")]
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0xD75D94", Offset = "0xD75D94", VA = "0xD75D94", Slot = "7")]
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0xD75F18", Offset = "0xD75F18", VA = "0xD75F18", Slot = "8")]
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0xD7713C", Offset = "0xD7713C", VA = "0xD7713C", Slot = "9")]
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0xD774B8", Offset = "0xD774B8", VA = "0xD774B8", Slot = "10")]
		public void Delete(ISavedGameMetadata metadata)
		{
		}

		[Token(Token = "0x6003DC1")]
		[Address(RVA = "0xD758D0", Offset = "0xD758D0", VA = "0xD758D0")]
		private void AddOnFailureListenerWithSignOut(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0xD751E4", Offset = "0xD751E4", VA = "0xD751E4")]
		private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback)
		{
			return null;
		}

		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0xD75290", Offset = "0xD75290", VA = "0xD75290")]
		internal static bool IsValidFilename(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0xD765F4", Offset = "0xD765F4", VA = "0xD765F4")]
		private static AndroidJavaObject AsMetadataChange(SavedGameMetadataUpdate update)
		{
			return null;
		}

		[Token(Token = "0x6003DC5")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
}
