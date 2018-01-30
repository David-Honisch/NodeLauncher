unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ScktComp, StdCtrls, ExtCtrls;
function Hex(strData:string): string;

type
  TForm1 = class(TForm)
    Memo1: TMemo;
    ClientSocket1: TClientSocket;
    Panel1: TPanel;
    GroupBox1: TGroupBox;
    Button1: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit4: TEdit;
    Button3: TButton;
    Panel2: TPanel;
    Edit3: TEdit;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure ClientSocket1Read(Sender: TObject; Socket: TCustomWinSocket);
    procedure ClientSocket1Connect(Sender: TObject;
      Socket: TCustomWinSocket);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

function Hex(strData:string): string;
var sresult:string; sfinal:string; hexc:cardinal; i:integer;
begin
  i:=1;
  while i<=length(strData) do
    begin
      hexc := strtoint('$' + copy(strData,i,2));  
      sresult :=  inttostr(hexc);
      sresult := chr(strtoint(sresult));
      sfinal := sfinal + sresult;
      i:=i+2;
    end;
  result := sfinal
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
clientsocket1.Host:=edit1.text;
clientsocket1.Port:=strtoint(edit2.Text);
clientsocket1.active:=true;
end;

procedure TForm1.ClientSocket1Read(Sender: TObject;
  Socket: TCustomWinSocket);
var
  ipacket:string; idata:string;
begin
idata:=clientsocket1.Socket.ReceiveText;
memo1.Text:=memo1.text + idata;

if pos('PING',idata) <> 0 then
begin
clientsocket1.Socket.SendText('PONG :' + copy(idata,pos(':',idata) + 1,length(idata) - pos(':',idata)) + hex('0A'));
memo1.Text:=memo1.Text+'OUT: ' + 'PONG :' + copy(idata,pos(':',idata) + 1,length(idata) - pos(':',idata)) + hex('0A');
end;

memo1.SelLength := length(memo1.Text);
memo1.SelStart := length(memo1.Text);
end;

procedure TForm1.ClientSocket1Connect(Sender: TObject;
  Socket: TCustomWinSocket);
begin
clientsocket1.Socket.SendText('NICK Delphi-TestUser' + hex('0A'));
clientsocket1.Socket.SendText('USER Delphi "' + clientsocket1.Socket.LocalAddress + '" "' + clientsocket1.Socket.RemoteHost + '" :Delphi Test' + hex('0A'));
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
// The two commands that are most useful
with clientsocket1.Socket do
begin
  if lowercase(copy(edit3.Text,1,5)) = '/join' then
    begin
    sendtext('JOIN ' + copy(edit3.text,6,length(edit3.Text)  - 5) + hex('0A'));
    memo1.text:=memo1.Text + 'OUT: JOIN ' + copy(edit3.text,6,length(edit3.Text)  - 5) + #13 + #10;
    end
  else if lowercase(copy(edit3.Text,1,4)) = '/msg' then
    begin
    sendtext('PRIVMSG ' + copy(edit3.text,5,length(edit3.Text)  - 4) + hex('0A'));
    memo1.text:=memo1.Text + 'OUT: PRIVMSG ' + copy(edit3.text,6,length(edit3.Text)  - 4) + #13 + #10;
    end
  else
    begin
    sendtext(edit3.Text + hex('0A'));
    memo1.Text:=memo1.Text + 'OUT: ' + edit3.Text + #13 + #10;
    end;
end;

memo1.SelLength := length(memo1.Text);
memo1.SelStart := length(memo1.Text);
end;

end.
