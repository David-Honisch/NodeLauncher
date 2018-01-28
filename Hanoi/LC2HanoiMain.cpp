/**
 *
 */
#include <windows.h> // for DLL usage
#include <stdio.h>
#include <string> 

#include ".\include\config\lc2config.h"
#include ".\include\config\lc2config.cpp"

#include ".\include\control\lc2control.h"
#include ".\include\control\lc2control.cpp"


using namespace std;

/**
 *
 */
string cwd = "c:\\";
int getBox(LC2CONTROL ctrl, LC2Config cfg) {
	string text = "LC2Hanoni";
	ctrl.doLoadConfig((char *)cfg.getDLLCore(), "showMessageBox",
		(char *)text.c_str());
}
;

/**
 *
 */
int doDLLPrint(LC2CONTROL ctrl, LC2Config cfg) {
	string dll = cwd;
	dll += "\\";
	dll += cfg.getDLLCore();
	string
		text =
		"LetzteChance.Org - LC2C++HanoiConsole\nC++ powered Plugin Library by\nDavid Honisch";
	int i = ctrl.doDLLPrint((char *)dll.c_str(), "doPrint",
		(char *)text.c_str());
	printf("\n");
}
/**
 *
 */
int getInput(LC2CONTROL ctrl, LC2Config cfg) {
	cfg.setConsoleColor(15, 0);
	string dll = cwd;
	dll += "\\";
	dll += cfg.getDLLCore();
	ctrl.getConsoleInput((char *)dll.c_str(), "getConsoleInput", "Input");
}
/**
 *
 */
int print(LC2CONTROL ctrl, LC2Config cfg) {

	cfg.setConsoleColor(4, 0);
	string dll = cwd;
	dll += "\\";
	dll += cfg.getDLLCore();
	string
		text =
		"LetzteChance.Org - LC2C++HanoiConsole\nC++ powered Plugin Library by\nDavid Honisch";
	int i = ctrl.doDLLPrint((char *)dll.c_str(), "doPrintResult",
		(char *)text.c_str());
	//printf("\n");
	printf("\n");
	cfg.setConsoleColor(12, 0);
	cfg.printSysInfo();
	printf(cfg.getWindowsDirectory().c_str());
	printf(cfg.getWindowsSystemDirectory().c_str());
	printf(cfg.getTempPath().c_str());
}
/**
 *
 */
int play(LC2CONTROL ctrl, LC2Config cfg) {

	cfg.setConsoleColor(4, 0);
	string dll = cwd;
	dll += "\\";
	dll += cfg.getDLLmci();
	if (ctrl.doDLLPrint((char *)dll.c_str(), "setMCISendString",
		"play snd.mid") != 0) {
		printf("No instruments played. Please check your devices.");
	}
}
/**
 *
 */
int playBye(LC2CONTROL ctrl, LC2Config cfg) {

	cfg.setConsoleColor(15, 0);
	string dll = cwd;
	dll += "\\";
	dll += cfg.getDLLmci();
	if (ctrl.doDLLPrint((char *)dll.c_str(), "setMCISendString",
		"stop snd.mid") != 0) {
		printf(
			"Can´t stop playing instruments stopped. Damn, please check your devices.");
	}

	if (ctrl.doDLLPrint((char *)dll.c_str(), "doPlayInstruments", "") != 0) {
		printf("No instruments played. Please check your devices.");
	}
}
/**
 *
 */
int printHead(LC2CONTROL ctrl, LC2Config cfg) {

	cfg.setConsoleColor(4, 0);
	doDLLPrint(ctrl, cfg);
}
/**
 *
 */
int Init(LC2Config cfg, int argc, char *argv[]) {
	cwd = (cfg.getCWD()).c_str();
	//printf("%s\n", cwd.c_str());
	//system("PAUSE");
}
/**
 *
 */
int main(int argc, char *argv[]) {
	LC2CONTROL ctrl;
	LC2Config cfg;
	Init(cfg, argc, argv);
	play(ctrl, cfg);
	printHead(ctrl, cfg);
	getInput(ctrl, cfg);
	//cfg.doReadDireotory((char *)cfg.getDLLConfig(),"parseDirectory","d:\\");
	//cfg.doReadDireotory((char *)cfg.getDLLCore(),"parseDirectory","d:\\");
	print(ctrl, cfg);

	printf("\n");
	system("PAUSE");
	printf("\nLet´s play some MCI instruments...");
	playBye(ctrl, cfg);
	printf("\nHave your heard 128 instruments ?\n");
	system("PAUSE");
	return EXIT_SUCCESS;
}