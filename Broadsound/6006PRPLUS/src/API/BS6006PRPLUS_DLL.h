#pragma once

#ifdef BS6006PRPLUS_DLL_EXPORTS
#define BS6006PRPLUS_API __declspec(dllexport)
#else
#define BS6006PRPLUS_API __declspec(dllimport)
#endif

extern "C" BS6006PRPLUS_API bool PR_ConnectDevice(HANDLE hDevice);
extern "C" BS6006PRPLUS_API bool PR_CheckDeviceExistance();
extern "C" BS6006PRPLUS_API void PR_DisconnectDevice();
extern "C" BS6006PRPLUS_API HANDLE PR_DeviceHandle();
extern "C" BS6006PRPLUS_API void PR_SerialNumber(wchar_t *SN);

extern "C" BS6006PRPLUS_API void PR_SwitchToPulseEchoMode();
extern "C" BS6006PRPLUS_API void PR_SwitchToThruMode();

extern "C" BS6006PRPLUS_API bool PR_SetPulse(int PulseIndex);
extern "C" BS6006PRPLUS_API int PR_CurrentPulseIndex();
extern "C" BS6006PRPLUS_API bool PR_SetPRF(int PRF);
extern "C" BS6006PRPLUS_API int PR_CurrentPRF();
extern "C" BS6006PRPLUS_API void PR_SetTriggerSource(int TriggerSource);
extern "C" BS6006PRPLUS_API int PR_CurrentTriggerSource();
extern "C" BS6006PRPLUS_API void PR_SetReceiverGain(int Gain);
extern "C" BS6006PRPLUS_API int PR_CurrentReceiverGain();

extern "C" BS6006PRPLUS_API int PR_SetNoAcqSignal(int Number);
extern "C" BS6006PRPLUS_API int PR_CurrentNoAcqSignal();
extern "C" BS6006PRPLUS_API int PR_SetLengthOfSignal(int Length);
extern "C" BS6006PRPLUS_API int PR_CurrentLengthOfSignal();
extern "C" BS6006PRPLUS_API void PR_SetTriggerDelay(int Delay);
extern "C" BS6006PRPLUS_API int PR_CurrentTriggerDelay();
extern "C" BS6006PRPLUS_API void PR_SetSampingFrequency(int Freq);
extern "C" BS6006PRPLUS_API int PR_CurrentSamplingFrequency();
extern "C" BS6006PRPLUS_API void PR_EnableAcquireSignal(bool bEnabled);
extern "C" BS6006PRPLUS_API bool PR_RunAndAcquireSignal(char* DataArray);
extern "C" BS6006PRPLUS_API void PR_AbortAcqSignal();
extern "C" BS6006PRPLUS_API void PR_SetTimeOut(int Seconds);

extern "C" BS6006PRPLUS_API void PR_Run();
extern "C" BS6006PRPLUS_API void PR_Stop();

extern "C" BS6006PRPLUS_API bool PR_CheckGeneralPower();
extern "C" BS6006PRPLUS_API bool PR_CheckVoltageOfPulser(int VoltLevel);
extern "C" BS6006PRPLUS_API void PR_ErrorCode(bool *bErrorCode);


