#ifndef __cplusplus
    #define _GNU_SOURCE
#endif

#include <unistd.h>
#include <dirent.h>
#include <sys/types.h> // for opendir(), readdir(), closedir()
#include <sys/stat.h> // for stat()

#ifdef __cplusplus
    #include <iostream>
    #include <cstdlib>
    #include <cstring>
    #include <cstdarg>
#else
    #include <stdio.h>
    #include <stdlib.h>
    #include <string.h>
    #include <stdarg.h>
#endif

#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <stdio.h>
#include <signal.h>

#define PROC_DIRECTORY "/proc/"
#define CASE_SENSITIVE    1
#define CASE_INSENSITIVE  0
#define EXACT_MATCH       1
#define INEXACT_MATCH     0


void daemonize()
{

    switch (fork())
    {
        case 0:  break;
        case -1: exit(1);
        default: exit(0);
    }
}


static int exec_prog(const char **argv, const char **envp)
{
    pid_t   my_pid;
    int     status, timeout /* unused ifdef WAIT_FOR_COMPLETION */;

    if (0 == (my_pid = fork())) {
            if (-1 == execve(argv[0], (char **)argv , (char**)envp)) {
                    printf("child process execve failed [%s]\n", argv[0]);
                    return 0;
            }
    }

#ifdef WAIT_FOR_COMPLETION
    timeout = 1000;

    while (0 == waitpid(my_pid , &status , WNOHANG)) {
            if ( --timeout < 0 ) {
                    perror("timeout");
                    return -1;
            }
            sleep(1);
    }

    printf("%s WEXITSTATUS %d WIFEXITED %d [status %d]\n",
            argv[0], WEXITSTATUS(status), WIFEXITED(status), status);

    if (1 != WIFEXITED(status) || 0 != WEXITSTATUS(status)) {
            perror("%s failed, halt system");
            return 0;
    }

#endif
    return 0;
}


int IsNumeric(const char* ccharptr_CharacterList)
{
    for ( ; *ccharptr_CharacterList; ccharptr_CharacterList++)
        if (*ccharptr_CharacterList < '0' || *ccharptr_CharacterList > '9')
            return 0; // false
    return 1; // true
}


int strcmp_Wrapper(const char *s1, const char *s2, int intCaseSensitive)
{
    if (intCaseSensitive)
        return !strcmp(s1, s2);
    else
        return !strcasecmp(s1, s2);
}

int strstr_Wrapper(const char* haystack, const char* needle, int intCaseSensitive)
{
    char *r = NULL;
    if (intCaseSensitive) 
        r = strstr(haystack, needle);
    else
        r = strcasestr(haystack, needle);
    if (r == NULL) return 0;
    return 1;
}


#ifdef __cplusplus
pid_t GetPIDbyName(const char* cchrptr_ProcessName, int intCaseSensitiveness, int intExactMatch)
#else
pid_t GetPIDbyName_implements(const char* cchrptr_ProcessName, int intCaseSensitiveness, int intExactMatch)
#endif
{
    char chrarry_CommandLinePath[100]  ;
    char chrarry_NameOfProcess[300]  ;
    char* chrptr_StringToCompare = NULL ;
    pid_t pid_ProcessIdentifier = (pid_t) -1 ;
    struct dirent* de_DirEntity = NULL ;
    DIR* dir_proc = NULL ;

    int (*CompareFunction) (const char*, const char*, int) ;

    if (intExactMatch)
        CompareFunction = &strcmp_Wrapper;
    else
        CompareFunction = &strstr_Wrapper;


    dir_proc = opendir(PROC_DIRECTORY) ;
    if (dir_proc == NULL)
    {
        perror("Couldn't open the " PROC_DIRECTORY " directory") ;
        return (pid_t) -2 ;
    }

    // Loop while not NULL
    while ( (de_DirEntity = readdir(dir_proc)) )
    {
        if (de_DirEntity->d_type == DT_DIR)
        {
            if (IsNumeric(de_DirEntity->d_name))
            {
                strcpy(chrarry_CommandLinePath, PROC_DIRECTORY) ;
                strcat(chrarry_CommandLinePath, de_DirEntity->d_name) ;
                strcat(chrarry_CommandLinePath, "/cmdline") ;
                FILE* fd_CmdLineFile = fopen (chrarry_CommandLinePath, "rt") ;  // open the file for reading text
                if (fd_CmdLineFile)
                {
                    fscanf(fd_CmdLineFile, "%s", chrarry_NameOfProcess) ; // read from /proc/<NR>/cmdline
                    fclose(fd_CmdLineFile);  // close the file prior to exiting the routine

                    if (strrchr(chrarry_NameOfProcess, '/'))
                        chrptr_StringToCompare = strrchr(chrarry_NameOfProcess, '/') +1 ;
                    else
                        chrptr_StringToCompare = chrarry_NameOfProcess ;

                    //printf("Process name: %s\n", chrarry_NameOfProcess);
                    //printf("Pure Process name: %s\n", chrptr_StringToCompare );

                    if ( CompareFunction(chrptr_StringToCompare, cchrptr_ProcessName, intCaseSensitiveness) )
                    {
                        pid_ProcessIdentifier = (pid_t) atoi(de_DirEntity->d_name) ;
                        closedir(dir_proc) ;
                        return pid_ProcessIdentifier ;
                    }
                }
            }
        }
    }
    closedir(dir_proc) ;
    return pid_ProcessIdentifier ;
}

