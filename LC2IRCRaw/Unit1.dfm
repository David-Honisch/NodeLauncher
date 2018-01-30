object Form1: TForm1
  Left = 301
  Top = 255
  Width = 760
  Height = 600
  Caption = 'LC2RawIRCClient'
  Color = clBtnFace
  Font.Charset = ANSI_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Courier New'
  Font.Style = []
  Icon.Data = {
    0000010001002020100000000400E80200001600000028000000200000004000
    0000010004000000000000000000000000000000000010000000000000004978
    AC00A4BBD5008AA8CA00CBD8E700D8E2ED007D9EC400B1C5DB0097B2D000E5EC
    F300F2F5F9005681B200BECFE100638BB8007095BE00FFFFFF003C6EA600FFFF
    FFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFFFFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFF
    FFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFFFFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFF
    FFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFFFFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFF
    FFFFFFFFF0DFFFEEEEEEE4339EEEFFFF03EEEEEEEEE0FFEEE91CFFFFF2EEFFFF
    F7EEFFFA23EDFFEE60FFFFFFFF6EFFFFFDEEFFFFFF77FFE7FFF2B8EE41A6FFFF
    FDEEFFFFFFF2FFBFF04EEEEEEEE1FFFFFDEEFFFFFFFFFFAF08EEEEEEEEEEFFFF
    FDEEFFFFFFFFFFFF6EEEEEEEEEEEFFFFFDEEFFFFFFFFFFF0EEEEEEEEEEEEFFFF
    FDEEFFFFFFFFFFF5EEEEEEEEEEEEFFFFFDEEFFFFFFFFFFF1EEEEEEEEEEEEFFFF
    FDEEFFFFFFFFFFF1EEEEEEEEEEEEFFFFFDEEFFFFFFFFFFF1EEEEEEEEEEEEFFFF
    FDEEFFFFFFFFFFFDEEEEEEEEEEEEFFFFFDEEFFFFFFFFFF00EEEEEEEEEEEEFFFF
    FDEEFFFFFFFFFF1F4EEEEEEEEE8EFFFFF5EEFFFFFFFFFFED5EEEEEEEEE28FFFF
    F7EE0FFFFFFFFFE9529EEEEE42FBFFFFF3EE2FFFFFFFFFEEE6ACDDDFFFF2FFFF
    0DDDDFFFFFFFFFEEEEE315DD5114FFFFFFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFF
    FFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFFFFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFF
    FFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFFFFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFF
    FFFFFFFFFFFFFFEEEEEEEEEEEEEEFFFFFFFFFFFFFFFFFFEEEEEEEEEEEEEE0000
    0000000000000000000000000000000000000000000000000000000000000000
    0000000000000000000000000000000000000000000000000000000000000000
    0000000000000000000000000000000000000000000000000000000000000000
    000000000000000000000000000000000000000000000000000000000000}
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 14
  object Memo1: TMemo
    Left = 0
    Top = 41
    Width = 752
    Height = 507
    Align = alClient
    TabOrder = 0
  end
  object Panel1: TPanel
    Left = 0
    Top = 0
    Width = 752
    Height = 41
    Align = alTop
    Caption = 'Panel1'
    TabOrder = 1
    object GroupBox1: TGroupBox
      Left = 1
      Top = 1
      Width = 736
      Height = 35
      TabOrder = 0
      object Button1: TButton
        Left = 4
        Top = 10
        Width = 89
        Height = 22
        Caption = 'Verbinde zu'
        TabOrder = 0
        OnClick = Button1Click
      end
      object Edit1: TEdit
        Left = 92
        Top = 10
        Width = 169
        Height = 22
        TabOrder = 1
        Text = 'irc.dal.net'
      end
      object Edit2: TEdit
        Left = 260
        Top = 10
        Width = 81
        Height = 22
        TabOrder = 2
        Text = '6667'
      end
      object Edit4: TEdit
        Left = 412
        Top = 10
        Width = 97
        Height = 22
        TabOrder = 3
        Text = 'channel'
      end
      object Button3: TButton
        Left = 340
        Top = 10
        Width = 75
        Height = 24
        Caption = 'Kanal'
        TabOrder = 4
      end
    end
  end
  object Panel2: TPanel
    Left = 0
    Top = 548
    Width = 752
    Height = 25
    Align = alBottom
    Caption = 'Panel2'
    TabOrder = 2
    object Edit3: TEdit
      Left = 136
      Top = 3
      Width = 593
      Height = 22
      TabOrder = 0
    end
    object Button2: TButton
      Left = 8
      Top = 2
      Width = 113
      Height = 23
      Caption = 'Send Command'
      TabOrder = 1
      OnClick = Button2Click
    end
  end
  object ClientSocket1: TClientSocket
    Active = False
    ClientType = ctNonBlocking
    Port = 0
    OnConnect = ClientSocket1Connect
    OnRead = ClientSocket1Read
    Left = 16
    Top = 48
  end
end
