\ 32w x 64h

: bs, ( 32-bit -- )
    dup 24 rshift c,
    dup 16 rshift c,
    dup 8  rshift c,
    c,
;

\ 32 constant digits32x64_x
\ 64 constant digits32x64_y
\ digits32x64_x 7 + 8 / digits32x64_y * constant digits32x64_sz

char 0 char 9 32 64  ( asc-min asc-max x y ) fontdef digits32x64
binary
  0000000000001111000000000000 bs,
  0000000000111111110000000000 bs,
  0000000001111111111000000000 bs,
  0000000011110000111100000000 bs,
  0000000111110000111110000000 bs,
  0000001111100000011111000000 bs,
  0000001111100000011111000000 bs,
  0000011111100000011111100000 bs,
  0000011111100000011111100000 bs,
  0000111111100000011111110000 bs,
  0000111111000000001111110000 bs,
  0001111111000000001111111000 bs,
  0001111111000000001111111000 bs,
  0001111111000000001111111000 bs,
  0011111111000000001111111000 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111100 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  1111111111000000001111111111 bs,
  1111111111000000001111111111 bs,
  1111111111000000001111111111 bs,
  1111111111000000001111111111 bs,
  1111111111000000001111111111 bs,
  1111111111000000001111111111 bs,
  1111111111000000001111111111 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111000 bs,
  0001111111000000001111111000 bs,
  0001111111000000001111111000 bs,
  0001111111000000001111111000 bs,
  0000111111000000001111110000 bs,
  0000111111100000011111110000 bs,
  0000011111100000011111100000 bs,
  0000011111100000011111100000 bs,
  0000001111100000011111000000 bs,
  0000001111100000011111000000 bs,
  0000000111110000111110000000 bs,
  0000000011110000111100000000 bs,
  0000000001111111111000000000 bs,
  0000000000111111110000000000 bs,
  0000000000001111000000000000 bs,

  0000000000000000010000000000 bs,
  0000000000000001110000000000 bs,
  0000000000000011110000000000 bs,
  0000000000001111110000000000 bs,
  0000000000011111110000000000 bs,
  0000000001111111110000000000 bs,
  0000000011111111110000000000 bs,
  0000001111111111110000000000 bs,
  0000011111111111110000000000 bs,
  0001111111111111110000000000 bs,
  0011110011111111110000000000 bs,
  0011000001111111110000000000 bs,
  0000000001111111110000000000 bs,
  0000000001111111110000000000 bs,
  0000000001111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000000111111110000000000 bs,
  0000000001111111111000000000 bs,
  0000000001111111111000000000 bs,
  0000000001111111111000000000 bs,
  0000000001111111111000000000 bs,
  0000000011111111111000000000 bs,
  0000000111111111111100000000 bs,
  0000111111111111111111100000 bs,
  0011111111111111111111111000 bs,
  0011111111111111111111111000 bs,

  0000000000001111100000000000 bs,
  0000000000111111111000000000 bs,
  0000000001111111111100000000 bs,
  0000000011111111111110000000 bs,
  0000000111111111111111000000 bs,
  0000001111111111111111100000 bs,
  0000001111111111111111100000 bs,
  0000011111111111111111110000 bs,
  0000011111111111111111110000 bs,
  0000111111111111111111110000 bs,
  0000111111111111111111111000 bs,
  0001111000000111111111111000 bs,
  0001110000000011111111111000 bs,
  0001100000000001111111111000 bs,
  0011100000000001111111111000 bs,
  0011000000000000111111111000 bs,
  0011000000000000111111111000 bs,
  0110000000000000011111111000 bs,
  0110000000000000011111111000 bs,
  0000000000000000011111111000 bs,
  0000000000000000011111111000 bs,
  0000000000000000011111111000 bs,
  0000000000000000011111111000 bs,
  0000000000000000011111111000 bs,
  0000000000000000011111111000 bs,
  0000000000000000011111110000 bs,
  0000000000000000011111110000 bs,
  0000000000000000011111110000 bs,
  0000000000000000011111100000 bs,
  0000000000000000111111100000 bs,
  0000000000000000111111000000 bs,
  0000000000000000111111000000 bs,
  0000000000000001111110000000 bs,
  0000000000000001111110000000 bs,
  0000000000000001111100000000 bs,
  0000000000000011111100000000 bs,
  0000000000000011111000000000 bs,
  0000000000000011110000000000 bs,
  0000000000000111110000000000 bs,
  0000000000000111100000000000 bs,
  0000000000001111000000000000 bs,
  0000000000001111000000000000 bs,
  0000000000011110000000000000 bs,
  0000000000011100000000000000 bs,
  0000000000111100000000000001 bs,
  0000000000111000000000000001 bs,
  0000000001110000000000000011 bs,
  0000000001110000000000000011 bs,
  0000000011100000000000000111 bs,
  0000000111000000000000000110 bs,
  0000000110000000000000001110 bs,
  0000001110000000000011111110 bs,
  0000001111111111111111111110 bs,
  0000011111111111111111111110 bs,
  0000011111111111111111111110 bs,
  0000111111111111111111111100 bs,
  0001111111111111111111111100 bs,
  0001111111111111111111111100 bs,
  0011111111111111111111111100 bs,
  0011111111111111111111111100 bs,
  0111111111111111111111111100 bs,
  1111111111111111111111111100 bs,
  1111111111111111111111111000 bs,
  1111111111111111111111111000 bs,

  0000000000001111110000000000 bs,
  0000000000111111111110000000 bs,
  0000000001111111111111000000 bs,
  0000000011111111111111100000 bs,
  0000000111111111111111100000 bs,
  0000001111111111111111110000 bs,
  0000011111111111111111110000 bs,
  0000111110011111111111111000 bs,
  0000111000000111111111111000 bs,
  0001110000000011111111111000 bs,
  0001100000000001111111111000 bs,
  0011100000000000111111111000 bs,
  0011000000000000111111111000 bs,
  0011000000000000111111111000 bs,
  0010000000000000111111111000 bs,
  0000000000000000111111111000 bs,
  0000000000000000111111111000 bs,
  0000000000000000111111111000 bs,
  0000000000000000111111110000 bs,
  0000000000000000111111110000 bs,
  0000000000000000111111100000 bs,
  0000000000000000111111100000 bs,
  0000000000000001111111000000 bs,
  0000000000000001111110000000 bs,
  0000000000000011111110000000 bs,
  0000000000000111111111000000 bs,
  0000000000001111111111100000 bs,
  0000000000011111111111110000 bs,
  0000000001111111111111111000 bs,
  0000000001111111111111111000 bs,
  0000000001111111111111111100 bs,
  0000000000011111111111111100 bs,
  0000000000001111111111111100 bs,
  0000000000000011111111111110 bs,
  0000000000000001111111111110 bs,
  0000000000000000111111111110 bs,
  0000000000000000011111111110 bs,
  0000000000000000001111111110 bs,
  0000000000000000001111111110 bs,
  0000000000000000000111111110 bs,
  0000000000000000000111111110 bs,
  0000000000000000000011111110 bs,
  0000000000000000000011111110 bs,
  0000000000000000000011111110 bs,
  0000000000000000000011111110 bs,
  0000000000000000000011111110 bs,
  0000000000000000000001111110 bs,
  0000000000000000000001111110 bs,
  0000000000000000000001111100 bs,
  0000000000000000000001111100 bs,
  0000000000000000000001111100 bs,
  0011111000000000000001111000 bs,
  0111111100000000000011111000 bs,
  0111111110000000000011111000 bs,
  1111111111000000000011110000 bs,
  1111111111000000000011100000 bs,
  1111111111100000000111100000 bs,
  0111111111110000001111000000 bs,
  0111111111111000011110000000 bs,
  0111111111111111111100000000 bs,
  0011111111111111111000000000 bs,
  0001111111111111110000000000 bs,
  0000111111111111000000000000 bs,
  0000001111111000000000000000 bs,

  0000000000000000000111110000 bs,
  0000000000000000001111110000 bs,
  0000000000000000001111110000 bs,
  0000000000000000011111110000 bs,
  0000000000000000011111110000 bs,
  0000000000000000111111110000 bs,
  0000000000000000111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000011111111110000 bs,
  0000000000000011111111110000 bs,
  0000000000000111111111110000 bs,
  0000000000000111111111110000 bs,
  0000000000001111111111110000 bs,
  0000000000001111111111110000 bs,
  0000000000011101111111110000 bs,
  0000000000011101111111110000 bs,
  0000000000111001111111110000 bs,
  0000000000111001111111110000 bs,
  0000000001110001111111110000 bs,
  0000000001110001111111110000 bs,
  0000000011100001111111110000 bs,
  0000000011100001111111110000 bs,
  0000000111000001111111110000 bs,
  0000000111000001111111110000 bs,
  0000001110000001111111110000 bs,
  0000001110000001111111110000 bs,
  0000011100000001111111110000 bs,
  0000011100000001111111110000 bs,
  0000111000000001111111110000 bs,
  0000111000000001111111110000 bs,
  0001110000000001111111110000 bs,
  0001110000000001111111110000 bs,
  0011100000000001111111110000 bs,
  0011100000000001111111110000 bs,
  0111000000000001111111110000 bs,
  0111000000000001111111110000 bs,
  1110000000000001111111110000 bs,
  1110000000000001111111110000 bs,
  1110000000000001111111110000 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  1111111111111111111111111111 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,

  0000000011111111111111111111 bs,
  0000000011111111111111111110 bs,
  0000000011111111111111111110 bs,
  0000000011111111111111111110 bs,
  0000000111111111111111111110 bs,
  0000000111111111111111111100 bs,
  0000000111111111111111111100 bs,
  0000000111111111111111111100 bs,
  0000000111111111111111111100 bs,
  0000001111111111111111111000 bs,
  0000001111111111111111111000 bs,
  0000001111111111111111111000 bs,
  0000001100000000000000000000 bs,
  0000001100000000000000000000 bs,
  0000001100000000000000000000 bs,
  0000011100000000000000000000 bs,
  0000011000000000000000000000 bs,
  0000011000000000000000000000 bs,
  0000011000000000000000000000 bs,
  0000011000000000000000000000 bs,
  0000111111111000000000000000 bs,
  0000111111111111000000000000 bs,
  0000111111111111110000000000 bs,
  0000111111111111111000000000 bs,
  0000111111111111111110000000 bs,
  0000111111111111111110000000 bs,
  0001111111111111111111000000 bs,
  0001111111111111111111100000 bs,
  0001111111111111111111100000 bs,
  0001111111111111111111110000 bs,
  0001111111111111111111110000 bs,
  0011111111111111111111111000 bs,
  0011111111111111111111111000 bs,
  0000000000111111111111111000 bs,
  0000000000001111111111111100 bs,
  0000000000000011111111111100 bs,
  0000000000000000111111111100 bs,
  0000000000000000011111111100 bs,
  0000000000000000001111111100 bs,
  0000000000000000000111111100 bs,
  0000000000000000000111111100 bs,
  0000000000000000000011111100 bs,
  0000000000000000000011111100 bs,
  0000000000000000000001111100 bs,
  0000000000000000000001111100 bs,
  0000000000000000000001111100 bs,
  0000000000000000000000111100 bs,
  0000000000000000000000111100 bs,
  0000000000000000000000111100 bs,
  0000000000000000000000111000 bs,
  0001110000000000000000111000 bs,
  0011111000000000000001111000 bs,
  0111111110000000000001110000 bs,
  0111111111000000000001110000 bs,
  1111111111000000000011110000 bs,
  1111111111100000000011100000 bs,
  1111111111110000000111000000 bs,
  1111111111111100001111000000 bs,
  0111111111111111111110000000 bs,
  0111111111111111111100000000 bs,
  0011111111111111111000000000 bs,
  0001111111111111110000000000 bs,
  0000111111111111000000000000 bs,
  0000001111111000000000000000 bs,

  0000000000000000000000001110 bs,
  0000000000000000000001111110 bs,
  0000000000000000000111111110 bs,
  0000000000000000011111110000 bs,
  0000000000000000111111100000 bs,
  0000000000000011111110000000 bs,
  0000000000000111111100000000 bs,
  0000000000001111111000000000 bs,
  0000000000011111110000000000 bs,
  0000000000111111100000000000 bs,
  0000000001111111100000000000 bs,
  0000000011111111000000000000 bs,
  0000000011111110000000000000 bs,
  0000000111111110000000000000 bs,
  0000001111111100000000000000 bs,
  0000001111111100000000000000 bs,
  0000011111111100000000000000 bs,
  0000011111111000000000000000 bs,
  0000111111111000000000000000 bs,
  0000111111111000000000000000 bs,
  0000111111110000000000000000 bs,
  0001111111110000000000000000 bs,
  0001111111110000000000000000 bs,
  0001111111110000000000000000 bs,
  0011111111100111110000000000 bs,
  0011111111111111111110000000 bs,
  0011111111111111111111000000 bs,
  0011111111111111111111100000 bs,
  0111111111110011111111110000 bs,
  0111111111100000111111111000 bs,
  0111111111100000111111111000 bs,
  0111111111000000011111111100 bs,
  0111111111000000011111111100 bs,
  0111111111000000011111111100 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111111 bs,
  0111111111000000001111111111 bs,
  0111111111000000001111111111 bs,
  0111111111000000001111111111 bs,
  0111111111000000001111111111 bs,
  0111111111000000001111111111 bs,
  0111111111000000001111111111 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0011111111000000001111111110 bs,
  0011111111000000001111111110 bs,
  0011111111000000001111111110 bs,
  0011111111000000001111111100 bs,
  0001111111100000001111111100 bs,
  0001111111100000001111111100 bs,
  0001111111100000001111111000 bs,
  0000111111100000001111111000 bs,
  0000111111100000001111111000 bs,
  0000011111100000001111110000 bs,
  0000011111110000001111110000 bs,
  0000001111110000011111100000 bs,
  0000000111111000011111000000 bs,
  0000000011111111111110000000 bs,
  0000000000111111111100000000 bs,
  0000000000001111100000000000 bs,

  0001111111111111111111111111 bs,
  0001111111111111111111111111 bs,
  0011111111111111111111111110 bs,
  0011111111111111111111111110 bs,
  0011111111111111111111111110 bs,
  0011111111111111111111111110 bs,
  0011111111111111111111111100 bs,
  0011111111111111111111111100 bs,
  0011111111111111111111111100 bs,
  0011111111111111111111111100 bs,
  0111111111111111111111111000 bs,
  0111111111111111111111111000 bs,
  0111111111111111111111111000 bs,
  0111100000000000000011111000 bs,
  0111000000000000000011111000 bs,
  0110000000000000000111110000 bs,
  1110000000000000000111110000 bs,
  1100000000000000000111110000 bs,
  1100000000000000000111110000 bs,
  1100000000000000001111100000 bs,
  1100000000000000001111100000 bs,
  0000000000000000001111100000 bs,
  0000000000000000001111100000 bs,
  0000000000000000011111100000 bs,
  0000000000000000011111000000 bs,
  0000000000000000011111000000 bs,
  0000000000000000011111000000 bs,
  0000000000000000011111000000 bs,
  0000000000000000111110000000 bs,
  0000000000000000111110000000 bs,
  0000000000000000111110000000 bs,
  0000000000000000111110000000 bs,
  0000000000000001111110000000 bs,
  0000000000000001111100000000 bs,
  0000000000000001111100000000 bs,
  0000000000000001111100000000 bs,
  0000000000000011111100000000 bs,
  0000000000000011111000000000 bs,
  0000000000000011111000000000 bs,
  0000000000000011111000000000 bs,
  0000000000000111111000000000 bs,
  0000000000000111111000000000 bs,
  0000000000000111110000000000 bs,
  0000000000000111110000000000 bs,
  0000000000001111110000000000 bs,
  0000000000001111110000000000 bs,
  0000000000001111100000000000 bs,
  0000000000001111100000000000 bs,
  0000000000001111100000000000 bs,
  0000000000011111100000000000 bs,
  0000000000011111100000000000 bs,
  0000000000011111000000000000 bs,
  0000000000011111000000000000 bs,
  0000000000111111000000000000 bs,
  0000000000111111000000000000 bs,
  0000000000111110000000000000 bs,
  0000000000111110000000000000 bs,
  0000000001111110000000000000 bs,
  0000000001111110000000000000 bs,
  0000000001111110000000000000 bs,
  0000000001111100000000000000 bs,
  0000000011111100000000000000 bs,
  0000000011111100000000000000 bs,
  0000000011111100000000000000 bs,

  0000000000011111110000000000 bs,
  0000000011111111111110000000 bs,
  0000000111111111111111000000 bs,
  0000001111110000111111100000 bs,
  0000011111100000011111110000 bs,
  0000111111000000001111111000 bs,
  0000111111000000001111111000 bs,
  0001111110000000000111111000 bs,
  0001111110000000000111111100 bs,
  0011111110000000000111111100 bs,
  0011111110000000000111111100 bs,
  0011111110000000000111111100 bs,
  0011111110000000000111111100 bs,
  0111111110000000000111111100 bs,
  0111111111000000000111111100 bs,
  0111111111000000000111111100 bs,
  0111111111100000000111111100 bs,
  0111111111100000000111111100 bs,
  0111111111110000000111111100 bs,
  0011111111110000000111111000 bs,
  0011111111111000001111111000 bs,
  0011111111111100001111110000 bs,
  0011111111111110001111100000 bs,
  0001111111111111011111000000 bs,
  0001111111111111111110000000 bs,
  0001111111111111111000000000 bs,
  0000111111111111111000000000 bs,
  0000011111111111111100000000 bs,
  0000011111111111111110000000 bs,
  0000001111111111111111000000 bs,
  0000000111111111111111100000 bs,
  0000000011111111111111100000 bs,
  0000000001111111111111110000 bs,
  0000000001111111111111110000 bs,
  0000000111111111111111111000 bs,
  0000001111101111111111111000 bs,
  0000011111000111111111111100 bs,
  0000111111000011111111111100 bs,
  0001111110000011111111111100 bs,
  0001111110000001111111111110 bs,
  0011111110000000111111111110 bs,
  0011111110000000011111111110 bs,
  0111111100000000011111111110 bs,
  0111111100000000001111111110 bs,
  0111111100000000001111111110 bs,
  0111111100000000001111111110 bs,
  0111111100000000000111111110 bs,
  0111111100000000000111111110 bs,
  0111111100000000000111111110 bs,
  0111111100000000000111111110 bs,
  0111111100000000000111111110 bs,
  0111111100000000000111111110 bs,
  0111111100000000000111111100 bs,
  0111111100000000000111111100 bs,
  0111111110000000000111111100 bs,
  0011111110000000000111111000 bs,
  0011111110000000001111111000 bs,
  0001111110000000001111110000 bs,
  0001111111000000011111110000 bs,
  0000111111100000011111100000 bs,
  0000011111110000111111000000 bs,
  0000001111111111111110000000 bs,
  0000000011111111111000000000 bs,
  0000000000111111000000000000 bs,

  0000000000011111100000000000 bs,
  0000000011111111111000000000 bs,
  0000000111111111111100000000 bs,
  0000001111110001111110000000 bs,
  0000011111100000111111000000 bs,
  0000011111100000011111100000 bs,
  0000111111000000011111100000 bs,
  0000111111000000011111110000 bs,
  0001111111000000011111110000 bs,
  0001111111000000011111111000 bs,
  0011111111000000001111111000 bs,
  0011111111000000001111111100 bs,
  0011111111000000001111111100 bs,
  0111111111000000001111111100 bs,
  0111111111000000001111111100 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111000000001111111110 bs,
  0111111111100000001111111110 bs,
  0011111111100000001111111110 bs,
  0011111111100000001111111110 bs,
  0011111111100000001111111110 bs,
  0001111111100000001111111110 bs,
  0001111111110000001111111110 bs,
  0000111111111000011111111110 bs,
  0000111111111111111111111110 bs,
  0000011111111111111111111110 bs,
  0000001111111111111111111100 bs,
  0000000111111111011111111100 bs,
  0000000000111000011111111100 bs,
  0000000000000000111111111100 bs,
  0000000000000000111111111000 bs,
  0000000000000000111111111000 bs,
  0000000000000000111111111000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111110000 bs,
  0000000000000001111111100000 bs,
  0000000000000011111111100000 bs,
  0000000000000011111111000000 bs,
  0000000000000011111111000000 bs,
  0000000000000111111110000000 bs,
  0000000000000111111100000000 bs,
  0000000000001111111100000000 bs,
  0000000000011111111000000000 bs,
  0000000000011111110000000000 bs,
  0000000000111111100000000000 bs,
  0000000001111111000000000000 bs,
  0000000011111110000000000000 bs,
  0000000111111100000000000000 bs,
  0000011111110000000000000000 bs,
  0000111111100000000000000000 bs,
  0111111110000000000000000000 bs,
  0111110000000000000000000000 bs,
  0110000000000000000000000000 bs,
decimal

calign

\ @EOF
