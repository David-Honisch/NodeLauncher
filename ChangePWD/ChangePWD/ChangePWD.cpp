//// ChangePWD.cpp : Defines the entry point for the console application.
////
//
//#include "stdafx.h"
//
//
//int main()
//{
//    return 0;
//}
//
#include "stdafx.h"
#include <iostream>
#include <windows.h>
#include <cstring>
#include <cstdlib>

#include <atlbase.h>
#include <atlconv.h>

using namespace std;


void gotoxy(short int, short int);
void maximizeConsoleWindow();
void changeWindowsPassword();
void showCredits();
void showWindowsCommandPrompt();


void init()
{

	int selection = 0;
	string title = "LC2PasswordChanger Utility for Microsoft Windows  By David Honisch";
	std::wstring stemp = std::wstring(title.begin(), title.end());
	SetConsoleTitle((LPCWSTR)stemp.c_str());
	menu:
	cout << "LC2PasswordChanger reading User Accounts" << endl;
	selection = 0;
	cout << "\t\t\t\tloading..." << endl;
	cout << "Visit http://www.letztechance.org";
	cout << system("net user") ? "Error 2.\n" : " Ok\n";

	cout << "Please Choose your option\n";
	cout << "1.Command Prompt\n"
		"2.Change Password\n"
		"3.Credits\n"
		"4.enable/disable Full Screen\n"
		"5.Regedit\n"
		"6.gpedit.msc\n"
		"7.enable regedit\n"
		"8.services.msc\n"
		"11.compmgmt.msc\n"
		"12.Exit\n";

	cin >> selection;

	switch (selection)
	{
	case 1:
		showWindowsCommandPrompt();
		break;

	case 2:
		changeWindowsPassword();
		break;

	case 3:
		showCredits();
		break;


	case 4:
		maximizeConsoleWindow();
		break;

	case 5:
		system("Regedit");
		break;

	case 6:
		system("gpedit.msc");
		break;

	case 7:
		system("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 0 /f");
		break;


	case 8:
		system("services.msc");
		break;

	case 11:
		system("compmgmt.msc");
		break;

	case 12:
		return;
		break;

	case '\n':
	case '\r':
	case '\t':
		break;

	default:
		cout << "wrong input !\n";
		break;

	}
	//Sleep(100);
	//system("cls");
	//goto menu;
	//return 0;
}

int main()
{
	init();
	return 0;
}

void gotoxy(short int x, short int y)
{
	COORD coord;
	coord.X = x;
	coord.X = y;

	HANDLE hout;
	hout = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleCursorPosition(hout, coord);
}

void maximizeConsoleWindow()
{
	HANDLE hConsole;
	COORD size;
	HWND hWnd;
	string title = "LC2PasswordChanger v.1.0";
	std::wstring stitle = std::wstring(title.begin(), title.end());
	string pattern = "LC2PasswordChanger";
	std::wstring spattern = std::wstring(pattern.begin(), pattern.end());

	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	size = GetLargestConsoleWindowSize(hConsole);
	SetConsoleScreenBufferSize(hConsole, size);
	
	SetConsoleTitle((LPCWSTR)stitle.c_str());
	hWnd = FindWindow(NULL, (LPCWSTR)spattern.c_str());
	SendMessage(hWnd, WM_SYSKEYDOWN,
		VK_RETURN, 0xFF000000);

	ShowWindow(hWnd, SW_MAXIMIZE);
}

void changeWindowsPassword()
{

	char  str[] = "net user";
	char  str2[50];
	char  pass[50];
	char str3[500];

	cout << "\t\t\tLC2PasswordChanger\n";

	cout << "\n\nCurrent System user Accounts...\n";

	//system("net user");
	if (system("net user"))
	{

		strcpy_s(str3, str);
		strcat_s(str3, " ");

		cout << "\nPlease enter one of  The usernames above\n";
		cin >> str2;


		strcat_s(str3, str2);


		cout << "\nEnter Your desired Password\n";
		cin >> pass;




		strcat_s(str3, " ");
		strcat_s(str3, pass);

		cout << "\ncommand  is:" << str3 << endl;

		system(str3);
		Sleep(5000);
		//system("cmd");
		cout << "\nPassword has been changed log off and then on with the new password\n";
	}
	else
		cout << "command scripting is disabled,application stoped!\n";

}


void showCredits()
{
	cout << "\n\n\n\n\t\t     Code by David Honisch\n";
	cout << "\t\t    Email: webmaster@letztechance.org\n";
	cout << "\t\t\t June 15 2018 Cologne,Germany\n\n\n\n";
	system("pause");
}

void showWindowsCommandPrompt()
{
	cout << "\t\t\tWindows Command Prompt\n"
		"\t\t      To Exit cmd mode Type \"exit\"\n\n";
	system("cmd");
}