//
//  half.h
//  Half
//
//  Copyright © 2021 SomeRandomiOSDev. All rights reserved.
//

#ifndef half_h
#define half_h

#include <stdint.h>
#include <stdbool.h>

#if !defined(EXTERN_C)
#   if defined(__cplusplus)
#       define EXTERN_C extern "C"
#   else
#       define EXTERN_C extern
#   endif // #if defined(__cplusplus)
#endif // #if !defined(EXTERN_C)

#if __has_attribute(__const__)
#   define HALF_CONST   __attribute__((__const__))
#else
#   define HALF_CONST   /* nothing */
#endif

#define HALF_FUNC HALF_CONST
#define HALF_OFUNC HALF_FUNC __attribute__((__overloadable__))

typedef union {
    uint16_t _bits;
    __fp16 _fp;
} __attribute__((packed)) half_t;

EXTERN_C HALF_FUNC half_t _half_zero(void);
EXTERN_C HALF_FUNC half_t _half_epsilon(void);
EXTERN_C HALF_FUNC half_t _half_pi(void);
EXTERN_C HALF_FUNC half_t _half_nan(void);

EXTERN_C HALF_FUNC uint16_t _half_to_raw(const half_t);
EXTERN_C HALF_FUNC half_t _half_from_raw(const uint16_t);

EXTERN_C HALF_OFUNC half_t _half_from(const double);
EXTERN_C HALF_OFUNC half_t _half_from(const float);
EXTERN_C HALF_OFUNC half_t _half_from(const long long);
EXTERN_C HALF_OFUNC half_t _half_from(const long);
EXTERN_C HALF_OFUNC half_t _half_from(const int);
EXTERN_C HALF_OFUNC half_t _half_from(const short);
EXTERN_C HALF_OFUNC half_t _half_from(const char);
EXTERN_C HALF_OFUNC half_t _half_from(const unsigned long long);
EXTERN_C HALF_OFUNC half_t _half_from(const unsigned long);
EXTERN_C HALF_OFUNC half_t _half_from(const unsigned int);
EXTERN_C HALF_OFUNC half_t _half_from(const unsigned short);
EXTERN_C HALF_OFUNC half_t _half_from(const unsigned char);

EXTERN_C HALF_FUNC double             _half_to_double(const half_t);
EXTERN_C HALF_FUNC float              _half_to_float(const half_t);
EXTERN_C HALF_FUNC long long          _half_to_longlong(const half_t);
EXTERN_C HALF_FUNC long               _half_to_long(const half_t);
EXTERN_C HALF_FUNC int                _half_to_int(const half_t);
EXTERN_C HALF_FUNC short              _half_to_short(const half_t);
EXTERN_C HALF_FUNC char               _half_to_char(const half_t);
EXTERN_C HALF_FUNC unsigned long long _half_to_ulonglong(const half_t);
EXTERN_C HALF_FUNC unsigned long      _half_to_ulong(const half_t);
EXTERN_C HALF_FUNC unsigned int       _half_to_uint(const half_t);
EXTERN_C HALF_FUNC unsigned short     _half_to_ushort(const half_t);
EXTERN_C HALF_FUNC unsigned char      _half_to_uchar(const half_t);

EXTERN_C HALF_FUNC half_t _half_add(const half_t, const half_t);
EXTERN_C HALF_FUNC half_t _half_sub(const half_t, const half_t);
EXTERN_C HALF_FUNC half_t _half_mul(const half_t, const half_t);
EXTERN_C HALF_FUNC half_t _half_div(const half_t, const half_t);
EXTERN_C HALF_FUNC half_t _half_fma(const half_t, const half_t, const half_t);

EXTERN_C HALF_FUNC half_t _half_neg(const half_t);
EXTERN_C HALF_FUNC half_t _half_abs(const half_t);
EXTERN_C HALF_FUNC half_t _half_sqrt(const half_t);

EXTERN_C HALF_FUNC bool _half_equal(const half_t, const half_t);
EXTERN_C HALF_FUNC bool _half_lt(const half_t, const half_t);
EXTERN_C HALF_FUNC bool _half_gt(const half_t, const half_t);
EXTERN_C HALF_FUNC bool _half_lte(const half_t, const half_t);
EXTERN_C HALF_FUNC bool _half_gte(const half_t, const half_t);

#endif /* half_h */
