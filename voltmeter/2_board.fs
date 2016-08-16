\ layer "B" - hardware and board definitions

<<always>>

compiletoflash

PB1 constant LED
PB0 constant TFT-D/C 

\ PA4 is default SSEL for LCD display in SPI driver

PB2  constant fluke_dp
PA8  constant fluke_hv

PC13 constant fluke_func_a   \  AC/DC
PC14 constant fluke_func_b   \  V
PC15 constant fluke_func_c   \  mA
PB10 constant fluke_func_d   \  relative mode switch

PB7  constant fluke_w        \ MSB
PB6  constant fluke_x        \
PB4  constant fluke_y        \
PB3  constant fluke_z        \ LSB

PA15 constant fluke_rng_a
PA14 constant fluke_rng_b
PA13 constant fluke_rng_c

PB15 constant fluke_st0
PB14 constant fluke_st1
PB13 constant fluke_st2
PB12 constant fluke_st3
PB11 constant fluke_st4


\ generate bit-band address given bit and offset into bitband region
: _io>bb ( bit offset -- addr )
    swap dup    ( offset bit bit )
    io-base rot +
    $000fffff and 5 lshift  \ offset into bitband region for register
    swap io# 2 lshift +     \ bit offset
    $42000000 +             \ base of bitband region
;

\ generate ARM Cortex bit-band addresses corresponding to bit position in GPIO input register
: ior>bb  ( pin -- addr ) GPIO.IDR _io>bb ;

\ generate ARM Cortex bit-band addresses corresponding to bit position in GPIO input register
: iow>bb  ( pin -- addr ) GPIO.ODR _io>bb ;

fluke_st0   ior>bb constant st0_bb
fluke_st1   ior>bb constant st1_bb
fluke_st2   ior>bb constant st2_bb
fluke_st3   ior>bb constant st3_bb
fluke_st4   ior>bb constant st4_bb
fluke_w     ior>bb constant w_bb
fluke_x     ior>bb constant x_bb
fluke_y     ior>bb constant y_bb
fluke_z     ior>bb constant z_bb
fluke_dp    ior>bb constant dp_bb
fluke_hv    ior>bb constant hv_bb
fluke_rng_a ior>bb constant rng_c_bb
fluke_rng_b ior>bb constant rng_c_bb
fluke_rng_c ior>bb constant rng_c_bb


: fl-input ( pin -- )
  IMODE-FLOAT swap io-mode!
;

: init-fluke-inputs
  fluke_func_a fl-input   fluke_w fl-input    fluke_rng_a fl-input    fluke_st0 fl-input   fluke_dp fl-input
  fluke_func_b fl-input   fluke_x fl-input    fluke_rng_b fl-input    fluke_st1 fl-input   fluke_hv fl-input
  fluke_func_c fl-input   fluke_y fl-input    fluke_rng_c fl-input    fluke_st2 fl-input
  fluke_func_d fl-input   fluke_z fl-input                            fluke_st3 fl-input
;

: init ( -- )  \ board initialisation
  -jtag  \ disable JTAG, we only need SWD
  OMODE-PP LED io-mode!     LED ios!   \ turn on LED
  72MHz
  flash-kb . ." KB <voltmeter> " hwid hex. cr
  init-fluke-inputs
  1000 systick-hz
;

cornerstone <<<board>>>

