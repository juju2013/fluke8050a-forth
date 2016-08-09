\ derived from TFT_8050A project by
\ Michael Damkier
\ Hamburg, Germany
\ (michael@vondervotteimittiss.com)


\ 16 constant digit_sm_x
\ 32 constant digit_sm_y
\ digit_sm_x 7 + 8 / digit_sm_y * constant digit_sm_sz

char 0 char 9 16 32 ( asc-min asc-max x y )  fontdef digit_sm
\  0
  $07 c, $C0 c,
  $0F c, $F0 c,
  $1F c, $F8 c,
  $1F c, $F8 c,
  $3E c, $7C c,
  $3C c, $3C c,
  $3C c, $3C c,
  $38 c, $1C c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $38 c, $1C c,
  $3C c, $3C c,
  $3C c, $3C c,
  $3C c, $3C c,
  $1E c, $78 c,
  $1F c, $F8 c,
  $0F c, $F0 c,
  $07 c, $E0 c,

\  1
  $0F c, $E0 c,
  $0F c, $E0 c,
  $0F c, $E0 c,
  $0F c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,

\  2
  $07 c, $E0 c,
  $1F c, $F8 c,
  $3F c, $FC c,
  $3F c, $FC c,
  $3C c, $3E c,
  $7C c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $78 c, $1E c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $7C c,
  $00 c, $78 c,
  $00 c, $F8 c,
  $00 c, $F0 c,
  $00 c, $F0 c,
  $01 c, $F0 c,
  $01 c, $E0 c,
  $03 c, $E0 c,
  $03 c, $C0 c,
  $07 c, $C0 c,
  $07 c, $80 c,
  $0F c, $00 c,
  $0F c, $00 c,
  $1E c, $00 c,
  $1F c, $FE c,
  $3F c, $FE c,
  $3F c, $FE c,
  $7F c, $FE c,

\  3
  $07 c, $E0 c,
  $0F c, $F8 c,
  $1F c, $FC c,
  $1F c, $FC c,
  $3E c, $3E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $3E c,
  $00 c, $FC c,
  $03 c, $F8 c,
  $03 c, $E0 c,
  $03 c, $F8 c,
  $00 c, $7C c,
  $00 c, $3E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $3E c,
  $3E c, $3C c,
  $1F c, $FC c,
  $1F c, $FC c,
  $0F c, $F8 c,
  $07 c, $E0 c,

\  4
  $00 c, $3C c,
  $00 c, $7C c,
  $00 c, $7C c,
  $00 c, $FC c,
  $00 c, $FC c,
  $00 c, $FC c,
  $01 c, $FC c,
  $01 c, $FC c,
  $03 c, $BC c,
  $03 c, $BC c,
  $07 c, $3C c,
  $07 c, $3C c,
  $0F c, $3C c,
  $0E c, $3C c,
  $0E c, $3C c,
  $1C c, $3C c,
  $1C c, $3C c,
  $3C c, $3C c,
  $38 c, $3C c,
  $78 c, $3C c,
  $7F c, $FF c,
  $7F c, $FF c,
  $7F c, $FF c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $3C c,

\  5
  $07 c, $FE c,
  $07 c, $FE c,
  $07 c, $FE c,
  $07 c, $FE c,
  $07 c, $00 c,
  $0F c, $00 c,
  $0F c, $00 c,
  $0F c, $00 c,
  $0F c, $00 c,
  $0F c, $00 c,
  $0E c, $00 c,
  $0E c, $00 c,
  $0F c, $E0 c,
  $1F c, $F0 c,
  $1F c, $F8 c,
  $1F c, $FC c,
  $00 c, $FC c,
  $00 c, $3E c,
  $00 c, $3E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $1E c,
  $00 c, $3C c,
  $00 c, $3C c,
  $10 c, $FC c,
  $3F c, $F8 c,
  $3F c, $F8 c,
  $3F c, $F0 c,
  $0F c, $C0 c,

\  6
  $00 c, $F0 c,
  $01 c, $F0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $03 c, $C0 c,
  $03 c, $C0 c,
  $07 c, $80 c,
  $07 c, $80 c,
  $0F c, $80 c,
  $0F c, $00 c,
  $0F c, $00 c,
  $1E c, $00 c,
  $1E c, $F0 c,
  $1F c, $F8 c,
  $1F c, $FC c,
  $3F c, $FC c,
  $3E c, $3E c,
  $3E c, $3E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3E c, $3E c,
  $1E c, $3C c,
  $1F c, $FC c,
  $0F c, $FC c,
  $0F c, $F8 c,
  $03 c, $E0 c,

\  7
  $3F c, $FF c,
  $3F c, $FF c,
  $3F c, $FE c,
  $3F c, $FE c,
  $00 c, $1E c,
  $00 c, $3E c,
  $00 c, $3C c,
  $00 c, $3C c,
  $00 c, $7C c,
  $00 c, $78 c,
  $00 c, $78 c,
  $00 c, $F8 c,
  $00 c, $F0 c,
  $00 c, $F0 c,
  $00 c, $F0 c,
  $01 c, $F0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $03 c, $E0 c,
  $03 c, $C0 c,
  $03 c, $C0 c,
  $07 c, $C0 c,
  $07 c, $80 c,
  $07 c, $80 c,
  $0F c, $80 c,
  $0F c, $80 c,
  $0F c, $00 c,
  $1F c, $00 c,
  $1F c, $00 c,
  $1E c, $00 c,
  $1E c, $00 c,
  $3E c, $00 c,

\  8
  $07 c, $F0 c,
  $0F c, $F8 c,
  $1F c, $FC c,
  $1F c, $FC c,
  $3E c, $3E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $1E c, $3C c,
  $0F c, $F8 c,
  $07 c, $F0 c,
  $0F c, $F8 c,
  $1F c, $FC c,
  $1E c, $3C c,
  $3E c, $3E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3E c, $3E c,
  $1E c, $3C c,
  $1F c, $FC c,
  $1F c, $FC c,
  $0F c, $F8 c,
  $03 c, $E0 c,

\  9
  $03 c, $E0 c,
  $0F c, $F8 c,
  $1F c, $F8 c,
  $1F c, $FC c,
  $1E c, $3C c,
  $3E c, $3E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3C c, $1E c,
  $3E c, $3E c,
  $3E c, $3E c,
  $1F c, $FE c,
  $1F c, $FC c,
  $0F c, $FC c,
  $07 c, $BC c,
  $00 c, $3C c,
  $00 c, $78 c,
  $00 c, $78 c,
  $00 c, $F0 c,
  $00 c, $F0 c,
  $01 c, $F0 c,
  $01 c, $E0 c,
  $01 c, $E0 c,
  $03 c, $C0 c,
  $03 c, $C0 c,
  $07 c, $80 c,
  $0F c, $80 c,

calign


\ 4  constant dp_small_x
\ 32 constant dp_small_y
0 0 4 32 fontdef dp_small
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $00 c,
  $60 c,
  $F0 c,
  $F0 c,
  $60 c,

calign

\ @EOF
