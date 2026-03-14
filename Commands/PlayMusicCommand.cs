using GameControlSystem.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Commands
{
    public class PlayMusicCommand : ICommand
    {
        private readonly MusicPlayer musicPlayer;

        public PlayMusicCommand(MusicPlayer musicPlayer)
        {
            this.musicPlayer = musicPlayer;
        }

        public void Execute()
        {
            musicPlayer.Play();
        }
    }
}
