\ derived from TFT_8050A project by
\ Michael Damkier
\ Hamburg, Germany
\ (michael@vondervotteimittiss.com)

\ FLUKE 8050A

120 constant splashFlukeX
41  constant splashFlukeY
create splashFluke
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $0F c,
  $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $0F c,
  $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $0F c,
  $F1 c, $FF c, $FF c, $8E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $E0 c, $0F c, $C7 c, $FF c, $FF c, $0F c,
  $F1 c, $FF c, $FF c, $8E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $E0 c, $3F c, $07 c, $FF c, $FF c, $0F c,
  $F1 c, $FF c, $FF c, $8E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $E0 c, $7E c, $07 c, $FF c, $FF c, $0F c,
  $F1 c, $E0 c, $00 c, $0E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $E1 c, $F8 c, $07 c, $80 c, $00 c, $0F c,
  $F1 c, $E0 c, $00 c, $0E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $E7 c, $F0 c, $07 c, $80 c, $00 c, $0F c,
  $F1 c, $E0 c, $00 c, $0E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $EF c, $C0 c, $07 c, $80 c, $00 c, $0F c,
  $F1 c, $FF c, $FF c, $8E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $FF c, $00 c, $07 c, $FF c, $FF c, $0F c,
  $F1 c, $FF c, $FF c, $8E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $FE c, $00 c, $07 c, $FF c, $FF c, $0F c,
  $F1 c, $FF c, $FF c, $8E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $FE c, $00 c, $07 c, $FF c, $FF c, $0F c,
  $F1 c, $E0 c, $00 c, $0E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $FF c, $C0 c, $07 c, $80 c, $00 c, $0F c,
  $F1 c, $E0 c, $00 c, $0E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $EF c, $E0 c, $07 c, $80 c, $00 c, $0F c,
  $F1 c, $E0 c, $00 c, $0E c, $00 c, $07 c, $80 c, $01 c, $E1 c, $E3 c, $F8 c, $07 c, $80 c, $00 c, $0F c,
  $F1 c, $E0 c, $00 c, $0F c, $FF c, $E7 c, $FF c, $FF c, $E1 c, $E0 c, $FE c, $07 c, $FF c, $FF c, $0F c,
  $F1 c, $E0 c, $00 c, $0F c, $FF c, $E3 c, $FF c, $FF c, $C1 c, $E0 c, $3F c, $07 c, $FF c, $FF c, $0F c,
  $F1 c, $E0 c, $00 c, $0F c, $FF c, $E3 c, $FF c, $FF c, $C1 c, $E0 c, $0F c, $C7 c, $FF c, $FF c, $0F c,
  $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $0F c,
  $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $0F c,
  $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $0F c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
  $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
  $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,
  $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c, $FF c,

\ 8050A GRAPHIC
236 constant splashNameX
23  constant splashNameY
create splashName
$07 c, $C0 c, $01 c, $F8 c, $00 c, $1F c, $F0 c, $07 c, $E0 c, $00 c, $04 c, $00 c, $00 c, $00 c, $1F c, $C0 c, $07 c,
 $F8 c, $00 c, $01 c, $00 c, $07 c, $F8 c, $07 c, $00 c, $38 c, $1C c, $00 c, $1F c, $C0 c,
$1F c, $F0 c, $03 c, $FC c, $00 c, $3F c, $F0 c, $0F c, $F0 c, $00 c, $0C c, $00 c, $00 c, $00 c, $FF c, $F0 c, $07 c,
 $FE c, $00 c, $03 c, $00 c, $07 c, $FE c, $07 c, $00 c, $38 c, $1C c, $00 c, $7F c, $F0 c,
$3F c, $F8 c, $07 c, $FE c, $00 c, $3F c, $F0 c, $1F c, $F8 c, $00 c, $0E c, $00 c, $00 c, $01 c, $FF c, $FC c, $07 c,
 $FF c, $00 c, $03 c, $80 c, $07 c, $FF c, $07 c, $00 c, $38 c, $1C c, $01 c, $FF c, $F0 c,
$3C c, $78 c, $0F c, $0F c, $00 c, $38 c, $00 c, $3C c, $3C c, $00 c, $1E c, $00 c, $00 c, $03 c, $E0 c, $7E c, $07 c,
 $0F c, $00 c, $07 c, $80 c, $07 c, $0F c, $07 c, $00 c, $38 c, $1C c, $03 c, $E0 c, $75 c,
