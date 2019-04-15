/*-----------------------------------------------------------------*\
|              ____                     _                           |
|             /    |                   | |_                         |
|            /     |_ __ ____  __ _  __| |_  __ _                   |
|           /  /|  | '__/  __|/ _` |/ _  | |/ _` |                  |
|          /  __   | | |  |__  (_| | (_| | | (_| |                  |
|         /  /  |  |_|  \____|\__,_|\__,_|_|\__,_|                  |
|        /__/   |__|                                                |
|                                                                   |
+-------------------------------------------------------------------+
| - Copyright: Athena & Hercules                                    |
| - Copyright: Spell master (Source Mod)                            |
\*-----------------------------------------------------------------*/

#ifndef COMMON_TIMER_H
#define COMMON_TIMER_H

#include "config/core.h"
#include "common/cbasetypes.h"

#define DIFF_TICK(a,b) ((a)-(b))
#define DIFF_TICK32(a,b) ((int32)((a)-(b)))

#define INVALID_TIMER (-1)

// timer flags
enum {
	TIMER_ONCE_AUTODEL = 0x01,
	TIMER_INTERVAL = 0x02,
	TIMER_REMOVE_HEAP = 0x10,
};

// Struct declaration

typedef int (*TimerFunc)(int tid, int64 tick, int id, intptr_t data);

struct TimerData {
	int64 tick;
	TimerFunc func;
	unsigned char type;
	int interval;

	// general-purpose storage
	int id;
	intptr_t data;
};


/*=====================================
* Interface : timer.h
* Generated by HerculesInterfaceMaker
* created by Susu
*-------------------------------------*/
struct timer_interface {

	/* funcs */
	int64 (*gettick) (void);
	int64 (*gettick_nocache) (void);

	int (*add) (int64 tick, TimerFunc func, int id, intptr_t data);
	int (*add_interval) (int64 tick, TimerFunc func, int id, intptr_t data, int interval);
	const struct TimerData *(*get) (int tid);
	int (*delete) (int tid, TimerFunc func);

	int64 (*addtick) (int tid, int64 tick);
	int64 (*settick) (int tid, int64 tick);

	int (*add_func_list) (TimerFunc func, char* name);

	unsigned long (*get_uptime) (void);

	int (*perform) (int64 tick);
	void (*init) (void);
	void (*final) (void);
};

void timer_defaults(void);
extern struct timer_interface *timer;

#endif /* COMMON_TIMER_H */