#ifdef __cplusplus
    pid_t GetPIDbyName(const char* cchrptr_ProcessName)
    {
        return GetPIDbyName(cchrptr_ProcessName, CASE_INSENSITIVE, EXACT_MATCH) ;
    }
#else
    // C cannot overload functions - fixed
    pid_t GetPIDbyName_Wrapper(const char* cchrptr_ProcessName, ... )
    {
        int intTempArgument ;
        int intInputArguments[2] ;
        // intInputArguments[0] = 0 ;
        // intInputArguments[1] = 0 ;
        memset(intInputArguments, 0, sizeof(intInputArguments) ) ;
        int intInputIndex ;
        va_list argptr;

        va_start( argptr, cchrptr_ProcessName );
            for (intInputIndex = 0;  (intTempArgument = va_arg( argptr, int )) != 15; ++intInputIndex)
            {
                intInputArguments[intInputIndex] = intTempArgument ;
            }
        va_end( argptr );
        return GetPIDbyName_implements(cchrptr_ProcessName, intInputArguments[0], intInputArguments[1]);
    }

    #define GetPIDbyName(ProcessName,...) GetPIDbyName_Wrapper(ProcessName, ##__VA_ARGS__, (int) 15)

#endif

void sig_handler(int signo)
{
  if (signo == SIGTERM) {
    printf("received SIGTERM\n");
    exit(0);
}
}


int main()
{

//    daemonize();

    if (signal(SIGTERM, sig_handler) == SIG_ERR) printf("can't catch SIGTERM\n");

    char firstrun = 1;
    char *mono = "mono";
    const char *monocmd[] = { "/framework/bin/mono", "/mnt/software/bin/Gateway.exe", "30", "&", NULL };
    const char *envp[] = { "PATH=/bin:/sbin:/usr/bin:/usr/sbin:/usr/local/bin:/framework/bin", 
			    "MONO_PATH=/framework/lib/mono/4.0", "LC_ALL=en_US.UTF-8", 
			    "LANG=en_US.UTF-8", "LC_TIME=en_US.UTF-8", "LC_CTYPE=en_US.UTF-8",
			    "LC_NUMERIC=en_US.UTF-8", "LC_COLLATE=en_US.UTF-8", "LC_MONETARY=en_US.UTF-8",
			    "LC_NAME=en_US.UTF-8", "LC_ADDRESS=en_US.UTF-8", "LC_TELEPHONE=en_US.UTF-8",
			    "LC_MEASUREMENT=en_US.UTF-8", "LC_IDENTIFICATION=en_US.UTF-8",
			    NULL };

    while(1) {

	// If -1 = not found, if -2 = proc fs access error
        pid_t pidg = GetPIDbyName(mono);
	
	if (pidg < 0) 
	    {
		printf("PID %d mono, starting it\n", pidg);
		exec_prog(monocmd, envp);
		firstrun = 1;
	    }

	if (firstrun) {
	    sleep(60);
	    firstrun = 0;
	} else sleep(10);
    }
    return EXIT_SUCCESS ;
}

