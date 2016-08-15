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
