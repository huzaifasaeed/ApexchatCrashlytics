namespace ApexchatCrashlytics
{
    public interface ICrashReporting
    {
	   bool CrashReportingInit();
	   bool CrashReportingMisc();
	   void ForceCrash();
	   void LogException();
    }
}
