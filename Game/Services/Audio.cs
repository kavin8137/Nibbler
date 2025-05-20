// importing libraries
using Raylib_cs;

namespace Game.Services
{
    public static class Audio
    {
        // defining private static variables for background music and initialization status
        private static Music _backgroundMusic;
        private static bool _initted = false;
        private const string MusicPath = "Assets/audio/Run-Amok.wav";
        private const float DefaultVolume = 0.5f;
        public static void Init()
        {
            // checking if the audio has already been initialized
            // if so, return to avoid re-initialization
            if (_initted) return;

            // initializing the audio device if it's not already ready
            if (!Raylib.IsAudioDeviceReady())
            {
                Raylib.InitAudioDevice();
            }

            // loading the music stream from the specified path
            string fullPath = Path.Combine(AppContext.BaseDirectory, MusicPath);
            _backgroundMusic = Raylib.LoadMusicStream(fullPath);
            Raylib.SetMusicVolume(_backgroundMusic, DefaultVolume);
            Raylib.PlayMusicStream(_backgroundMusic);
            Raylib.UpdateMusicStream(_backgroundMusic);
            _initted = true;
        }

        // defining the method to update the music stream
        // this method is called in the game loop to ensure the music plays continuously
        public static void Update()
        {
            if (!_initted) return;

            Raylib.UpdateMusicStream(_backgroundMusic);

            if (!Raylib.IsMusicStreamPlaying(_backgroundMusic))
            {
                Raylib.StopMusicStream(_backgroundMusic);
                Raylib.PlayMusicStream(_backgroundMusic);
            }
        }

        // defining the method to stop the music and unload the audio device
        // this method is called when the game ends to clean up resources
        public static void Stop()
        {
            if (!_initted) return;

            Raylib.StopMusicStream(_backgroundMusic);
            Raylib.UnloadMusicStream(_backgroundMusic);

            if (Raylib.IsAudioDeviceReady())
                Raylib.CloseAudioDevice();
        }
    }
}