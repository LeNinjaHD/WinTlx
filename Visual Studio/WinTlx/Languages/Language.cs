﻿using System;
using System.Collections.Generic;

namespace WinTlx.Languages
{
	public enum LngKeys
	{
		Invalid,

		Start_Text,
		NoFunction_ToolTip,

		MainForm_SearchText,
		MainForm_SearchText_ToolTip,
		MainForm_SearchResult,
		MainForm_SearchButton,
		MainForm_SearchButton_ToolTip,
		MainForm_Answerback,
		MainForm_Answerback_ToolTip,
		MainForm_Address,
		MainForm_Port,
		MainForm_Extension,
		MainForm_PeerType,
		MainForm_Itelex,
		MainForm_ASCII,
		MainForm_ConnectButton,
		MainForm_DisconnectButton,
		MainForm_LocalButton,
		MainForm_SendWruButton,
		MainForm_SendHereisButton,
		MainForm_SendLettersButton,
		MainForm_SendFiguresButton,
		MainForm_SendReturnButton,
		MainForm_SendLinefeedButton,
		MainForm_SendBellButton,
		MainForm_SendNullButton,
		MainForm_SendNullButton_ToolTip,
		MainForm_SendTimeButton,
		MainForm_SendRyButton,
		MainForm_SendPanButton,
		MainForm_ClearButton,
		MainForm_ClearButton_ToolTip,
		MainForm_EditorButton,
		MainForm_EditorButton_ToolTip,
		MainForm_RecvOnButton,
		MainForm_RecvOnButton_ToolTip,
		MainForm_UpdateIpAddressButton,
		MainForm_UpdateIpAddressButton_ToolTip,
		MainForm_TapePunchButton,
		MainForm_TapePunchButton_ToolTip,
		MainForm_EyeBallCharsButton,
		MainForm_EyeBallCharsButton_ToolTip,
		MainForm_ConfigButton,
		MainForm_AboutButton,
		MainForm_ExitButton,

		Setup_Setup,
		Setup_General,
		Setup_LogfilePath,
		Setup_Language,
		Setup_Answerback,
		Setup_IdleTimeout,
		Setup_OutputSpeed,
		Setup_CodeSet,
		Setup_SubscribeServer,
		Setup_SubscribeServerAddress,
		Setup_SubscribeServerPort,
		Setup_IncomingConnection,
		Setup_SubscribeServerPin,
		Setup_OwnTelexNumber,
		Setup_ExtensionNumber,
		Setup_IncomingLocalPort,
		Setup_IncomingPublicPort,
		Setup_LimitedClient,
		Setup_ServerDataHint,
		Setup_CancelButton,
		Setup_SaveButton,

		SendFile_SendFile,
		SendFile_LoadFile,
		SendFile_LineLength,
		SendFile_Cropping,
		SendFile_CroppingRight,
		SendFile_CroppingCenter,
		SendFile_CroppingLeft,
		SendFile_Convert,
		SendFile_SendButton,
		SendFile_CancelButton,

		TapePunch_TapePunch,
		TapePunch_RecvButton,
		TapePunch_RecvButton_ToolTip,
		TapePunch_SendButton,
		TapePunch_SendButton_ToolTip,
		TapePunch_ClearButton,
		TapePunch_ClearButton_ToolTip,
		TapePunch_LoadButton,
		TapePunch_LoadButton_ToolTip,
		TapePunch_SaveButton,
		TapePunch_SaveButton_ToolTip,
		TapePunch_EditButton,
		TapePunch_EditButton_ToolTip,
		TapePunch_InsertButton,
		TapePunch_InsertButton_ToolTip,
		TapePunch_DeleteButton,
		TapePunch_DeleteButton_ToolTip,
		TapePunch_CropStartButton_ToolTip,
		TapePunch_CropEndButton_ToolTip,
		TapePunch_CloseButton,
		TapePunch_CodeLetters,
		TapePunch_CodeFigures,
		TapePunch_CodeCarriageReturn,
		TapePunch_CodeLinefeed,

		Scheduler_Scheduler,
		Scheduler_AddEntry,
		Scheduler_CopyEntry,
		Scheduler_DeleteEntry,
		Scheduler_CloseButton,
		Scheduler_ActiveRow,
		Scheduler_SuccessRow,
		Scheduler_ErrorRow,
		Scheduler_DateRow,
		Scheduler_TimeRow,
		Scheduler_DestRow,
		Scheduler_FileRow,

		Message_Connected,
		Message_Disconnected,
		Message_Reject,
		Message_IdleTimeout,
		Message_IncomingConnection,
		Message_SubscribeServerError,
		Message_InvalidSubscribeServerData,
		Message_QueryResult,
		Message_ConnectNoAddress,
		Message_ConnectInvalidPort,
		Message_ConnectInvalidExtension,
		Message_ConnectionError,
		Message_Pangram,
		Message_EyeballCharActive,

		Editor_Header,
		Editor_Clear,
		Editor_Load,
		Editor_Save,
		Editor_Send,
		Editor_Close,
		Editor_ConvBaudot,
		Editor_ConvRtty,
		Editor_AlignBlock,
		Editor_AlignLeft,
		Editor_ShiftLeft,
		Editor_ShiftRight,
		Editor_LineNr,
		Editor_ColumnNr,
		Editor_CharWidth,
		Editor_NotSavedHeader,
		Editor_NotSavedMessage,
		Editor_LoadError,
		Editor_SaveError,
		Editor_Error,
	}

	class Language
	{
		public string Key { get; set; }

		public string Version { get; set; }

		public string DisplayName { get; set; }

		public Dictionary<LngKeys, string> Items { get; set; }

		public Language()
		{
			Items = new Dictionary<LngKeys, string>();
		}

		public Language(string key, string displayName)
		{
			Key = key;
			DisplayName = displayName;
			Items = new Dictionary<LngKeys, string>();
		}

		public static LngKeys StringToLngKey(string keyStr)
		{
			if (Enum.TryParse(keyStr, true, out LngKeys lngKey))
			{
				return lngKey;
			}
			else
			{
				return LngKeys.Invalid;
			}
		}

		public override string ToString()
		{
			return $"{Key} {DisplayName} {Items?.Count}";
		}
	}
}
