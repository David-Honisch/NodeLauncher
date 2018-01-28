/*
    FMOD 3.72 (26/04/2004)
    This is a basic program.
    You MUST copy an MP3 file (named sound.mp3) into the EXE directory.
    You MUST copy fmod.dll into the EXE directory.
    Tutorials and others examples : http://www.fmod.org/files/fmodapi372win.zip
*/

//------------------------------------------------------------------------------
// Includes                          
//------------------------------------------------------------------------------


    #include <windows.h>        // Windows Header
    #include <stdio.h>          // For Printf
    #include <fmod/fmod.h>      // FMOD Header
//------------------------------------------------------------------------------
// global filename
//------------------------------------------------------------------------------
    

char * cFileName;    
//------------------------------------------------------------------------------
// Initialization of FMOD functions
//------------------------------------------------------------------------------

void    InitFMOD ( )
{
    FSOUND_SAMPLE * son = NULL;                     // NULL is significant
    int channel;                                    // sound channel

    printf ( "LCFMOD Player...\n" );
    printf ( "initializing...\n" );
    FSOUND_SetOutput ( FSOUND_OUTPUT_DSOUND );      // DirectSound
    FSOUND_SetDriver ( 0 );                         // Sound Driver (default 0)
    FSOUND_SetMixer ( FSOUND_MIXER_AUTODETECT );    // Mixer
    FSOUND_Init ( 44100, 32, 0 );                   // 44.1 kHz and 32 channels
    
    // Loading of our sound (2D)
    printf ( "Loading ...\n" );
    son = FSOUND_Sample_Load ( FSOUND_FREE, "sound.mp3", FSOUND_HW2D, 0, 0);
    channel = FSOUND_PlaySoundEx ( FSOUND_FREE, son, NULL, FALSE );
    
    // Some informations
    printf ( "Playing ...\n" );
    printf ( "Frequence : %d Hz ", FSOUND_GetOutputRate ( ) );
    printf ( "OR %d Hz\n", FSOUND_GetFrequency( channel ));
}



//------------------------------------------------------------------------------
// Main function
//------------------------------------------------------------------------------


int     main ( int argc, char *argv[ ], char *envp[ ] )
{
    cFileName = "";
    printf("Paramteranzahl:%d\n", argc);
    if (argc >= 2)
    {
        cFileName = argv[1];
        printf("Found:%s\n",argv[1]);
    }
    if (cFileName != "")
    {
        printf("%s\n",cFileName);
    }
    else
    {
        printf("%s\n","file or parameter not found.\n");
    }            
    InitFMOD ( );       // Initialization and loading sound
    system("PAUSE");    // Pause (hit a key ...)
    FSOUND_Close ( );   // Close sound
    return 0;           // OK !
}


//------------------------------------------------------------------------------
// THE END
//------------------------------------------------------------------------------
