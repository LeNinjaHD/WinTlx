﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTlx.Languages
{
	class LanguageDeutsch
	{
		public static Language GetLng()
		{
			Language lng = new Language("de", "Deutsch");
			lng.Items = new Dictionary<LngKeys, string>
			{
				{ LngKeys.Start_Text, "Bitte beachte, dass dies ein Test- und Diagnose-Tool für das i-Telex-Netzwerk ist. " +
					"Die Teilnehmer habe reale Fernschreiber angeschlossen. " +
					"Sende bitte keine längeren Texte oder Spam an i-Telex-Nummern!" },

				{ LngKeys.MainForm_SearchText, "Suchtext" },
				{ LngKeys.MainForm_SearchResult, "Ergebnisse (auswählen)" },
				{ LngKeys.MainForm_SearchButton, "Suchen" },
				{ LngKeys.MainForm_Answerback, "Kennung" },
				{ LngKeys.MainForm_Address, "Adresse" },
				{ LngKeys.MainForm_Port, "Port" },
				{ LngKeys.MainForm_Extension, "Extension" },
				{ LngKeys.MainForm_Itelex, "i-Telex" },
				{ LngKeys.MainForm_ASCII, "ASCII" },
				{ LngKeys.MainForm_ConnectButton, "Verbinden" },
				{ LngKeys.MainForm_DisconnectButton, "Trennen" },
				{ LngKeys.MainForm_LocalButton, "Lokal" },
				{ LngKeys.MainForm_SendWruButton, "WRU" },
				{ LngKeys.MainForm_SendHereisButton, "Hier ist" },
				{ LngKeys.MainForm_SendLettersButton, "Bu" },
				{ LngKeys.MainForm_SendFiguresButton, "Zi" },
				{ LngKeys.MainForm_SendReturnButton, "<" },
				{ LngKeys.MainForm_SendLinefeedButton, "\u2261" },
				{ LngKeys.MainForm_SendBellButton, "Klingel" },
				{ LngKeys.MainForm_SendNullButton, "....." },
				{ LngKeys.MainForm_SendTimeButton, "Zeit" },
				{ LngKeys.MainForm_SendRyButton, "RY" },
				{ LngKeys.MainForm_SendPanButton, "Quax" },
				{ LngKeys.MainForm_ClearButton, "Löschen" },
				{ LngKeys.MainForm_SendfileButton, "Datei senden" },
				{ LngKeys.MainForm_RecvOnButton, "Empfang" },
				{ LngKeys.MainForm_UpdateIpAddressButton, "Update IP" },
				{ LngKeys.MainForm_TapePunchButton, "Lochstreifen" },
				{ LngKeys.MainForm_EyeBallCharsButton, "Bildlocher" },
				{ LngKeys.MainForm_ConfigButton, "Einstellungen" },
				{ LngKeys.MainForm_AboutButton, "Info" },
				{ LngKeys.MainForm_ExitButton, "Beenden" },

				{ LngKeys.Setup_Setup, "Einstellungen" },
				{ LngKeys.Setup_General, "Allgemein" },
				{ LngKeys.Setup_Language, "Sprache / Language" },
				{ LngKeys.Setup_LogfilePath, "Logfile-Pfad" },
				{ LngKeys.Setup_Answerback, "Kennungsgeber" },
				{ LngKeys.Setup_IdleTimeout, "Inaktivitäts-Timeout" },
				{ LngKeys.Setup_OutputSpeed, "Ausgabegeschw. (Baud)" },
				{ LngKeys.Setup_CodeStandard, "Code-Standard" },
				{ LngKeys.Setup_SubscribeServer, "Teilnehmer-Server" },
				{ LngKeys.Setup_SubscribeServerAddress, "Server-Adresse" },
				{ LngKeys.Setup_SubscribeServerPort, "Server-Port" },
				{ LngKeys.Setup_IncomingConnection, "Eingehende Verbindungen" },
				{ LngKeys.Setup_SubscribeServerPin, "Teilnehmer-Server-Pin" },
				{ LngKeys.Setup_OwnTelexNumber, "Telex-Nummer" },
				{ LngKeys.Setup_ExtensionNumber, "Extension-Nummer" },
				{ LngKeys.Setup_IncomingLocalPort, "Lokaler Port" },
				{ LngKeys.Setup_IncomingPublicPort, "Öffentlicher Port" },
				{ LngKeys.Setup_CancelButton, "Abbruch" },
				{ LngKeys.Setup_SaveButton, "Speichern" },

				{ LngKeys.SendFile_SendFile, "Textdatei senden" },
				{ LngKeys.SendFile_LoadFile, "Datei laden" },
				{ LngKeys.SendFile_LineLength, "Zeilenlänge" },
				{ LngKeys.SendFile_Cropping, "Begrenzung" },
				{ LngKeys.SendFile_CroppingRight, "rechts" },
				{ LngKeys.SendFile_CroppingCenter, "zentriert" },
				{ LngKeys.SendFile_CroppingLeft, "links" },
				{ LngKeys.SendFile_Convert, "Konvertieren" },
				{ LngKeys.SendFile_SendButton, "Senden" },
				{ LngKeys.SendFile_CancelButton, "Abbrechen" },

				{ LngKeys.TapePunch_TapePunch, "Lochstreifen" },
				{ LngKeys.TapePunch_OnButton, "Ein" },
				{ LngKeys.TapePunch_OffButton, "Aus" },
				{ LngKeys.TapePunch_ClearButton, "Löschen" },
				{ LngKeys.TapePunch_CloseButton, "Schließen" },
				{ LngKeys.TapePunch_CodeLetters, "BU" },
				{ LngKeys.TapePunch_CodeFigures, "ZI" },
				{ LngKeys.TapePunch_CodeCarriageReturn, "<" },
				{ LngKeys.TapePunch_CodeLinefeed, "\u2261" },

				{ LngKeys.Scheduler_Scheduler, "Zeitplaner" },
				{ LngKeys.Scheduler_AddEntry, "Neuer Eintrag" },
				{ LngKeys.Scheduler_CopyEntry, "Eintrag kopieren" },
				{ LngKeys.Scheduler_DeleteEntry, "Eintrag löschen" },
				{ LngKeys.Scheduler_CloseButton, "Schliessen" },
				{ LngKeys.Scheduler_ActiveRow, "Aktiv" },
				{ LngKeys.Scheduler_SuccessRow, "Erfolg" },
				{ LngKeys.Scheduler_ErrorRow, "Fehler" },
				{ LngKeys.Scheduler_DateRow, "Datum" },
				{ LngKeys.Scheduler_TimeRow, "Zeit" },
				{ LngKeys.Scheduler_DestRow, "Nummer oder Host;Port;Extension" },
				{ LngKeys.Scheduler_FileRow, "Textdatei" },

				{ LngKeys.Message_Connected, "verbunden" },
				{ LngKeys.Message_Disconnected, "getrennt" },
				{ LngKeys.Message_Reject, "reject" },
				{ LngKeys.Message_IdleTimeout, "inaktivitaetstimeout" },
				{ LngKeys.Message_IncomingConnection, "eingehende verbindung" },
				{ LngKeys.Message_SubscribeServerError, "tln.-server-fehler" },
				{ LngKeys.Message_InvalidSubscribeServerData, "ungueltige tln.-server adresse oder port" },
				{ LngKeys.Message_QueryResult, "eintraege gefunden" },
				{ LngKeys.Message_ConnectNoAddress, "adresse fehlt" },
				{ LngKeys.Message_ConnectInvalidPort, "ungueltiger port" },
				{ LngKeys.Message_ConnectInvalidExtension, "ungueltige extension-nummer" },
				{ LngKeys.Message_ConnectionError, "verbindungsfehler" },
				{ LngKeys.Message_Pangram, "prall vom whisky flog quax den jet zu bruch. 1234567890/(:-),=?" },
				{ LngKeys.Message_EyeballCharActive, "bildlocher aktiv - starte lochstreifenstanzer" },
			};

			return lng;
		}
	}
}