$78 c, $3C c, $1E c, $07 c, $80 c, $78 c, $00 c, $78 c, $1E c, $00 c, $1F c, $00 c, $00 c, $07 c, $C0 c, $1F c, $07 c,
 $07 c, $80 c, $07 c, $C0 c, $07 c, $07 c, $87 c, $00 c, $38 c, $1C c, $07 c, $C0 c, $10 c,
$70 c, $1C c, $1C c, $03 c, $80 c, $70 c, $00 c, $70 c, $0E c, $00 c, $3F c, $00 c, $00 c, $0F c, $00 c, $0C c, $07 c,
 $03 c, $80 c, $0F c, $C0 c, $07 c, $03 c, $87 c, $00 c, $38 c, $1C c, $07 c, $00 c, $0F c,
$70 c, $1C c, $1C c, $03 c, $80 c, $70 c, $00 c, $70 c, $0E c, $00 c, $3F c, $80 c, $00 c, $0F c, $00 c, $08 c, $07 c,
 $03 c, $80 c, $0F c, $E0 c, $07 c, $03 c, $87 c, $00 c, $38 c, $1C c, $0F c, $00 c, $09 c,
$70 c, $1C c, $3C c, $03 c, $C0 c, $70 c, $00 c, $F0 c, $0F c, $00 c, $7B c, $80 c, $00 c, $0E c, $00 c, $00 c, $07 c,
 $03 c, $80 c, $1E c, $E0 c, $07 c, $03 c, $87 c, $00 c, $38 c, $1C c, $0E c, $00 c, $00 c,
$78 c, $3C c, $38 c, $01 c, $C0 c, $FF c, $00 c, $E0 c, $07 c, $00 c, $73 c, $C0 c, $00 c, $1C c, $00 c, $00 c, $07 c,
 $07 c, $80 c, $1C c, $F0 c, $07 c, $03 c, $87 c, $00 c, $38 c, $1C c, $1E c, $00 c, $04 c,
$3C c, $78 c, $38 c, $01 c, $C0 c, $FF c, $80 c, $E0 c, $07 c, $00 c, $F1 c, $C0 c, $00 c, $1C c, $00 c, $00 c, $07 c,
 $0F c, $00 c, $3C c, $70 c, $07 c, $07 c, $87 c, $FF c, $F8 c, $1C c, $1C c, $00 c, $05 c,
$1F c, $F0 c, $38 c, $01 c, $C0 c, $FF c, $C0 c, $E0 c, $07 c, $00 c, $E1 c, $C0 c, $00 c, $1C c, $00 c, $00 c, $07 c,
 $FF c, $00 c, $38 c, $70 c, $07 c, $0F c, $07 c, $FF c, $F8 c, $1C c, $1C c, $00 c, $05 c,
$1F c, $F0 c, $38 c, $01 c, $C0 c, $C3 c, $E0 c, $E0 c, $07 c, $01 c, $E0 c, $E0 c, $00 c, $1C c, $01 c, $FF c, $87 c,
 $FE c, $00 c, $78 c, $38 c, $07 c, $FF c, $07 c, $FF c, $F8 c, $1C c, $1C c, $00 c, $05 c,
$7F c, $F8 c, $38 c, $01 c, $C1 c, $80 c, $F0 c, $E0 c, $07 c, $01 c, $C0 c, $E0 c, $00 c, $1C c, $01 c, $FF c, $87 c,
 $FC c, $00 c, $70 c, $38 c, $07 c, $FE c, $07 c, $00 c, $38 c, $1C c, $1C c, $00 c, $00 c,
$78 c, $7C c, $38 c, $01 c, $C0 c, $00 c, $70 c, $E0 c, $07 c, $01 c, $C0 c, $F0 c, $00 c, $1C c, $01 c, $FF c, $87 c,
 $F0 c, $00 c, $70 c, $3C c, $07 c, $F8 c, $07 c, $00 c, $38 c, $1C c, $1C c, $00 c, $0F c,
$F0 c, $3C c, $38 c, $01 c, $C0 c, $00 c, $70 c, $E0 c, $07 c, $03 c, $FF c, $F0 c, $3F c, $9C c, $00 c, $07 c, $07 c,
 $78 c, $00 c, $FF c, $FC c, $07 c, $00 c, $07 c, $00 c, $38 c, $1C c, $1C c, $00 c, $0C c,
$E0 c, $1C c, $3C c, $03 c, $C0 c, $00 c, $70 c, $F0 c, $0F c, $03 c, $FF c, $F8 c, $3F c, $8E c, $00 c, $07 c, $07 c,
 $3C c, $00 c, $FF c, $FE c, $07 c, $00 c, $07 c, $00 c, $38 c, $1C c, $0E c, $00 c, $00 c,
