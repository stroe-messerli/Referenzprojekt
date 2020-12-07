using System;

namespace Gaming_Library.BL.UseCase.Entity.Types
{
    public struct GameAttributes
    {
        public bool IsMultiPlayer;
        public bool IsSinglePlayer;
        public bool IsCooperative;
        public bool IsVRSupportive;
        public bool HasFullControllerSupport;
        public bool HasPartialControllerSupport;
        public bool HasAchievements;
    }
}