program lc2ircraw;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'LC2IRCRaw';
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