$E0 c, $1C c, $1C c, $03 c, $80 c, $00 c, $70 c, $70 c, $0E c, $07 c, $FF c, $F8 c, $3F c, $8F c, $00 c, $0F c, $07 c,
 $3C c, $01 c, $FF c, $FE c, $07 c, $00 c, $07 c, $00 c, $38 c, $1C c, $0F c, $00 c, $01 c,
$E0 c, $1C c, $1C c, $03 c, $83 c, $00 c, $70 c, $70 c, $0E c, $07 c, $00 c, $3C c, $00 c, $0F c, $00 c, $1F c, $07 c,
 $1E c, $01 c, $C0 c, $0F c, $07 c, $00 c, $07 c, $00 c, $38 c, $1C c, $0F c, $00 c, $1C c,
$F0 c, $3C c, $1E c, $07 c, $87 c, $80 c, $E0 c, $78 c, $1E c, $0F c, $00 c, $1C c, $00 c, $07 c, $C0 c, $3E c, $07 c,
 $0F c, $03 c, $C0 c, $07 c, $07 c, $00 c, $07 c, $00 c, $38 c, $1C c, $07 c, $80 c, $1D c,
$78 c, $78 c, $0F c, $0F c, $07 c, $C3 c, $E0 c, $3C c, $3C c, $0E c, $00 c, $1E c, $00 c, $03 c, $F0 c, $7C c, $07 c,
 $07 c, $83 c, $80 c, $07 c, $87 c, $00 c, $07 c, $00 c, $38 c, $1C c, $03 c, $E0 c, $70 c,
$7F c, $F8 c, $07 c, $FE c, $03 c, $FF c, $C0 c, $1F c, $F8 c, $1E c, $00 c, $1E c, $00 c, $01 c, $FF c, $F8 c, $07 c,
 $07 c, $87 c, $80 c, $07 c, $87 c, $00 c, $07 c, $00 c, $38 c, $1C c, $01 c, $FF c, $F9 c,
$3F c, $F0 c, $03 c, $FC c, $01 c, $FF c, $80 c, $0F c, $F0 c, $1C c, $00 c, $0E c, $00 c, $00 c, $FF c, $F0 c, $07 c,
 $03 c, $C7 c, $00 c, $03 c, $87 c, $00 c, $07 c, $00 c, $38 c, $1C c, $00 c, $FF c, $FD c,
$0F c, $C0 c, $00 c, $F8 c, $00 c, $7E c, $00 c, $03 c, $E0 c, $3C c, $00 c, $0F c, $00 c, $00 c, $1F c, $C0 c, $07 c,
 $01 c, $EF c, $00 c, $03 c, $C7 c, $00 c, $07 c, $00 c, $38 c, $1C c, $00 c, $1F c, $C0 c,

\ TFT_8050A
75 constant splashProgNameX
13 constant splashProgNameY
create splashProgName
  $FE c, $7F c, $3F c, $80 c, $0E c, $0E c, $1F c, $8E c, $02 c, $00 c,
  $10 c, $40 c, $04 c, $00 c, $11 c, $11 c, $10 c, $11 c, $05 c, $02 c,
  $10 c, $40 c, $04 c, $00 c, $20 c, $A0 c, $90 c, $20 c, $85 c, $02 c,
  $10 c, $40 c, $04 c, $00 c, $20 c, $A0 c, $A0 c, $20 c, $85 c, $00 c,
  $10 c, $40 c, $04 c, $00 c, $20 c, $A0 c, $BE c, $20 c, $85 c, $00 c,
  $10 c, $40 c, $04 c, $00 c, $11 c, $20 c, $B1 c, $20 c, $88 c, $80 c,
  $10 c, $7E c, $04 c, $00 c, $0E c, $20 c, $A0 c, $A0 c, $88 c, $87 c,
  $10 c, $40 c, $04 c, $00 c, $11 c, $20 c, $80 c, $A0 c, $88 c, $8D c,
  $10 c, $40 c, $04 c, $00 c, $20 c, $A0 c, $80 c, $A0 c, $9F c, $C0 c,
  $10 c, $40 c, $04 c, $00 c, $20 c, $A0 c, $A0 c, $A0 c, $90 c, $4B c,
  $10 c, $40 c, $04 c, $00 c, $20 c, $A0 c, $A0 c, $A0 c, $90 c, $4C c,
  $10 c, $40 c, $04 c, $00 c, $11 c, $11 c, $11 c, $11 c, $20 c, $20 c,
  $10 c, $40 c, $04 c, $3F c, $8E c, $0E c, $0E c, $0E c, $20 c, $23 c,

calign

\ @EOF
